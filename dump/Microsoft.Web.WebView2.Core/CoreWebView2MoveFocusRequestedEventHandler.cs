using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2MoveFocusRequestedEventHandler : ICoreWebView2MoveFocusRequestedEventHandler
	{
		private CoreWebView2MoveFocusRequestedEventHandler.CallbackType _callback;

		public CoreWebView2MoveFocusRequestedEventHandler(CoreWebView2MoveFocusRequestedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2Controller source, ICoreWebView2MoveFocusRequestedEventArgs args)
		{
			this._callback(new CoreWebView2MoveFocusRequestedEventArgs(args));
		}

		public delegate void CallbackType(CoreWebView2MoveFocusRequestedEventArgs args);
	}
}