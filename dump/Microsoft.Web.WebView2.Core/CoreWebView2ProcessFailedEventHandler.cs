using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2ProcessFailedEventHandler : ICoreWebView2ProcessFailedEventHandler
	{
		private CoreWebView2ProcessFailedEventHandler.CallbackType _callback;

		public CoreWebView2ProcessFailedEventHandler(CoreWebView2ProcessFailedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2 source, ICoreWebView2ProcessFailedEventArgs args)
		{
			this._callback(new CoreWebView2ProcessFailedEventArgs(args));
		}

		public delegate void CallbackType(CoreWebView2ProcessFailedEventArgs args);
	}
}