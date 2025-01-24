using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2WebResourceResponseReceivedEventArgs : EventArgs
	{
		internal ICoreWebView2WebResourceResponseReceivedEventArgs _nativeICoreWebView2WebResourceResponseReceivedEventArgsValue;

		internal Object _rawNative;

		internal ICoreWebView2WebResourceResponseReceivedEventArgs _nativeICoreWebView2WebResourceResponseReceivedEventArgs
		{
			get
			{
				if (this._nativeICoreWebView2WebResourceResponseReceivedEventArgsValue == null)
				{
					try
					{
						this._nativeICoreWebView2WebResourceResponseReceivedEventArgsValue = (ICoreWebView2WebResourceResponseReceivedEventArgs)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponseReceivedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2WebResourceResponseReceivedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2WebResourceResponseReceivedEventArgsValue = value;
			}
		}

		public CoreWebView2WebResourceRequest Request
		{
			get
			{
				CoreWebView2WebResourceRequest coreWebView2WebResourceRequest;
				CoreWebView2WebResourceRequest coreWebView2WebResourceRequest1;
				try
				{
					if (this._nativeICoreWebView2WebResourceResponseReceivedEventArgs.Request == null)
					{
						coreWebView2WebResourceRequest1 = null;
					}
					else
					{
						coreWebView2WebResourceRequest1 = new CoreWebView2WebResourceRequest(this._nativeICoreWebView2WebResourceResponseReceivedEventArgs.Request);
					}
					coreWebView2WebResourceRequest = coreWebView2WebResourceRequest1;
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
				return coreWebView2WebResourceRequest;
			}
		}

		public CoreWebView2WebResourceResponseView Response
		{
			get
			{
				CoreWebView2WebResourceResponseView coreWebView2WebResourceResponseView;
				CoreWebView2WebResourceResponseView coreWebView2WebResourceResponseView1;
				try
				{
					if (this._nativeICoreWebView2WebResourceResponseReceivedEventArgs.Response == null)
					{
						coreWebView2WebResourceResponseView1 = null;
					}
					else
					{
						coreWebView2WebResourceResponseView1 = new CoreWebView2WebResourceResponseView(this._nativeICoreWebView2WebResourceResponseReceivedEventArgs.Response);
					}
					coreWebView2WebResourceResponseView = coreWebView2WebResourceResponseView1;
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
				return coreWebView2WebResourceResponseView;
			}
		}

		internal CoreWebView2WebResourceResponseReceivedEventArgs(Object rawCoreWebView2WebResourceResponseReceivedEventArgs)
		{
			this._rawNative = rawCoreWebView2WebResourceResponseReceivedEventArgs;
		}
	}
}