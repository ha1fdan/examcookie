using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2EnvironmentOptions
	{
		internal ICoreWebView2EnvironmentOptions _nativeICoreWebView2EnvironmentOptionsValue;

		internal ICoreWebView2EnvironmentOptions2 _nativeICoreWebView2EnvironmentOptions2Value;

		internal ICoreWebView2EnvironmentOptions3 _nativeICoreWebView2EnvironmentOptions3Value;

		internal ICoreWebView2EnvironmentOptions4 _nativeICoreWebView2EnvironmentOptions4Value;

		internal ICoreWebView2EnvironmentOptions5 _nativeICoreWebView2EnvironmentOptions5Value;

		internal Object _rawNative;

		internal ICoreWebView2EnvironmentOptions _nativeICoreWebView2EnvironmentOptions
		{
			get
			{
				if (this._nativeICoreWebView2EnvironmentOptionsValue == null)
				{
					try
					{
						this._nativeICoreWebView2EnvironmentOptionsValue = (ICoreWebView2EnvironmentOptions)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2EnvironmentOptionsValue;
			}
			set
			{
				this._nativeICoreWebView2EnvironmentOptionsValue = value;
			}
		}

		internal ICoreWebView2EnvironmentOptions2 _nativeICoreWebView2EnvironmentOptions2
		{
			get
			{
				if (this._nativeICoreWebView2EnvironmentOptions2Value == null)
				{
					try
					{
						this._nativeICoreWebView2EnvironmentOptions2Value = (ICoreWebView2EnvironmentOptions2)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2EnvironmentOptions2Value;
			}
			set
			{
				this._nativeICoreWebView2EnvironmentOptions2Value = value;
			}
		}

		internal ICoreWebView2EnvironmentOptions3 _nativeICoreWebView2EnvironmentOptions3
		{
			get
			{
				if (this._nativeICoreWebView2EnvironmentOptions3Value == null)
				{
					try
					{
						this._nativeICoreWebView2EnvironmentOptions3Value = (ICoreWebView2EnvironmentOptions3)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2EnvironmentOptions3Value;
			}
			set
			{
				this._nativeICoreWebView2EnvironmentOptions3Value = value;
			}
		}

		internal ICoreWebView2EnvironmentOptions4 _nativeICoreWebView2EnvironmentOptions4
		{
			get
			{
				if (this._nativeICoreWebView2EnvironmentOptions4Value == null)
				{
					try
					{
						this._nativeICoreWebView2EnvironmentOptions4Value = (ICoreWebView2EnvironmentOptions4)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2EnvironmentOptions4Value;
			}
			set
			{
				this._nativeICoreWebView2EnvironmentOptions4Value = value;
			}
		}

		internal ICoreWebView2EnvironmentOptions5 _nativeICoreWebView2EnvironmentOptions5
		{
			get
			{
				if (this._nativeICoreWebView2EnvironmentOptions5Value == null)
				{
					try
					{
						this._nativeICoreWebView2EnvironmentOptions5Value = (ICoreWebView2EnvironmentOptions5)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions5.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2EnvironmentOptions5Value;
			}
			set
			{
				this._nativeICoreWebView2EnvironmentOptions5Value = value;
			}
		}

		public String AdditionalBrowserArguments
		{
			get
			{
				String additionalBrowserArguments;
				try
				{
					additionalBrowserArguments = this._nativeICoreWebView2EnvironmentOptions.AdditionalBrowserArguments;
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
				return additionalBrowserArguments;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2EnvironmentOptions.AdditionalBrowserArguments = value;
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

		public Boolean AllowSingleSignOnUsingOSPrimaryAccount
		{
			get
			{
				Boolean allowSingleSignOnUsingOSPrimaryAccount;
				try
				{
					allowSingleSignOnUsingOSPrimaryAccount = this._nativeICoreWebView2EnvironmentOptions.AllowSingleSignOnUsingOSPrimaryAccount != 0;
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
				return allowSingleSignOnUsingOSPrimaryAccount;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2EnvironmentOptions.AllowSingleSignOnUsingOSPrimaryAccount = (value ? 1 : 0);
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

		public List<CoreWebView2CustomSchemeRegistration> CustomSchemeRegistrations
		{
			get;
		}

		public Boolean EnableTrackingPrevention
		{
			get
			{
				Boolean enableTrackingPrevention;
				try
				{
					enableTrackingPrevention = this._nativeICoreWebView2EnvironmentOptions5.EnableTrackingPrevention != 0;
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
				return enableTrackingPrevention;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2EnvironmentOptions5.EnableTrackingPrevention = (value ? 1 : 0);
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

		public Boolean ExclusiveUserDataFolderAccess
		{
			get
			{
				Boolean exclusiveUserDataFolderAccess;
				try
				{
					exclusiveUserDataFolderAccess = this._nativeICoreWebView2EnvironmentOptions2.ExclusiveUserDataFolderAccess != 0;
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
				return exclusiveUserDataFolderAccess;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2EnvironmentOptions2.ExclusiveUserDataFolderAccess = (value ? 1 : 0);
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

		public Boolean IsCustomCrashReportingEnabled
		{
			get
			{
				Boolean isCustomCrashReportingEnabled;
				try
				{
					isCustomCrashReportingEnabled = this._nativeICoreWebView2EnvironmentOptions3.IsCustomCrashReportingEnabled != 0;
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
				return isCustomCrashReportingEnabled;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2EnvironmentOptions3.IsCustomCrashReportingEnabled = (value ? 1 : 0);
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

		public String Language
		{
			get
			{
				String language;
				try
				{
					language = this._nativeICoreWebView2EnvironmentOptions.Language;
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
				return language;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2EnvironmentOptions.Language = value;
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

		public String TargetCompatibleBrowserVersion
		{
			get
			{
				String targetCompatibleBrowserVersion;
				try
				{
					targetCompatibleBrowserVersion = this._nativeICoreWebView2EnvironmentOptions.TargetCompatibleBrowserVersion;
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
				return targetCompatibleBrowserVersion;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2EnvironmentOptions.TargetCompatibleBrowserVersion = value;
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

		public CoreWebView2EnvironmentOptions(String additionalBrowserArguments = null, String language = null, String targetCompatibleBrowserVersion = null, Boolean allowSingleSignOnUsingOSPrimaryAccount = false, List<CoreWebView2CustomSchemeRegistration> customSchemeRegistrations = null)
		{
			targetCompatibleBrowserVersion = BrowserInfo.PRODUCT_VERSION;
			CoreWebView2EnvironmentOptions.RawOptions rawOption = new CoreWebView2EnvironmentOptions.RawOptions(additionalBrowserArguments, language, targetCompatibleBrowserVersion, allowSingleSignOnUsingOSPrimaryAccount, customSchemeRegistrations);
			this._nativeICoreWebView2EnvironmentOptions = rawOption;
			this._nativeICoreWebView2EnvironmentOptions2 = rawOption;
			this._nativeICoreWebView2EnvironmentOptions3 = rawOption;
			this._nativeICoreWebView2EnvironmentOptions4 = rawOption;
			this._nativeICoreWebView2EnvironmentOptions5 = rawOption;
			this.CustomSchemeRegistrations = customSchemeRegistrations;
		}

		internal CoreWebView2EnvironmentOptions(Object rawCoreWebView2EnvironmentOptions)
		{
			this._rawNative = rawCoreWebView2EnvironmentOptions;
		}

		private class RawOptions : ICoreWebView2EnvironmentOptions, ICoreWebView2EnvironmentOptions2, ICoreWebView2EnvironmentOptions3, ICoreWebView2EnvironmentOptions4, ICoreWebView2EnvironmentOptions5
		{
			public String AdditionalBrowserArguments
			{
				get;
				set;
			}

			public Int32 AllowSingleSignOnUsingOSPrimaryAccount
			{
				get;
				set;
			}

			public List<CoreWebView2CustomSchemeRegistration> CustomSchemeRegistrations
			{
				get;
				set;
			}

			public Int32 EnableTrackingPrevention
			{
				get;
				set;
			}

			public Int32 ExclusiveUserDataFolderAccess
			{
				get;
				set;
			}

			public Int32 IsCustomCrashReportingEnabled
			{
				get;
				set;
			}

			public String Language
			{
				get;
				set;
			}

			public String TargetCompatibleBrowserVersion
			{
				get;
				set;
			}

			public RawOptions(String additionalBrowserArguments, String language, String targetCompatibleBrowserVersion, Boolean allowSingleSignOnUsingOSPrimaryAccount, List<CoreWebView2CustomSchemeRegistration> customSchemeRegistrations)
			{
				this.AdditionalBrowserArguments = additionalBrowserArguments;
				this.Language = language;
				this.TargetCompatibleBrowserVersion = targetCompatibleBrowserVersion;
				this.AllowSingleSignOnUsingOSPrimaryAccount = (allowSingleSignOnUsingOSPrimaryAccount ? 1 : 0);
				this.CustomSchemeRegistrations = customSchemeRegistrations;
			}

			public Void GetCustomSchemeRegistrations(out UInt32 count, IntPtr registrationsPtr)
			{
				if (this.CustomSchemeRegistrations == null || this.CustomSchemeRegistrations.get_Count() == 0)
				{
					count = 0;
					return;
				}
				count = (UInt32)this.CustomSchemeRegistrations.get_Count();
				Marshal.SizeOf<IntPtr>();
				IntPtr intPtr = Marshal.AllocCoTaskMem(count * Marshal.SizeOf<IntPtr>());
				for (Int32 i = 0; (Int64)i < (UInt64)count; i++)
				{
					Marshal.WriteIntPtr(intPtr + i * Marshal.SizeOf<IntPtr>(), this.CustomSchemeRegistrations.get_Item(i).GetNative());
				}
				Marshal.WriteIntPtr(registrationsPtr, intPtr);
			}

			public Void SetCustomSchemeRegistrations(UInt32 count, ref ICoreWebView2CustomSchemeRegistration registration)
			{
				throw new NotImplementedException();
			}
		}
	}
}