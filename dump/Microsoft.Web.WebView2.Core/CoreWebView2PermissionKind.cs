using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public enum CoreWebView2PermissionKind
	{
		UnknownPermission,
		Microphone,
		Camera,
		Geolocation,
		Notifications,
		OtherSensors,
		ClipboardRead,
		MultipleAutomaticDownloads,
		FileReadWrite,
		Autoplay,
		LocalFonts,
		MidiSystemExclusiveMessages,
		WindowManagement
	}
}