using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2CreateCoreWebView2ControllerCompletedHandler : ICoreWebView2CreateCoreWebView2ControllerCompletedHandler, INotifyCompletion
	{
		private Action continuation;

		public CoreWebView2Controller createdController
		{
			get;
			private set;
		}

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

		public CoreWebView2CreateCoreWebView2ControllerCompletedHandler()
		{
			this.IsCompleted = false;
		}

		public CoreWebView2CreateCoreWebView2ControllerCompletedHandler GetAwaiter()
		{
			return this;
		}

		public CoreWebView2Controller GetResult()
		{
			return this.createdController;
		}

		public Void Invoke(Int32 errCode, ICoreWebView2Controller createdController)
		{
			this.createdController = new CoreWebView2Controller(createdController);
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