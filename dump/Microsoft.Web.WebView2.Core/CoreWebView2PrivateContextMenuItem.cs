using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2PrivateContextMenuItem
	{
		internal ICoreWebView2PrivateContextMenuItem _nativeICoreWebView2PrivateContextMenuItemValue;

		internal Object _rawNative;

		internal ICoreWebView2PrivateContextMenuItem _nativeICoreWebView2PrivateContextMenuItem
		{
			get
			{
				if (this._nativeICoreWebView2PrivateContextMenuItemValue == null)
				{
					try
					{
						this._nativeICoreWebView2PrivateContextMenuItemValue = (ICoreWebView2PrivateContextMenuItem)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivateContextMenuItem.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2PrivateContextMenuItemValue;
			}
			set
			{
				this._nativeICoreWebView2PrivateContextMenuItemValue = value;
			}
		}

		internal CoreWebView2PrivateContextMenuItem(Object rawCoreWebView2PrivateContextMenuItem)
		{
			this._rawNative = rawCoreWebView2PrivateContextMenuItem;
		}

		internal Int32 HasReadIconStream()
		{
			Int32 num;
			try
			{
				num = this._nativeICoreWebView2PrivateContextMenuItem.HasReadIconStream();
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
			return num;
		}

		internal Int32 IsCustom()
		{
			Int32 num;
			try
			{
				num = this._nativeICoreWebView2PrivateContextMenuItem.IsCustom();
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
			return num;
		}

		internal Void ReportSelected()
		{
			try
			{
				this._nativeICoreWebView2PrivateContextMenuItem.ReportSelected();
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

		internal Void SetHasReadIconStream(Boolean has_read_icon_stream)
		{
			try
			{
				this._nativeICoreWebView2PrivateContextMenuItem.SetHasReadIconStream((has_read_icon_stream ? 1 : 0));
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