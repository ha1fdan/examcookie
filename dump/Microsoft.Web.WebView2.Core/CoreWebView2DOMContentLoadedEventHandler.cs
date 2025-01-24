using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2DOMContentLoadedEventHandler : ICoreWebView2DOMContentLoadedEventHandler
	{
		private CoreWebView2DOMContentLoadedEventHandler.CallbackType _callback;

		public CoreWebView2DOMContentLoadedEventHandler(CoreWebView2DOMContentLoadedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public Void Invoke(ICoreWebView2 source, ICoreWebView2DOMContentLoadedEventArgs args)
		{
			this._callback(new CoreWebView2DOMContentLoadedEventArgs(args));
		}

		public delegate Void CallbackType(CoreWebView2DOMContentLoadedEventArgs args);
	}
}