using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2PrivateKeyPressedEventHandler : ICoreWebView2PrivateKeyPressedEventHandler
	{
		private CoreWebView2PrivateKeyPressedEventHandler.CallbackType _callback;

		public CoreWebView2PrivateKeyPressedEventHandler(CoreWebView2PrivateKeyPressedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2Controller source, ICoreWebView2PrivateKeyPressedEventArgs args)
		{
			this._callback(new CoreWebView2PrivateKeyPressedEventArgs(args));
		}

		public delegate void CallbackType(CoreWebView2PrivateKeyPressedEventArgs args);
	}
}