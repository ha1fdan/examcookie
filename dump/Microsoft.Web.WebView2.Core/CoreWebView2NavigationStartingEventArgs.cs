using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2NavigationStartingEventArgs : EventArgs
	{
		internal ICoreWebView2NavigationStartingEventArgs _nativeICoreWebView2NavigationStartingEventArgsValue;

		internal ICoreWebView2NavigationStartingEventArgs2 _nativeICoreWebView2NavigationStartingEventArgs2Value;

		internal ICoreWebView2NavigationStartingEventArgs3 _nativeICoreWebView2NavigationStartingEventArgs3Value;

		internal Object _rawNative;

		internal ICoreWebView2NavigationStartingEventArgs _nativeICoreWebView2NavigationStartingEventArgs
		{
			get
			{
				if (this._nativeICoreWebView2NavigationStartingEventArgsValue == null)
				{
					try
					{
						this._nativeICoreWebView2NavigationStartingEventArgsValue = (ICoreWebView2NavigationStartingEventArgs)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationStartingEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2NavigationStartingEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2NavigationStartingEventArgsValue = value;
			}
		}

		internal ICoreWebView2NavigationStartingEventArgs2 _nativeICoreWebView2NavigationStartingEventArgs2
		{
			get
			{
				if (this._nativeICoreWebView2NavigationStartingEventArgs2Value == null)
				{
					try
					{
						this._nativeICoreWebView2NavigationStartingEventArgs2Value = (ICoreWebView2NavigationStartingEventArgs2)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationStartingEventArgs2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2NavigationStartingEventArgs2Value;
			}
			set
			{
				this._nativeICoreWebView2NavigationStartingEventArgs2Value = value;
			}
		}

		internal ICoreWebView2NavigationStartingEventArgs3 _nativeICoreWebView2NavigationStartingEventArgs3
		{
			get
			{
				if (this._nativeICoreWebView2NavigationStartingEventArgs3Value == null)
				{
					try
					{
						this._nativeICoreWebView2NavigationStartingEventArgs3Value = (ICoreWebView2NavigationStartingEventArgs3)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationStartingEventArgs3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2NavigationStartingEventArgs3Value;
			}
			set
			{
				this._nativeICoreWebView2NavigationStartingEventArgs3Value = value;
			}
		}

		public String AdditionalAllowedFrameAncestors
		{
			get
			{
				String additionalAllowedFrameAncestors;
				try
				{
					additionalAllowedFrameAncestors = this._nativeICoreWebView2NavigationStartingEventArgs2.AdditionalAllowedFrameAncestors;
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
				return additionalAllowedFrameAncestors;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2NavigationStartingEventArgs2.AdditionalAllowedFrameAncestors = value;
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
			}
		}

		public Boolean Cancel
		{
			get
			{
				Boolean cancel;
				try
				{
					cancel = this._nativeICoreWebView2NavigationStartingEventArgs.Cancel != 0;
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
				return cancel;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2NavigationStartingEventArgs.Cancel = (value ? 1 : 0);
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
			}
		}

		public Boolean IsRedirected
		{
			get
			{
				Boolean isRedirected;
				try
				{
					isRedirected = this._nativeICoreWebView2NavigationStartingEventArgs.IsRedirected != 0;
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
				return isRedirected;
			}
		}

		public Boolean IsUserInitiated
		{
			get
			{
				Boolean isUserInitiated;
				try
				{
					isUserInitiated = this._nativeICoreWebView2NavigationStartingEventArgs.IsUserInitiated != 0;
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
				return isUserInitiated;
			}
		}

		public UInt64 NavigationId
		{
			get
			{
				UInt64 navigationId;
				try
				{
					navigationId = this._nativeICoreWebView2NavigationStartingEventArgs.NavigationId;
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

		public CoreWebView2NavigationKind NavigationKind
		{
			get
			{
				CoreWebView2NavigationKind navigationKind;
				try
				{
					navigationKind = (CoreWebView2NavigationKind)this._nativeICoreWebView2NavigationStartingEventArgs3.NavigationKind;
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
				return navigationKind;
			}
		}

		public CoreWebView2HttpRequestHeaders RequestHeaders
		{
			get
			{
				CoreWebView2HttpRequestHeaders coreWebView2HttpRequestHeaders;
				CoreWebView2HttpRequestHeaders coreWebView2HttpRequestHeaders1;
				try
				{
					if (this._nativeICoreWebView2NavigationStartingEventArgs.RequestHeaders == null)
					{
						coreWebView2HttpRequestHeaders1 = null;
					}
					else
					{
						coreWebView2HttpRequestHeaders1 = new CoreWebView2HttpRequestHeaders(this._nativeICoreWebView2NavigationStartingEventArgs.RequestHeaders);
					}
					coreWebView2HttpRequestHeaders = coreWebView2HttpRequestHeaders1;
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
				return coreWebView2HttpRequestHeaders;
			}
		}

		public String Uri
		{
			get
			{
				String uri;
				try
				{
					uri = this._nativeICoreWebView2NavigationStartingEventArgs.Uri;
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
				return uri;
			}
		}

		internal CoreWebView2NavigationStartingEventArgs(Object rawCoreWebView2NavigationStartingEventArgs)
		{
			this._rawNative = rawCoreWebView2NavigationStartingEventArgs;
		}
	}
}