using System;

namespace Microsoft.Web.WebView2.Core
{
	internal struct Variant
	{
		public UInt16 vt;

		public UInt16 wReserved1;

		public UInt16 wReserved2;

		public UInt16 wReserved3;

		public IntPtr pVal;

		public IntPtr pRecInfo;
	}
}