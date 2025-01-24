using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2GetFaviconCompletedHandler : ICoreWebView2GetFaviconCompletedHandler, INotifyCompletion
	{
		private Action continuation;

		public Int32 errCode
		{
			get;
			private set;
		}

		public Stream faviconStream
		{
			get;
			private set;
		}

		public Boolean IsCompleted
		{
			get;
			private set;
		}

		public CoreWebView2GetFaviconCompletedHandler()
		{
			this.IsCompleted = false;
		}

		public CoreWebView2GetFaviconCompletedHandler GetAwaiter()
		{
			return this;
		}

		public Stream GetResult()
		{
			return this.faviconStream;
		}

		public Void Invoke(Int32 errCode, IStream faviconStream)
		{
			this.faviconStream = COMDotNetTypeConverter.StreamCOMToNet(faviconStream);
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