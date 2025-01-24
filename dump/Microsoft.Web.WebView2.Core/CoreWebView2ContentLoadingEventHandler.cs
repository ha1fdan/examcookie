using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2ContentLoadingEventHandler : ICoreWebView2ContentLoadingEventHandler
	{
		private CoreWebView2ContentLoadingEventHandler.CallbackType _callback;

		public CoreWebView2ContentLoadingEventHandler(CoreWebView2ContentLoadingEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public Void Invoke(ICoreWebView2 source, ICoreWebView2ContentLoadingEventArgs args)
		{
			this._callback(new CoreWebView2ContentLoadingEventArgs(args));
		}

		public delegate Void CallbackType(CoreWebView2ContentLoadingEventArgs args);
	}
}