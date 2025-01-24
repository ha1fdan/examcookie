using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2FramePermissionRequestedEventHandler : ICoreWebView2FramePermissionRequestedEventHandler
	{
		private CoreWebView2FramePermissionRequestedEventHandler.CallbackType _callback;

		public CoreWebView2FramePermissionRequestedEventHandler(CoreWebView2FramePermissionRequestedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2Frame source, ICoreWebView2PermissionRequestedEventArgs2 args)
		{
			this._callback(new CoreWebView2PermissionRequestedEventArgs(args));
		}

		public delegate void CallbackType(CoreWebView2PermissionRequestedEventArgs args);
	}
}