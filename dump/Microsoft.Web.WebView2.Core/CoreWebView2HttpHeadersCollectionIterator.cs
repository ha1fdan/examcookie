using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2HttpHeadersCollectionIterator : IEnumerator<KeyValuePair<String, String>>, IDisposable, IEnumerator
	{
		private Boolean isInitialized;

		internal ICoreWebView2HttpHeadersCollectionIterator _nativeICoreWebView2HttpHeadersCollectionIteratorValue;

		internal Object _rawNative;

		internal ICoreWebView2HttpHeadersCollectionIterator _nativeICoreWebView2HttpHeadersCollectionIterator
		{
			get
			{
				if (this._nativeICoreWebView2HttpHeadersCollectionIteratorValue == null)
				{
					try
					{
						this._nativeICoreWebView2HttpHeadersCollectionIteratorValue = (ICoreWebView2HttpHeadersCollectionIterator)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2HttpHeadersCollectionIterator.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2HttpHeadersCollectionIteratorValue;
			}
			set
			{
				this._nativeICoreWebView2HttpHeadersCollectionIteratorValue = value;
			}
		}

		public KeyValuePair<String, String> Current
		{
			get
			{
				String str;
				String str1;
				KeyValuePair<String, String> keyValuePair;
				try
				{
					this.GetCurrentHeader(out str, out str1);
					keyValuePair = new KeyValuePair<String, String>(str, str1);
				}
				catch (IndexOutOfRangeException indexOutOfRangeException)
				{
					throw new InvalidOperationException();
				}
				return keyValuePair;
			}
		}

		public Boolean HasCurrentHeader
		{
			get
			{
				Boolean hasCurrentHeader;
				try
				{
					hasCurrentHeader = this._nativeICoreWebView2HttpHeadersCollectionIterator.HasCurrentHeader != 0;
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
				return hasCurrentHeader;
			}
		}

		Object System.Collections.IEnumerator.Current
		{
			get
			{
				return this.Current;
			}
		}

		internal CoreWebView2HttpHeadersCollectionIterator(Object rawCoreWebView2HttpHeadersCollectionIterator)
		{
			this._rawNative = rawCoreWebView2HttpHeadersCollectionIterator;
		}

		public Void Dispose()
		{
		}

		private Void GetCurrentHeader(out String name, out String value)
		{
			try
			{
				this._nativeICoreWebView2HttpHeadersCollectionIterator.GetCurrentHeader(out name, out value);
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

		public Boolean MoveNext()
		{
			if (this.isInitialized)
			{
				return this._nativeICoreWebView2HttpHeadersCollectionIterator.MoveNext() != 0;
			}
			this.isInitialized = true;
			return this.HasCurrentHeader;
		}

		public Void Reset()
		{
			throw new NotSupportedException();
		}
	}
}