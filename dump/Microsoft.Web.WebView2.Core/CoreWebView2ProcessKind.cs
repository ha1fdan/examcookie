using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public enum CoreWebView2ProcessKind
	{
		Browser,
		Renderer,
		Utility,
		SandboxHelper,
		Gpu,
		PpapiPlugin,
		PpapiBroker
	}
}