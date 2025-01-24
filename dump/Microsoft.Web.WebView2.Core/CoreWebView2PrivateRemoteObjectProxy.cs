using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2PrivateRemoteObjectProxy
	{
		internal ICoreWebView2PrivateRemoteObjectProxy _nativeICoreWebView2PrivateRemoteObjectProxyValue;

		internal Object _rawNative;

		private EventRegistrationToken _passivatedToken;

		private EventHandler<Object> passivated;

		internal ICoreWebView2PrivateRemoteObjectProxy _nativeICoreWebView2PrivateRemoteObjectProxy
		{
			get
			{
				if (this._nativeICoreWebView2PrivateRemoteObjectProxyValue == null)
				{
					try
					{
						this._nativeICoreWebView2PrivateRemoteObjectProxyValue = (ICoreWebView2PrivateRemoteObjectProxy)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivateRemoteObjectProxy.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2PrivateRemoteObjectProxyValue;
			}
			set
			{
				this._nativeICoreWebView2PrivateRemoteObjectProxyValue = value;
			}
		}

		internal CoreWebView2PrivateRemoteObjectProxy(Object rawCoreWebView2PrivateRemoteObjectProxy)
		{
			this._rawNative = rawCoreWebView2PrivateRemoteObjectProxy;
		}

		internal Int32 GetId()
		{
			Int32 id;
			try
			{
				id = this._nativeICoreWebView2PrivateRemoteObjectProxy.GetId();
			}
			catch (InvalidCastException invalidCastException1)
			{
				InvalidCastException invalidCastException = invalidCastException1;
				if (invalidCastException.get_HResult() != -2147467262)
				{
					throw invalidCastException;
				}
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", invalidCastException);
			}
			catch (COMException cOMException1)
			{
				COMException cOMException = cOMException1;
				if (cOMException.get_HResult() != -2147019873)
				{
					throw cOMException;
				}
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", cOMException);
			}
			return id;
		}

		internal Void OnPassivated(Object args)
		{
			EventHandler<Object> eventHandler = this.passivated;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal event EventHandler<Object> Passivated
		{
			add
			{
				if (this.passivated == null)
				{
					try
					{
						this._nativeICoreWebView2PrivateRemoteObjectProxy.add_Passivated(new CoreWebView2PrivateRemoteObjectProxyPassivatedEventHandler(new CoreWebView2PrivateRemoteObjectProxyPassivatedEventHandler.CallbackType(this.OnPassivated)), out this._passivatedToken);
					}
					catch (InvalidCastException invalidCastException1)
					{
						InvalidCastException invalidCastException = invalidCastException1;
						if (invalidCastException.get_HResult() != -2147467262)
						{
							throw invalidCastException;
						}
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", invalidCastException);
					}
					catch (COMException cOMException1)
					{
						COMException cOMException = cOMException1;
						if (cOMException.get_HResult() != -2147019873)
						{
							throw cOMException;
						}
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", cOMException);
					}
				}
				this.passivated = (EventHandler<Object>)Delegate.Combine(this.passivated, value);
			}
			remove
			{
				this.passivated = (EventHandler<Object>)Delegate.Remove(this.passivated, value);
				if (this.passivated == null)
				{
					try
					{
						this._nativeICoreWebView2PrivateRemoteObjectProxy.remove_Passivated(this._passivatedToken);
					}
					catch (InvalidCastException invalidCastException1)
					{
						InvalidCastException invalidCastException = invalidCastException1;
						if (invalidCastException.get_HResult() != -2147467262)
						{
							throw invalidCastException;
						}
						throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", invalidCastException);
					}
					catch (COMException cOMException1)
					{
						COMException cOMException = cOMException1;
						if (cOMException.get_HResult() != -2147019873)
						{
							throw cOMException;
						}
						throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", cOMException);
					}
				}
			}
		}
	}
}