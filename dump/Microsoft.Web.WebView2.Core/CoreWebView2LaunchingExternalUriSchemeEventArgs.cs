using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2LaunchingExternalUriSchemeEventArgs : EventArgs
	{
		internal ICoreWebView2LaunchingExternalUriSchemeEventArgs _nativeICoreWebView2LaunchingExternalUriSchemeEventArgsValue;

		internal Object _rawNative;

		internal ICoreWebView2LaunchingExternalUriSchemeEventArgs _nativeICoreWebView2LaunchingExternalUriSchemeEventArgs
		{
			get
			{
				if (this._nativeICoreWebView2LaunchingExternalUriSchemeEventArgsValue == null)
				{
					try
					{
						this._nativeICoreWebView2LaunchingExternalUriSchemeEventArgsValue = (ICoreWebView2LaunchingExternalUriSchemeEventArgs)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2LaunchingExternalUriSchemeEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2LaunchingExternalUriSchemeEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2LaunchingExternalUriSchemeEventArgsValue = value;
			}
		}

		public Boolean Cancel
		{
			get
			{
				Boolean cancel;
				try
				{
					cancel = this._nativeICoreWebView2LaunchingExternalUriSchemeEventArgs.Cancel != 0;
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
				return cancel;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2LaunchingExternalUriSchemeEventArgs.Cancel = (value ? 1 : 0);
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

		public String InitiatingOrigin
		{
			get
			{
				String initiatingOrigin;
				try
				{
					initiatingOrigin = this._nativeICoreWebView2LaunchingExternalUriSchemeEventArgs.InitiatingOrigin;
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
				return initiatingOrigin;
			}
		}

		public Boolean IsUserInitiated
		{
			get
			{
				Boolean isUserInitiated;
				try
				{
					isUserInitiated = this._nativeICoreWebView2LaunchingExternalUriSchemeEventArgs.IsUserInitiated != 0;
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

		public String Uri
		{
			get
			{
				String uri;
				try
				{
					uri = this._nativeICoreWebView2LaunchingExternalUriSchemeEventArgs.Uri;
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

		internal CoreWebView2LaunchingExternalUriSchemeEventArgs(Object rawCoreWebView2LaunchingExternalUriSchemeEventArgs)
		{
			this._rawNative = rawCoreWebView2LaunchingExternalUriSchemeEventArgs;
		}

		public CoreWebView2Deferral GetDeferral()
		{
			CoreWebView2Deferral coreWebView2Deferral;
			try
			{
				coreWebView2Deferral = new CoreWebView2Deferral(this._nativeICoreWebView2LaunchingExternalUriSchemeEventArgs.GetDeferral());
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