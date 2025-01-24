using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2GetCookiesCompletedHandler : ICoreWebView2GetCookiesCompletedHandler, INotifyCompletion
	{
		private Action continuation;

		public List<CoreWebView2Cookie> cookieList
		{
			get;
			private set;
		}

		public Int32 errCode
		{
			get;
			private set;
		}

		public Boolean IsCompleted
		{
			get;
			private set;
		}

		public CoreWebView2GetCookiesCompletedHandler()
		{
			this.IsCompleted = false;
		}

		public CoreWebView2GetCookiesCompletedHandler GetAwaiter()
		{
			return this;
		}

		public List<CoreWebView2Cookie> GetResult()
		{
			return this.cookieList;
		}

		public Void Invoke(Int32 errCode, ICoreWebView2CookieList cookieList)
		{
			this.cookieList = (cookieList == null ? new List<CoreWebView2Cookie>() : COMDotNetTypeConverter.CookieListCOMToNet(cookieList));
			this.errCode = errCode;
			this.IsCompleted = true;
			if (this.continuation != null)
			{
				this.continuation.Invoke();
			}
		}

		public Void OnCompleted(Action continuation)
		{
			this.continuation = continuation;
			if (this.IsCompleted)
			{
				continuation.Invoke();
			}
		}
	}
}