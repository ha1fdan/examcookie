using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler : ICoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler
	{
		private CoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler.CallbackType _callback;

		public CoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler(CoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2 source, Object args)
		{
			this._callback(EventArgs.Empty);
		}

		public delegate void CallbackType(EventArgs args);
	}
}