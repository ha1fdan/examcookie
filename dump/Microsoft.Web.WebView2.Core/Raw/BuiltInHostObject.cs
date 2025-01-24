using Microsoft.Web.WebView2.Core;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	[ClassInterface(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
	[ComVisible(true)]
	public class BuiltInHostObject
	{
		private Object _originalHostObject;

		private Microsoft.Web.WebView2.Core.EventConnector _eventConnector;

		private Microsoft.Web.WebView2.Core.EventConnector EventConnector
		{
			get
			{
				if (this._eventConnector == null)
				{
					this._eventConnector = new Microsoft.Web.WebView2.Core.EventConnector(this._originalHostObject);
				}
				return this._eventConnector;
			}
		}

		public BuiltInHostObject(Object originalHostObject)
		{
			this._originalHostObject = originalHostObject;
		}

		public Void addEventListener(String eventName, Object JSHandler)
		{
			this.EventConnector.addEventListener(eventName, JSHandler);
		}

		public Void removeEventListener(String eventName, Object JSHandler)
		{
			this.EventConnector.removeEventListener(eventName, JSHandler);
		}
	}
}