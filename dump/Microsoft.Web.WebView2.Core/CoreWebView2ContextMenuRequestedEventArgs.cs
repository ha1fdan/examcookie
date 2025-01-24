using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2ContextMenuRequestedEventArgs : EventArgs
	{
		internal ICoreWebView2ContextMenuRequestedEventArgs _nativeICoreWebView2ContextMenuRequestedEventArgsValue;

		internal Object _rawNative;

		internal ICoreWebView2ContextMenuRequestedEventArgs _nativeICoreWebView2ContextMenuRequestedEventArgs
		{
			get
			{
				if (this._nativeICoreWebView2ContextMenuRequestedEventArgsValue == null)
				{
					try
					{
						this._nativeICoreWebView2ContextMenuRequestedEventArgsValue = (ICoreWebView2ContextMenuRequestedEventArgs)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ContextMenuRequestedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2ContextMenuRequestedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2ContextMenuRequestedEventArgsValue = value;
			}
		}

		public CoreWebView2ContextMenuTarget ContextMenuTarget
		{
			get
			{
				CoreWebView2ContextMenuTarget coreWebView2ContextMenuTarget;
				CoreWebView2ContextMenuTarget coreWebView2ContextMenuTarget1;
				try
				{
					if (this._nativeICoreWebView2ContextMenuRequestedEventArgs.ContextMenuTarget == null)
					{
						coreWebView2ContextMenuTarget1 = null;
					}
					else
					{
						coreWebView2ContextMenuTarget1 = new CoreWebView2ContextMenuTarget(this._nativeICoreWebView2ContextMenuRequestedEventArgs.ContextMenuTarget);
					}
					coreWebView2ContextMenuTarget = coreWebView2ContextMenuTarget1;
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
				return coreWebView2ContextMenuTarget;
			}
		}

		public Boolean Handled
		{
			get
			{
				Boolean handled;
				try
				{
					handled = this._nativeICoreWebView2ContextMenuRequestedEventArgs.Handled != 0;
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
				return handled;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2ContextMenuRequestedEventArgs.Handled = (value ? 1 : 0);
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

		public Point Location
		{
			get
			{
				Point net;
				try
				{
					net = COMDotNetTypeConverter.PointCOMToNet(this._nativeICoreWebView2ContextMenuRequestedEventArgs.Location);
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

		public IList<CoreWebView2ContextMenuItem> MenuItems
		{
			get
			{
				IList<CoreWebView2ContextMenuItem> net;
				try
				{
					net = COMDotNetTypeConverter.CoreWebView2ContextMenuItemCollectionCOMToNet(this._nativeICoreWebView2ContextMenuRequestedEventArgs.MenuItems);
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

		public Int32 SelectedCommandId
		{
			get
			{
				Int32 selectedCommandId;
				try
				{
					selectedCommandId = this._nativeICoreWebView2ContextMenuRequestedEventArgs.SelectedCommandId;
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
				return selectedCommandId;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2ContextMenuRequestedEventArgs.SelectedCommandId = value;
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

		internal CoreWebView2ContextMenuRequestedEventArgs(Object rawCoreWebView2ContextMenuRequestedEventArgs)
		{
			this._rawNative = rawCoreWebView2ContextMenuRequestedEventArgs;
		}

		public CoreWebView2Deferral GetDeferral()
		{
			CoreWebView2Deferral coreWebView2Deferral;
			try
			{
				coreWebView2Deferral = new CoreWebView2Deferral(this._nativeICoreWebView2ContextMenuRequestedEventArgs.GetDeferral());
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
			return coreWebView2Deferral;
		}
	}
}