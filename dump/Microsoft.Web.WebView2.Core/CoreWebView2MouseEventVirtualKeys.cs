using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	[Flags]
	public enum CoreWebView2MouseEventVirtualKeys
	{
		None = 0,
		LeftButton = 1,
		RightButton = 2,
		Shift = 4,
		Control = 8,
		MiddleButton = 16,
		XButton1 = 32,
		XButton2 = 64
	}
}