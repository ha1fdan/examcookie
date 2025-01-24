using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2FrameNameChangedEventHandler : ICoreWebView2FrameNameChangedEventHandler
	{
		private CoreWebView2FrameNameChangedEventHandler.CallbackType _callback;

		public CoreWebView2FrameNameChangedEventHandler(CoreWebView2FrameNameChangedEventHandler.CallbackType callback)
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