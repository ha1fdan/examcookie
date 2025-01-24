using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2PermissionRequestedEventHandler : ICoreWebView2PermissionRequestedEventHandler
	{
		private CoreWebView2PermissionRequestedEventHandler.CallbackType _callback;

		public CoreWebView2PermissionRequestedEventHandler(CoreWebView2PermissionRequestedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2 source, ICoreWebView2PermissionRequestedEventArgs args)
		{
			this._callback(new CoreWebView2PermissionRequestedEventArgs(args));
		}

		public delegate void CallbackType(CoreWebView2PermissionRequestedEventArgs args);
	}
}