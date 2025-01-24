using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2DevToolsProtocolEventReceiver
	{
		internal ICoreWebView2DevToolsProtocolEventReceiver _nativeICoreWebView2DevToolsProtocolEventReceiverValue;

		internal Object _rawNative;

		private EventRegistrationToken _devToolsProtocolEventReceivedToken;

		private EventHandler<CoreWebView2DevToolsProtocolEventReceivedEventArgs> devToolsProtocolEventReceived;

		internal ICoreWebView2DevToolsProtocolEventReceiver _nativeICoreWebView2DevToolsProtocolEventReceiver
		{
			get
			{
				if (this._nativeICoreWebView2DevToolsProtocolEventReceiverValue == null)
				{
					try
					{
						this._nativeICoreWebView2DevToolsProtocolEventReceiverValue = (ICoreWebView2DevToolsProtocolEventReceiver)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DevToolsProtocolEventReceiver.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2DevToolsProtocolEventReceiverValue;
			}
			set
			{
				this._nativeICoreWebView2DevToolsProtocolEventReceiverValue = value;
			}
		}

		internal CoreWebView2DevToolsProtocolEventReceiver(Object rawCoreWebView2DevToolsProtocolEventReceiver)
		{
			this._rawNative = rawCoreWebView2DevToolsProtocolEventReceiver;
		}

		internal Void OnDevToolsProtocolEventReceived(CoreWebView2DevToolsProtocolEventReceivedEventArgs args)
		{
			EventHandler<CoreWebView2DevToolsProtocolEventReceivedEventArgs> eventHandler = this.devToolsProtocolEventReceived;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		public event EventHandler<CoreWebView2DevToolsProtocolEventReceivedEventArgs> DevToolsProtocolEventReceived
		{
			add
			{
				if (this.devToolsProtocolEventReceived == null)
				{
					try
					{
						this._nativeICoreWebView2DevToolsProtocolEventReceiver.add_DevToolsProtocolEventReceived(new CoreWebView2DevToolsProtocolEventReceivedEventHandler(new CoreWebView2DevToolsProtocolEventReceivedEventHandler.CallbackType(this.OnDevToolsProtocolEventReceived)), out this._devToolsProtocolEventReceivedToken);
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
				this.devToolsProtocolEventReceived = (EventHandler<CoreWebView2DevToolsProtocolEventReceivedEventArgs>)Delegate.Combine(this.devToolsProtocolEventReceived, value);
			}
			remove
			{
				this.devToolsProtocolEventReceived = (EventHandler<CoreWebView2DevToolsProtocolEventReceivedEventArgs>)Delegate.Remove(this.devToolsProtocolEventReceived, value);
				if (this.devToolsProtocolEventReceived == null)
				{
					try
					{
						this._nativeICoreWebView2DevToolsProtocolEventReceiver.remove_DevToolsProtocolEventReceived(this._devToolsProtocolEventReceivedToken);
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