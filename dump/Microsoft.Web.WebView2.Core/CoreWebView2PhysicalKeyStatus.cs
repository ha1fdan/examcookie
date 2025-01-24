using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public struct CoreWebView2PhysicalKeyStatus
	{
		public UInt32 RepeatCount;

		public UInt32 ScanCode;

		public Int32 IsExtendedKey;

		public Int32 IsMenuKeyDown;

		public Int32 WasKeyDown;

		public Int32 IsKeyReleased;

		internal CoreWebView2PhysicalKeyStatus(COREWEBVIEW2_PHYSICAL_KEY_STATUS rawStruct)
		{
			this.RepeatCount = rawStruct.RepeatCount;
			this.ScanCode = rawStruct.ScanCode;
			this.IsExtendedKey = rawStruct.IsExtendedKey;
			this.IsMenuKeyDown = rawStruct.IsMenuKeyDown;
			this.WasKeyDown = rawStruct.WasKeyDown;
			this.IsKeyReleased = rawStruct.IsKeyReleased;
		}
	}
}