using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2WebResourceRequestedEventHandler : ICoreWebView2WebResourceRequestedEventHandler
	{
		private CoreWebView2WebResourceRequestedEventHandler.CallbackType _callback;

		public CoreWebView2WebResourceRequestedEventHandler(CoreWebView2WebResourceRequestedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2 source, ICoreWebView2WebResourceRequestedEventArgs args)
		{
			this._callback(new CoreWebView2WebResourceRequestedEventArgs(args));
		}

		public delegate void CallbackType(CoreWebView2WebResourceRequestedEventArgs args);
	}
}