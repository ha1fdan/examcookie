using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2BrowserProcessExitedEventHandler : ICoreWebView2BrowserProcessExitedEventHandler
	{
		private CoreWebView2BrowserProcessExitedEventHandler.CallbackType _callback;

		public CoreWebView2BrowserProcessExitedEventHandler(CoreWebView2BrowserProcessExitedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public Void Invoke(ICoreWebView2Environment source, ICoreWebView2BrowserProcessExitedEventArgs args)
		{
			this._callback(new CoreWebView2BrowserProcessExitedEventArgs(args));
		}

		public delegate Void CallbackType(CoreWebView2BrowserProcessExitedEventArgs args);
	}
}