using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2NavigationCompletedEventHandler : ICoreWebView2NavigationCompletedEventHandler
	{
		private CoreWebView2NavigationCompletedEventHandler.CallbackType _callback;

		public CoreWebView2NavigationCompletedEventHandler(CoreWebView2NavigationCompletedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2 source, ICoreWebView2NavigationCompletedEventArgs args)
		{
			this._callback(new CoreWebView2NavigationCompletedEventArgs(args));
		}

		public delegate void CallbackType(CoreWebView2NavigationCompletedEventArgs args);
	}
}