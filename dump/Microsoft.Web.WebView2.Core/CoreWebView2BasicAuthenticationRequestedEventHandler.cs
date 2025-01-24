using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2BasicAuthenticationRequestedEventHandler : ICoreWebView2BasicAuthenticationRequestedEventHandler
	{
		private CoreWebView2BasicAuthenticationRequestedEventHandler.CallbackType _callback;

		public CoreWebView2BasicAuthenticationRequestedEventHandler(CoreWebView2BasicAuthenticationRequestedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public Void Invoke(ICoreWebView2 source, ICoreWebView2BasicAuthenticationRequestedEventArgs args)
		{
			this._callback(new CoreWebView2BasicAuthenticationRequestedEventArgs(args));
		}

		public delegate Void CallbackType(CoreWebView2BasicAuthenticationRequestedEventArgs args);
	}
}