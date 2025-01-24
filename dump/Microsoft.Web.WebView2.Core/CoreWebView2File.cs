using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2File
	{
		internal ICoreWebView2File _nativeICoreWebView2FileValue;

		internal Object _rawNative;

		internal ICoreWebView2File _nativeICoreWebView2File
		{
			get
			{
				if (this._nativeICoreWebView2FileValue == null)
				{
					try
					{
						this._nativeICoreWebView2FileValue = (ICoreWebView2File)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2File.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2FileValue;
			}
			set
			{
				this._nativeICoreWebView2FileValue = value;
			}
		}

		public String Path
		{
			get
			{
				String path;
				try
				{
					path = this._nativeICoreWebView2File.Path;
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
				return path;
			}
		}

		internal CoreWebView2File(Object rawCoreWebView2File)
		{
			this._rawNative = rawCoreWebView2File;
		}
	}
}