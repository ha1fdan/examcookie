using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2HistoryChangedEventHandler : ICoreWebView2HistoryChangedEventHandler
	{
		private CoreWebView2HistoryChangedEventHandler.CallbackType _callback;

		public CoreWebView2HistoryChangedEventHandler(CoreWebView2HistoryChangedEventHandler.CallbackType callback)
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