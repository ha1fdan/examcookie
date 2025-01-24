using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2WebResourceResponseView
	{
		internal ICoreWebView2WebResourceResponseView _nativeICoreWebView2WebResourceResponseViewValue;

		internal Object _rawNative;

		internal ICoreWebView2WebResourceResponseView _nativeICoreWebView2WebResourceResponseView
		{
			get
			{
				if (this._nativeICoreWebView2WebResourceResponseViewValue == null)
				{
					try
					{
						this._nativeICoreWebView2WebResourceResponseViewValue = (ICoreWebView2WebResourceResponseView)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponseView.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2WebResourceResponseViewValue;
			}
			set
			{
				this._nativeICoreWebView2WebResourceResponseViewValue = value;
			}
		}

		public CoreWebView2HttpResponseHeaders Headers
		{
			get
			{
				CoreWebView2HttpResponseHeaders coreWebView2HttpResponseHeaders;
				CoreWebView2HttpResponseHeaders coreWebView2HttpResponseHeaders1;
				try
				{
					if (this._nativeICoreWebView2WebResourceResponseView.Headers == null)
					{
						coreWebView2HttpResponseHeaders1 = null;
					}
					else
					{
						coreWebView2HttpResponseHeaders1 = new CoreWebView2HttpResponseHeaders(this._nativeICoreWebView2WebResourceResponseView.Headers);
					}
					coreWebView2HttpResponseHeaders = coreWebView2HttpResponseHeaders1;
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
				return coreWebView2HttpResponseHeaders;
			}
		}

		public String ReasonPhrase
		{
			get
			{
				String reasonPhrase;
				try
				{
					reasonPhrase = this._nativeICoreWebView2WebResourceResponseView.ReasonPhrase;
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
				return reasonPhrase;
			}
		}

		public Int32 StatusCode
		{
			get
			{
				Int32 statusCode;
				try
				{
					statusCode = this._nativeICoreWebView2WebResourceResponseView.StatusCode;
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
				return statusCode;
			}
		}

		internal CoreWebView2WebResourceResponseView(Object rawCoreWebView2WebResourceResponseView)
		{
			this._rawNative = rawCoreWebView2WebResourceResponseView;
		}

		public async Task<Stream> GetContentAsync()
		{
			CoreWebView2WebResourceResponseViewGetContentCompletedHandler coreWebView2WebResourceResponseViewGetContentCompletedHandler;
			try
			{
				coreWebView2WebResourceResponseViewGetContentCompletedHandler = new CoreWebView2WebResourceResponseViewGetContentCompletedHandler();
				this._nativeICoreWebView2WebResourceResponseView.GetContent(coreWebView2WebResourceResponseViewGetContentCompletedHandler);
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
			await coreWebView2WebResourceResponseViewGetContentCompletedHandler;
			Marshal.ThrowExceptionForHR(coreWebView2WebResourceResponseViewGetContentCompletedHandler.errCode);
			Stream content = coreWebView2WebResourceResponseViewGetContentCompletedHandler.Content;
			coreWebView2WebResourceResponseViewGetContentCompletedHandler = null;
			return content;
		}
	}
}