using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler : ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler, INotifyCompletion
	{
		private Action continuation;

		public CoreWebView2Environment createdEnvironment
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

		public CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler()
		{
			this.IsCompleted = false;
		}

		public CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler GetAwaiter()
		{
			return this;
		}

		public CoreWebView2Environment GetResult()
		{
			return this.createdEnvironment;
		}

		public Void Invoke(Int32 errCode, ICoreWebView2Environment createdEnvironment)
		{
			this.createdEnvironment = new CoreWebView2Environment(createdEnvironment);
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