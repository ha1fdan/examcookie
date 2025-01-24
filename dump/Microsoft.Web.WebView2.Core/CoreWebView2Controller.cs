using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2Controller
	{
		private const String HostObjectHelperName = "{60A417CA-F1AB-4307-801B-F96003F8938B} Host Object Helper";

		private Microsoft.Web.WebView2.Core.CoreWebView2 _coreWebView2;

		internal ICoreWebView2Controller _nativeICoreWebView2ControllerValue;

		internal ICoreWebView2Controller2 _nativeICoreWebView2Controller2Value;

		internal ICoreWebView2Controller3 _nativeICoreWebView2Controller3Value;

		internal ICoreWebView2Controller4 _nativeICoreWebView2Controller4Value;

		internal ICoreWebView2PrivatePartialController _nativeICoreWebView2PrivatePartialControllerValue;

		internal Object _rawNative;

		private EventRegistrationToken _zoomFactorChangedToken;

		private EventHandler<Object> zoomFactorChanged;

		private EventRegistrationToken _moveFocusRequestedToken;

		private EventHandler<CoreWebView2MoveFocusRequestedEventArgs> moveFocusRequested;

		private EventRegistrationToken _gotFocusToken;

		private EventHandler<Object> gotFocus;

		private EventRegistrationToken _lostFocusToken;

		private EventHandler<Object> lostFocus;

		private EventRegistrationToken _acceleratorKeyPressedToken;

		private EventHandler<CoreWebView2AcceleratorKeyPressedEventArgs> acceleratorKeyPressed;

		private EventRegistrationToken _rasterizationScaleChangedToken;

		private EventHandler<Object> rasterizationScaleChanged;

		private EventRegistrationToken _keyPressedToken;

		private EventHandler<CoreWebView2PrivateKeyPressedEventArgs> keyPressed;

		internal ICoreWebView2Controller _nativeICoreWebView2Controller
		{
			get
			{
				if (this._nativeICoreWebView2ControllerValue == null)
				{
					try
					{
						this._nativeICoreWebView2ControllerValue = (ICoreWebView2Controller)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2ControllerValue;
			}
			set
			{
				this._nativeICoreWebView2ControllerValue = value;
			}
		}

		internal ICoreWebView2Controller2 _nativeICoreWebView2Controller2
		{
			get
			{
				if (this._nativeICoreWebView2Controller2Value == null)
				{
					try
					{
						this._nativeICoreWebView2Controller2Value = (ICoreWebView2Controller2)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2Controller2Value;
			}
			set
			{
				this._nativeICoreWebView2Controller2Value = value;
			}
		}

		internal ICoreWebView2Controller3 _nativeICoreWebView2Controller3
		{
			get
			{
				if (this._nativeICoreWebView2Controller3Value == null)
				{
					try
					{
						this._nativeICoreWebView2Controller3Value = (ICoreWebView2Controller3)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2Controller3Value;
			}
			set
			{
				this._nativeICoreWebView2Controller3Value = value;
			}
		}

		internal ICoreWebView2Controller4 _nativeICoreWebView2Controller4
		{
			get
			{
				if (this._nativeICoreWebView2Controller4Value == null)
				{
					try
					{
						this._nativeICoreWebView2Controller4Value = (ICoreWebView2Controller4)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2Controller4Value;
			}
			set
			{
				this._nativeICoreWebView2Controller4Value = value;
			}
		}

		internal ICoreWebView2PrivatePartialController _nativeICoreWebView2PrivatePartialController
		{
			get
			{
				if (this._nativeICoreWebView2PrivatePartialControllerValue == null)
				{
					try
					{
						this._nativeICoreWebView2PrivatePartialControllerValue = (ICoreWebView2PrivatePartialController)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivatePartialController.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2PrivatePartialControllerValue;
			}
			set
			{
				this._nativeICoreWebView2PrivatePartialControllerValue = value;
			}
		}

		public Boolean AllowExternalDrop
		{
			get
			{
				Boolean allowExternalDrop;
				try
				{
					allowExternalDrop = this._nativeICoreWebView2Controller4.AllowExternalDrop != 0;
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
				return allowExternalDrop;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2Controller4.AllowExternalDrop = (value ? 1 : 0);
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

		public Rectangle Bounds
		{
			get
			{
				Rectangle net;
				try
				{
					net = COMDotNetTypeConverter.RectangleCOMToNet(this._nativeICoreWebView2Controller.Bounds);
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
			set
			{
				try
				{
					this._nativeICoreWebView2Controller.Bounds = COMDotNetTypeConverter.RectangleNetToCOM(value);
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

		public CoreWebView2BoundsMode BoundsMode
		{
			get
			{
				CoreWebView2BoundsMode boundsMode;
				try
				{
					boundsMode = (CoreWebView2BoundsMode)this._nativeICoreWebView2Controller3.BoundsMode;
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
				return boundsMode;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2Controller3.BoundsMode = (COREWEBVIEW2_BOUNDS_MODE)value;
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

		public Microsoft.Web.WebView2.Core.CoreWebView2 CoreWebView2
		{
			get
			{
				if (this._nativeICoreWebView2Controller.CoreWebView2 == null)
				{
					return null;
				}
				if (this._coreWebView2 == null)
				{
					this._coreWebView2 = new Microsoft.Web.WebView2.Core.CoreWebView2(this._nativeICoreWebView2Controller.CoreWebView2);
				}
				return this._coreWebView2;
			}
		}

		public Color DefaultBackgroundColor
		{
			get
			{
				Color net;
				try
				{
					net = COMDotNetTypeConverter.ColorCOMToNet(this._nativeICoreWebView2Controller2.DefaultBackgroundColor);
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
			set
			{
				try
				{
					this._nativeICoreWebView2Controller2.DefaultBackgroundColor = COMDotNetTypeConverter.ColorNetToCOM(value);
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

		internal Boolean IsBrowserHitTransparent
		{
			get
			{
				Boolean isBrowserHitTransparent;
				try
				{
					isBrowserHitTransparent = this._nativeICoreWebView2PrivatePartialController.IsBrowserHitTransparent != 0;
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
				return isBrowserHitTransparent;
			}
		}

		public Boolean IsVisible
		{
			get
			{
				Boolean isVisible;
				try
				{
					isVisible = this._nativeICoreWebView2Controller.IsVisible != 0;
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
				return isVisible;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2Controller.IsVisible = (value ? 1 : 0);
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

		public IntPtr ParentWindow
		{
			get
			{
				IntPtr parentWindow;
				try
				{
					parentWindow = this._nativeICoreWebView2Controller.ParentWindow;
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
				return parentWindow;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2Controller.ParentWindow = value;
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

		public Double RasterizationScale
		{
			get
			{
				Double rasterizationScale;
				try
				{
					rasterizationScale = this._nativeICoreWebView2Controller3.RasterizationScale;
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
				return rasterizationScale;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2Controller3.RasterizationScale = value;
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

		public Boolean ShouldDetectMonitorScaleChanges
		{
			get
			{
				Boolean shouldDetectMonitorScaleChanges;
				try
				{
					shouldDetectMonitorScaleChanges = this._nativeICoreWebView2Controller3.ShouldDetectMonitorScaleChanges != 0;
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
				return shouldDetectMonitorScaleChanges;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2Controller3.ShouldDetectMonitorScaleChanges = (value ? 1 : 0);
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

		public Double ZoomFactor
		{
			get
			{
				Double zoomFactor;
				try
				{
					zoomFactor = this._nativeICoreWebView2Controller.ZoomFactor;
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
				return zoomFactor;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2Controller.ZoomFactor = value;
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

		internal CoreWebView2Controller(Object rawCoreWebView2Controller)
		{
			this._rawNative = rawCoreWebView2Controller;
			this.Initialize();
		}

		public Void Close()
		{
			try
			{
				this._nativeICoreWebView2Controller.Close();
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

		private Void Initialize()
		{
			if (this._nativeICoreWebView2Controller != null)
			{
				try
				{
					CoreWebView2PrivateHostObjectHelper coreWebView2PrivateHostObjectHelper = new CoreWebView2PrivateHostObjectHelper();
					this.CoreWebView2.AddHostObjectHelper(coreWebView2PrivateHostObjectHelper);
				}
				catch (NotImplementedException notImplementedException)
				{
					ICoreWebView2 coreWebView2 = this._nativeICoreWebView2Controller.CoreWebView2;
					Object hostObjectHelper = new HostObjectHelper();
					coreWebView2.AddHostObjectToScript("{60A417CA-F1AB-4307-801B-F96003F8938B} Host Object Helper", ref hostObjectHelper);
				}
			}
		}

		public Void MoveFocus(CoreWebView2MoveFocusReason reason)
		{
			try
			{
				this._nativeICoreWebView2Controller.MoveFocus((COREWEBVIEW2_MOVE_FOCUS_REASON)reason);
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
			catch (ArgumentException argumentException1)
			{
				ArgumentException argumentException = argumentException1;
				if (argumentException.get_HResult() != -2147024809)
				{
					throw argumentException;
				}
			}
		}

		public Void NotifyParentWindowPositionChanged()
		{
			try
			{
				this._nativeICoreWebView2Controller.NotifyParentWindowPositionChanged();
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

		internal Void OnAcceleratorKeyPressed(CoreWebView2AcceleratorKeyPressedEventArgs args)
		{
			EventHandler<CoreWebView2AcceleratorKeyPressedEventArgs> eventHandler = this.acceleratorKeyPressed;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnGotFocus(Object args)
		{
			EventHandler<Object> eventHandler = this.gotFocus;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnKeyPressed(CoreWebView2PrivateKeyPressedEventArgs args)
		{
			EventHandler<CoreWebView2PrivateKeyPressedEventArgs> eventHandler = this.keyPressed;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnLostFocus(Object args)
		{
			EventHandler<Object> eventHandler = this.lostFocus;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnMoveFocusRequested(CoreWebView2MoveFocusRequestedEventArgs args)
		{
			EventHandler<CoreWebView2MoveFocusRequestedEventArgs> eventHandler = this.moveFocusRequested;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnRasterizationScaleChanged(Object args)
		{
			EventHandler<Object> eventHandler = this.rasterizationScaleChanged;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnZoomFactorChanged(Object args)
		{
			EventHandler<Object> eventHandler = this.zoomFactorChanged;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		public Void SetBoundsAndZoomFactor(Rectangle Bounds, Double ZoomFactor)
		{
			try
			{
				this._nativeICoreWebView2Controller.SetBoundsAndZoomFactor(COMDotNetTypeConverter.RectangleNetToCOM(Bounds), ZoomFactor);
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

		public event EventHandler<CoreWebView2AcceleratorKeyPressedEventArgs> AcceleratorKeyPressed
		{
			add
			{
				if (this.acceleratorKeyPressed == null)
				{
					try
					{
						this._nativeICoreWebView2Controller.add_AcceleratorKeyPressed(new CoreWebView2AcceleratorKeyPressedEventHandler(new CoreWebView2AcceleratorKeyPressedEventHandler.CallbackType(this.OnAcceleratorKeyPressed)), out this._acceleratorKeyPressedToken);
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
				this.acceleratorKeyPressed = (EventHandler<CoreWebView2AcceleratorKeyPressedEventArgs>)Delegate.Combine(this.acceleratorKeyPressed, value);
			}
			remove
			{
				this.acceleratorKeyPressed = (EventHandler<CoreWebView2AcceleratorKeyPressedEventArgs>)Delegate.Remove(this.acceleratorKeyPressed, value);
				if (this.acceleratorKeyPressed == null)
				{
					try
					{
						this._nativeICoreWebView2Controller.remove_AcceleratorKeyPressed(this._acceleratorKeyPressedToken);
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

		public event EventHandler<Object> GotFocus
		{
			add
			{
				if (this.gotFocus == null)
				{
					try
					{
						this._nativeICoreWebView2Controller.add_GotFocus(new CoreWebView2FocusChangedEventHandler(new CoreWebView2FocusChangedEventHandler.CallbackType(this.OnGotFocus)), out this._gotFocusToken);
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
				this.gotFocus = (EventHandler<Object>)Delegate.Combine(this.gotFocus, value);
			}
			remove
			{
				this.gotFocus = (EventHandler<Object>)Delegate.Remove(this.gotFocus, value);
				if (this.gotFocus == null)
				{
					try
					{
						this._nativeICoreWebView2Controller.remove_GotFocus(this._gotFocusToken);
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

		internal event EventHandler<CoreWebView2PrivateKeyPressedEventArgs> KeyPressed
		{
			add
			{
				if (this.keyPressed == null)
				{
					try
					{
						this._nativeICoreWebView2PrivatePartialController.add_KeyPressed(new CoreWebView2PrivateKeyPressedEventHandler(new CoreWebView2PrivateKeyPressedEventHandler.CallbackType(this.OnKeyPressed)), out this._keyPressedToken);
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
				this.keyPressed = (EventHandler<CoreWebView2PrivateKeyPressedEventArgs>)Delegate.Combine(this.keyPressed, value);
			}
			remove
			{
				this.keyPressed = (EventHandler<CoreWebView2PrivateKeyPressedEventArgs>)Delegate.Remove(this.keyPressed, value);
				if (this.keyPressed == null)
				{
					try
					{
						this._nativeICoreWebView2PrivatePartialController.remove_KeyPressed(this._keyPressedToken);
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

		public event EventHandler<Object> LostFocus
		{
			add
			{
				if (this.lostFocus == null)
				{
					try
					{
						this._nativeICoreWebView2Controller.add_LostFocus(new CoreWebView2FocusChangedEventHandler(new CoreWebView2FocusChangedEventHandler.CallbackType(this.OnLostFocus)), out this._lostFocusToken);
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
				this.lostFocus = (EventHandler<Object>)Delegate.Combine(this.lostFocus, value);
			}
			remove
			{
				this.lostFocus = (EventHandler<Object>)Delegate.Remove(this.lostFocus, value);
				if (this.lostFocus == null)
				{
					try
					{
						this._nativeICoreWebView2Controller.remove_LostFocus(this._lostFocusToken);
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

		public event EventHandler<CoreWebView2MoveFocusRequestedEventArgs> MoveFocusRequested
		{
			add
			{
				if (this.moveFocusRequested == null)
				{
					try
					{
						this._nativeICoreWebView2Controller.add_MoveFocusRequested(new CoreWebView2MoveFocusRequestedEventHandler(new CoreWebView2MoveFocusRequestedEventHandler.CallbackType(this.OnMoveFocusRequested)), out this._moveFocusRequestedToken);
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
				this.moveFocusRequested = (EventHandler<CoreWebView2MoveFocusRequestedEventArgs>)Delegate.Combine(this.moveFocusRequested, value);
			}
			remove
			{
				this.moveFocusRequested = (EventHandler<CoreWebView2MoveFocusRequestedEventArgs>)Delegate.Remove(this.moveFocusRequested, value);
				if (this.moveFocusRequested == null)
				{
					try
					{
						this._nativeICoreWebView2Controller.remove_MoveFocusRequested(this._moveFocusRequestedToken);
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

		public event EventHandler<Object> RasterizationScaleChanged
		{
			add
			{
				if (this.rasterizationScaleChanged == null)
				{
					try
					{
						this._nativeICoreWebView2Controller3.add_RasterizationScaleChanged(new CoreWebView2RasterizationScaleChangedEventHandler(new CoreWebView2RasterizationScaleChangedEventHandler.CallbackType(this.OnRasterizationScaleChanged)), out this._rasterizationScaleChangedToken);
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
				this.rasterizationScaleChanged = (EventHandler<Object>)Delegate.Combine(this.rasterizationScaleChanged, value);
			}
			remove
			{
				this.rasterizationScaleChanged = (EventHandler<Object>)Delegate.Remove(this.rasterizationScaleChanged, value);
				if (this.rasterizationScaleChanged == null)
				{
					try
					{
						this._nativeICoreWebView2Controller3.remove_RasterizationScaleChanged(this._rasterizationScaleChangedToken);
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

		public event EventHandler<Object> ZoomFactorChanged
		{
			add
			{
				if (this.zoomFactorChanged == null)
				{
					try
					{
						this._nativeICoreWebView2Controller.add_ZoomFactorChanged(new CoreWebView2ZoomFactorChangedEventHandler(new CoreWebView2ZoomFactorChangedEventHandler.CallbackType(this.OnZoomFactorChanged)), out this._zoomFactorChangedToken);
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
				this.zoomFactorChanged = (EventHandler<Object>)Delegate.Combine(this.zoomFactorChanged, value);
			}
			remove
			{
				this.zoomFactorChanged = (EventHandler<Object>)Delegate.Remove(this.zoomFactorChanged, value);
				if (this.zoomFactorChanged == null)
				{
					try
					{
						this._nativeICoreWebView2Controller.remove_ZoomFactorChanged(this._zoomFactorChangedToken);
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
	}
}