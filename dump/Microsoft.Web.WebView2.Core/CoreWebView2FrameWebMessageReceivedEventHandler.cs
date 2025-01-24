using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2FrameWebMessageReceivedEventHandler : ICoreWebView2FrameWebMessageReceivedEventHandler
	{
		private CoreWebView2FrameWebMessageReceivedEventHandler.CallbackType _callback;

		public CoreWebView2FrameWebMessageReceivedEventHandler(CoreWebView2FrameWebMessageReceivedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2Frame source, ICoreWebView2WebMessageReceivedEventArgs args)
		{
			this._callback(new CoreWebView2WebMessageReceivedEventArgs(args));
		}

		public delegate void CallbackType(CoreWebView2WebMessageReceivedEventArgs args);
	}
}