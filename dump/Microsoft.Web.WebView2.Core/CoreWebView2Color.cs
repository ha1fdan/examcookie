using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public struct CoreWebView2Color
	{
		public Byte A;

		public Byte R;

		public Byte G;

		public Byte B;

		internal CoreWebView2Color(COREWEBVIEW2_COLOR rawStruct)
		{
			this.A = rawStruct.A;
			this.R = rawStruct.R;
			this.G = rawStruct.G;
			this.B = rawStruct.B;
		}
	}
}