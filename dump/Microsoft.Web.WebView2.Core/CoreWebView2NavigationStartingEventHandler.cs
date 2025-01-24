using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2NavigationStartingEventHandler : ICoreWebView2NavigationStartingEventHandler
	{
		private CoreWebView2NavigationStartingEventHandler.CallbackType _callback;

		public CoreWebView2NavigationStartingEventHandler(CoreWebView2NavigationStartingEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2 source, ICoreWebView2NavigationStartingEventArgs args)
		{
			this._callback(new CoreWebView2NavigationStartingEventArgs(args));
		}

		public delegate void CallbackType(CoreWebView2NavigationStartingEventArgs args);
	}
}