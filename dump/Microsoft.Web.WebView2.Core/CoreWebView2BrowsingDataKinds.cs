using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	[Flags]
	public enum CoreWebView2BrowsingDataKinds
	{
		FileSystems = 1,
		IndexedDb = 2,
		LocalStorage = 4,
		WebSql = 8,
		CacheStorage = 16,
		AllDomStorage = 32,
		Cookies = 64,
		AllSite = 128,
		DiskCache = 256,
		DownloadHistory = 512,
		GeneralAutofill = 1024,
		PasswordAutosave = 2048,
		BrowsingHistory = 4096,
		Settings = 8192,
		AllProfile = 16384,
		ServiceWorkers = 32768
	}
}