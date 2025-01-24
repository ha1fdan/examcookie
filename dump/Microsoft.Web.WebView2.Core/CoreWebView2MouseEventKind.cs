using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public enum CoreWebView2MouseEventKind
	{
		NonClientRightButtonDown = 164,
		NonClientRightButtonUp = 165,
		Move = 512,
		LeftButtonDown = 513,
		LeftButtonUp = 514,
		LeftButtonDoubleClick = 515,
		RightButtonDown = 516,
		RightButtonUp = 517,
		RightButtonDoubleClick = 518,
		MiddleButtonDown = 519,
		MiddleButtonUp = 520,
		MiddleButtonDoubleClick = 521,
		Wheel = 522,
		XButtonDown = 523,
		XButtonUp = 524,
		XButtonDoubleClick = 525,
		HorizontalWheel = 526,
		Leave = 675
	}
}