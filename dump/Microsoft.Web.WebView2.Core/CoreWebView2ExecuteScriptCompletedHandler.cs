using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2ExecuteScriptCompletedHandler : ICoreWebView2ExecuteScriptCompletedHandler, INotifyCompletion
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

		public String resultObjectAsJson
		{
			get;
			private set;
		}

		public CoreWebView2ExecuteScriptCompletedHandler()
		{
			this.IsCompleted = false;
		}

		public CoreWebView2ExecuteScriptCompletedHandler GetAwaiter()
		{
			return this;
		}

		public String GetResult()
		{
			return this.resultObjectAsJson;
		}

		public Void Invoke(Int32 errCode, String resultObjectAsJson)
		{
			this.resultObjectAsJson = resultObjectAsJson;
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