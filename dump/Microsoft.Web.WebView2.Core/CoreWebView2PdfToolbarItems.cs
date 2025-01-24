using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	[Flags]
	public enum CoreWebView2PdfToolbarItems
	{
		None = 0,
		Save = 1,
		Print = 2,
		SaveAs = 4,
		ZoomIn = 8,
		ZoomOut = 16,
		Rotate = 32,
		FitPage = 64,
		PageLayout = 128,
		Bookmarks = 256,
		PageSelector = 512,
		Search = 1024,
		FullScreen = 2048,
		MoreSettings = 4096
	}
}