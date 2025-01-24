using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2ContextMenuRequestedEventHandler : ICoreWebView2ContextMenuRequestedEventHandler
	{
		private CoreWebView2ContextMenuRequestedEventHandler.CallbackType _callback;

		public CoreWebView2ContextMenuRequestedEventHandler(CoreWebView2ContextMenuRequestedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public Void Invoke(ICoreWebView2 source, ICoreWebView2ContextMenuRequestedEventArgs args)
		{
			this._callback(new CoreWebView2ContextMenuRequestedEventArgs(args));
		}

		public delegate Void CallbackType(CoreWebView2ContextMenuRequestedEventArgs args);
	}
}