using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2WebResourceResponseReceivedEventHandler : ICoreWebView2WebResourceResponseReceivedEventHandler
	{
		private CoreWebView2WebResourceResponseReceivedEventHandler.CallbackType _callback;

		public CoreWebView2WebResourceResponseReceivedEventHandler(CoreWebView2WebResourceResponseReceivedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2 source, ICoreWebView2WebResourceResponseReceivedEventArgs args)
		{
			this._callback(new CoreWebView2WebResourceResponseReceivedEventArgs(args));
		}

		public delegate void CallbackType(CoreWebView2WebResourceResponseReceivedEventArgs args);
	}
}