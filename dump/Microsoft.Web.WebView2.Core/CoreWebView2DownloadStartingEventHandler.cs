using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2DownloadStartingEventHandler : ICoreWebView2DownloadStartingEventHandler
	{
		private CoreWebView2DownloadStartingEventHandler.CallbackType _callback;

		public CoreWebView2DownloadStartingEventHandler(CoreWebView2DownloadStartingEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public Void Invoke(ICoreWebView2 source, ICoreWebView2DownloadStartingEventArgs args)
		{
			this._callback(new CoreWebView2DownloadStartingEventArgs(args));
		}

		public delegate Void CallbackType(CoreWebView2DownloadStartingEventArgs args);
	}
}