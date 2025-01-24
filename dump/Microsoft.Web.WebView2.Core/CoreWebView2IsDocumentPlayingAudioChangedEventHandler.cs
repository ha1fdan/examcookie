using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2IsDocumentPlayingAudioChangedEventHandler : ICoreWebView2IsDocumentPlayingAudioChangedEventHandler
	{
		private CoreWebView2IsDocumentPlayingAudioChangedEventHandler.CallbackType _callback;

		public CoreWebView2IsDocumentPlayingAudioChangedEventHandler(CoreWebView2IsDocumentPlayingAudioChangedEventHandler.CallbackType callback)
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