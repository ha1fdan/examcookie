using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2NewWindowRequestedEventArgs : EventArgs
	{
		internal ICoreWebView2NewWindowRequestedEventArgs _nativeICoreWebView2NewWindowRequestedEventArgsValue;

		internal ICoreWebView2NewWindowRequestedEventArgs2 _nativeICoreWebView2NewWindowRequestedEventArgs2Value;

		internal ICoreWebView2NewWindowRequestedEventArgs3 _nativeICoreWebView2NewWindowRequestedEventArgs3Value;

		internal Object _rawNative;

		internal ICoreWebView2NewWindowRequestedEventArgs _nativeICoreWebView2NewWindowRequestedEventArgs
		{
			get
			{
				if (this._nativeICoreWebView2NewWindowRequestedEventArgsValue == null)
				{
					try
					{
						this._nativeICoreWebView2NewWindowRequestedEventArgsValue = (ICoreWebView2NewWindowRequestedEventArgs)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NewWindowRequestedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2NewWindowRequestedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2NewWindowRequestedEventArgsValue = value;
			}
		}

		internal ICoreWebView2NewWindowRequestedEventArgs2 _nativeICoreWebView2NewWindowRequestedEventArgs2
		{
			get
			{
				if (this._nativeICoreWebView2NewWindowRequestedEventArgs2Value == null)
				{
					try
					{
						this._nativeICoreWebView2NewWindowRequestedEventArgs2Value = (ICoreWebView2NewWindowRequestedEventArgs2)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NewWindowRequestedEventArgs2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2NewWindowRequestedEventArgs2Value;
			}
			set
			{
				this._nativeICoreWebView2NewWindowRequestedEventArgs2Value = value;
			}
		}

		internal ICoreWebView2NewWindowRequestedEventArgs3 _nativeICoreWebView2NewWindowRequestedEventArgs3
		{
			get
			{
				if (this._nativeICoreWebView2NewWindowRequestedEventArgs3Value == null)
				{
					try
					{
						this._nativeICoreWebView2NewWindowRequestedEventArgs3Value = (ICoreWebView2NewWindowRequestedEventArgs3)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NewWindowRequestedEventArgs3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2NewWindowRequestedEventArgs3Value;
			}
			set
			{
				this._nativeICoreWebView2NewWindowRequestedEventArgs3Value = value;
			}
		}

		public Boolean Handled
		{
			get
			{
				Boolean handled;
				try
				{
					handled = this._nativeICoreWebView2NewWindowRequestedEventArgs.Handled != 0;
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
				return handled;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2NewWindowRequestedEventArgs.Handled = (value ? 1 : 0);
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

		public Boolean IsUserInitiated
		{
			get
			{
				Boolean isUserInitiated;
				try
				{
					isUserInitiated = this._nativeICoreWebView2NewWindowRequestedEventArgs.IsUserInitiated != 0;
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
				return isUserInitiated;
			}
		}

		public String Name
		{
			get
			{
				String name;
				try
				{
					name = this._nativeICoreWebView2NewWindowRequestedEventArgs2.Name;
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

		public CoreWebView2 NewWindow
		{
			get
			{
				CoreWebView2 coreWebView2;
				CoreWebView2 coreWebView21;
				try
				{
					if (this._nativeICoreWebView2NewWindowRequestedEventArgs.NewWindow == null)
					{
						coreWebView21 = null;
					}
					else
					{
						coreWebView21 = new CoreWebView2(this._nativeICoreWebView2NewWindowRequestedEventArgs.NewWindow);
					}
					coreWebView2 = coreWebView21;
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
				return coreWebView2;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2NewWindowRequestedEventArgs.NewWindow = value._nativeICoreWebView2;
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

		public CoreWebView2FrameInfo OriginalSourceFrameInfo
		{
			get
			{
				CoreWebView2FrameInfo coreWebView2FrameInfo;
				CoreWebView2FrameInfo coreWebView2FrameInfo1;
				try
				{
					if (this._nativeICoreWebView2NewWindowRequestedEventArgs3.OriginalSourceFrameInfo == null)
					{
						coreWebView2FrameInfo1 = null;
					}
					else
					{
						coreWebView2FrameInfo1 = new CoreWebView2FrameInfo(this._nativeICoreWebView2NewWindowRequestedEventArgs3.OriginalSourceFrameInfo);
					}
					coreWebView2FrameInfo = coreWebView2FrameInfo1;
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
				return coreWebView2FrameInfo;
			}
		}

		public String Uri
		{
			get
			{
				String uri;
				try
				{
					uri = this._nativeICoreWebView2NewWindowRequestedEventArgs.Uri;
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
				return uri;
			}
		}

		public CoreWebView2WindowFeatures WindowFeatures
		{
			get
			{
				CoreWebView2WindowFeatures coreWebView2WindowFeature;
				CoreWebView2WindowFeatures coreWebView2WindowFeature1;
				try
				{
					if (this._nativeICoreWebView2NewWindowRequestedEventArgs.WindowFeatures == null)
					{
						coreWebView2WindowFeature1 = null;
					}
					else
					{
						coreWebView2WindowFeature1 = new CoreWebView2WindowFeatures(this._nativeICoreWebView2NewWindowRequestedEventArgs.WindowFeatures);
					}
					coreWebView2WindowFeature = coreWebView2WindowFeature1;
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
				return coreWebView2WindowFeature;
			}
		}

		internal CoreWebView2NewWindowRequestedEventArgs(Object rawCoreWebView2NewWindowRequestedEventArgs)
		{
			this._rawNative = rawCoreWebView2NewWindowRequestedEventArgs;
		}

		public CoreWebView2Deferral GetDeferral()
		{
			CoreWebView2Deferral coreWebView2Deferral;
			try
			{
				coreWebView2Deferral = new CoreWebView2Deferral(this._nativeICoreWebView2NewWindowRequestedEventArgs.GetDeferral());
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
			return coreWebView2Deferral;
		}
	}
}