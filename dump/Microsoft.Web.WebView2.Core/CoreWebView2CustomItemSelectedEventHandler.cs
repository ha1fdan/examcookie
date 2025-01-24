using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2CustomItemSelectedEventHandler : ICoreWebView2CustomItemSelectedEventHandler
	{
		private CoreWebView2CustomItemSelectedEventHandler.CallbackType _callback;

		public CoreWebView2CustomItemSelectedEventHandler(CoreWebView2CustomItemSelectedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public Void Invoke(ICoreWebView2ContextMenuItem source, Object args)
		{
			this._callback(EventArgs.Empty);
		}

		public delegate Void CallbackType(EventArgs args);
	}
}