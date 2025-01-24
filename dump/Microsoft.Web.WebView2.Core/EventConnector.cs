using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Microsoft.Web.WebView2.Core
{
	internal class EventConnector
	{
		private DelegateMap _DelegatesMap = new DelegateMap();

		private Object _originalHostObject;

		public EventConnector(Object originalHostObject)
		{
			this._originalHostObject = originalHostObject;
		}

		public Void addEventListener(String eventName, Object JSHandler)
		{
			try
			{
				CoreWebView2PrivateRemoteObjectProxy coreWebView2PrivateRemoteObjectProxy = new CoreWebView2PrivateRemoteObjectProxy(JSHandler);
				Int32 id = coreWebView2PrivateRemoteObjectProxy.GetId();
				EventInfo eventInfo = this.CheckAndGetEventInfo(eventName);
				Delegate @delegate = this._DelegatesMap.GetDelegate(id);
				if (@delegate == null)
				{
					coreWebView2PrivateRemoteObjectProxy.Passivated += new EventHandler<Object>(this, EventConnector.RemoteObjectPassivated);
					@delegate = (new JSHandlerWrapper(JSHandler)).CreateDelegate(eventInfo);
				}
				if (this._DelegatesMap.InsertDelegate(eventName, id, @delegate))
				{
					eventInfo.AddEventHandler(this._originalHostObject, @delegate);
				}
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		private EventInfo CheckAndGetEventInfo(String eventName)
		{
			EventInfo @event = this._originalHostObject.GetType().GetEvent(eventName, 20);
			if (@event == null)
			{
				throw new Exception(String.Concat("No such event or it is not public, event's name:", eventName, "."));
			}
			return @event;
		}

		private Void RemoteObjectPassivated(Object sender, Object args)
		{
			try
			{
				Int32 id = (sender as CoreWebView2PrivateRemoteObjectProxy).GetId();
				List<String> registeredEventNameById = this._DelegatesMap.GetRegisteredEventNameById(id);
				Delegate @delegate = this._DelegatesMap.GetDelegate(id);
				if (@delegate != null)
				{
					foreach (String str in registeredEventNameById)
					{
						this._DelegatesMap.RemoveDelegate(str, id);
						this.CheckAndGetEventInfo(str).RemoveEventHandler(this._originalHostObject, @delegate);
					}
				}
			}
			catch (Exception exception)
			{
			}
		}

		public Void removeEventListener(String eventName, Object JSHandler)
		{
			try
			{
				Delegate @delegate = this._DelegatesMap.RemoveDelegate(eventName, (JSHandler as ICoreWebView2PrivateRemoteObjectProxy).GetId());
				if (@delegate != null)
				{
					this.CheckAndGetEventInfo(eventName).RemoveEventHandler(this._originalHostObject, @delegate);
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				if (exception.get_InnerException() == null)
				{
					throw exception;
				}
				throw exception.get_InnerException();
			}
		}
	}
}