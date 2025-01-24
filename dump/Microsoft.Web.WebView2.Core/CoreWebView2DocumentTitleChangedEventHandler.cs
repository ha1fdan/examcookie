using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2DocumentTitleChangedEventHandler : ICoreWebView2DocumentTitleChangedEventHandler
	{
		private CoreWebView2DocumentTitleChangedEventHandler.CallbackType _callback;

		public CoreWebView2DocumentTitleChangedEventHandler(CoreWebView2DocumentTitleChangedEventHandler.CallbackType callback)
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