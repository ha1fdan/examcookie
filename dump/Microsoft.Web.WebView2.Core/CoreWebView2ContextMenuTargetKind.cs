using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public enum CoreWebView2ContextMenuTargetKind
	{
		Page,
		Image,
		SelectedText,
		Audio,
		Video
	}
}