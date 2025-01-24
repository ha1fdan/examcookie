using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2DevToolsProtocolEventReceivedEventHandler : ICoreWebView2DevToolsProtocolEventReceivedEventHandler
	{
		private CoreWebView2DevToolsProtocolEventReceivedEventHandler.CallbackType _callback;

		public CoreWebView2DevToolsProtocolEventReceivedEventHandler(CoreWebView2DevToolsProtocolEventReceivedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public Void Invoke(ICoreWebView2 source, ICoreWebView2DevToolsProtocolEventReceivedEventArgs args)
		{
			this._callback(new CoreWebView2DevToolsProtocolEventReceivedEventArgs(args));
		}

		public delegate Void CallbackType(CoreWebView2DevToolsProtocolEventReceivedEventArgs args);
	}
}