using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2WebMessageReceivedEventArgs : EventArgs
	{
		internal ICoreWebView2WebMessageReceivedEventArgs _nativeICoreWebView2WebMessageReceivedEventArgsValue;

		internal ICoreWebView2WebMessageReceivedEventArgs2 _nativeICoreWebView2WebMessageReceivedEventArgs2Value;

		internal Object _rawNative;

		internal ICoreWebView2WebMessageReceivedEventArgs _nativeICoreWebView2WebMessageReceivedEventArgs
		{
			get
			{
				if (this._nativeICoreWebView2WebMessageReceivedEventArgsValue == null)
				{
					try
					{
						this._nativeICoreWebView2WebMessageReceivedEventArgsValue = (ICoreWebView2WebMessageReceivedEventArgs)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebMessageReceivedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2WebMessageReceivedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2WebMessageReceivedEventArgsValue = value;
			}
		}

		internal ICoreWebView2WebMessageReceivedEventArgs2 _nativeICoreWebView2WebMessageReceivedEventArgs2
		{
			get
			{
				if (this._nativeICoreWebView2WebMessageReceivedEventArgs2Value == null)
				{
					try
					{
						this._nativeICoreWebView2WebMessageReceivedEventArgs2Value = (ICoreWebView2WebMessageReceivedEventArgs2)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebMessageReceivedEventArgs2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2WebMessageReceivedEventArgs2Value;
			}
			set
			{
				this._nativeICoreWebView2WebMessageReceivedEventArgs2Value = value;
			}
		}

		public IReadOnlyList<Object> AdditionalObjects
		{
			get
			{
				IReadOnlyList<Object> net;
				try
				{
					net = COMDotNetTypeConverter.CoreWebView2ObjectCollectionViewCOMToNet(this._nativeICoreWebView2WebMessageReceivedEventArgs2.AdditionalObjects);
				}
				catch (InvalidCastException invalidCastException1)
				{
					InvalidCastException invalidCastException = invalidCastException1;
					if (invalidCastException.get_HResult() != -2147467262)
					{
						throw invalidCastException;
					}
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", invalidCastException);
				}
				catch (COMException cOMException1)
				{
					COMException cOMException = cOMException1;
					if (cOMException.get_HResult() != -2147019873)
					{
						throw cOMException;
					}
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", cOMException);
				}
				return net;
			}
		}

		public String Source
		{
			get
			{
				String source;
				try
				{
					source = this._nativeICoreWebView2WebMessageReceivedEventArgs.Source;
				}
				catch (InvalidCastException invalidCastException1)
				{
					InvalidCastException invalidCastException = invalidCastException1;
					if (invalidCastException.get_HResult() != -2147467262)
					{
						throw invalidCastException;
					}
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", invalidCastException);
				}
				catch (COMException cOMException1)
				{
					COMException cOMException = cOMException1;
					if (cOMException.get_HResult() != -2147019873)
					{
						throw cOMException;
					}
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", cOMException);
				}
				return source;
			}
		}

		public String WebMessageAsJson
		{
			get
			{
				String webMessageAsJson;
				try
				{
					webMessageAsJson = this._nativeICoreWebView2WebMessageReceivedEventArgs.WebMessageAsJson;
				}
				catch (InvalidCastException invalidCastException1)
				{
					InvalidCastException invalidCastException = invalidCastException1;
					if (invalidCastException.get_HResult() != -2147467262)
					{
						throw invalidCastException;
					}
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", invalidCastException);
				}
				catch (COMException cOMException1)
				{
					COMException cOMException = cOMException1;
					if (cOMException.get_HResult() != -2147019873)
					{
						throw cOMException;
					}
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", cOMException);
				}
				return webMessageAsJson;
			}
		}

		internal CoreWebView2WebMessageReceivedEventArgs(Object rawCoreWebView2WebMessageReceivedEventArgs)
		{
			this._rawNative = rawCoreWebView2WebMessageReceivedEventArgs;
		}

		public String TryGetWebMessageAsString()
		{
			String str;
			try
			{
				str = this._nativeICoreWebView2WebMessageReceivedEventArgs.TryGetWebMessageAsString();
			}
			catch (InvalidCastException invalidCastException1)
			{
				InvalidCastException invalidCastException = invalidCastException1;
				if (invalidCastException.get_HResult() != -2147467262)
				{
					throw invalidCastException;
				}
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", invalidCastException);
			}
			catch (COMException cOMException1)
			{
				COMException cOMException = cOMException1;
				if (cOMException.get_HResult() != -2147019873)
				{
					throw cOMException;
				}
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", cOMException);
			}
			return str;
		}
	}
}