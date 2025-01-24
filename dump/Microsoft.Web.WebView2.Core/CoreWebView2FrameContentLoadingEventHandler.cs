using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2FrameContentLoadingEventHandler : ICoreWebView2FrameContentLoadingEventHandler
	{
		private CoreWebView2FrameContentLoadingEventHandler.CallbackType _callback;

		public CoreWebView2FrameContentLoadingEventHandler(CoreWebView2FrameContentLoadingEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2Frame source, ICoreWebView2ContentLoadingEventArgs args)
		{
			this._callback(new CoreWebView2ContentLoadingEventArgs(args));
		}

		public delegate void CallbackType(CoreWebView2ContentLoadingEventArgs args);
	}
}