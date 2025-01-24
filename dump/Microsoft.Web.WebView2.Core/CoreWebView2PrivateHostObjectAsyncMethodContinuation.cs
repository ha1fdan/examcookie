using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2PrivateHostObjectAsyncMethodContinuation
	{
		internal ICoreWebView2PrivateHostObjectAsyncMethodContinuation _nativeICoreWebView2PrivateHostObjectAsyncMethodContinuationValue;

		internal Object _rawNative;

		internal ICoreWebView2PrivateHostObjectAsyncMethodContinuation _nativeICoreWebView2PrivateHostObjectAsyncMethodContinuation
		{
			get
			{
				if (this._nativeICoreWebView2PrivateHostObjectAsyncMethodContinuationValue == null)
				{
					try
					{
						this._nativeICoreWebView2PrivateHostObjectAsyncMethodContinuationValue = (ICoreWebView2PrivateHostObjectAsyncMethodContinuation)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivateHostObjectAsyncMethodContinuation.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2PrivateHostObjectAsyncMethodContinuationValue;
			}
			set
			{
				this._nativeICoreWebView2PrivateHostObjectAsyncMethodContinuationValue = value;
			}
		}

		internal CoreWebView2PrivateHostObjectAsyncMethodContinuation(Object rawCoreWebView2PrivateHostObjectAsyncMethodContinuation)
		{
			this._rawNative = rawCoreWebView2PrivateHostObjectAsyncMethodContinuation;
		}

		internal Void Invoke(Int32 errorCode, Object result)
		{
			try
			{
				Object obj = result;
				this._nativeICoreWebView2PrivateHostObjectAsyncMethodContinuation.Invoke(errorCode, ref obj);
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
}