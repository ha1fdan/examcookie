using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public enum CoreWebView2PrintStatus
	{
		Succeeded,
		PrinterUnavailable,
		OtherError
	}
}