using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2FocusChangedEventHandler : ICoreWebView2FocusChangedEventHandler
	{
		private CoreWebView2FocusChangedEventHandler.CallbackType _callback;

		public CoreWebView2FocusChangedEventHandler(CoreWebView2FocusChangedEventHandler.CallbackType callback)
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