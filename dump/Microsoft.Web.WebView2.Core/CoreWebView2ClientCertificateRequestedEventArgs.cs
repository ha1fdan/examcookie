using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2ClientCertificateRequestedEventArgs : EventArgs
	{
		internal ICoreWebView2ClientCertificateRequestedEventArgs _nativeICoreWebView2ClientCertificateRequestedEventArgsValue;

		internal Object _rawNative;

		internal ICoreWebView2ClientCertificateRequestedEventArgs _nativeICoreWebView2ClientCertificateRequestedEventArgs
		{
			get
			{
				if (this._nativeICoreWebView2ClientCertificateRequestedEventArgsValue == null)
				{
					try
					{
						this._nativeICoreWebView2ClientCertificateRequestedEventArgsValue = (ICoreWebView2ClientCertificateRequestedEventArgs)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ClientCertificateRequestedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2ClientCertificateRequestedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2ClientCertificateRequestedEventArgsValue = value;
			}
		}

		public IReadOnlyList<String> AllowedCertificateAuthorities
		{
			get
			{
				IReadOnlyList<String> net;
				try
				{
					net = COMDotNetTypeConverter.CoreWebView2StringCollectionCOMToNet(this._nativeICoreWebView2ClientCertificateRequestedEventArgs.AllowedCertificateAuthorities);
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
				return net;
			}
		}

		public Boolean Cancel
		{
			get
			{
				Boolean cancel;
				try
				{
					cancel = this._nativeICoreWebView2ClientCertificateRequestedEventArgs.Cancel != 0;
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
					this._nativeICoreWebView2ClientCertificateRequestedEventArgs.Cancel = (value ? 1 : 0);
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

		public Boolean Handled
		{
			get
			{
				Boolean handled;
				try
				{
					handled = this._nativeICoreWebView2ClientCertificateRequestedEventArgs.Handled != 0;
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
					this._nativeICoreWebView2ClientCertificateRequestedEventArgs.Handled = (value ? 1 : 0);
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

		public String Host
		{
			get
			{
				String host;
				try
				{
					host = this._nativeICoreWebView2ClientCertificateRequestedEventArgs.Host;
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
				return host;
			}
		}

		public Boolean IsProxy
		{
			get
			{
				Boolean isProxy;
				try
				{
					isProxy = this._nativeICoreWebView2ClientCertificateRequestedEventArgs.IsProxy != 0;
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
				return isProxy;
			}
		}

		public IReadOnlyList<CoreWebView2ClientCertificate> MutuallyTrustedCertificates
		{
			get
			{
				IReadOnlyList<CoreWebView2ClientCertificate> net;
				try
				{
					net = COMDotNetTypeConverter.CoreWebView2ClientCertificateCollectionCOMToNet(this._nativeICoreWebView2ClientCertificateRequestedEventArgs.MutuallyTrustedCertificates);
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
				return net;
			}
		}

		public Int32 Port
		{
			get
			{
				Int32 port;
				try
				{
					port = this._nativeICoreWebView2ClientCertificateRequestedEventArgs.Port;
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
				return port;
			}
		}

		public CoreWebView2ClientCertificate SelectedCertificate
		{
			get
			{
				CoreWebView2ClientCertificate coreWebView2ClientCertificate;
				CoreWebView2ClientCertificate coreWebView2ClientCertificate1;
				try
				{
					if (this._nativeICoreWebView2ClientCertificateRequestedEventArgs.SelectedCertificate == null)
					{
						coreWebView2ClientCertificate1 = null;
					}
					else
					{
						coreWebView2ClientCertificate1 = new CoreWebView2ClientCertificate(this._nativeICoreWebView2ClientCertificateRequestedEventArgs.SelectedCertificate);
					}
					coreWebView2ClientCertificate = coreWebView2ClientCertificate1;
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
				return coreWebView2ClientCertificate;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2ClientCertificateRequestedEventArgs.SelectedCertificate = value._nativeICoreWebView2ClientCertificate;
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

		internal CoreWebView2ClientCertificateRequestedEventArgs(Object rawCoreWebView2ClientCertificateRequestedEventArgs)
		{
			this._rawNative = rawCoreWebView2ClientCertificateRequestedEventArgs;
		}

		public CoreWebView2Deferral GetDeferral()
		{
			CoreWebView2Deferral coreWebView2Deferral;
			try
			{
				coreWebView2Deferral = new CoreWebView2Deferral(this._nativeICoreWebView2ClientCertificateRequestedEventArgs.GetDeferral());
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