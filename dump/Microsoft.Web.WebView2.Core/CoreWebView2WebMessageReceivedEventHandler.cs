using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2WebMessageReceivedEventHandler : ICoreWebView2WebMessageReceivedEventHandler
	{
		private CoreWebView2WebMessageReceivedEventHandler.CallbackType _callback;

		public CoreWebView2WebMessageReceivedEventHandler(CoreWebView2WebMessageReceivedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2 source, ICoreWebView2WebMessageReceivedEventArgs args)
		{
			this._callback(new CoreWebView2WebMessageReceivedEventArgs(args));
		}

		public delegate void CallbackType(CoreWebView2WebMessageReceivedEventArgs args);
	}
}