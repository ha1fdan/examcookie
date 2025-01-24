using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2DevToolsProtocolEventReceivedEventArgs : EventArgs
	{
		internal ICoreWebView2DevToolsProtocolEventReceivedEventArgs _nativeICoreWebView2DevToolsProtocolEventReceivedEventArgsValue;

		internal ICoreWebView2DevToolsProtocolEventReceivedEventArgs2 _nativeICoreWebView2DevToolsProtocolEventReceivedEventArgs2Value;

		internal Object _rawNative;

		internal ICoreWebView2DevToolsProtocolEventReceivedEventArgs _nativeICoreWebView2DevToolsProtocolEventReceivedEventArgs
		{
			get
			{
				if (this._nativeICoreWebView2DevToolsProtocolEventReceivedEventArgsValue == null)
				{
					try
					{
						this._nativeICoreWebView2DevToolsProtocolEventReceivedEventArgsValue = (ICoreWebView2DevToolsProtocolEventReceivedEventArgs)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DevToolsProtocolEventReceivedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2DevToolsProtocolEventReceivedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2DevToolsProtocolEventReceivedEventArgsValue = value;
			}
		}

		internal ICoreWebView2DevToolsProtocolEventReceivedEventArgs2 _nativeICoreWebView2DevToolsProtocolEventReceivedEventArgs2
		{
			get
			{
				if (this._nativeICoreWebView2DevToolsProtocolEventReceivedEventArgs2Value == null)
				{
					try
					{
						this._nativeICoreWebView2DevToolsProtocolEventReceivedEventArgs2Value = (ICoreWebView2DevToolsProtocolEventReceivedEventArgs2)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DevToolsProtocolEventReceivedEventArgs2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2DevToolsProtocolEventReceivedEventArgs2Value;
			}
			set
			{
				this._nativeICoreWebView2DevToolsProtocolEventReceivedEventArgs2Value = value;
			}
		}

		public String ParameterObjectAsJson
		{
			get
			{
				String parameterObjectAsJson;
				try
				{
					parameterObjectAsJson = this._nativeICoreWebView2DevToolsProtocolEventReceivedEventArgs.ParameterObjectAsJson;
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
				return parameterObjectAsJson;
			}
		}

		public String SessionId
		{
			get
			{
				String sessionId;
				try
				{
					sessionId = this._nativeICoreWebView2DevToolsProtocolEventReceivedEventArgs2.SessionId;
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
				return sessionId;
			}
		}

		internal CoreWebView2DevToolsProtocolEventReceivedEventArgs(Object rawCoreWebView2DevToolsProtocolEventReceivedEventArgs)
		{
			this._rawNative = rawCoreWebView2DevToolsProtocolEventReceivedEventArgs;
		}
	}
}