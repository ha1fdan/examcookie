using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2AcceleratorKeyPressedEventArgs : EventArgs
	{
		internal ICoreWebView2AcceleratorKeyPressedEventArgs _nativeICoreWebView2AcceleratorKeyPressedEventArgsValue;

		internal Object _rawNative;

		internal ICoreWebView2AcceleratorKeyPressedEventArgs _nativeICoreWebView2AcceleratorKeyPressedEventArgs
		{
			get
			{
				if (this._nativeICoreWebView2AcceleratorKeyPressedEventArgsValue == null)
				{
					try
					{
						this._nativeICoreWebView2AcceleratorKeyPressedEventArgsValue = (ICoreWebView2AcceleratorKeyPressedEventArgs)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2AcceleratorKeyPressedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2AcceleratorKeyPressedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2AcceleratorKeyPressedEventArgsValue = value;
			}
		}

		public Boolean Handled
		{
			get
			{
				Boolean handled;
				try
				{
					handled = this._nativeICoreWebView2AcceleratorKeyPressedEventArgs.Handled != 0;
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
					this._nativeICoreWebView2AcceleratorKeyPressedEventArgs.Handled = (value ? 1 : 0);
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

		public CoreWebView2KeyEventKind KeyEventKind
		{
			get
			{
				CoreWebView2KeyEventKind keyEventKind;
				try
				{
					keyEventKind = (CoreWebView2KeyEventKind)this._nativeICoreWebView2AcceleratorKeyPressedEventArgs.KeyEventKind;
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
				return keyEventKind;
			}
		}

		public Int32 KeyEventLParam
		{
			get
			{
				Int32 keyEventLParam;
				try
				{
					keyEventLParam = this._nativeICoreWebView2AcceleratorKeyPressedEventArgs.KeyEventLParam;
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
				return keyEventLParam;
			}
		}

		public CoreWebView2PhysicalKeyStatus PhysicalKeyStatus
		{
			get
			{
				CoreWebView2PhysicalKeyStatus coreWebView2PhysicalKeyStatu;
				try
				{
					coreWebView2PhysicalKeyStatu = new CoreWebView2PhysicalKeyStatus(this._nativeICoreWebView2AcceleratorKeyPressedEventArgs.PhysicalKeyStatus);
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
				return coreWebView2PhysicalKeyStatu;
			}
		}

		public UInt32 VirtualKey
		{
			get
			{
				UInt32 virtualKey;
				try
				{
					virtualKey = this._nativeICoreWebView2AcceleratorKeyPressedEventArgs.VirtualKey;
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
				return virtualKey;
			}
		}

		internal CoreWebView2AcceleratorKeyPressedEventArgs(Object rawCoreWebView2AcceleratorKeyPressedEventArgs)
		{
			this._rawNative = rawCoreWebView2AcceleratorKeyPressedEventArgs;
		}
	}
}