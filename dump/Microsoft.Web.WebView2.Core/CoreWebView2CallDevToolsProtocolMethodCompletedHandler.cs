using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2CallDevToolsProtocolMethodCompletedHandler : ICoreWebView2CallDevToolsProtocolMethodCompletedHandler, INotifyCompletion
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

		public String returnObjectAsJson
		{
			get;
			private set;
		}

		public CoreWebView2CallDevToolsProtocolMethodCompletedHandler()
		{
			this.IsCompleted = false;
		}

		public CoreWebView2CallDevToolsProtocolMethodCompletedHandler GetAwaiter()
		{
			return this;
		}

		public String GetResult()
		{
			return this.returnObjectAsJson;
		}

		public Void Invoke(Int32 errCode, String returnObjectAsJson)
		{
			this.returnObjectAsJson = returnObjectAsJson;
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