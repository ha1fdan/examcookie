using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2FrameInfo
	{
		internal ICoreWebView2FrameInfo _nativeICoreWebView2FrameInfoValue;

		internal Object _rawNative;

		internal ICoreWebView2FrameInfo _nativeICoreWebView2FrameInfo
		{
			get
			{
				if (this._nativeICoreWebView2FrameInfoValue == null)
				{
					try
					{
						this._nativeICoreWebView2FrameInfoValue = (ICoreWebView2FrameInfo)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FrameInfo.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2FrameInfoValue;
			}
			set
			{
				this._nativeICoreWebView2FrameInfoValue = value;
			}
		}

		public String Name
		{
			get
			{
				String name;
				try
				{
					name = this._nativeICoreWebView2FrameInfo.Name;
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
				return name;
			}
		}

		public String Source
		{
			get
			{
				String source;
				try
				{
					source = this._nativeICoreWebView2FrameInfo.Source;
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
				return source;
			}
		}

		internal CoreWebView2FrameInfo(Object rawCoreWebView2FrameInfo)
		{
			this._rawNative = rawCoreWebView2FrameInfo;
		}
	}
}