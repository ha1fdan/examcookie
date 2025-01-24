using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2ZoomFactorChangedEventHandler : ICoreWebView2ZoomFactorChangedEventHandler
	{
		private CoreWebView2ZoomFactorChangedEventHandler.CallbackType _callback;

		public CoreWebView2ZoomFactorChangedEventHandler(CoreWebView2ZoomFactorChangedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2Controller source, Object args)
		{
			this._callback(EventArgs.Empty);
		}

		public delegate void CallbackType(EventArgs args);
	}
}