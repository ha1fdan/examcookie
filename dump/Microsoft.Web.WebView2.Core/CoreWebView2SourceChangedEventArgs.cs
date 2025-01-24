using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2SourceChangedEventArgs : EventArgs
	{
		internal ICoreWebView2SourceChangedEventArgs _nativeICoreWebView2SourceChangedEventArgsValue;

		internal Object _rawNative;

		internal ICoreWebView2SourceChangedEventArgs _nativeICoreWebView2SourceChangedEventArgs
		{
			get
			{
				if (this._nativeICoreWebView2SourceChangedEventArgsValue == null)
				{
					try
					{
						this._nativeICoreWebView2SourceChangedEventArgsValue = (ICoreWebView2SourceChangedEventArgs)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2SourceChangedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2SourceChangedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2SourceChangedEventArgsValue = value;
			}
		}

		public Boolean IsNewDocument
		{
			get
			{
				Boolean isNewDocument;
				try
				{
					isNewDocument = this._nativeICoreWebView2SourceChangedEventArgs.IsNewDocument != 0;
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
				return isNewDocument;
			}
		}

		internal CoreWebView2SourceChangedEventArgs(Object rawCoreWebView2SourceChangedEventArgs)
		{
			this._rawNative = rawCoreWebView2SourceChangedEventArgs;
		}
	}
}