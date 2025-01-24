using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2PrivateRemoteObjectProxyPassivatedEventHandler : ICoreWebView2PrivateRemoteObjectProxyPassivatedEventHandler
	{
		private CoreWebView2PrivateRemoteObjectProxyPassivatedEventHandler.CallbackType _callback;

		public CoreWebView2PrivateRemoteObjectProxyPassivatedEventHandler(CoreWebView2PrivateRemoteObjectProxyPassivatedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2PrivateRemoteObjectProxy source, Object args)
		{
			this._callback(EventArgs.Empty);
		}

		public delegate void CallbackType(EventArgs args);
	}
}