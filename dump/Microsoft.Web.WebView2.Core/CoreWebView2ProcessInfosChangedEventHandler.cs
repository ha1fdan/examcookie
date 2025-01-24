using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2ProcessInfosChangedEventHandler : ICoreWebView2ProcessInfosChangedEventHandler
	{
		private CoreWebView2ProcessInfosChangedEventHandler.CallbackType _callback;

		public CoreWebView2ProcessInfosChangedEventHandler(CoreWebView2ProcessInfosChangedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2Environment source, Object args)
		{
			this._callback(EventArgs.Empty);
		}

		public delegate void CallbackType(EventArgs args);
	}
}