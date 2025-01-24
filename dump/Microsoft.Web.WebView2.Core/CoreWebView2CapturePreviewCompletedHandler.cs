using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2CapturePreviewCompletedHandler : ICoreWebView2CapturePreviewCompletedHandler, INotifyCompletion
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

		public CoreWebView2CapturePreviewCompletedHandler()
		{
			this.IsCompleted = false;
		}

		public CoreWebView2CapturePreviewCompletedHandler GetAwaiter()
		{
			return this;
		}

		public Void GetResult()
		{
		}

		public Void Invoke(Int32 errCode)
		{
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