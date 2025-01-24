using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2Certificate
	{
		private static DateTime _unixEpoch;

		internal ICoreWebView2Certificate _nativeICoreWebView2CertificateValue;

		internal Object _rawNative;

		internal ICoreWebView2Certificate _nativeICoreWebView2Certificate
		{
			get
			{
				if (this._nativeICoreWebView2CertificateValue == null)
				{
					try
					{
						this._nativeICoreWebView2CertificateValue = (ICoreWebView2Certificate)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Certificate.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2CertificateValue;
			}
			set
			{
				this._nativeICoreWebView2CertificateValue = value;
			}
		}

		public String DerEncodedSerialNumber
		{
			get
			{
				String derEncodedSerialNumber;
				try
				{
					derEncodedSerialNumber = this._nativeICoreWebView2Certificate.DerEncodedSerialNumber;
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
				return derEncodedSerialNumber;
			}
		}

		public String DisplayName
		{
			get
			{
				String displayName;
				try
				{
					displayName = this._nativeICoreWebView2Certificate.DisplayName;
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
				return displayName;
			}
		}

		public String Issuer
		{
			get
			{
				String issuer;
				try
				{
					issuer = this._nativeICoreWebView2Certificate.Issuer;
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
				return issuer;
			}
		}

		public IReadOnlyList<String> PemEncodedIssuerCertificateChain
		{
			get
			{
				IReadOnlyList<String> net;
				try
				{
					net = COMDotNetTypeConverter.CoreWebView2StringCollectionCOMToNet(this._nativeICoreWebView2Certificate.PemEncodedIssuerCertificateChain);
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

		public String Subject
		{
			get
			{
				String subject;
				try
				{
					subject = this._nativeICoreWebView2Certificate.Subject;
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
				return subject;
			}
		}

		public DateTime ValidFrom
		{
			get
			{
				return this.SecondsSinceUnixEpochToDateTime(this._nativeICoreWebView2Certificate.ValidFrom);
			}
		}

		public DateTime ValidTo
		{
			get
			{
				return this.SecondsSinceUnixEpochToDateTime(this._nativeICoreWebView2Certificate.ValidTo);
			}
		}

		static CoreWebView2Certificate()
		{
			CoreWebView2Certificate._unixEpoch = DateTime.SpecifyKind(new DateTime(1970, 1, 1), 1);
		}

		internal CoreWebView2Certificate(Object rawCoreWebView2Certificate)
		{
			this._rawNative = rawCoreWebView2Certificate;
		}

		private DateTime SecondsSinceUnixEpochToDateTime(Double seconds)
		{
			if (seconds < 0)
			{
				return DateTime.MinValue;
			}
			if (seconds * 10000000 + (Double)CoreWebView2Certificate._unixEpoch.get_Ticks() > (Double)DateTime.MaxValue.get_Ticks())
			{
				return DateTime.MaxValue;
			}
			return CoreWebView2Certificate._unixEpoch.AddSeconds(seconds);
		}

		public String ToPemEncoding()
		{
			String pemEncoding;
			try
			{
				pemEncoding = this._nativeICoreWebView2Certificate.ToPemEncoding();
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
			return pemEncoding;
		}

		public X509Certificate2 ToX509Certificate2()
		{
			X509Certificate2 x509Certificate2 = new X509Certificate2(Convert.FromBase64String(this.ToPemEncoding().Replace("-----BEGIN CERTIFICATE-----", String.Empty).Replace("-----END CERTIFICATE-----", String.Empty)));
			if (x509Certificate2 != null)
			{
				x509Certificate2.set_FriendlyName(this.DisplayName);
			}
			return x509Certificate2;
		}
	}
}