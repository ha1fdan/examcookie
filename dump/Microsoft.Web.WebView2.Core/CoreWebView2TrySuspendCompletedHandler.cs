using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2TrySuspendCompletedHandler : ICoreWebView2TrySuspendCompletedHandler, INotifyCompletion
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

		public Boolean isSuccessful
		{
			get;
			private set;
		}

		public CoreWebView2TrySuspendCompletedHandler()
		{
			this.IsCompleted = false;
		}

		public CoreWebView2TrySuspendCompletedHandler GetAwaiter()
		{
			return this;
		}

		public Boolean GetResult()
		{
			return this.isSuccessful;
		}

		public Void Invoke(Int32 errCode, Int32 isSuccessful)
		{
			this.isSuccessful = (isSuccessful == 0 ? false : true);
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