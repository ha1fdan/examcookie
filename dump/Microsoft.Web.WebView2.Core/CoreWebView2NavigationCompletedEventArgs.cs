using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2NavigationCompletedEventArgs : EventArgs
	{
		internal ICoreWebView2NavigationCompletedEventArgs _nativeICoreWebView2NavigationCompletedEventArgsValue;

		internal ICoreWebView2NavigationCompletedEventArgs2 _nativeICoreWebView2NavigationCompletedEventArgs2Value;

		internal Object _rawNative;

		internal ICoreWebView2NavigationCompletedEventArgs _nativeICoreWebView2NavigationCompletedEventArgs
		{
			get
			{
				if (this._nativeICoreWebView2NavigationCompletedEventArgsValue == null)
				{
					try
					{
						this._nativeICoreWebView2NavigationCompletedEventArgsValue = (ICoreWebView2NavigationCompletedEventArgs)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationCompletedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2NavigationCompletedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2NavigationCompletedEventArgsValue = value;
			}
		}

		internal ICoreWebView2NavigationCompletedEventArgs2 _nativeICoreWebView2NavigationCompletedEventArgs2
		{
			get
			{
				if (this._nativeICoreWebView2NavigationCompletedEventArgs2Value == null)
				{
					try
					{
						this._nativeICoreWebView2NavigationCompletedEventArgs2Value = (ICoreWebView2NavigationCompletedEventArgs2)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationCompletedEventArgs2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2NavigationCompletedEventArgs2Value;
			}
			set
			{
				this._nativeICoreWebView2NavigationCompletedEventArgs2Value = value;
			}
		}

		public Int32 HttpStatusCode
		{
			get
			{
				Int32 httpStatusCode;
				try
				{
					httpStatusCode = this._nativeICoreWebView2NavigationCompletedEventArgs2.HttpStatusCode;
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
				return httpStatusCode;
			}
		}

		public Boolean IsSuccess
		{
			get
			{
				Boolean isSuccess;
				try
				{
					isSuccess = this._nativeICoreWebView2NavigationCompletedEventArgs.IsSuccess != 0;
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
				return isSuccess;
			}
		}

		public UInt64 NavigationId
		{
			get
			{
				UInt64 navigationId;
				try
				{
					navigationId = this._nativeICoreWebView2NavigationCompletedEventArgs.NavigationId;
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
				return navigationId;
			}
		}

		public CoreWebView2WebErrorStatus WebErrorStatus
		{
			get
			{
				CoreWebView2WebErrorStatus webErrorStatus;
				try
				{
					webErrorStatus = (CoreWebView2WebErrorStatus)this._nativeICoreWebView2NavigationCompletedEventArgs.WebErrorStatus;
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
				return webErrorStatus;
			}
		}

		internal CoreWebView2NavigationCompletedEventArgs(Object rawCoreWebView2NavigationCompletedEventArgs)
		{
			this._rawNative = rawCoreWebView2NavigationCompletedEventArgs;
		}
	}
}