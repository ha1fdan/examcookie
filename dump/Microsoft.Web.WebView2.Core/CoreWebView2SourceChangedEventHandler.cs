using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2SourceChangedEventHandler : ICoreWebView2SourceChangedEventHandler
	{
		private CoreWebView2SourceChangedEventHandler.CallbackType _callback;

		public CoreWebView2SourceChangedEventHandler(CoreWebView2SourceChangedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2 source, ICoreWebView2SourceChangedEventArgs args)
		{
			this._callback(new CoreWebView2SourceChangedEventArgs(args));
		}

		public delegate void CallbackType(CoreWebView2SourceChangedEventArgs args);
	}
}