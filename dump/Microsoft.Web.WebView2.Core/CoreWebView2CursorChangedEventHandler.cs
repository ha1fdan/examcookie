using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2CursorChangedEventHandler : ICoreWebView2CursorChangedEventHandler
	{
		private CoreWebView2CursorChangedEventHandler.CallbackType _callback;

		public CoreWebView2CursorChangedEventHandler(CoreWebView2CursorChangedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public Void Invoke(ICoreWebView2CompositionController source, Object args)
		{
			this._callback(EventArgs.Empty);
		}

		public delegate Void CallbackType(EventArgs args);
	}
}