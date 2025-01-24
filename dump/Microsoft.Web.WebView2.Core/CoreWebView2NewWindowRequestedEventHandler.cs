using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2NewWindowRequestedEventHandler : ICoreWebView2NewWindowRequestedEventHandler
	{
		private CoreWebView2NewWindowRequestedEventHandler.CallbackType _callback;

		public CoreWebView2NewWindowRequestedEventHandler(CoreWebView2NewWindowRequestedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2 source, ICoreWebView2NewWindowRequestedEventArgs args)
		{
			this._callback(new CoreWebView2NewWindowRequestedEventArgs(args));
		}

		public delegate void CallbackType(CoreWebView2NewWindowRequestedEventArgs args);
	}
}