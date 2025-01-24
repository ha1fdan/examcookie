using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ClassInterface(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
	[ComVisible(true)]
	public class HostObjectHelper
	{
		private CoreWebView2PrivateHostObjectHelper _helper = new CoreWebView2PrivateHostObjectHelper();

		public HostObjectHelper()
		{
		}

		public Boolean IsMethod(Object obj, String name)
		{
			return this._helper.IsMethodMember(obj, name) != 0;
		}
	}
}