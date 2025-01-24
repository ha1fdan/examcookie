using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2CompositionController
	{
		internal ICoreWebView2CompositionController _nativeICoreWebView2CompositionControllerValue;

		internal ICoreWebView2CompositionController2 _nativeICoreWebView2CompositionController2Value;

		internal ICoreWebView2CompositionController3 _nativeICoreWebView2CompositionController3Value;

		internal Object _rawNative;

		private EventRegistrationToken _cursorChangedToken;

		private EventHandler<Object> cursorChanged;

		internal ICoreWebView2CompositionController _nativeICoreWebView2CompositionController
		{
			get
			{
				if (this._nativeICoreWebView2CompositionControllerValue == null)
				{
					try
					{
						this._nativeICoreWebView2CompositionControllerValue = (ICoreWebView2CompositionController)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CompositionController.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2CompositionControllerValue;
			}
			set
			{
				this._nativeICoreWebView2CompositionControllerValue = value;
			}
		}

		internal ICoreWebView2CompositionController2 _nativeICoreWebView2CompositionController2
		{
			get
			{
				if (this._nativeICoreWebView2CompositionController2Value == null)
				{
					try
					{
						this._nativeICoreWebView2CompositionController2Value = (ICoreWebView2CompositionController2)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CompositionController2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2CompositionController2Value;
			}
			set
			{
				this._nativeICoreWebView2CompositionController2Value = value;
			}
		}

		internal ICoreWebView2CompositionController3 _nativeICoreWebView2CompositionController3
		{
			get
			{
				if (this._nativeICoreWebView2CompositionController3Value == null)
				{
					try
					{
						this._nativeICoreWebView2CompositionController3Value = (ICoreWebView2CompositionController3)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CompositionController3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2CompositionController3Value;
			}
			set
			{
				this._nativeICoreWebView2CompositionController3Value = value;
			}
		}

		public IntPtr Cursor
		{
			get
			{
				IntPtr cursor;
				try
				{
					cursor = this._nativeICoreWebView2CompositionController.Cursor;
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
				return cursor;
			}
		}

		public Object RootVisualTarget
		{
			get
			{
				Object rootVisualTarget;
				try
				{
					rootVisualTarget = this._nativeICoreWebView2CompositionController.RootVisualTarget;
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
				return rootVisualTarget;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2CompositionController.RootVisualTarget = value;
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

		public UInt32 SystemCursorId
		{
			get
			{
				UInt32 systemCursorId;
				try
				{
					systemCursorId = this._nativeICoreWebView2CompositionController.SystemCursorId;
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
				return systemCursorId;
			}
		}

		internal CoreWebView2CompositionController(Object rawCoreWebView2CompositionController)
		{
			this._rawNative = rawCoreWebView2CompositionController;
		}

		public Void DragLeave()
		{
			try
			{
				this._nativeICoreWebView2CompositionController3.DragLeave();
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

		internal Void OnCursorChanged(Object args)
		{
			EventHandler<Object> eventHandler = this.cursorChanged;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		public Void SendMouseInput(CoreWebView2MouseEventKind eventKind, CoreWebView2MouseEventVirtualKeys virtualKeys, UInt32 mouseData, Point point)
		{
			try
			{
				this._nativeICoreWebView2CompositionController.SendMouseInput((COREWEBVIEW2_MOUSE_EVENT_KIND)eventKind, (COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS)virtualKeys, mouseData, COMDotNetTypeConverter.PointNetToCOM(point));
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

		public Void SendPointerInput(CoreWebView2PointerEventKind eventKind, CoreWebView2PointerInfo pointerInfo)
		{
			try
			{
				this._nativeICoreWebView2CompositionController.SendPointerInput((COREWEBVIEW2_POINTER_EVENT_KIND)eventKind, pointerInfo._nativeICoreWebView2PointerInfo);
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

		public event EventHandler<Object> CursorChanged
		{
			add
			{
				if (this.cursorChanged == null)
				{
					try
					{
						this._nativeICoreWebView2CompositionController.add_CursorChanged(new CoreWebView2CursorChangedEventHandler(new CoreWebView2CursorChangedEventHandler.CallbackType(this.OnCursorChanged)), out this._cursorChangedToken);
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
				this.cursorChanged = (EventHandler<Object>)Delegate.Combine(this.cursorChanged, value);
			}
			remove
			{
				this.cursorChanged = (EventHandler<Object>)Delegate.Remove(this.cursorChanged, value);
				if (this.cursorChanged == null)
				{
					try
					{
						this._nativeICoreWebView2CompositionController.remove_CursorChanged(this._cursorChangedToken);
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