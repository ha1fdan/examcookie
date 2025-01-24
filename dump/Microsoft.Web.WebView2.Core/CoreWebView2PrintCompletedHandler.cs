using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2PrintCompletedHandler : ICoreWebView2PrintCompletedHandler, INotifyCompletion
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

		public CoreWebView2PrintStatus printStatus
		{
			get;
			private set;
		}

		public CoreWebView2PrintCompletedHandler()
		{
			this.IsCompleted = false;
		}

		public CoreWebView2PrintCompletedHandler GetAwaiter()
		{
			return this;
		}

		public CoreWebView2PrintStatus GetResult()
		{
			return this.printStatus;
		}

		public Void Invoke(Int32 errCode, COREWEBVIEW2_PRINT_STATUS printStatus)
		{
			this.printStatus = (CoreWebView2PrintStatus)printStatus;
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