using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2ProcessFailedEventArgs : EventArgs
	{
		internal ICoreWebView2ProcessFailedEventArgs _nativeICoreWebView2ProcessFailedEventArgsValue;

		internal ICoreWebView2ProcessFailedEventArgs2 _nativeICoreWebView2ProcessFailedEventArgs2Value;

		internal Object _rawNative;

		internal ICoreWebView2ProcessFailedEventArgs _nativeICoreWebView2ProcessFailedEventArgs
		{
			get
			{
				if (this._nativeICoreWebView2ProcessFailedEventArgsValue == null)
				{
					try
					{
						this._nativeICoreWebView2ProcessFailedEventArgsValue = (ICoreWebView2ProcessFailedEventArgs)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ProcessFailedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2ProcessFailedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2ProcessFailedEventArgsValue = value;
			}
		}

		internal ICoreWebView2ProcessFailedEventArgs2 _nativeICoreWebView2ProcessFailedEventArgs2
		{
			get
			{
				if (this._nativeICoreWebView2ProcessFailedEventArgs2Value == null)
				{
					try
					{
						this._nativeICoreWebView2ProcessFailedEventArgs2Value = (ICoreWebView2ProcessFailedEventArgs2)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ProcessFailedEventArgs2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2ProcessFailedEventArgs2Value;
			}
			set
			{
				this._nativeICoreWebView2ProcessFailedEventArgs2Value = value;
			}
		}

		public Int32 ExitCode
		{
			get
			{
				Int32 exitCode;
				try
				{
					exitCode = this._nativeICoreWebView2ProcessFailedEventArgs2.ExitCode;
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
				return exitCode;
			}
		}

		public IReadOnlyList<CoreWebView2FrameInfo> FrameInfosForFailedProcess
		{
			get
			{
				IReadOnlyList<CoreWebView2FrameInfo> net;
				try
				{
					net = COMDotNetTypeConverter.CoreWebView2FrameInfoCollectionCOMToNet(this._nativeICoreWebView2ProcessFailedEventArgs2.FrameInfosForFailedProcess);
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

		public String ProcessDescription
		{
			get
			{
				String processDescription;
				try
				{
					processDescription = this._nativeICoreWebView2ProcessFailedEventArgs2.ProcessDescription;
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
				return processDescription;
			}
		}

		public CoreWebView2ProcessFailedKind ProcessFailedKind
		{
			get
			{
				CoreWebView2ProcessFailedKind processFailedKind;
				try
				{
					processFailedKind = (CoreWebView2ProcessFailedKind)this._nativeICoreWebView2ProcessFailedEventArgs.ProcessFailedKind;
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
				return processFailedKind;
			}
		}

		public CoreWebView2ProcessFailedReason Reason
		{
			get
			{
				CoreWebView2ProcessFailedReason reason;
				try
				{
					reason = (CoreWebView2ProcessFailedReason)this._nativeICoreWebView2ProcessFailedEventArgs2.Reason;
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
				return reason;
			}
		}

		internal CoreWebView2ProcessFailedEventArgs(Object rawCoreWebView2ProcessFailedEventArgs)
		{
			this._rawNative = rawCoreWebView2ProcessFailedEventArgs;
		}
	}
}