using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2FrameNavigationStartingEventHandler : ICoreWebView2FrameNavigationStartingEventHandler
	{
		private CoreWebView2FrameNavigationStartingEventHandler.CallbackType _callback;

		public CoreWebView2FrameNavigationStartingEventHandler(CoreWebView2FrameNavigationStartingEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2Frame source, ICoreWebView2NavigationStartingEventArgs args)
		{
			this._callback(new CoreWebView2NavigationStartingEventArgs(args));
		}

		public delegate void CallbackType(CoreWebView2NavigationStartingEventArgs args);
	}
}