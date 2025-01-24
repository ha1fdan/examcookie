using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2Profile
	{
		internal ICoreWebView2Profile _nativeICoreWebView2ProfileValue;

		internal ICoreWebView2Profile2 _nativeICoreWebView2Profile2Value;

		internal ICoreWebView2Profile3 _nativeICoreWebView2Profile3Value;

		internal ICoreWebView2Profile4 _nativeICoreWebView2Profile4Value;

		internal ICoreWebView2Profile5 _nativeICoreWebView2Profile5Value;

		internal ICoreWebView2Profile6 _nativeICoreWebView2Profile6Value;

		internal Object _rawNative;

		internal ICoreWebView2Profile _nativeICoreWebView2Profile
		{
			get
			{
				if (this._nativeICoreWebView2ProfileValue == null)
				{
					try
					{
						this._nativeICoreWebView2ProfileValue = (ICoreWebView2Profile)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2ProfileValue;
			}
			set
			{
				this._nativeICoreWebView2ProfileValue = value;
			}
		}

		internal ICoreWebView2Profile2 _nativeICoreWebView2Profile2
		{
			get
			{
				if (this._nativeICoreWebView2Profile2Value == null)
				{
					try
					{
						this._nativeICoreWebView2Profile2Value = (ICoreWebView2Profile2)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2Profile2Value;
			}
			set
			{
				this._nativeICoreWebView2Profile2Value = value;
			}
		}

		internal ICoreWebView2Profile3 _nativeICoreWebView2Profile3
		{
			get
			{
				if (this._nativeICoreWebView2Profile3Value == null)
				{
					try
					{
						this._nativeICoreWebView2Profile3Value = (ICoreWebView2Profile3)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2Profile3Value;
			}
			set
			{
				this._nativeICoreWebView2Profile3Value = value;
			}
		}

		internal ICoreWebView2Profile4 _nativeICoreWebView2Profile4
		{
			get
			{
				if (this._nativeICoreWebView2Profile4Value == null)
				{
					try
					{
						this._nativeICoreWebView2Profile4Value = (ICoreWebView2Profile4)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2Profile4Value;
			}
			set
			{
				this._nativeICoreWebView2Profile4Value = value;
			}
		}

		internal ICoreWebView2Profile5 _nativeICoreWebView2Profile5
		{
			get
			{
				if (this._nativeICoreWebView2Profile5Value == null)
				{
					try
					{
						this._nativeICoreWebView2Profile5Value = (ICoreWebView2Profile5)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile5.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2Profile5Value;
			}
			set
			{
				this._nativeICoreWebView2Profile5Value = value;
			}
		}

		internal ICoreWebView2Profile6 _nativeICoreWebView2Profile6
		{
			get
			{
				if (this._nativeICoreWebView2Profile6Value == null)
				{
					try
					{
						this._nativeICoreWebView2Profile6Value = (ICoreWebView2Profile6)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile6.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2Profile6Value;
			}
			set
			{
				this._nativeICoreWebView2Profile6Value = value;
			}
		}

		public CoreWebView2CookieManager CookieManager
		{
			get
			{
				CoreWebView2CookieManager coreWebView2CookieManager;
				CoreWebView2CookieManager coreWebView2CookieManager1;
				try
				{
					if (this._nativeICoreWebView2Profile5.CookieManager == null)
					{
						coreWebView2CookieManager1 = null;
					}
					else
					{
						coreWebView2CookieManager1 = new CoreWebView2CookieManager(this._nativeICoreWebView2Profile5.CookieManager);
					}
					coreWebView2CookieManager = coreWebView2CookieManager1;
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
				return coreWebView2CookieManager;
			}
		}

		public String DefaultDownloadFolderPath
		{
			get
			{
				String defaultDownloadFolderPath;
				try
				{
					defaultDownloadFolderPath = this._nativeICoreWebView2Profile.DefaultDownloadFolderPath;
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
				return defaultDownloadFolderPath;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2Profile.DefaultDownloadFolderPath = value;
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

		public Boolean IsGeneralAutofillEnabled
		{
			get
			{
				Boolean isGeneralAutofillEnabled;
				try
				{
					isGeneralAutofillEnabled = this._nativeICoreWebView2Profile6.IsGeneralAutofillEnabled != 0;
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
				return isGeneralAutofillEnabled;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2Profile6.IsGeneralAutofillEnabled = (value ? 1 : 0);
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

		public Boolean IsInPrivateModeEnabled
		{
			get
			{
				Boolean isInPrivateModeEnabled;
				try
				{
					isInPrivateModeEnabled = this._nativeICoreWebView2Profile.IsInPrivateModeEnabled != 0;
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
				return isInPrivateModeEnabled;
			}
		}

		public Boolean IsPasswordAutosaveEnabled
		{
			get
			{
				Boolean isPasswordAutosaveEnabled;
				try
				{
					isPasswordAutosaveEnabled = this._nativeICoreWebView2Profile6.IsPasswordAutosaveEnabled != 0;
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
				return isPasswordAutosaveEnabled;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2Profile6.IsPasswordAutosaveEnabled = (value ? 1 : 0);
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

		public CoreWebView2PreferredColorScheme PreferredColorScheme
		{
			get
			{
				CoreWebView2PreferredColorScheme preferredColorScheme;
				try
				{
					preferredColorScheme = (CoreWebView2PreferredColorScheme)this._nativeICoreWebView2Profile.PreferredColorScheme;
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
				return preferredColorScheme;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2Profile.PreferredColorScheme = (COREWEBVIEW2_PREFERRED_COLOR_SCHEME)value;
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

		public CoreWebView2TrackingPreventionLevel PreferredTrackingPreventionLevel
		{
			get
			{
				CoreWebView2TrackingPreventionLevel preferredTrackingPreventionLevel;
				try
				{
					preferredTrackingPreventionLevel = (CoreWebView2TrackingPreventionLevel)this._nativeICoreWebView2Profile3.PreferredTrackingPreventionLevel;
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
				return preferredTrackingPreventionLevel;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2Profile3.PreferredTrackingPreventionLevel = (COREWEBVIEW2_TRACKING_PREVENTION_LEVEL)value;
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

		public String ProfileName
		{
			get
			{
				String profileName;
				try
				{
					profileName = this._nativeICoreWebView2Profile.ProfileName;
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
				return profileName;
			}
		}

		public String ProfilePath
		{
			get
			{
				String profilePath;
				try
				{
					profilePath = this._nativeICoreWebView2Profile.ProfilePath;
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
				return profilePath;
			}
		}

		internal CoreWebView2Profile(Object rawCoreWebView2Profile)
		{
			this._rawNative = rawCoreWebView2Profile;
		}

		public async Task ClearBrowsingDataAsync(CoreWebView2BrowsingDataKinds dataKinds, DateTime startTime, DateTime endTime)
		{
			CoreWebView2ClearBrowsingDataCompletedHandler coreWebView2ClearBrowsingDataCompletedHandler;
			try
			{
				DateTimeOffset dateTimeOffset = new DateTimeOffset(startTime);
				Double unixTimeSeconds = (Double)dateTimeOffset.ToUnixTimeSeconds();
				dateTimeOffset = new DateTimeOffset(endTime);
				Double num = (Double)dateTimeOffset.ToUnixTimeSeconds();
				coreWebView2ClearBrowsingDataCompletedHandler = new CoreWebView2ClearBrowsingDataCompletedHandler();
				this._nativeICoreWebView2Profile2.ClearBrowsingDataInTimeRange((COREWEBVIEW2_BROWSING_DATA_KINDS)dataKinds, unixTimeSeconds, num, coreWebView2ClearBrowsingDataCompletedHandler);
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
			await coreWebView2ClearBrowsingDataCompletedHandler;
			Marshal.ThrowExceptionForHR(coreWebView2ClearBrowsingDataCompletedHandler.errCode);
			coreWebView2ClearBrowsingDataCompletedHandler = null;
		}

		public async Task ClearBrowsingDataAsync()
		{
			CoreWebView2ClearBrowsingDataCompletedHandler coreWebView2ClearBrowsingDataCompletedHandler;
			try
			{
				coreWebView2ClearBrowsingDataCompletedHandler = new CoreWebView2ClearBrowsingDataCompletedHandler();
				this._nativeICoreWebView2Profile2.ClearBrowsingDataAll(coreWebView2ClearBrowsingDataCompletedHandler);
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
			await coreWebView2ClearBrowsingDataCompletedHandler;
			Marshal.ThrowExceptionForHR(coreWebView2ClearBrowsingDataCompletedHandler.errCode);
			coreWebView2ClearBrowsingDataCompletedHandler = null;
		}

		public async Task ClearBrowsingDataAsync(CoreWebView2BrowsingDataKinds dataKinds)
		{
			CoreWebView2ClearBrowsingDataCompletedHandler coreWebView2ClearBrowsingDataCompletedHandler;
			try
			{
				coreWebView2ClearBrowsingDataCompletedHandler = new CoreWebView2ClearBrowsingDataCompletedHandler();
				this._nativeICoreWebView2Profile2.ClearBrowsingData((COREWEBVIEW2_BROWSING_DATA_KINDS)dataKinds, coreWebView2ClearBrowsingDataCompletedHandler);
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
			await coreWebView2ClearBrowsingDataCompletedHandler;
			Marshal.ThrowExceptionForHR(coreWebView2ClearBrowsingDataCompletedHandler.errCode);
			coreWebView2ClearBrowsingDataCompletedHandler = null;
		}

		public async Task<IReadOnlyList<CoreWebView2PermissionSetting>> GetNonDefaultPermissionSettingsAsync()
		{
			CoreWebView2GetNonDefaultPermissionSettingsCompletedHandler coreWebView2GetNonDefaultPermissionSettingsCompletedHandler;
			try
			{
				coreWebView2GetNonDefaultPermissionSettingsCompletedHandler = new CoreWebView2GetNonDefaultPermissionSettingsCompletedHandler();
				this._nativeICoreWebView2Profile4.GetNonDefaultPermissionSettings(coreWebView2GetNonDefaultPermissionSettingsCompletedHandler);
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
			await coreWebView2GetNonDefaultPermissionSettingsCompletedHandler;
			Marshal.ThrowExceptionForHR(coreWebView2GetNonDefaultPermissionSettingsCompletedHandler.errCode);
			IReadOnlyList<CoreWebView2PermissionSetting> readOnlyList = coreWebView2GetNonDefaultPermissionSettingsCompletedHandler.collectionView;
			coreWebView2GetNonDefaultPermissionSettingsCompletedHandler = null;
			return readOnlyList;
		}

		public async Task SetPermissionStateAsync(CoreWebView2PermissionKind PermissionKind, String origin, CoreWebView2PermissionState State)
		{
			CoreWebView2SetPermissionStateCompletedHandler coreWebView2SetPermissionStateCompletedHandler;
			try
			{
				coreWebView2SetPermissionStateCompletedHandler = new CoreWebView2SetPermissionStateCompletedHandler();
				this._nativeICoreWebView2Profile4.SetPermissionState((COREWEBVIEW2_PERMISSION_KIND)PermissionKind, origin, (COREWEBVIEW2_PERMISSION_STATE)State, coreWebView2SetPermissionStateCompletedHandler);
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
			await coreWebView2SetPermissionStateCompletedHandler;
			Marshal.ThrowExceptionForHR(coreWebView2SetPermissionStateCompletedHandler.errCode);
			coreWebView2SetPermissionStateCompletedHandler = null;
		}
	}
}