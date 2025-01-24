using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2ServerCertificateErrorDetectedEventHandler : ICoreWebView2ServerCertificateErrorDetectedEventHandler
	{
		private CoreWebView2ServerCertificateErrorDetectedEventHandler.CallbackType _callback;

		public CoreWebView2ServerCertificateErrorDetectedEventHandler(CoreWebView2ServerCertificateErrorDetectedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2 source, ICoreWebView2ServerCertificateErrorDetectedEventArgs args)
		{
			this._callback(new CoreWebView2ServerCertificateErrorDetectedEventArgs(args));
		}

		public delegate void CallbackType(CoreWebView2ServerCertificateErrorDetectedEventArgs args);
	}
}