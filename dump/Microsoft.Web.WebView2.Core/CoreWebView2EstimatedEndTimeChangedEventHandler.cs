using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2EstimatedEndTimeChangedEventHandler : ICoreWebView2EstimatedEndTimeChangedEventHandler
	{
		private CoreWebView2EstimatedEndTimeChangedEventHandler.CallbackType _callback;

		public CoreWebView2EstimatedEndTimeChangedEventHandler(CoreWebView2EstimatedEndTimeChangedEventHandler.CallbackType callback)
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