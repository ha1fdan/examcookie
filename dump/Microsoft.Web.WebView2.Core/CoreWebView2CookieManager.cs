using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2CookieManager
	{
		internal ICoreWebView2CookieManager _nativeICoreWebView2CookieManagerValue;

		internal Object _rawNative;

		internal ICoreWebView2CookieManager _nativeICoreWebView2CookieManager
		{
			get
			{
				if (this._nativeICoreWebView2CookieManagerValue == null)
				{
					try
					{
						this._nativeICoreWebView2CookieManagerValue = (ICoreWebView2CookieManager)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CookieManager.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2CookieManagerValue;
			}
			set
			{
				this._nativeICoreWebView2CookieManagerValue = value;
			}
		}

		internal CoreWebView2CookieManager(Object rawCoreWebView2CookieManager)
		{
			this._rawNative = rawCoreWebView2CookieManager;
		}

		public Void AddOrUpdateCookie(CoreWebView2Cookie cookie)
		{
			try
			{
				this._nativeICoreWebView2CookieManager.AddOrUpdateCookie(cookie._nativeICoreWebView2Cookie);
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

		public CoreWebView2Cookie CopyCookie(CoreWebView2Cookie cookieParam)
		{
			CoreWebView2Cookie coreWebView2Cookie;
			try
			{
				coreWebView2Cookie = new CoreWebView2Cookie(this._nativeICoreWebView2CookieManager.CopyCookie(cookieParam._nativeICoreWebView2Cookie));
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
			return coreWebView2Cookie;
		}

		public CoreWebView2Cookie CreateCookie(String name, String value, String Domain, String Path)
		{
			CoreWebView2Cookie coreWebView2Cookie;
			try
			{
				coreWebView2Cookie = new CoreWebView2Cookie(this._nativeICoreWebView2CookieManager.CreateCookie(name, value, Domain, Path));
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
			return coreWebView2Cookie;
		}

		public CoreWebView2Cookie CreateCookieWithSystemNetCookie(Cookie systemNetCookie)
		{
			return new CoreWebView2Cookie(this._nativeICoreWebView2CookieManager.CreateCookie(systemNetCookie.get_Name(), systemNetCookie.get_Value(), systemNetCookie.get_Domain(), systemNetCookie.get_Path()))
			{
				IsHttpOnly = systemNetCookie.get_HttpOnly(),
				IsSecure = systemNetCookie.get_Secure(),
				Expires = systemNetCookie.get_Expires().ToUniversalTime()
			};
		}

		public Void DeleteAllCookies()
		{
			try
			{
				this._nativeICoreWebView2CookieManager.DeleteAllCookies();
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

		public Void DeleteCookie(CoreWebView2Cookie cookie)
		{
			try
			{
				this._nativeICoreWebView2CookieManager.DeleteCookie(cookie._nativeICoreWebView2Cookie);
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

		public Void DeleteCookies(String name, String uri)
		{
			try
			{
				this._nativeICoreWebView2CookieManager.DeleteCookies(name, uri);
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

		public Void DeleteCookiesWithDomainAndPath(String name, String Domain, String Path)
		{
			try
			{
				this._nativeICoreWebView2CookieManager.DeleteCookiesWithDomainAndPath(name, Domain, Path);
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

		public async Task<List<CoreWebView2Cookie>> GetCookiesAsync(String uri)
		{
			CoreWebView2GetCookiesCompletedHandler coreWebView2GetCookiesCompletedHandler;
			try
			{
				coreWebView2GetCookiesCompletedHandler = new CoreWebView2GetCookiesCompletedHandler();
				this._nativeICoreWebView2CookieManager.GetCookies(uri, coreWebView2GetCookiesCompletedHandler);
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
			await coreWebView2GetCookiesCompletedHandler;
			Marshal.ThrowExceptionForHR(coreWebView2GetCookiesCompletedHandler.errCode);
			List<CoreWebView2Cookie> list = coreWebView2GetCookiesCompletedHandler.cookieList;
			coreWebView2GetCookiesCompletedHandler = null;
			return list;
		}
	}
}