using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2ContainsFullScreenElementChangedEventHandler : ICoreWebView2ContainsFullScreenElementChangedEventHandler
	{
		private CoreWebView2ContainsFullScreenElementChangedEventHandler.CallbackType _callback;

		public CoreWebView2ContainsFullScreenElementChangedEventHandler(CoreWebView2ContainsFullScreenElementChangedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public Void Invoke(ICoreWebView2 source, Object args)
		{
			this._callback(EventArgs.Empty);
		}

		public delegate Void CallbackType(EventArgs args);
	}
}