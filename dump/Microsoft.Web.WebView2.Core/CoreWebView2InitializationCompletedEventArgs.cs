using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2InitializationCompletedEventArgs : EventArgs
	{
		public Exception InitializationException
		{
			get;
			private set;
		}

		public Boolean IsSuccess
		{
			get
			{
				return this.InitializationException == null;
			}
		}

		public CoreWebView2InitializationCompletedEventArgs(Exception ex = null)
		{
			this.InitializationException = ex;
		}
	}
}