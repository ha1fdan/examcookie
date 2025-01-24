using Microsoft.Web.WebView2.Core.Raw;
using System;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2ScriptDialogOpeningEventHandler : ICoreWebView2ScriptDialogOpeningEventHandler
	{
		private CoreWebView2ScriptDialogOpeningEventHandler.CallbackType _callback;

		public CoreWebView2ScriptDialogOpeningEventHandler(CoreWebView2ScriptDialogOpeningEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		public void Invoke(ICoreWebView2 source, ICoreWebView2ScriptDialogOpeningEventArgs args)
		{
			this._callback(new CoreWebView2ScriptDialogOpeningEventArgs(args));
		}

		public delegate void CallbackType(CoreWebView2ScriptDialogOpeningEventArgs args);
	}
}