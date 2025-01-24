using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2StatusBarTextChangedEventHandler : ICoreWebView2StatusBarTextChangedEventHandler
	{
		private CoreWebView2StatusBarTextChangedEventHandler.CallbackType _callback;

		public CoreWebView2StatusBarTextChangedEventHandler(CoreWebView2StatusBarTextChangedEventHandler.CallbackType callback)
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