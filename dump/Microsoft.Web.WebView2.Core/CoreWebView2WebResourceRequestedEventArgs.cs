using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2WebResourceRequestedEventArgs : EventArgs
	{
		internal ICoreWebView2WebResourceRequestedEventArgs _nativeICoreWebView2WebResourceRequestedEventArgsValue;

		internal Object _rawNative;

		internal ICoreWebView2WebResourceRequestedEventArgs _nativeICoreWebView2WebResourceRequestedEventArgs
		{
			get
			{
				if (this._nativeICoreWebView2WebResourceRequestedEventArgsValue == null)
				{
					try
					{
						this._nativeICoreWebView2WebResourceRequestedEventArgsValue = (ICoreWebView2WebResourceRequestedEventArgs)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceRequestedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2WebResourceRequestedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2WebResourceRequestedEventArgsValue = value;
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
					if (this._nativeICoreWebView2WebResourceRequestedEventArgs.Request == null)
					{
						coreWebView2WebResourceRequest1 = null;
					}
					else
					{
						coreWebView2WebResourceRequest1 = new CoreWebView2WebResourceRequest(this._nativeICoreWebView2WebResourceRequestedEventArgs.Request);
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

		public CoreWebView2WebResourceContext ResourceContext
		{
			get
			{
				CoreWebView2WebResourceContext resourceContext;
				try
				{
					resourceContext = (CoreWebView2WebResourceContext)this._nativeICoreWebView2WebResourceRequestedEventArgs.ResourceContext;
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
				return resourceContext;
			}
		}

		public CoreWebView2WebResourceResponse Response
		{
			get
			{
				CoreWebView2WebResourceResponse coreWebView2WebResourceResponse;
				CoreWebView2WebResourceResponse coreWebView2WebResourceResponse1;
				try
				{
					if (this._nativeICoreWebView2WebResourceRequestedEventArgs.Response == null)
					{
						coreWebView2WebResourceResponse1 = null;
					}
					else
					{
						coreWebView2WebResourceResponse1 = new CoreWebView2WebResourceResponse(this._nativeICoreWebView2WebResourceRequestedEventArgs.Response);
					}
					coreWebView2WebResourceResponse = coreWebView2WebResourceResponse1;
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
				return coreWebView2WebResourceResponse;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2WebResourceRequestedEventArgs.Response = value._nativeICoreWebView2WebResourceResponse;
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

		internal CoreWebView2WebResourceRequestedEventArgs(Object rawCoreWebView2WebResourceRequestedEventArgs)
		{
			this._rawNative = rawCoreWebView2WebResourceRequestedEventArgs;
		}

		public CoreWebView2Deferral GetDeferral()
		{
			CoreWebView2Deferral coreWebView2Deferral;
			try
			{
				coreWebView2Deferral = new CoreWebView2Deferral(this._nativeICoreWebView2WebResourceRequestedEventArgs.GetDeferral());
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
			return coreWebView2Deferral;
		}
	}
}