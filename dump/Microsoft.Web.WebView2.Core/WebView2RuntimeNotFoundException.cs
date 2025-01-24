using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	[Serializable]
	public class WebView2RuntimeNotFoundException : Exception
	{
		public WebView2RuntimeNotFoundException() : this((Exception)null)
		{
		}

		public WebView2RuntimeNotFoundException(String message) : base(message)
		{
		}

		public WebView2RuntimeNotFoundException(Exception inner) : base("Couldn't find a compatible Webview2 Runtime installation to host WebViews.", inner)
		{
		}

		public WebView2RuntimeNotFoundException(String message, Exception inner) : base(message, inner)
		{
		}
	}
}