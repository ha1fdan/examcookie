using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public enum CoreWebView2ProcessFailedKind
	{
		BrowserProcessExited,
		RenderProcessExited,
		RenderProcessUnresponsive,
		FrameRenderProcessExited,
		UtilityProcessExited,
		SandboxHelperProcessExited,
		GpuProcessExited,
		PpapiPluginProcessExited,
		PpapiBrokerProcessExited,
		UnknownProcessExited
	}
}