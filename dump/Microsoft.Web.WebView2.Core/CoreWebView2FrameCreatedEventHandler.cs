using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2FrameCreatedEventHandler : ICoreWebView2FrameCreatedEventHandler
	{
		private CoreWebView2FrameCreatedEventHandler.CallbackType _callback;

		public CoreWebView2FrameCreatedEventHandler(CoreWebView2FrameCreatedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2 source, ICoreWebView2FrameCreatedEventArgs args)
		{
			this._callback(new CoreWebView2FrameCreatedEventArgs(args));
		}

		public delegate void CallbackType(CoreWebView2FrameCreatedEventArgs args);
	}
}