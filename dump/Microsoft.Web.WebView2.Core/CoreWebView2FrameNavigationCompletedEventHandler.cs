using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2FrameNavigationCompletedEventHandler : ICoreWebView2FrameNavigationCompletedEventHandler
	{
		private CoreWebView2FrameNavigationCompletedEventHandler.CallbackType _callback;

		public CoreWebView2FrameNavigationCompletedEventHandler(CoreWebView2FrameNavigationCompletedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2Frame source, ICoreWebView2NavigationCompletedEventArgs args)
		{
			this._callback(new CoreWebView2NavigationCompletedEventArgs(args));
		}

		public delegate void CallbackType(CoreWebView2NavigationCompletedEventArgs args);
	}
}