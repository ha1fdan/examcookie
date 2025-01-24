using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Net;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2Cookie
	{
		private static DateTime _unixEpoch;

		internal ICoreWebView2Cookie _nativeICoreWebView2CookieValue;

		internal Object _rawNative;

		internal ICoreWebView2Cookie _nativeICoreWebView2Cookie
		{
			get
			{
				if (this._nativeICoreWebView2CookieValue == null)
				{
					try
					{
						this._nativeICoreWebView2CookieValue = (ICoreWebView2Cookie)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Cookie.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2CookieValue;
			}
			set
			{
				this._nativeICoreWebView2CookieValue = value;
			}
		}

		public String Domain
		{
			get
			{
				String domain;
				try
				{
					domain = this._nativeICoreWebView2Cookie.Domain;
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
				return domain;
			}
		}

		public DateTime Expires
		{
			get
			{
				return this.SecondsSinceUnixEpochToDateTime(this._nativeICoreWebView2Cookie.Expires);
			}
			set
			{
				if (value.get_Kind() != 1)
				{
					value = value.ToUniversalTime();
				}
				Double totalSeconds = (value - CoreWebView2Cookie._unixEpoch).get_TotalSeconds();
				this._nativeICoreWebView2Cookie.Expires = (totalSeconds < 0 ? Convert.ToDouble(-1) : totalSeconds);
			}
		}

		public Boolean IsHttpOnly
		{
			get
			{
				Boolean isHttpOnly;
				try
				{
					isHttpOnly = this._nativeICoreWebView2Cookie.IsHttpOnly != 0;
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
				return isHttpOnly;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2Cookie.IsHttpOnly = (value ? 1 : 0);
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

		public Boolean IsSecure
		{
			get
			{
				Boolean isSecure;
				try
				{
					isSecure = this._nativeICoreWebView2Cookie.IsSecure != 0;
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
				return isSecure;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2Cookie.IsSecure = (value ? 1 : 0);
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

		public Boolean IsSession
		{
			get
			{
				Boolean isSession;
				try
				{
					isSession = this._nativeICoreWebView2Cookie.IsSession != 0;
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
				return isSession;
			}
		}

		public String Name
		{
			get
			{
				String name;
				try
				{
					name = this._nativeICoreWebView2Cookie.Name;
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
				return name;
			}
		}

		public String Path
		{
			get
			{
				String path;
				try
				{
					path = this._nativeICoreWebView2Cookie.Path;
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
				return path;
			}
		}

		public CoreWebView2CookieSameSiteKind SameSite
		{
			get
			{
				CoreWebView2CookieSameSiteKind sameSite;
				try
				{
					sameSite = (CoreWebView2CookieSameSiteKind)this._nativeICoreWebView2Cookie.SameSite;
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
				return sameSite;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2Cookie.SameSite = (COREWEBVIEW2_COOKIE_SAME_SITE_KIND)value;
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

		public String Value
		{
			get
			{
				String value;
				try
				{
					value = this._nativeICoreWebView2Cookie.Value;
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
				return value;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2Cookie.Value = value;
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

		static CoreWebView2Cookie()
		{
			CoreWebView2Cookie._unixEpoch = DateTime.SpecifyKind(new DateTime(1970, 1, 1), 1);
		}

		internal CoreWebView2Cookie(Object rawCoreWebView2Cookie)
		{
			this._rawNative = rawCoreWebView2Cookie;
		}

		private DateTime SecondsSinceUnixEpochToDateTime(Double seconds)
		{
			if (seconds < 0)
			{
				return DateTime.MinValue;
			}
			if (seconds * 10000000 + (Double)CoreWebView2Cookie._unixEpoch.get_Ticks() > (Double)DateTime.MaxValue.get_Ticks())
			{
				return DateTime.MaxValue;
			}
			return CoreWebView2Cookie._unixEpoch.AddSeconds(seconds);
		}

		public Cookie ToSystemNetCookie()
		{
			Cookie cookie = new Cookie(this.Name, this.Value, this.Path, this.Domain);
			cookie.set_Expires(this.Expires);
			cookie.set_HttpOnly(this.IsHttpOnly);
			cookie.set_Secure(this.IsSecure);
			return cookie;
		}
	}
}