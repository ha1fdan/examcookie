using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2StateChangedEventHandler : ICoreWebView2StateChangedEventHandler
	{
		private CoreWebView2StateChangedEventHandler.CallbackType _callback;

		public CoreWebView2StateChangedEventHandler(CoreWebView2StateChangedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2DownloadOperation source, Object args)
		{
			this._callback(EventArgs.Empty);
		}

		public delegate void CallbackType(EventArgs args);
	}
}