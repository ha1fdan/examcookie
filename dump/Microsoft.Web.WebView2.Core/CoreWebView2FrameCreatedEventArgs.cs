using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2FrameCreatedEventArgs : EventArgs
	{
		internal ICoreWebView2FrameCreatedEventArgs _nativeICoreWebView2FrameCreatedEventArgsValue;

		internal Object _rawNative;

		internal ICoreWebView2FrameCreatedEventArgs _nativeICoreWebView2FrameCreatedEventArgs
		{
			get
			{
				if (this._nativeICoreWebView2FrameCreatedEventArgsValue == null)
				{
					try
					{
						this._nativeICoreWebView2FrameCreatedEventArgsValue = (ICoreWebView2FrameCreatedEventArgs)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FrameCreatedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2FrameCreatedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2FrameCreatedEventArgsValue = value;
			}
		}

		public CoreWebView2Frame Frame
		{
			get
			{
				CoreWebView2Frame coreWebView2Frame;
				CoreWebView2Frame coreWebView2Frame1;
				try
				{
					if (this._nativeICoreWebView2FrameCreatedEventArgs.Frame == null)
					{
						coreWebView2Frame1 = null;
					}
					else
					{
						coreWebView2Frame1 = new CoreWebView2Frame(this._nativeICoreWebView2FrameCreatedEventArgs.Frame);
					}
					coreWebView2Frame = coreWebView2Frame1;
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
				return coreWebView2Frame;
			}
		}

		internal CoreWebView2FrameCreatedEventArgs(Object rawCoreWebView2FrameCreatedEventArgs)
		{
			this._rawNative = rawCoreWebView2FrameCreatedEventArgs;
		}
	}
}