using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2PrivateKeyPressedEventArgs : EventArgs
	{
		internal ICoreWebView2PrivateKeyPressedEventArgs _nativeICoreWebView2PrivateKeyPressedEventArgsValue;

		internal Object _rawNative;

		internal ICoreWebView2PrivateKeyPressedEventArgs _nativeICoreWebView2PrivateKeyPressedEventArgs
		{
			get
			{
				if (this._nativeICoreWebView2PrivateKeyPressedEventArgsValue == null)
				{
					try
					{
						this._nativeICoreWebView2PrivateKeyPressedEventArgsValue = (ICoreWebView2PrivateKeyPressedEventArgs)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivateKeyPressedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2PrivateKeyPressedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2PrivateKeyPressedEventArgsValue = value;
			}
		}

		internal Boolean Handled
		{
			get
			{
				Boolean handled;
				try
				{
					handled = this._nativeICoreWebView2PrivateKeyPressedEventArgs.Handled != 0;
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
					this._nativeICoreWebView2PrivateKeyPressedEventArgs.Handled = (value ? 1 : 0);
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

		internal CoreWebView2KeyEventKind KeyEventKind
		{
			get
			{
				CoreWebView2KeyEventKind keyEventKind;
				try
				{
					keyEventKind = (CoreWebView2KeyEventKind)this._nativeICoreWebView2PrivateKeyPressedEventArgs.KeyEventKind;
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

		internal Int32 KeyEventLParam
		{
			get
			{
				Int32 keyEventLParam;
				try
				{
					keyEventLParam = this._nativeICoreWebView2PrivateKeyPressedEventArgs.KeyEventLParam;
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

		internal CoreWebView2PhysicalKeyStatus PhysicalKeyStatus
		{
			get
			{
				CoreWebView2PhysicalKeyStatus coreWebView2PhysicalKeyStatu;
				try
				{
					coreWebView2PhysicalKeyStatu = new CoreWebView2PhysicalKeyStatus(this._nativeICoreWebView2PrivateKeyPressedEventArgs.PhysicalKeyStatus);
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

		internal UInt32 VirtualKey
		{
			get
			{
				UInt32 virtualKey;
				try
				{
					virtualKey = this._nativeICoreWebView2PrivateKeyPressedEventArgs.VirtualKey;
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

		internal CoreWebView2PrivateKeyPressedEventArgs(Object rawCoreWebView2PrivateKeyPressedEventArgs)
		{
			this._rawNative = rawCoreWebView2PrivateKeyPressedEventArgs;
		}
	}
}