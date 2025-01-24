using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2NewBrowserVersionAvailableEventHandler : ICoreWebView2NewBrowserVersionAvailableEventHandler
	{
		private CoreWebView2NewBrowserVersionAvailableEventHandler.CallbackType _callback;

		public CoreWebView2NewBrowserVersionAvailableEventHandler(CoreWebView2NewBrowserVersionAvailableEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2Environment source, Object args)
		{
			this._callback(EventArgs.Empty);
		}

		public delegate void CallbackType(EventArgs args);
	}
}