using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2BasicAuthenticationRequestedEventArgs : EventArgs
	{
		internal ICoreWebView2BasicAuthenticationRequestedEventArgs _nativeICoreWebView2BasicAuthenticationRequestedEventArgsValue;

		internal Object _rawNative;

		internal ICoreWebView2BasicAuthenticationRequestedEventArgs _nativeICoreWebView2BasicAuthenticationRequestedEventArgs
		{
			get
			{
				if (this._nativeICoreWebView2BasicAuthenticationRequestedEventArgsValue == null)
				{
					try
					{
						this._nativeICoreWebView2BasicAuthenticationRequestedEventArgsValue = (ICoreWebView2BasicAuthenticationRequestedEventArgs)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2BasicAuthenticationRequestedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2BasicAuthenticationRequestedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2BasicAuthenticationRequestedEventArgsValue = value;
			}
		}

		public Boolean Cancel
		{
			get
			{
				Boolean cancel;
				try
				{
					cancel = this._nativeICoreWebView2BasicAuthenticationRequestedEventArgs.Cancel != 0;
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
					this._nativeICoreWebView2BasicAuthenticationRequestedEventArgs.Cancel = (value ? 1 : 0);
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

		public String Challenge
		{
			get
			{
				String challenge;
				try
				{
					challenge = this._nativeICoreWebView2BasicAuthenticationRequestedEventArgs.Challenge;
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
				return challenge;
			}
		}

		public CoreWebView2BasicAuthenticationResponse Response
		{
			get
			{
				CoreWebView2BasicAuthenticationResponse coreWebView2BasicAuthenticationResponse;
				CoreWebView2BasicAuthenticationResponse coreWebView2BasicAuthenticationResponse1;
				try
				{
					if (this._nativeICoreWebView2BasicAuthenticationRequestedEventArgs.Response == null)
					{
						coreWebView2BasicAuthenticationResponse1 = null;
					}
					else
					{
						coreWebView2BasicAuthenticationResponse1 = new CoreWebView2BasicAuthenticationResponse(this._nativeICoreWebView2BasicAuthenticationRequestedEventArgs.Response);
					}
					coreWebView2BasicAuthenticationResponse = coreWebView2BasicAuthenticationResponse1;
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
				return coreWebView2BasicAuthenticationResponse;
			}
		}

		public String Uri
		{
			get
			{
				String uri;
				try
				{
					uri = this._nativeICoreWebView2BasicAuthenticationRequestedEventArgs.Uri;
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

		internal CoreWebView2BasicAuthenticationRequestedEventArgs(Object rawCoreWebView2BasicAuthenticationRequestedEventArgs)
		{
			this._rawNative = rawCoreWebView2BasicAuthenticationRequestedEventArgs;
		}

		public CoreWebView2Deferral GetDeferral()
		{
			CoreWebView2Deferral coreWebView2Deferral;
			try
			{
				coreWebView2Deferral = new CoreWebView2Deferral(this._nativeICoreWebView2BasicAuthenticationRequestedEventArgs.GetDeferral());
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