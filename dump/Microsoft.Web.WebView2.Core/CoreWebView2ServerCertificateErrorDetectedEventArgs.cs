using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2ServerCertificateErrorDetectedEventArgs : EventArgs
	{
		internal ICoreWebView2ServerCertificateErrorDetectedEventArgs _nativeICoreWebView2ServerCertificateErrorDetectedEventArgsValue;

		internal Object _rawNative;

		internal ICoreWebView2ServerCertificateErrorDetectedEventArgs _nativeICoreWebView2ServerCertificateErrorDetectedEventArgs
		{
			get
			{
				if (this._nativeICoreWebView2ServerCertificateErrorDetectedEventArgsValue == null)
				{
					try
					{
						this._nativeICoreWebView2ServerCertificateErrorDetectedEventArgsValue = (ICoreWebView2ServerCertificateErrorDetectedEventArgs)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ServerCertificateErrorDetectedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2ServerCertificateErrorDetectedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2ServerCertificateErrorDetectedEventArgsValue = value;
			}
		}

		public CoreWebView2ServerCertificateErrorAction Action
		{
			get
			{
				CoreWebView2ServerCertificateErrorAction action;
				try
				{
					action = (CoreWebView2ServerCertificateErrorAction)this._nativeICoreWebView2ServerCertificateErrorDetectedEventArgs.Action;
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
				return action;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2ServerCertificateErrorDetectedEventArgs.Action = (COREWEBVIEW2_SERVER_CERTIFICATE_ERROR_ACTION)value;
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

		public CoreWebView2WebErrorStatus ErrorStatus
		{
			get
			{
				CoreWebView2WebErrorStatus errorStatus;
				try
				{
					errorStatus = (CoreWebView2WebErrorStatus)this._nativeICoreWebView2ServerCertificateErrorDetectedEventArgs.ErrorStatus;
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
				return errorStatus;
			}
		}

		public String RequestUri
		{
			get
			{
				String requestUri;
				try
				{
					requestUri = this._nativeICoreWebView2ServerCertificateErrorDetectedEventArgs.RequestUri;
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
				return requestUri;
			}
		}

		public CoreWebView2Certificate ServerCertificate
		{
			get
			{
				CoreWebView2Certificate coreWebView2Certificate;
				CoreWebView2Certificate coreWebView2Certificate1;
				try
				{
					if (this._nativeICoreWebView2ServerCertificateErrorDetectedEventArgs.ServerCertificate == null)
					{
						coreWebView2Certificate1 = null;
					}
					else
					{
						coreWebView2Certificate1 = new CoreWebView2Certificate(this._nativeICoreWebView2ServerCertificateErrorDetectedEventArgs.ServerCertificate);
					}
					coreWebView2Certificate = coreWebView2Certificate1;
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
				return coreWebView2Certificate;
			}
		}

		internal CoreWebView2ServerCertificateErrorDetectedEventArgs(Object rawCoreWebView2ServerCertificateErrorDetectedEventArgs)
		{
			this._rawNative = rawCoreWebView2ServerCertificateErrorDetectedEventArgs;
		}

		public CoreWebView2Deferral GetDeferral()
		{
			CoreWebView2Deferral coreWebView2Deferral;
			try
			{
				coreWebView2Deferral = new CoreWebView2Deferral(this._nativeICoreWebView2ServerCertificateErrorDetectedEventArgs.GetDeferral());
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