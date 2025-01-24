using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public enum CoreWebView2ServerCertificateErrorAction
	{
		AlwaysAllow,
		Cancel,
		Default
	}
}