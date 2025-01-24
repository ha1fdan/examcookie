using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2ClientCertificateRequestedEventHandler : ICoreWebView2ClientCertificateRequestedEventHandler
	{
		private CoreWebView2ClientCertificateRequestedEventHandler.CallbackType _callback;

		public CoreWebView2ClientCertificateRequestedEventHandler(CoreWebView2ClientCertificateRequestedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public Void Invoke(ICoreWebView2 source, ICoreWebView2ClientCertificateRequestedEventArgs args)
		{
			this._callback(new CoreWebView2ClientCertificateRequestedEventArgs(args));
		}

		public delegate Void CallbackType(CoreWebView2ClientCertificateRequestedEventArgs args);
	}
}