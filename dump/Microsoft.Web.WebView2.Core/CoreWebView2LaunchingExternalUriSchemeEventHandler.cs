using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2LaunchingExternalUriSchemeEventHandler : ICoreWebView2LaunchingExternalUriSchemeEventHandler
	{
		private CoreWebView2LaunchingExternalUriSchemeEventHandler.CallbackType _callback;

		public CoreWebView2LaunchingExternalUriSchemeEventHandler(CoreWebView2LaunchingExternalUriSchemeEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2 source, ICoreWebView2LaunchingExternalUriSchemeEventArgs args)
		{
			this._callback(new CoreWebView2LaunchingExternalUriSchemeEventArgs(args));
		}

		public delegate void CallbackType(CoreWebView2LaunchingExternalUriSchemeEventArgs args);
	}
}