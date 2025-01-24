using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler : ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler, INotifyCompletion
	{
		private Action continuation;

		public Int32 errCode
		{
			get;
			private set;
		}

		public String id
		{
			get;
			private set;
		}

		public Boolean IsCompleted
		{
			get;
			private set;
		}

		public CoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler()
		{
			this.IsCompleted = false;
		}

		public CoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler GetAwaiter()
		{
			return this;
		}

		public String GetResult()
		{
			return this.id;
		}

		public Void Invoke(Int32 errCode, String id)
		{
			this.id = id;
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