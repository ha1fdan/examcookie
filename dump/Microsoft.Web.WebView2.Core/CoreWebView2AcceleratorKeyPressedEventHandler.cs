using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2AcceleratorKeyPressedEventHandler : ICoreWebView2AcceleratorKeyPressedEventHandler
	{
		private CoreWebView2AcceleratorKeyPressedEventHandler.CallbackType _callback;

		public CoreWebView2AcceleratorKeyPressedEventHandler(CoreWebView2AcceleratorKeyPressedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public Void Invoke(ICoreWebView2Controller source, ICoreWebView2AcceleratorKeyPressedEventArgs args)
		{
			this._callback(new CoreWebView2AcceleratorKeyPressedEventArgs(args));
		}

		public delegate Void CallbackType(CoreWebView2AcceleratorKeyPressedEventArgs args);
	}
}