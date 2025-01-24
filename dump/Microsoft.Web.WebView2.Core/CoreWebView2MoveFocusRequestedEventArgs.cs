using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2MoveFocusRequestedEventArgs : EventArgs
	{
		internal ICoreWebView2MoveFocusRequestedEventArgs _nativeICoreWebView2MoveFocusRequestedEventArgsValue;

		internal Object _rawNative;

		internal ICoreWebView2MoveFocusRequestedEventArgs _nativeICoreWebView2MoveFocusRequestedEventArgs
		{
			get
			{
				if (this._nativeICoreWebView2MoveFocusRequestedEventArgsValue == null)
				{
					try
					{
						this._nativeICoreWebView2MoveFocusRequestedEventArgsValue = (ICoreWebView2MoveFocusRequestedEventArgs)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2MoveFocusRequestedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2MoveFocusRequestedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2MoveFocusRequestedEventArgsValue = value;
			}
		}

		public Boolean Handled
		{
			get
			{
				Boolean handled;
				try
				{
					handled = this._nativeICoreWebView2MoveFocusRequestedEventArgs.Handled != 0;
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
					this._nativeICoreWebView2MoveFocusRequestedEventArgs.Handled = (value ? 1 : 0);
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

		public CoreWebView2MoveFocusReason Reason
		{
			get
			{
				CoreWebView2MoveFocusReason reason;
				try
				{
					reason = (CoreWebView2MoveFocusReason)this._nativeICoreWebView2MoveFocusRequestedEventArgs.Reason;
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
				return reason;
			}
		}

		internal CoreWebView2MoveFocusRequestedEventArgs(Object rawCoreWebView2MoveFocusRequestedEventArgs)
		{
			this._rawNative = rawCoreWebView2MoveFocusRequestedEventArgs;
		}
	}
}