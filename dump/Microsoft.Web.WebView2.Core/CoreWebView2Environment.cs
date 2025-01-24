using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2Environment
	{
		private const Char DirectorySeparatorChar = '\\';

		private const Char AltDirectorySeparatorChar = '/';

		private const Char VolumeSeparatorChar = ':';

		private static Boolean webView2LoaderLoaded;

		private static String loaderDllFolderPath;

		internal ICoreWebView2Environment _nativeICoreWebView2EnvironmentValue;

		internal ICoreWebView2Environment2 _nativeICoreWebView2Environment2Value;

		internal ICoreWebView2Environment3 _nativeICoreWebView2Environment3Value;

		internal ICoreWebView2Environment4 _nativeICoreWebView2Environment4Value;

		internal ICoreWebView2Environment5 _nativeICoreWebView2Environment5Value;

		internal ICoreWebView2Environment6 _nativeICoreWebView2Environment6Value;

		internal ICoreWebView2Environment7 _nativeICoreWebView2Environment7Value;

		internal ICoreWebView2Environment8 _nativeICoreWebView2Environment8Value;

		internal ICoreWebView2Environment9 _nativeICoreWebView2Environment9Value;

		internal ICoreWebView2Environment10 _nativeICoreWebView2Environment10Value;

		internal ICoreWebView2Environment11 _nativeICoreWebView2Environment11Value;

		internal ICoreWebView2Environment12 _nativeICoreWebView2Environment12Value;

		internal Object _rawNative;

		private EventRegistrationToken _newBrowserVersionAvailableToken;

		private EventHandler<Object> newBrowserVersionAvailable;

		private EventRegistrationToken _browserProcessExitedToken;

		private EventHandler<CoreWebView2BrowserProcessExitedEventArgs> browserProcessExited;

		private EventRegistrationToken _processInfosChangedToken;

		private EventHandler<Object> processInfosChanged;

		internal ICoreWebView2Environment _nativeICoreWebView2Environment
		{
			get
			{
				if (this._nativeICoreWebView2EnvironmentValue == null)
				{
					try
					{
						this._nativeICoreWebView2EnvironmentValue = (ICoreWebView2Environment)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2EnvironmentValue;
			}
			set
			{
				this._nativeICoreWebView2EnvironmentValue = value;
			}
		}

		internal ICoreWebView2Environment10 _nativeICoreWebView2Environment10
		{
			get
			{
				if (this._nativeICoreWebView2Environment10Value == null)
				{
					try
					{
						this._nativeICoreWebView2Environment10Value = (ICoreWebView2Environment10)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment10.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2Environment10Value;
			}
			set
			{
				this._nativeICoreWebView2Environment10Value = value;
			}
		}

		internal ICoreWebView2Environment11 _nativeICoreWebView2Environment11
		{
			get
			{
				if (this._nativeICoreWebView2Environment11Value == null)
				{
					try
					{
						this._nativeICoreWebView2Environment11Value = (ICoreWebView2Environment11)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment11.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2Environment11Value;
			}
			set
			{
				this._nativeICoreWebView2Environment11Value = value;
			}
		}

		internal ICoreWebView2Environment12 _nativeICoreWebView2Environment12
		{
			get
			{
				if (this._nativeICoreWebView2Environment12Value == null)
				{
					try
					{
						this._nativeICoreWebView2Environment12Value = (ICoreWebView2Environment12)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment12.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2Environment12Value;
			}
			set
			{
				this._nativeICoreWebView2Environment12Value = value;
			}
		}

		internal ICoreWebView2Environment2 _nativeICoreWebView2Environment2
		{
			get
			{
				if (this._nativeICoreWebView2Environment2Value == null)
				{
					try
					{
						this._nativeICoreWebView2Environment2Value = (ICoreWebView2Environment2)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2Environment2Value;
			}
			set
			{
				this._nativeICoreWebView2Environment2Value = value;
			}
		}

		internal ICoreWebView2Environment3 _nativeICoreWebView2Environment3
		{
			get
			{
				if (this._nativeICoreWebView2Environment3Value == null)
				{
					try
					{
						this._nativeICoreWebView2Environment3Value = (ICoreWebView2Environment3)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2Environment3Value;
			}
			set
			{
				this._nativeICoreWebView2Environment3Value = value;
			}
		}

		internal ICoreWebView2Environment4 _nativeICoreWebView2Environment4
		{
			get
			{
				if (this._nativeICoreWebView2Environment4Value == null)
				{
					try
					{
						this._nativeICoreWebView2Environment4Value = (ICoreWebView2Environment4)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2Environment4Value;
			}
			set
			{
				this._nativeICoreWebView2Environment4Value = value;
			}
		}

		internal ICoreWebView2Environment5 _nativeICoreWebView2Environment5
		{
			get
			{
				if (this._nativeICoreWebView2Environment5Value == null)
				{
					try
					{
						this._nativeICoreWebView2Environment5Value = (ICoreWebView2Environment5)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment5.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2Environment5Value;
			}
			set
			{
				this._nativeICoreWebView2Environment5Value = value;
			}
		}

		internal ICoreWebView2Environment6 _nativeICoreWebView2Environment6
		{
			get
			{
				if (this._nativeICoreWebView2Environment6Value == null)
				{
					try
					{
						this._nativeICoreWebView2Environment6Value = (ICoreWebView2Environment6)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment6.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2Environment6Value;
			}
			set
			{
				this._nativeICoreWebView2Environment6Value = value;
			}
		}

		internal ICoreWebView2Environment7 _nativeICoreWebView2Environment7
		{
			get
			{
				if (this._nativeICoreWebView2Environment7Value == null)
				{
					try
					{
						this._nativeICoreWebView2Environment7Value = (ICoreWebView2Environment7)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment7.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2Environment7Value;
			}
			set
			{
				this._nativeICoreWebView2Environment7Value = value;
			}
		}

		internal ICoreWebView2Environment8 _nativeICoreWebView2Environment8
		{
			get
			{
				if (this._nativeICoreWebView2Environment8Value == null)
				{
					try
					{
						this._nativeICoreWebView2Environment8Value = (ICoreWebView2Environment8)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment8.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2Environment8Value;
			}
			set
			{
				this._nativeICoreWebView2Environment8Value = value;
			}
		}

		internal ICoreWebView2Environment9 _nativeICoreWebView2Environment9
		{
			get
			{
				if (this._nativeICoreWebView2Environment9Value == null)
				{
					try
					{
						this._nativeICoreWebView2Environment9Value = (ICoreWebView2Environment9)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment9.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2Environment9Value;
			}
			set
			{
				this._nativeICoreWebView2Environment9Value = value;
			}
		}

		public String BrowserVersionString
		{
			get
			{
				String browserVersionString;
				try
				{
					browserVersionString = this._nativeICoreWebView2Environment.BrowserVersionString;
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
				return browserVersionString;
			}
		}

		public String FailureReportFolderPath
		{
			get
			{
				String failureReportFolderPath;
				try
				{
					failureReportFolderPath = this._nativeICoreWebView2Environment11.FailureReportFolderPath;
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
				return failureReportFolderPath;
			}
		}

		public String UserDataFolder
		{
			get
			{
				String userDataFolder;
				try
				{
					userDataFolder = this._nativeICoreWebView2Environment7.UserDataFolder;
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
				return userDataFolder;
			}
		}

		internal CoreWebView2Environment(Object rawCoreWebView2Environment)
		{
			this._rawNative = rawCoreWebView2Environment;
		}

		[DllImport("WebView2Loader.dll", CharSet=1, ExactSpelling=false)]
		internal static extern Int32 CompareBrowserVersions([In] String version1, [In] String version2, ref Int32 result);

		public static Int32 CompareBrowserVersions(String version1, String version2)
		{
			CoreWebView2Environment.LoadWebView2LoaderDll();
			Int32 num = 0;
			Marshal.ThrowExceptionForHR(CoreWebView2Environment.CompareBrowserVersions(version1, version2, ref num));
			return num;
		}

		public static async Task<CoreWebView2Environment> CreateAsync(String browserExecutableFolder = null, String userDataFolder = null, CoreWebView2EnvironmentOptions options = null)
		{
			CoreWebView2Environment.LoadWebView2LoaderDll();
			CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler coreWebView2CreateCoreWebView2EnvironmentCompletedHandler = new CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler();
			CoreWebView2EnvironmentOptions coreWebView2EnvironmentOption = options;
			if (coreWebView2EnvironmentOption == null)
			{
				coreWebView2EnvironmentOption = new CoreWebView2EnvironmentOptions(null, null, null, false, null);
			}
			CoreWebView2EnvironmentOptions coreWebView2EnvironmentOption1 = coreWebView2EnvironmentOption;
			Int32 num = CoreWebView2Environment.CreateCoreWebView2EnvironmentWithOptions(browserExecutableFolder, userDataFolder, coreWebView2EnvironmentOption1._nativeICoreWebView2EnvironmentOptions, coreWebView2CreateCoreWebView2EnvironmentCompletedHandler);
			if (num == -2147024894)
			{
				throw new WebView2RuntimeNotFoundException(Marshal.GetExceptionForHR(num));
			}
			Marshal.ThrowExceptionForHR(num);
			await coreWebView2CreateCoreWebView2EnvironmentCompletedHandler;
			Marshal.ThrowExceptionForHR(coreWebView2CreateCoreWebView2EnvironmentCompletedHandler.errCode);
			CoreWebView2Environment coreWebView2Environment = coreWebView2CreateCoreWebView2EnvironmentCompletedHandler.createdEnvironment;
			coreWebView2CreateCoreWebView2EnvironmentCompletedHandler = null;
			return coreWebView2Environment;
		}

		public CoreWebView2ContextMenuItem CreateContextMenuItem(String Label, Stream iconStream, CoreWebView2ContextMenuItemKind Kind)
		{
			CoreWebView2ContextMenuItem coreWebView2ContextMenuItem;
			IStream managedIStream;
			try
			{
				ICoreWebView2Environment9 variable = this._nativeICoreWebView2Environment9;
				String label = Label;
				if (iconStream == null)
				{
					managedIStream = null;
				}
				else
				{
					managedIStream = new ManagedIStream(iconStream);
				}
				coreWebView2ContextMenuItem = new CoreWebView2ContextMenuItem(variable.CreateContextMenuItem(label, managedIStream, (COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND)Kind));
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
			return coreWebView2ContextMenuItem;
		}

		public async Task<CoreWebView2CompositionController> CreateCoreWebView2CompositionControllerAsync(IntPtr ParentWindow, CoreWebView2ControllerOptions options)
		{
			CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler coreWebView2CreateCoreWebView2CompositionControllerCompletedHandler;
			try
			{
				coreWebView2CreateCoreWebView2CompositionControllerCompletedHandler = new CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler();
				this._nativeICoreWebView2Environment10.CreateCoreWebView2CompositionControllerWithOptions(ParentWindow, options._nativeICoreWebView2ControllerOptions, coreWebView2CreateCoreWebView2CompositionControllerCompletedHandler);
			}
			catch (InvalidCastException invalidCastException1)
			{
				InvalidCastException invalidCastException = invalidCastException1;
				if (invalidCastException.get_HResult() != -2147467262)
				{
					throw invalidCastException;
				}
				throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", invalidCastException);
			}
			catch (COMException cOMException1)
			{
				COMException cOMException = cOMException1;
				if (cOMException.get_HResult() != -2147019873)
				{
					throw cOMException;
				}
				throw new InvalidOperationException("CreateCoreWebView2CompositionControllerAsync failed to create the composition controller due to incompatible options.", cOMException);
			}
			await coreWebView2CreateCoreWebView2CompositionControllerCompletedHandler;
			Marshal.ThrowExceptionForHR(coreWebView2CreateCoreWebView2CompositionControllerCompletedHandler.errCode);
			CoreWebView2CompositionController coreWebView2CompositionController = coreWebView2CreateCoreWebView2CompositionControllerCompletedHandler.webView;
			coreWebView2CreateCoreWebView2CompositionControllerCompletedHandler = null;
			return coreWebView2CompositionController;
		}

		public async Task<CoreWebView2CompositionController> CreateCoreWebView2CompositionControllerAsync(IntPtr ParentWindow)
		{
			CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler coreWebView2CreateCoreWebView2CompositionControllerCompletedHandler;
			try
			{
				coreWebView2CreateCoreWebView2CompositionControllerCompletedHandler = new CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler();
				this._nativeICoreWebView2Environment3.CreateCoreWebView2CompositionController(ParentWindow, coreWebView2CreateCoreWebView2CompositionControllerCompletedHandler);
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
			await coreWebView2CreateCoreWebView2CompositionControllerCompletedHandler;
			Marshal.ThrowExceptionForHR(coreWebView2CreateCoreWebView2CompositionControllerCompletedHandler.errCode);
			CoreWebView2CompositionController coreWebView2CompositionController = coreWebView2CreateCoreWebView2CompositionControllerCompletedHandler.webView;
			coreWebView2CreateCoreWebView2CompositionControllerCompletedHandler = null;
			return coreWebView2CompositionController;
		}

		public async Task<CoreWebView2Controller> CreateCoreWebView2ControllerAsync(IntPtr ParentWindow, CoreWebView2ControllerOptions options)
		{
			CoreWebView2CreateCoreWebView2ControllerCompletedHandler coreWebView2CreateCoreWebView2ControllerCompletedHandler;
			try
			{
				coreWebView2CreateCoreWebView2ControllerCompletedHandler = new CoreWebView2CreateCoreWebView2ControllerCompletedHandler();
				this._nativeICoreWebView2Environment10.CreateCoreWebView2ControllerWithOptions(ParentWindow, options._nativeICoreWebView2ControllerOptions, coreWebView2CreateCoreWebView2ControllerCompletedHandler);
			}
			catch (InvalidCastException invalidCastException1)
			{
				InvalidCastException invalidCastException = invalidCastException1;
				if (invalidCastException.get_HResult() != -2147467262)
				{
					throw invalidCastException;
				}
				throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", invalidCastException);
			}
			catch (COMException cOMException1)
			{
				COMException cOMException = cOMException1;
				if (cOMException.get_HResult() != -2147019873)
				{
					throw cOMException;
				}
				throw new InvalidOperationException("CreateCoreWebView2ControllerAsync failed to create the controller due to incompatible options.", cOMException);
			}
			await coreWebView2CreateCoreWebView2ControllerCompletedHandler;
			Marshal.ThrowExceptionForHR(coreWebView2CreateCoreWebView2ControllerCompletedHandler.errCode);
			CoreWebView2Controller coreWebView2Controller = coreWebView2CreateCoreWebView2ControllerCompletedHandler.createdController;
			coreWebView2CreateCoreWebView2ControllerCompletedHandler = null;
			return coreWebView2Controller;
		}

		public async Task<CoreWebView2Controller> CreateCoreWebView2ControllerAsync(IntPtr ParentWindow)
		{
			CoreWebView2CreateCoreWebView2ControllerCompletedHandler coreWebView2CreateCoreWebView2ControllerCompletedHandler;
			try
			{
				coreWebView2CreateCoreWebView2ControllerCompletedHandler = new CoreWebView2CreateCoreWebView2ControllerCompletedHandler();
				this._nativeICoreWebView2Environment.CreateCoreWebView2Controller(ParentWindow, coreWebView2CreateCoreWebView2ControllerCompletedHandler);
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
			await coreWebView2CreateCoreWebView2ControllerCompletedHandler;
			Marshal.ThrowExceptionForHR(coreWebView2CreateCoreWebView2ControllerCompletedHandler.errCode);
			CoreWebView2Controller coreWebView2Controller = coreWebView2CreateCoreWebView2ControllerCompletedHandler.createdController;
			coreWebView2CreateCoreWebView2ControllerCompletedHandler = null;
			return coreWebView2Controller;
		}

		public CoreWebView2ControllerOptions CreateCoreWebView2ControllerOptions()
		{
			CoreWebView2ControllerOptions coreWebView2ControllerOption;
			try
			{
				coreWebView2ControllerOption = new CoreWebView2ControllerOptions(this._nativeICoreWebView2Environment10.CreateCoreWebView2ControllerOptions());
			}
			catch (InvalidCastException invalidCastException1)
			{
				InvalidCastException invalidCastException = invalidCastException1;
				if (invalidCastException.get_HResult() != -2147467262)
				{
					throw invalidCastException;
				}
				throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", invalidCastException);
			}
			catch (COMException cOMException1)
			{
				COMException cOMException = cOMException1;
				if (cOMException.get_HResult() != -2147019873)
				{
					throw cOMException;
				}
				throw new InvalidOperationException("CreateCoreWebView2ControllerOptions members cannot be accessed after the WebView2 control is disposed.", cOMException);
			}
			return coreWebView2ControllerOption;
		}

		[DllImport("WebView2Loader.dll", CharSet=1, ExactSpelling=false)]
		internal static extern Int32 CreateCoreWebView2EnvironmentWithOptions([In] String browserExecutableFolder, [In] String userDataFolder, ICoreWebView2EnvironmentOptions options, ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environment_created_handler);

		public CoreWebView2PointerInfo CreateCoreWebView2PointerInfo()
		{
			CoreWebView2PointerInfo coreWebView2PointerInfo;
			try
			{
				coreWebView2PointerInfo = new CoreWebView2PointerInfo(this._nativeICoreWebView2Environment3.CreateCoreWebView2PointerInfo());
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
			return coreWebView2PointerInfo;
		}

		public CoreWebView2PrintSettings CreatePrintSettings()
		{
			CoreWebView2PrintSettings coreWebView2PrintSetting;
			try
			{
				coreWebView2PrintSetting = new CoreWebView2PrintSettings(this._nativeICoreWebView2Environment6.CreatePrintSettings());
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
			return coreWebView2PrintSetting;
		}

		public CoreWebView2SharedBuffer CreateSharedBuffer(UInt64 Size)
		{
			CoreWebView2SharedBuffer coreWebView2SharedBuffer;
			try
			{
				coreWebView2SharedBuffer = new CoreWebView2SharedBuffer(this._nativeICoreWebView2Environment12.CreateSharedBuffer(Size));
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
			return coreWebView2SharedBuffer;
		}

		public CoreWebView2WebResourceRequest CreateWebResourceRequest(String uri, String Method, Stream postData, String Headers)
		{
			IStream managedIStream;
			ICoreWebView2Environment2 variable = this._nativeICoreWebView2Environment2;
			String str = uri;
			String method = Method;
			if (postData == null)
			{
				managedIStream = null;
			}
			else
			{
				managedIStream = new ManagedIStream(postData);
			}
			return new CoreWebView2WebResourceRequest(variable.CreateWebResourceRequest(str, method, managedIStream, Headers));
		}

		public CoreWebView2WebResourceResponse CreateWebResourceResponse(Stream Content, Int32 StatusCode, String ReasonPhrase, String Headers)
		{
			CoreWebView2WebResourceResponse coreWebView2WebResourceResponse;
			IStream managedIStream;
			try
			{
				ICoreWebView2Environment variable = this._nativeICoreWebView2Environment;
				if (Content == null)
				{
					managedIStream = null;
				}
				else
				{
					managedIStream = new ManagedIStream(Content);
				}
				coreWebView2WebResourceResponse = new CoreWebView2WebResourceResponse(variable.CreateWebResourceResponse(managedIStream, StatusCode, ReasonPhrase, Headers));
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
			return coreWebView2WebResourceResponse;
		}

		private static CoreWebView2Environment.ProcessorArchitecture GetArchitecture()
		{
			CoreWebView2Environment.SYSTEM_INFO sYSTEMINFO;
			CoreWebView2Environment.GetSystemInfo(out sYSTEMINFO);
			return (CoreWebView2Environment.ProcessorArchitecture)sYSTEMINFO.wProcessorArchitecture;
		}

		private static String GetAssemblyCodeBaseDirectory()
		{
			String str;
			try
			{
				String codeBase = typeof(CoreWebView2Environment).get_Assembly().get_CodeBase();
				if (codeBase.StartsWith("file:///"))
				{
					codeBase = Path.GetDirectoryName(codeBase.Substring("file:///".get_Length()));
				}
				str = codeBase;
			}
			catch
			{
				str = "";
			}
			return str;
		}

		private static String GetAssemblyLocationDirectory()
		{
			String directoryName;
			try
			{
				directoryName = Path.GetDirectoryName(typeof(CoreWebView2Environment).get_Assembly().get_Location());
			}
			catch
			{
				directoryName = "";
			}
			return directoryName;
		}

		public static String GetAvailableBrowserVersionString(String browserExecutableFolder = null)
		{
			CoreWebView2Environment.LoadWebView2LoaderDll();
			String str = null;
			Int32 availableCoreWebView2BrowserVersionString = CoreWebView2Environment.GetAvailableCoreWebView2BrowserVersionString(browserExecutableFolder, ref str);
			if (availableCoreWebView2BrowserVersionString == -2147024894)
			{
				throw new WebView2RuntimeNotFoundException(Marshal.GetExceptionForHR(availableCoreWebView2BrowserVersionString));
			}
			Marshal.ThrowExceptionForHR(availableCoreWebView2BrowserVersionString);
			return str;
		}

		[DllImport("WebView2Loader.dll", CharSet=1, ExactSpelling=false)]
		internal static extern Int32 GetAvailableCoreWebView2BrowserVersionString([In] String browserExecutableFolder, ref String versionInfo);

		private static String GetCurrentDllRuningDirectory()
		{
			String str;
			try
			{
				IntPtr moduleHandle = CoreWebView2Environment.GetModuleHandle("Microsoft.Web.WebView2.Core.dll");
				StringBuilder stringBuilder = new StringBuilder(256);
				str = (CoreWebView2Environment.GetModuleFileName(moduleHandle, stringBuilder, stringBuilder.get_Capacity()) != 0 ? Path.GetDirectoryName(stringBuilder.ToString()) : "");
			}
			catch
			{
				str = "";
			}
			return str;
		}

		[DllImport("kernel32.dll", CharSet=1, ExactSpelling=false, SetLastError=true)]
		private static extern UInt32 GetModuleFileName([In] IntPtr hModule, [Out] StringBuilder lpFilename, [In] Int32 nSize);

		[DllImport("kernel32.dll", CharSet=4, ExactSpelling=false)]
		private static extern IntPtr GetModuleHandle(String lpModuleName);

		private static String GetProcessArchSubFolder()
		{
			String str = "runtimes\\win-";
			CoreWebView2Environment.ProcessorArchitecture architecture = CoreWebView2Environment.GetArchitecture();
			if (architecture == CoreWebView2Environment.ProcessorArchitecture.x86)
			{
				str = String.Concat(str, "x86");
			}
			else if (architecture == CoreWebView2Environment.ProcessorArchitecture.x64)
			{
				str = String.Concat(str, "x64");
			}
			else
			{
				if (architecture != CoreWebView2Environment.ProcessorArchitecture.ARM64)
				{
					throw new NotSupportedException("Unknown Processor Architecture of WebView2Loader.dll is not supported");
				}
				str = String.Concat(str, "arm64");
			}
			return Path.Combine(str, "native");
		}

		public IReadOnlyList<CoreWebView2ProcessInfo> GetProcessInfos()
		{
			IReadOnlyList<CoreWebView2ProcessInfo> net;
			try
			{
				net = COMDotNetTypeConverter.ProcessInfoCollectionCOMToNet(this._nativeICoreWebView2Environment8.GetProcessInfos());
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

		[DllImport("kernel32.dll", CharSet=1, ExactSpelling=false, SetLastError=true)]
		private static extern Void GetSystemInfo(out CoreWebView2Environment.SYSTEM_INFO lpSystemInfo);

		private static Boolean IsDirectorySeparator(Char c)
		{
			if (c == '\\')
			{
				return true;
			}
			return c == '/';
		}

		private static Boolean IsDotNetFramework()
		{
			return CustomAttributeExtensions.GetCustomAttribute<AssemblyProductAttribute>(typeof(Object).get_Assembly()).get_Product().Contains(".NET Framework");
		}

		internal static Boolean IsValidDriveChar(Char value)
		{
			if (value >= 'A' && value <= 'Z')
			{
				return true;
			}
			if (value < 'a')
			{
				return false;
			}
			return value <= 'z';
		}

		[DllImport("kernel32.dll", CharSet=3, ExactSpelling=false, SetLastError=true)]
		internal static extern IntPtr LoadLibrary(String dllToLoad);

		private static Void LoadWebView2LoaderDll()
		{
			if (CoreWebView2Environment.webView2LoaderLoaded)
			{
				return;
			}
			String processArchSubFolder = "";
			if (!String.IsNullOrEmpty(CoreWebView2Environment.loaderDllFolderPath))
			{
				processArchSubFolder = CoreWebView2Environment.loaderDllFolderPath;
			}
			else if (CoreWebView2Environment.IsDotNetFramework())
			{
				processArchSubFolder = CoreWebView2Environment.GetProcessArchSubFolder();
			}
			if (!String.IsNullOrEmpty(processArchSubFolder))
			{
				processArchSubFolder = CoreWebView2Environment.TrimFormat(processArchSubFolder);
				ArrayList arrayList = new ArrayList();
				if (!Path.IsPathRooted(processArchSubFolder))
				{
					arrayList.Add(Path.Combine(CoreWebView2Environment.GetAssemblyLocationDirectory(), processArchSubFolder));
					arrayList.Add(Path.Combine(CoreWebView2Environment.GetAssemblyCodeBaseDirectory(), processArchSubFolder));
					arrayList.Add(Path.Combine(CoreWebView2Environment.GetCurrentDllRuningDirectory(), processArchSubFolder));
				}
				else
				{
					arrayList.Add(processArchSubFolder);
				}
				arrayList.Add("");
				String str = "";
				foreach (Object obj in arrayList)
				{
					str = Path.Combine((String)obj, "WebView2Loader.dll");
					if (CoreWebView2Environment.LoadLibrary(str) == IntPtr.Zero)
					{
						continue;
					}
					CoreWebView2Environment.webView2LoaderLoaded = true;
					goto Label0;
				}
			Label0:
				if (!CoreWebView2Environment.webView2LoaderLoaded && !String.IsNullOrEmpty(CoreWebView2Environment.loaderDllFolderPath))
				{
					Int32 hRForLastWin32Error = Marshal.GetHRForLastWin32Error();
					throw new DllNotFoundException(String.Format("Unable to load DLL '{0}' or one of its dependencies: {1} (0x{2:X})", str, (new Win32Exception(hRForLastWin32Error)).get_Message(), hRForLastWin32Error));
				}
			}
			CoreWebView2Environment.webView2LoaderLoaded = true;
		}

		internal Void OnBrowserProcessExited(CoreWebView2BrowserProcessExitedEventArgs args)
		{
			EventHandler<CoreWebView2BrowserProcessExitedEventArgs> eventHandler = this.browserProcessExited;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnNewBrowserVersionAvailable(Object args)
		{
			EventHandler<Object> eventHandler = this.newBrowserVersionAvailable;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnProcessInfosChanged(Object args)
		{
			EventHandler<Object> eventHandler = this.processInfosChanged;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		public static Void SetLoaderDllFolderPath(String folderPath)
		{
			if (CoreWebView2Environment.webView2LoaderLoaded)
			{
				throw new InvalidOperationException("The function should be called before before any other API is called in `CoreWebView2Environment` class.");
			}
			CoreWebView2Environment.loaderDllFolderPath = folderPath;
		}

		private static String TrimFormat(String path)
		{
			Char[] chrArray = new Char[] { '/', '\\' };
			path = path.Trim(new Char[] { ' ' });
			path = path.TrimEnd(chrArray);
			return path;
		}

		public event EventHandler<CoreWebView2BrowserProcessExitedEventArgs> BrowserProcessExited
		{
			add
			{
				if (this.browserProcessExited == null)
				{
					try
					{
						this._nativeICoreWebView2Environment5.add_BrowserProcessExited(new CoreWebView2BrowserProcessExitedEventHandler(new CoreWebView2BrowserProcessExitedEventHandler.CallbackType(this.OnBrowserProcessExited)), out this._browserProcessExitedToken);
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
				this.browserProcessExited = (EventHandler<CoreWebView2BrowserProcessExitedEventArgs>)Delegate.Combine(this.browserProcessExited, value);
			}
			remove
			{
				this.browserProcessExited = (EventHandler<CoreWebView2BrowserProcessExitedEventArgs>)Delegate.Remove(this.browserProcessExited, value);
				if (this.browserProcessExited == null)
				{
					try
					{
						this._nativeICoreWebView2Environment5.remove_BrowserProcessExited(this._browserProcessExitedToken);
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

		public event EventHandler<Object> NewBrowserVersionAvailable
		{
			add
			{
				if (this.newBrowserVersionAvailable == null)
				{
					try
					{
						this._nativeICoreWebView2Environment.add_NewBrowserVersionAvailable(new CoreWebView2NewBrowserVersionAvailableEventHandler(new CoreWebView2NewBrowserVersionAvailableEventHandler.CallbackType(this.OnNewBrowserVersionAvailable)), out this._newBrowserVersionAvailableToken);
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
				this.newBrowserVersionAvailable = (EventHandler<Object>)Delegate.Combine(this.newBrowserVersionAvailable, value);
			}
			remove
			{
				this.newBrowserVersionAvailable = (EventHandler<Object>)Delegate.Remove(this.newBrowserVersionAvailable, value);
				if (this.newBrowserVersionAvailable == null)
				{
					try
					{
						this._nativeICoreWebView2Environment.remove_NewBrowserVersionAvailable(this._newBrowserVersionAvailableToken);
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

		public event EventHandler<Object> ProcessInfosChanged
		{
			add
			{
				if (this.processInfosChanged == null)
				{
					try
					{
						this._nativeICoreWebView2Environment8.add_ProcessInfosChanged(new CoreWebView2ProcessInfosChangedEventHandler(new CoreWebView2ProcessInfosChangedEventHandler.CallbackType(this.OnProcessInfosChanged)), out this._processInfosChangedToken);
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
				this.processInfosChanged = (EventHandler<Object>)Delegate.Combine(this.processInfosChanged, value);
			}
			remove
			{
				this.processInfosChanged = (EventHandler<Object>)Delegate.Remove(this.processInfosChanged, value);
				if (this.processInfosChanged == null)
				{
					try
					{
						this._nativeICoreWebView2Environment8.remove_ProcessInfosChanged(this._processInfosChangedToken);
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

		private enum ProcessorArchitecture : UInt16
		{
			x86 = 0,
			x64 = 9,
			ARM64 = 12,
			Unknown = 65535
		}

		private struct SYSTEM_INFO
		{
			internal UInt16 wProcessorArchitecture;

			private UInt16 wReserved;

			private Int32 dwPageSize;

			private IntPtr lpMinimumApplicationAddress;

			private IntPtr lpMaximumApplicationAddress;

			private IntPtr dwActiveProcessorMask;

			private Int32 dwNumberOfProcessors;

			private Int32 dwProcessorType;

			private Int32 dwAllocationGranularity;

			private Int16 wProcessorLevel;

			private Int16 wProcessorRevision;
		}
	}
}