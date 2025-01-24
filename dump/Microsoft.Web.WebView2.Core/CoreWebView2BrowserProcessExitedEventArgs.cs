using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2BrowserProcessExitedEventArgs : EventArgs
	{
		internal ICoreWebView2BrowserProcessExitedEventArgs _nativeICoreWebView2BrowserProcessExitedEventArgsValue;

		internal Object _rawNative;

		internal ICoreWebView2BrowserProcessExitedEventArgs _nativeICoreWebView2BrowserProcessExitedEventArgs
		{
			get
			{
				if (this._nativeICoreWebView2BrowserProcessExitedEventArgsValue == null)
				{
					try
					{
						this._nativeICoreWebView2BrowserProcessExitedEventArgsValue = (ICoreWebView2BrowserProcessExitedEventArgs)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2BrowserProcessExitedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2BrowserProcessExitedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2BrowserProcessExitedEventArgsValue = value;
			}
		}

		public CoreWebView2BrowserProcessExitKind BrowserProcessExitKind
		{
			get
			{
				CoreWebView2BrowserProcessExitKind browserProcessExitKind;
				try
				{
					browserProcessExitKind = (CoreWebView2BrowserProcessExitKind)this._nativeICoreWebView2BrowserProcessExitedEventArgs.BrowserProcessExitKind;
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
				return browserProcessExitKind;
			}
		}

		public UInt32 BrowserProcessId
		{
			get
			{
				UInt32 browserProcessId;
				try
				{
					browserProcessId = this._nativeICoreWebView2BrowserProcessExitedEventArgs.BrowserProcessId;
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
				return browserProcessId;
			}
		}

		internal CoreWebView2BrowserProcessExitedEventArgs(Object rawCoreWebView2BrowserProcessExitedEventArgs)
		{
			this._rawNative = rawCoreWebView2BrowserProcessExitedEventArgs;
		}
	}
}