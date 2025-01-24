using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2Frame
	{
		internal ICoreWebView2Frame _nativeICoreWebView2FrameValue;

		internal ICoreWebView2Frame2 _nativeICoreWebView2Frame2Value;

		internal ICoreWebView2Frame3 _nativeICoreWebView2Frame3Value;

		internal ICoreWebView2Frame4 _nativeICoreWebView2Frame4Value;

		internal Object _rawNative;

		private EventRegistrationToken _nameChangedToken;

		private EventHandler<Object> nameChanged;

		private EventRegistrationToken _destroyedToken;

		private EventHandler<Object> destroyed;

		private EventRegistrationToken _navigationStartingToken;

		private EventHandler<CoreWebView2NavigationStartingEventArgs> navigationStarting;

		private EventRegistrationToken _contentLoadingToken;

		private EventHandler<CoreWebView2ContentLoadingEventArgs> contentLoading;

		private EventRegistrationToken _navigationCompletedToken;

		private EventHandler<CoreWebView2NavigationCompletedEventArgs> navigationCompleted;

		private EventRegistrationToken _dOMContentLoadedToken;

		private EventHandler<CoreWebView2DOMContentLoadedEventArgs> dOMContentLoaded;

		private EventRegistrationToken _webMessageReceivedToken;

		private EventHandler<CoreWebView2WebMessageReceivedEventArgs> webMessageReceived;

		private EventRegistrationToken _permissionRequestedToken;

		private EventHandler<CoreWebView2PermissionRequestedEventArgs> permissionRequested;

		internal ICoreWebView2Frame _nativeICoreWebView2Frame
		{
			get
			{
				if (this._nativeICoreWebView2FrameValue == null)
				{
					try
					{
						this._nativeICoreWebView2FrameValue = (ICoreWebView2Frame)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2FrameValue;
			}
			set
			{
				this._nativeICoreWebView2FrameValue = value;
			}
		}

		internal ICoreWebView2Frame2 _nativeICoreWebView2Frame2
		{
			get
			{
				if (this._nativeICoreWebView2Frame2Value == null)
				{
					try
					{
						this._nativeICoreWebView2Frame2Value = (ICoreWebView2Frame2)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2Frame2Value;
			}
			set
			{
				this._nativeICoreWebView2Frame2Value = value;
			}
		}

		internal ICoreWebView2Frame3 _nativeICoreWebView2Frame3
		{
			get
			{
				if (this._nativeICoreWebView2Frame3Value == null)
				{
					try
					{
						this._nativeICoreWebView2Frame3Value = (ICoreWebView2Frame3)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2Frame3Value;
			}
			set
			{
				this._nativeICoreWebView2Frame3Value = value;
			}
		}

		internal ICoreWebView2Frame4 _nativeICoreWebView2Frame4
		{
			get
			{
				if (this._nativeICoreWebView2Frame4Value == null)
				{
					try
					{
						this._nativeICoreWebView2Frame4Value = (ICoreWebView2Frame4)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2Frame4Value;
			}
			set
			{
				this._nativeICoreWebView2Frame4Value = value;
			}
		}

		public String Name
		{
			get
			{
				String name;
				try
				{
					name = this._nativeICoreWebView2Frame.Name;
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
				return name;
			}
		}

		internal CoreWebView2Frame(Object rawCoreWebView2Frame)
		{
			this._rawNative = rawCoreWebView2Frame;
		}

		public Void AddHostObjectToScript(String name, Object rawObject, IEnumerable<String> origins)
		{
			ICoreWebView2Frame variable = this._nativeICoreWebView2Frame;
			String str = name;
			Object obj = rawObject;
			Int32 num = Enumerable.Count<String>(origins);
			IEnumerable<String> enumerable = origins;
			Func<String, String> u003cu003e9_00 = CoreWebView2Frame.u003cu003ec.u003cu003e9__0_0;
			if (u003cu003e9_00 == null)
			{
				u003cu003e9_00 = new Func<String, String>(CoreWebView2Frame.u003cu003ec.u003cu003e9, (String origin) => origin);
				CoreWebView2Frame.u003cu003ec.u003cu003e9__0_0 = u003cu003e9_00;
			}
			variable.AddHostObjectToScriptWithOrigins(str, ref obj, (UInt32)num, Enumerable.ToArray<String>(Enumerable.Select<String, String>(enumerable, u003cu003e9_00)));
		}

		public async Task<String> ExecuteScriptAsync(String javaScript)
		{
			CoreWebView2ExecuteScriptCompletedHandler coreWebView2ExecuteScriptCompletedHandler;
			try
			{
				coreWebView2ExecuteScriptCompletedHandler = new CoreWebView2ExecuteScriptCompletedHandler();
				this._nativeICoreWebView2Frame2.ExecuteScript(javaScript, coreWebView2ExecuteScriptCompletedHandler);
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
			await coreWebView2ExecuteScriptCompletedHandler;
			Marshal.ThrowExceptionForHR(coreWebView2ExecuteScriptCompletedHandler.errCode);
			String str = coreWebView2ExecuteScriptCompletedHandler.resultObjectAsJson;
			coreWebView2ExecuteScriptCompletedHandler = null;
			return str;
		}

		public Int32 IsDestroyed()
		{
			Int32 num;
			try
			{
				num = this._nativeICoreWebView2Frame.IsDestroyed();
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
			return num;
		}

		internal Void OnContentLoading(CoreWebView2ContentLoadingEventArgs args)
		{
			EventHandler<CoreWebView2ContentLoadingEventArgs> eventHandler = this.contentLoading;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnDestroyed(Object args)
		{
			EventHandler<Object> eventHandler = this.destroyed;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnDOMContentLoaded(CoreWebView2DOMContentLoadedEventArgs args)
		{
			EventHandler<CoreWebView2DOMContentLoadedEventArgs> eventHandler = this.dOMContentLoaded;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnNameChanged(Object args)
		{
			EventHandler<Object> eventHandler = this.nameChanged;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnNavigationCompleted(CoreWebView2NavigationCompletedEventArgs args)
		{
			EventHandler<CoreWebView2NavigationCompletedEventArgs> eventHandler = this.navigationCompleted;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnNavigationStarting(CoreWebView2NavigationStartingEventArgs args)
		{
			EventHandler<CoreWebView2NavigationStartingEventArgs> eventHandler = this.navigationStarting;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnPermissionRequested(CoreWebView2PermissionRequestedEventArgs args)
		{
			EventHandler<CoreWebView2PermissionRequestedEventArgs> eventHandler = this.permissionRequested;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnWebMessageReceived(CoreWebView2WebMessageReceivedEventArgs args)
		{
			EventHandler<CoreWebView2WebMessageReceivedEventArgs> eventHandler = this.webMessageReceived;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		public Void PostSharedBufferToScript(CoreWebView2SharedBuffer sharedBuffer, CoreWebView2SharedBufferAccess access, String additionalDataAsJson)
		{
			try
			{
				this._nativeICoreWebView2Frame4.PostSharedBufferToScript(sharedBuffer._nativeICoreWebView2SharedBuffer, (COREWEBVIEW2_SHARED_BUFFER_ACCESS)access, additionalDataAsJson);
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

		public Void PostWebMessageAsJson(String webMessageAsJson)
		{
			try
			{
				this._nativeICoreWebView2Frame2.PostWebMessageAsJson(webMessageAsJson);
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

		public Void PostWebMessageAsString(String webMessageAsString)
		{
			try
			{
				this._nativeICoreWebView2Frame2.PostWebMessageAsString(webMessageAsString);
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

		public Void RemoveHostObjectFromScript(String name)
		{
			try
			{
				this._nativeICoreWebView2Frame.RemoveHostObjectFromScript(name);
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

		public event EventHandler<CoreWebView2ContentLoadingEventArgs> ContentLoading
		{
			add
			{
				if (this.contentLoading == null)
				{
					try
					{
						this._nativeICoreWebView2Frame2.add_ContentLoading(new CoreWebView2FrameContentLoadingEventHandler(new CoreWebView2FrameContentLoadingEventHandler.CallbackType(this.OnContentLoading)), out this._contentLoadingToken);
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
				this.contentLoading = (EventHandler<CoreWebView2ContentLoadingEventArgs>)Delegate.Combine(this.contentLoading, value);
			}
			remove
			{
				this.contentLoading = (EventHandler<CoreWebView2ContentLoadingEventArgs>)Delegate.Remove(this.contentLoading, value);
				if (this.contentLoading == null)
				{
					try
					{
						this._nativeICoreWebView2Frame2.remove_ContentLoading(this._contentLoadingToken);
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

		public event EventHandler<Object> Destroyed
		{
			add
			{
				if (this.destroyed == null)
				{
					try
					{
						this._nativeICoreWebView2Frame.add_Destroyed(new CoreWebView2FrameDestroyedEventHandler(new CoreWebView2FrameDestroyedEventHandler.CallbackType(this.OnDestroyed)), out this._destroyedToken);
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
				this.destroyed = (EventHandler<Object>)Delegate.Combine(this.destroyed, value);
			}
			remove
			{
				this.destroyed = (EventHandler<Object>)Delegate.Remove(this.destroyed, value);
				if (this.destroyed == null)
				{
					try
					{
						this._nativeICoreWebView2Frame.remove_Destroyed(this._destroyedToken);
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

		public event EventHandler<CoreWebView2DOMContentLoadedEventArgs> DOMContentLoaded
		{
			add
			{
				if (this.dOMContentLoaded == null)
				{
					try
					{
						this._nativeICoreWebView2Frame2.add_DOMContentLoaded(new CoreWebView2FrameDOMContentLoadedEventHandler(new CoreWebView2FrameDOMContentLoadedEventHandler.CallbackType(this.OnDOMContentLoaded)), out this._dOMContentLoadedToken);
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
				this.dOMContentLoaded = (EventHandler<CoreWebView2DOMContentLoadedEventArgs>)Delegate.Combine(this.dOMContentLoaded, value);
			}
			remove
			{
				this.dOMContentLoaded = (EventHandler<CoreWebView2DOMContentLoadedEventArgs>)Delegate.Remove(this.dOMContentLoaded, value);
				if (this.dOMContentLoaded == null)
				{
					try
					{
						this._nativeICoreWebView2Frame2.remove_DOMContentLoaded(this._dOMContentLoadedToken);
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

		public event EventHandler<Object> NameChanged
		{
			add
			{
				if (this.nameChanged == null)
				{
					try
					{
						this._nativeICoreWebView2Frame.add_NameChanged(new CoreWebView2FrameNameChangedEventHandler(new CoreWebView2FrameNameChangedEventHandler.CallbackType(this.OnNameChanged)), out this._nameChangedToken);
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
				this.nameChanged = (EventHandler<Object>)Delegate.Combine(this.nameChanged, value);
			}
			remove
			{
				this.nameChanged = (EventHandler<Object>)Delegate.Remove(this.nameChanged, value);
				if (this.nameChanged == null)
				{
					try
					{
						this._nativeICoreWebView2Frame.remove_NameChanged(this._nameChangedToken);
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

		public event EventHandler<CoreWebView2NavigationCompletedEventArgs> NavigationCompleted
		{
			add
			{
				if (this.navigationCompleted == null)
				{
					try
					{
						this._nativeICoreWebView2Frame2.add_NavigationCompleted(new CoreWebView2FrameNavigationCompletedEventHandler(new CoreWebView2FrameNavigationCompletedEventHandler.CallbackType(this.OnNavigationCompleted)), out this._navigationCompletedToken);
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
				this.navigationCompleted = (EventHandler<CoreWebView2NavigationCompletedEventArgs>)Delegate.Combine(this.navigationCompleted, value);
			}
			remove
			{
				this.navigationCompleted = (EventHandler<CoreWebView2NavigationCompletedEventArgs>)Delegate.Remove(this.navigationCompleted, value);
				if (this.navigationCompleted == null)
				{
					try
					{
						this._nativeICoreWebView2Frame2.remove_NavigationCompleted(this._navigationCompletedToken);
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

		public event EventHandler<CoreWebView2NavigationStartingEventArgs> NavigationStarting
		{
			add
			{
				if (this.navigationStarting == null)
				{
					try
					{
						this._nativeICoreWebView2Frame2.add_NavigationStarting(new CoreWebView2FrameNavigationStartingEventHandler(new CoreWebView2FrameNavigationStartingEventHandler.CallbackType(this.OnNavigationStarting)), out this._navigationStartingToken);
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
				this.navigationStarting = (EventHandler<CoreWebView2NavigationStartingEventArgs>)Delegate.Combine(this.navigationStarting, value);
			}
			remove
			{
				this.navigationStarting = (EventHandler<CoreWebView2NavigationStartingEventArgs>)Delegate.Remove(this.navigationStarting, value);
				if (this.navigationStarting == null)
				{
					try
					{
						this._nativeICoreWebView2Frame2.remove_NavigationStarting(this._navigationStartingToken);
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

		public event EventHandler<CoreWebView2PermissionRequestedEventArgs> PermissionRequested
		{
			add
			{
				if (this.permissionRequested == null)
				{
					try
					{
						this._nativeICoreWebView2Frame3.add_PermissionRequested(new CoreWebView2FramePermissionRequestedEventHandler(new CoreWebView2FramePermissionRequestedEventHandler.CallbackType(this.OnPermissionRequested)), out this._permissionRequestedToken);
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
				this.permissionRequested = (EventHandler<CoreWebView2PermissionRequestedEventArgs>)Delegate.Combine(this.permissionRequested, value);
			}
			remove
			{
				this.permissionRequested = (EventHandler<CoreWebView2PermissionRequestedEventArgs>)Delegate.Remove(this.permissionRequested, value);
				if (this.permissionRequested == null)
				{
					try
					{
						this._nativeICoreWebView2Frame3.remove_PermissionRequested(this._permissionRequestedToken);
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

		public event EventHandler<CoreWebView2WebMessageReceivedEventArgs> WebMessageReceived
		{
			add
			{
				if (this.webMessageReceived == null)
				{
					try
					{
						this._nativeICoreWebView2Frame2.add_WebMessageReceived(new CoreWebView2FrameWebMessageReceivedEventHandler(new CoreWebView2FrameWebMessageReceivedEventHandler.CallbackType(this.OnWebMessageReceived)), out this._webMessageReceivedToken);
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
				this.webMessageReceived = (EventHandler<CoreWebView2WebMessageReceivedEventArgs>)Delegate.Combine(this.webMessageReceived, value);
			}
			remove
			{
				this.webMessageReceived = (EventHandler<CoreWebView2WebMessageReceivedEventArgs>)Delegate.Remove(this.webMessageReceived, value);
				if (this.webMessageReceived == null)
				{
					try
					{
						this._nativeICoreWebView2Frame2.remove_WebMessageReceived(this._webMessageReceivedToken);
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
	}
}