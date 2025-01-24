using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2HttpResponseHeaders : IEnumerable<KeyValuePair<String, String>>, IEnumerable
	{
		internal ICoreWebView2HttpResponseHeaders _nativeICoreWebView2HttpResponseHeadersValue;

		internal Object _rawNative;

		internal ICoreWebView2HttpResponseHeaders _nativeICoreWebView2HttpResponseHeaders
		{
			get
			{
				if (this._nativeICoreWebView2HttpResponseHeadersValue == null)
				{
					try
					{
						this._nativeICoreWebView2HttpResponseHeadersValue = (ICoreWebView2HttpResponseHeaders)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2HttpResponseHeaders.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2HttpResponseHeadersValue;
			}
			set
			{
				this._nativeICoreWebView2HttpResponseHeadersValue = value;
			}
		}

		internal CoreWebView2HttpResponseHeaders(Object rawCoreWebView2HttpResponseHeaders)
		{
			this._rawNative = rawCoreWebView2HttpResponseHeaders;
		}

		public Void AppendHeader(String name, String value)
		{
			try
			{
				this._nativeICoreWebView2HttpResponseHeaders.AppendHeader(name, value);
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

		public Boolean Contains(String name)
		{
			Boolean flag;
			try
			{
				flag = this._nativeICoreWebView2HttpResponseHeaders.Contains(name) != 0;
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
			return flag;
		}

		public CoreWebView2HttpHeadersCollectionIterator GetEnumerator()
		{
			return this.GetIterator();
		}

		public String GetHeader(String name)
		{
			String header;
			try
			{
				header = this._nativeICoreWebView2HttpResponseHeaders.GetHeader(name);
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
			return header;
		}

		public CoreWebView2HttpHeadersCollectionIterator GetHeaders(String name)
		{
			CoreWebView2HttpHeadersCollectionIterator coreWebView2HttpHeadersCollectionIterator;
			try
			{
				coreWebView2HttpHeadersCollectionIterator = new CoreWebView2HttpHeadersCollectionIterator(this._nativeICoreWebView2HttpResponseHeaders.GetHeaders(name));
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
			return coreWebView2HttpHeadersCollectionIterator;
		}

		public CoreWebView2HttpHeadersCollectionIterator GetIterator()
		{
			CoreWebView2HttpHeadersCollectionIterator coreWebView2HttpHeadersCollectionIterator;
			try
			{
				coreWebView2HttpHeadersCollectionIterator = new CoreWebView2HttpHeadersCollectionIterator(this._nativeICoreWebView2HttpResponseHeaders.GetIterator());
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
			return coreWebView2HttpHeadersCollectionIterator;
		}

		IEnumerator<KeyValuePair<String, String>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}