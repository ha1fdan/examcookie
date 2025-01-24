using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2IsMutedChangedEventHandler : ICoreWebView2IsMutedChangedEventHandler
	{
		private CoreWebView2IsMutedChangedEventHandler.CallbackType _callback;

		public CoreWebView2IsMutedChangedEventHandler(CoreWebView2IsMutedChangedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2 source, Object args)
		{
			this._callback(EventArgs.Empty);
		}

		public delegate void CallbackType(EventArgs args);
	}
}