using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2FaviconChangedEventHandler : ICoreWebView2FaviconChangedEventHandler
	{
		private CoreWebView2FaviconChangedEventHandler.CallbackType _callback;

		public CoreWebView2FaviconChangedEventHandler(CoreWebView2FaviconChangedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2 source, Object args)
		{
			this._callback(EventArgs.Empty);
		}

		public delegate void CallbackType(EventArgs args);
	}
}