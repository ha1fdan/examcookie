using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2WebResourceResponseViewGetContentCompletedHandler : ICoreWebView2WebResourceResponseViewGetContentCompletedHandler, INotifyCompletion
	{
		private Action continuation;

		public Stream Content
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

		public CoreWebView2WebResourceResponseViewGetContentCompletedHandler()
		{
			this.IsCompleted = false;
		}

		public CoreWebView2WebResourceResponseViewGetContentCompletedHandler GetAwaiter()
		{
			return this;
		}

		public Stream GetResult()
		{
			return this.Content;
		}

		public Void Invoke(Int32 errCode, IStream Content)
		{
			this.Content = COMDotNetTypeConverter.StreamCOMToNet(Content);
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