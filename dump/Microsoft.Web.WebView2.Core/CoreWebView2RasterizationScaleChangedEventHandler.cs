using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2RasterizationScaleChangedEventHandler : ICoreWebView2RasterizationScaleChangedEventHandler
	{
		private CoreWebView2RasterizationScaleChangedEventHandler.CallbackType _callback;

		public CoreWebView2RasterizationScaleChangedEventHandler(CoreWebView2RasterizationScaleChangedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2Controller source, Object args)
		{
			this._callback(EventArgs.Empty);
		}

		public delegate void CallbackType(EventArgs args);
	}
}