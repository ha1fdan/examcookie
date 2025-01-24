using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2FrameDOMContentLoadedEventHandler : ICoreWebView2FrameDOMContentLoadedEventHandler
	{
		private CoreWebView2FrameDOMContentLoadedEventHandler.CallbackType _callback;

		public CoreWebView2FrameDOMContentLoadedEventHandler(CoreWebView2FrameDOMContentLoadedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2Frame source, ICoreWebView2DOMContentLoadedEventArgs args)
		{
			this._callback(new CoreWebView2DOMContentLoadedEventArgs(args));
		}

		public delegate void CallbackType(CoreWebView2DOMContentLoadedEventArgs args);
	}
}