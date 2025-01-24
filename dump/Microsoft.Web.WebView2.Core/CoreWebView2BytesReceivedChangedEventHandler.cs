using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2BytesReceivedChangedEventHandler : ICoreWebView2BytesReceivedChangedEventHandler
	{
		private CoreWebView2BytesReceivedChangedEventHandler.CallbackType _callback;

		public CoreWebView2BytesReceivedChangedEventHandler(CoreWebView2BytesReceivedChangedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public Void Invoke(ICoreWebView2DownloadOperation source, Object args)
		{
			this._callback(EventArgs.Empty);
		}

		public delegate Void CallbackType(EventArgs args);
	}
}