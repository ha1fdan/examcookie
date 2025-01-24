using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2WebResourceResponse
	{
		internal ICoreWebView2WebResourceResponse _nativeICoreWebView2WebResourceResponseValue;

		internal Object _rawNative;

		internal ICoreWebView2WebResourceResponse _nativeICoreWebView2WebResourceResponse
		{
			get
			{
				if (this._nativeICoreWebView2WebResourceResponseValue == null)
				{
					try
					{
						this._nativeICoreWebView2WebResourceResponseValue = (ICoreWebView2WebResourceResponse)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponse.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2WebResourceResponseValue;
			}
			set
			{
				this._nativeICoreWebView2WebResourceResponseValue = value;
			}
		}

		public Stream Content
		{
			get
			{
				Stream net;
				try
				{
					net = COMDotNetTypeConverter.StreamCOMToNet(this._nativeICoreWebView2WebResourceResponse.Content);
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
				return net;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2WebResourceResponse.Content = new ManagedIStream(value);
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

		public CoreWebView2HttpResponseHeaders Headers
		{
			get
			{
				CoreWebView2HttpResponseHeaders coreWebView2HttpResponseHeaders;
				CoreWebView2HttpResponseHeaders coreWebView2HttpResponseHeaders1;
				try
				{
					if (this._nativeICoreWebView2WebResourceResponse.Headers == null)
					{
						coreWebView2HttpResponseHeaders1 = null;
					}
					else
					{
						coreWebView2HttpResponseHeaders1 = new CoreWebView2HttpResponseHeaders(this._nativeICoreWebView2WebResourceResponse.Headers);
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
					reasonPhrase = this._nativeICoreWebView2WebResourceResponse.ReasonPhrase;
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
			set
			{
				try
				{
					this._nativeICoreWebView2WebResourceResponse.ReasonPhrase = value;
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

		public Int32 StatusCode
		{
			get
			{
				Int32 statusCode;
				try
				{
					statusCode = this._nativeICoreWebView2WebResourceResponse.StatusCode;
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
			set
			{
				try
				{
					this._nativeICoreWebView2WebResourceResponse.StatusCode = value;
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

		internal CoreWebView2WebResourceResponse(Object rawCoreWebView2WebResourceResponse)
		{
			this._rawNative = rawCoreWebView2WebResourceResponse;
		}
	}
}