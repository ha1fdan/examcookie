using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2PermissionSetting
	{
		internal ICoreWebView2PermissionSetting _nativeICoreWebView2PermissionSettingValue;

		internal Object _rawNative;

		internal ICoreWebView2PermissionSetting _nativeICoreWebView2PermissionSetting
		{
			get
			{
				if (this._nativeICoreWebView2PermissionSettingValue == null)
				{
					try
					{
						this._nativeICoreWebView2PermissionSettingValue = (ICoreWebView2PermissionSetting)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PermissionSetting.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2PermissionSettingValue;
			}
			set
			{
				this._nativeICoreWebView2PermissionSettingValue = value;
			}
		}

		public CoreWebView2PermissionKind PermissionKind
		{
			get
			{
				CoreWebView2PermissionKind permissionKind;
				try
				{
					permissionKind = (CoreWebView2PermissionKind)this._nativeICoreWebView2PermissionSetting.PermissionKind;
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
				return permissionKind;
			}
		}

		public String PermissionOrigin
		{
			get
			{
				String permissionOrigin;
				try
				{
					permissionOrigin = this._nativeICoreWebView2PermissionSetting.PermissionOrigin;
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
				return permissionOrigin;
			}
		}

		public CoreWebView2PermissionState PermissionState
		{
			get
			{
				CoreWebView2PermissionState permissionState;
				try
				{
					permissionState = (CoreWebView2PermissionState)this._nativeICoreWebView2PermissionSetting.PermissionState;
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
				return permissionState;
			}
		}

		internal CoreWebView2PermissionSetting(Object rawCoreWebView2PermissionSetting)
		{
			this._rawNative = rawCoreWebView2PermissionSetting;
		}
	}
}