using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public enum CoreWebView2WebResourceContext
	{
		All,
		Document,
		Stylesheet,
		Image,
		Media,
		Font,
		Script,
		XmlHttpRequest,
		Fetch,
		TextTrack,
		EventSource,
		Websocket,
		Manifest,
		SignedExchange,
		Ping,
		CspViolationReport,
		Other
	}
}