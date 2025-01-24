using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler : ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler, INotifyCompletion
	{
		private Action continuation;

		public Int32 errCode
		{
			get;
			private set;
		}

		public Boolean IsCompleted
		{
			get;
			private set;
		}

		public CoreWebView2CompositionController webView
		{
			get;
			private set;
		}

		public CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler()
		{
			this.IsCompleted = false;
		}

		public CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler GetAwaiter()
		{
			return this;
		}

		public CoreWebView2CompositionController GetResult()
		{
			return this.webView;
		}

		public Void Invoke(Int32 errCode, ICoreWebView2CompositionController webView)
		{
			this.webView = new CoreWebView2CompositionController(webView);
			this.errCode = errCode;
			this.IsCompleted = true;
			if (this.continuation != null)
			{
				this.continuation.Invoke();
			}
		}

		public Void OnCompleted(Action continuation)
		{
			this.continuation = continuation;
			if (this.IsCompleted)
			{
				continuation.Invoke();
			}
		}
	}
}