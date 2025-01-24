using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2FrameDestroyedEventHandler : ICoreWebView2FrameDestroyedEventHandler
	{
		private CoreWebView2FrameDestroyedEventHandler.CallbackType _callback;

		public CoreWebView2FrameDestroyedEventHandler(CoreWebView2FrameDestroyedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2Frame source, Object args)
		{
			this._callback(EventArgs.Empty);
		}

		public delegate void CallbackType(EventArgs args);
	}
}