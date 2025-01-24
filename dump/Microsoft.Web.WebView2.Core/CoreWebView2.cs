using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2
	{
		internal ICoreWebView2 _nativeICoreWebView2Value;

		internal ICoreWebView2_2 _nativeICoreWebView2_2Value;

		internal ICoreWebView2_3 _nativeICoreWebView2_3Value;

		internal ICoreWebView2_4 _nativeICoreWebView2_4Value;

		internal ICoreWebView2_5 _nativeICoreWebView2_5Value;

		internal ICoreWebView2_6 _nativeICoreWebView2_6Value;

		internal ICoreWebView2_7 _nativeICoreWebView2_7Value;

		internal ICoreWebView2_8 _nativeICoreWebView2_8Value;

		internal ICoreWebView2_9 _nativeICoreWebView2_9Value;

		internal ICoreWebView2_10 _nativeICoreWebView2_10Value;

		internal ICoreWebView2_11 _nativeICoreWebView2_11Value;

		internal ICoreWebView2_12 _nativeICoreWebView2_12Value;

		internal ICoreWebView2_13 _nativeICoreWebView2_13Value;

		internal ICoreWebView2_14 _nativeICoreWebView2_14Value;

		internal ICoreWebView2_15 _nativeICoreWebView2_15Value;

		internal ICoreWebView2_16 _nativeICoreWebView2_16Value;

		internal ICoreWebView2_17 _nativeICoreWebView2_17Value;

		internal ICoreWebView2_18 _nativeICoreWebView2_18Value;

		internal ICoreWebView2_19 _nativeICoreWebView2_19Value;

		internal ICoreWebView2PrivatePartial _nativeICoreWebView2PrivatePartialValue;

		internal Object _rawNative;

		private EventRegistrationToken _navigationStartingToken;

		private EventHandler<CoreWebView2NavigationStartingEventArgs> navigationStarting;

		private EventRegistrationToken _contentLoadingToken;

		private EventHandler<CoreWebView2ContentLoadingEventArgs> contentLoading;

		private EventRegistrationToken _sourceChangedToken;

		private EventHandler<CoreWebView2SourceChangedEventArgs> sourceChanged;

		private EventRegistrationToken _historyChangedToken;

		private EventHandler<Object> historyChanged;

		private EventRegistrationToken _navigationCompletedToken;

		private EventHandler<CoreWebView2NavigationCompletedEventArgs> navigationCompleted;

		private EventRegistrationToken _frameNavigationStartingToken;

		private EventHandler<CoreWebView2NavigationStartingEventArgs> frameNavigationStarting;

		private EventRegistrationToken _frameNavigationCompletedToken;

		private EventHandler<CoreWebView2NavigationCompletedEventArgs> frameNavigationCompleted;

		private EventRegistrationToken _scriptDialogOpeningToken;

		private EventHandler<CoreWebView2ScriptDialogOpeningEventArgs> scriptDialogOpening;

		private EventRegistrationToken _permissionRequestedToken;

		private EventHandler<CoreWebView2PermissionRequestedEventArgs> permissionRequested;

		private EventRegistrationToken _processFailedToken;

		private EventHandler<CoreWebView2ProcessFailedEventArgs> processFailed;

		private EventRegistrationToken _webMessageReceivedToken;

		private EventHandler<CoreWebView2WebMessageReceivedEventArgs> webMessageReceived;

		private EventRegistrationToken _newWindowRequestedToken;

		private EventHandler<CoreWebView2NewWindowRequestedEventArgs> newWindowRequested;

		private EventRegistrationToken _documentTitleChangedToken;

		private EventHandler<Object> documentTitleChanged;

		private EventRegistrationToken _containsFullScreenElementChangedToken;

		private EventHandler<Object> containsFullScreenElementChanged;

		private EventRegistrationToken _webResourceRequestedToken;

		private EventHandler<CoreWebView2WebResourceRequestedEventArgs> webResourceRequested;

		private EventRegistrationToken _windowCloseRequestedToken;

		private EventHandler<Object> windowCloseRequested;

		private EventRegistrationToken _webResourceResponseReceivedToken;

		private EventHandler<CoreWebView2WebResourceResponseReceivedEventArgs> webResourceResponseReceived;

		private EventRegistrationToken _dOMContentLoadedToken;

		private EventHandler<CoreWebView2DOMContentLoadedEventArgs> dOMContentLoaded;

		private EventRegistrationToken _frameCreatedToken;

		private EventHandler<CoreWebView2FrameCreatedEventArgs> frameCreated;

		private EventRegistrationToken _downloadStartingToken;

		private EventHandler<CoreWebView2DownloadStartingEventArgs> downloadStarting;

		private EventRegistrationToken _clientCertificateRequestedToken;

		private EventHandler<CoreWebView2ClientCertificateRequestedEventArgs> clientCertificateRequested;

		private EventRegistrationToken _isMutedChangedToken;

		private EventHandler<Object> isMutedChanged;

		private EventRegistrationToken _isDocumentPlayingAudioChangedToken;

		private EventHandler<Object> isDocumentPlayingAudioChanged;

		private EventRegistrationToken _isDefaultDownloadDialogOpenChangedToken;

		private EventHandler<Object> isDefaultDownloadDialogOpenChanged;

		private EventRegistrationToken _basicAuthenticationRequestedToken;

		private EventHandler<CoreWebView2BasicAuthenticationRequestedEventArgs> basicAuthenticationRequested;

		private EventRegistrationToken _contextMenuRequestedToken;

		private EventHandler<CoreWebView2ContextMenuRequestedEventArgs> contextMenuRequested;

		private EventRegistrationToken _statusBarTextChangedToken;

		private EventHandler<Object> statusBarTextChanged;

		private EventRegistrationToken _serverCertificateErrorDetectedToken;

		private EventHandler<CoreWebView2ServerCertificateErrorDetectedEventArgs> serverCertificateErrorDetected;

		private EventRegistrationToken _faviconChangedToken;

		private EventHandler<Object> faviconChanged;

		private EventRegistrationToken _launchingExternalUriSchemeToken;

		private EventHandler<CoreWebView2LaunchingExternalUriSchemeEventArgs> launchingExternalUriScheme;

		internal ICoreWebView2 _nativeICoreWebView2
		{
			get
			{
				if (this._nativeICoreWebView2Value == null)
				{
					try
					{
						this._nativeICoreWebView2Value = (ICoreWebView2)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2Value;
			}
			set
			{
				this._nativeICoreWebView2Value = value;
			}
		}

		internal ICoreWebView2_10 _nativeICoreWebView2_10
		{
			get
			{
				if (this._nativeICoreWebView2_10Value == null)
				{
					try
					{
						this._nativeICoreWebView2_10Value = (ICoreWebView2_10)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_10.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2_10Value;
			}
			set
			{
				this._nativeICoreWebView2_10Value = value;
			}
		}

		internal ICoreWebView2_11 _nativeICoreWebView2_11
		{
			get
			{
				if (this._nativeICoreWebView2_11Value == null)
				{
					try
					{
						this._nativeICoreWebView2_11Value = (ICoreWebView2_11)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_11.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2_11Value;
			}
			set
			{
				this._nativeICoreWebView2_11Value = value;
			}
		}

		internal ICoreWebView2_12 _nativeICoreWebView2_12
		{
			get
			{
				if (this._nativeICoreWebView2_12Value == null)
				{
					try
					{
						this._nativeICoreWebView2_12Value = (ICoreWebView2_12)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_12.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2_12Value;
			}
			set
			{
				this._nativeICoreWebView2_12Value = value;
			}
		}

		internal ICoreWebView2_13 _nativeICoreWebView2_13
		{
			get
			{
				if (this._nativeICoreWebView2_13Value == null)
				{
					try
					{
						this._nativeICoreWebView2_13Value = (ICoreWebView2_13)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_13.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2_13Value;
			}
			set
			{
				this._nativeICoreWebView2_13Value = value;
			}
		}

		internal ICoreWebView2_14 _nativeICoreWebView2_14
		{
			get
			{
				if (this._nativeICoreWebView2_14Value == null)
				{
					try
					{
						this._nativeICoreWebView2_14Value = (ICoreWebView2_14)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_14.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2_14Value;
			}
			set
			{
				this._nativeICoreWebView2_14Value = value;
			}
		}

		internal ICoreWebView2_15 _nativeICoreWebView2_15
		{
			get
			{
				if (this._nativeICoreWebView2_15Value == null)
				{
					try
					{
						this._nativeICoreWebView2_15Value = (ICoreWebView2_15)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_15.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2_15Value;
			}
			set
			{
				this._nativeICoreWebView2_15Value = value;
			}
		}

		internal ICoreWebView2_16 _nativeICoreWebView2_16
		{
			get
			{
				if (this._nativeICoreWebView2_16Value == null)
				{
					try
					{
						this._nativeICoreWebView2_16Value = (ICoreWebView2_16)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_16.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2_16Value;
			}
			set
			{
				this._nativeICoreWebView2_16Value = value;
			}
		}

		internal ICoreWebView2_17 _nativeICoreWebView2_17
		{
			get
			{
				if (this._nativeICoreWebView2_17Value == null)
				{
					try
					{
						this._nativeICoreWebView2_17Value = (ICoreWebView2_17)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_17.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2_17Value;
			}
			set
			{
				this._nativeICoreWebView2_17Value = value;
			}
		}

		internal ICoreWebView2_18 _nativeICoreWebView2_18
		{
			get
			{
				if (this._nativeICoreWebView2_18Value == null)
				{
					try
					{
						this._nativeICoreWebView2_18Value = (ICoreWebView2_18)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_18.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2_18Value;
			}
			set
			{
				this._nativeICoreWebView2_18Value = value;
			}
		}

		internal ICoreWebView2_19 _nativeICoreWebView2_19
		{
			get
			{
				if (this._nativeICoreWebView2_19Value == null)
				{
					try
					{
						this._nativeICoreWebView2_19Value = (ICoreWebView2_19)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_19.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2_19Value;
			}
			set
			{
				this._nativeICoreWebView2_19Value = value;
			}
		}

		internal ICoreWebView2_2 _nativeICoreWebView2_2
		{
			get
			{
				if (this._nativeICoreWebView2_2Value == null)
				{
					try
					{
						this._nativeICoreWebView2_2Value = (ICoreWebView2_2)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2_2Value;
			}
			set
			{
				this._nativeICoreWebView2_2Value = value;
			}
		}

		internal ICoreWebView2_3 _nativeICoreWebView2_3
		{
			get
			{
				if (this._nativeICoreWebView2_3Value == null)
				{
					try
					{
						this._nativeICoreWebView2_3Value = (ICoreWebView2_3)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2_3Value;
			}
			set
			{
				this._nativeICoreWebView2_3Value = value;
			}
		}

		internal ICoreWebView2_4 _nativeICoreWebView2_4
		{
			get
			{
				if (this._nativeICoreWebView2_4Value == null)
				{
					try
					{
						this._nativeICoreWebView2_4Value = (ICoreWebView2_4)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2_4Value;
			}
			set
			{
				this._nativeICoreWebView2_4Value = value;
			}
		}

		internal ICoreWebView2_5 _nativeICoreWebView2_5
		{
			get
			{
				if (this._nativeICoreWebView2_5Value == null)
				{
					try
					{
						this._nativeICoreWebView2_5Value = (ICoreWebView2_5)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_5.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2_5Value;
			}
			set
			{
				this._nativeICoreWebView2_5Value = value;
			}
		}

		internal ICoreWebView2_6 _nativeICoreWebView2_6
		{
			get
			{
				if (this._nativeICoreWebView2_6Value == null)
				{
					try
					{
						this._nativeICoreWebView2_6Value = (ICoreWebView2_6)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_6.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2_6Value;
			}
			set
			{
				this._nativeICoreWebView2_6Value = value;
			}
		}

		internal ICoreWebView2_7 _nativeICoreWebView2_7
		{
			get
			{
				if (this._nativeICoreWebView2_7Value == null)
				{
					try
					{
						this._nativeICoreWebView2_7Value = (ICoreWebView2_7)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_7.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2_7Value;
			}
			set
			{
				this._nativeICoreWebView2_7Value = value;
			}
		}

		internal ICoreWebView2_8 _nativeICoreWebView2_8
		{
			get
			{
				if (this._nativeICoreWebView2_8Value == null)
				{
					try
					{
						this._nativeICoreWebView2_8Value = (ICoreWebView2_8)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_8.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2_8Value;
			}
			set
			{
				this._nativeICoreWebView2_8Value = value;
			}
		}

		internal ICoreWebView2_9 _nativeICoreWebView2_9
		{
			get
			{
				if (this._nativeICoreWebView2_9Value == null)
				{
					try
					{
						this._nativeICoreWebView2_9Value = (ICoreWebView2_9)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_9.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2_9Value;
			}
			set
			{
				this._nativeICoreWebView2_9Value = value;
			}
		}

		internal ICoreWebView2PrivatePartial _nativeICoreWebView2PrivatePartial
		{
			get
			{
				if (this._nativeICoreWebView2PrivatePartialValue == null)
				{
					try
					{
						this._nativeICoreWebView2PrivatePartialValue = (ICoreWebView2PrivatePartial)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivatePartial.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2PrivatePartialValue;
			}
			set
			{
				this._nativeICoreWebView2PrivatePartialValue = value;
			}
		}

		public UInt32 BrowserProcessId
		{
			get
			{
				UInt32 browserProcessId;
				try
				{
					browserProcessId = this._nativeICoreWebView2.BrowserProcessId;
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
				return browserProcessId;
			}
		}

		public Boolean CanGoBack
		{
			get
			{
				Boolean canGoBack;
				try
				{
					canGoBack = this._nativeICoreWebView2.CanGoBack != 0;
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
				return canGoBack;
			}
		}

		public Boolean CanGoForward
		{
			get
			{
				Boolean canGoForward;
				try
				{
					canGoForward = this._nativeICoreWebView2.CanGoForward != 0;
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
				return canGoForward;
			}
		}

		public Boolean ContainsFullScreenElement
		{
			get
			{
				Boolean containsFullScreenElement;
				try
				{
					containsFullScreenElement = this._nativeICoreWebView2.ContainsFullScreenElement != 0;
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
				return containsFullScreenElement;
			}
		}

		public CoreWebView2CookieManager CookieManager
		{
			get
			{
				CoreWebView2CookieManager coreWebView2CookieManager;
				CoreWebView2CookieManager coreWebView2CookieManager1;
				try
				{
					if (this._nativeICoreWebView2_2.CookieManager == null)
					{
						coreWebView2CookieManager1 = null;
					}
					else
					{
						coreWebView2CookieManager1 = new CoreWebView2CookieManager(this._nativeICoreWebView2_2.CookieManager);
					}
					coreWebView2CookieManager = coreWebView2CookieManager1;
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
				return coreWebView2CookieManager;
			}
		}

		public CoreWebView2DefaultDownloadDialogCornerAlignment DefaultDownloadDialogCornerAlignment
		{
			get
			{
				CoreWebView2DefaultDownloadDialogCornerAlignment defaultDownloadDialogCornerAlignment;
				try
				{
					defaultDownloadDialogCornerAlignment = (CoreWebView2DefaultDownloadDialogCornerAlignment)this._nativeICoreWebView2_9.DefaultDownloadDialogCornerAlignment;
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
				return defaultDownloadDialogCornerAlignment;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2_9.DefaultDownloadDialogCornerAlignment = (COREWEBVIEW2_DEFAULT_DOWNLOAD_DIALOG_CORNER_ALIGNMENT)value;
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

		public Point DefaultDownloadDialogMargin
		{
			get
			{
				Point net;
				try
				{
					net = COMDotNetTypeConverter.PointCOMToNet(this._nativeICoreWebView2_9.DefaultDownloadDialogMargin);
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
			set
			{
				try
				{
					this._nativeICoreWebView2_9.DefaultDownloadDialogMargin = COMDotNetTypeConverter.PointNetToCOM(value);
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

		public String DocumentTitle
		{
			get
			{
				String documentTitle;
				try
				{
					documentTitle = this._nativeICoreWebView2.DocumentTitle;
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
				return documentTitle;
			}
		}

		public CoreWebView2Environment Environment
		{
			get
			{
				CoreWebView2Environment coreWebView2Environment;
				CoreWebView2Environment coreWebView2Environment1;
				try
				{
					if (this._nativeICoreWebView2_2.Environment == null)
					{
						coreWebView2Environment1 = null;
					}
					else
					{
						coreWebView2Environment1 = new CoreWebView2Environment(this._nativeICoreWebView2_2.Environment);
					}
					coreWebView2Environment = coreWebView2Environment1;
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
				return coreWebView2Environment;
			}
		}

		public String FaviconUri
		{
			get
			{
				String faviconUri;
				try
				{
					faviconUri = this._nativeICoreWebView2_15.FaviconUri;
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
				return faviconUri;
			}
		}

		public Boolean IsDefaultDownloadDialogOpen
		{
			get
			{
				Boolean isDefaultDownloadDialogOpen;
				try
				{
					isDefaultDownloadDialogOpen = this._nativeICoreWebView2_9.IsDefaultDownloadDialogOpen != 0;
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
				return isDefaultDownloadDialogOpen;
			}
		}

		public Boolean IsDocumentPlayingAudio
		{
			get
			{
				Boolean isDocumentPlayingAudio;
				try
				{
					isDocumentPlayingAudio = this._nativeICoreWebView2_8.IsDocumentPlayingAudio != 0;
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
				return isDocumentPlayingAudio;
			}
		}

		public Boolean IsMuted
		{
			get
			{
				Boolean isMuted;
				try
				{
					isMuted = this._nativeICoreWebView2_8.IsMuted != 0;
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
				return isMuted;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2_8.IsMuted = (value ? 1 : 0);
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

		public Boolean IsSuspended
		{
			get
			{
				Boolean isSuspended;
				try
				{
					isSuspended = this._nativeICoreWebView2_3.IsSuspended != 0;
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
				return isSuspended;
			}
		}

		public CoreWebView2MemoryUsageTargetLevel MemoryUsageTargetLevel
		{
			get
			{
				CoreWebView2MemoryUsageTargetLevel memoryUsageTargetLevel;
				try
				{
					memoryUsageTargetLevel = (CoreWebView2MemoryUsageTargetLevel)this._nativeICoreWebView2_19.MemoryUsageTargetLevel;
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
				return memoryUsageTargetLevel;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2_19.MemoryUsageTargetLevel = (COREWEBVIEW2_MEMORY_USAGE_TARGET_LEVEL)value;
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

		public CoreWebView2Profile Profile
		{
			get
			{
				CoreWebView2Profile coreWebView2Profile;
				CoreWebView2Profile coreWebView2Profile1;
				try
				{
					if (this._nativeICoreWebView2_13.Profile == null)
					{
						coreWebView2Profile1 = null;
					}
					else
					{
						coreWebView2Profile1 = new CoreWebView2Profile(this._nativeICoreWebView2_13.Profile);
					}
					coreWebView2Profile = coreWebView2Profile1;
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
				return coreWebView2Profile;
			}
		}

		public CoreWebView2Settings Settings
		{
			get
			{
				CoreWebView2Settings coreWebView2Setting;
				CoreWebView2Settings coreWebView2Setting1;
				try
				{
					if (this._nativeICoreWebView2.Settings == null)
					{
						coreWebView2Setting1 = null;
					}
					else
					{
						coreWebView2Setting1 = new CoreWebView2Settings(this._nativeICoreWebView2.Settings);
					}
					coreWebView2Setting = coreWebView2Setting1;
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
				return coreWebView2Setting;
			}
		}

		public String Source
		{
			get
			{
				String source;
				try
				{
					source = this._nativeICoreWebView2.Source;
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

		public String StatusBarText
		{
			get
			{
				String statusBarText;
				try
				{
					statusBarText = this._nativeICoreWebView2_12.StatusBarText;
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
				return statusBarText;
			}
		}

		internal CoreWebView2(Object rawCoreWebView2)
		{
			this._rawNative = rawCoreWebView2;
		}

		internal Void AddHostObjectHelper(CoreWebView2PrivateHostObjectHelper helper)
		{
			try
			{
				this._nativeICoreWebView2PrivatePartial.AddHostObjectHelper(helper._nativeICoreWebView2PrivateHostObjectHelper);
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

		public Void AddHostObjectToScript(String name, Object rawObject)
		{
			try
			{
				Object obj = rawObject;
				this._nativeICoreWebView2.AddHostObjectToScript(name, ref obj);
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

		public async Task<String> AddScriptToExecuteOnDocumentCreatedAsync(String javaScript)
		{
			CoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler coreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler;
			try
			{
				coreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler = new CoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler();
				this._nativeICoreWebView2.AddScriptToExecuteOnDocumentCreated(javaScript, coreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler);
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
			await coreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler;
			Marshal.ThrowExceptionForHR(coreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler.errCode);
			String str = coreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler.id;
			coreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler = null;
			return str;
		}

		public Void AddWebResourceRequestedFilter(String uri, CoreWebView2WebResourceContext ResourceContext)
		{
			try
			{
				this._nativeICoreWebView2.AddWebResourceRequestedFilter(uri, (COREWEBVIEW2_WEB_RESOURCE_CONTEXT)ResourceContext);
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

		public async Task<String> CallDevToolsProtocolMethodAsync(String methodName, String parametersAsJson)
		{
			CoreWebView2CallDevToolsProtocolMethodCompletedHandler coreWebView2CallDevToolsProtocolMethodCompletedHandler;
			try
			{
				coreWebView2CallDevToolsProtocolMethodCompletedHandler = new CoreWebView2CallDevToolsProtocolMethodCompletedHandler();
				this._nativeICoreWebView2.CallDevToolsProtocolMethod(methodName, parametersAsJson, coreWebView2CallDevToolsProtocolMethodCompletedHandler);
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
			await coreWebView2CallDevToolsProtocolMethodCompletedHandler;
			Marshal.ThrowExceptionForHR(coreWebView2CallDevToolsProtocolMethodCompletedHandler.errCode);
			String str = coreWebView2CallDevToolsProtocolMethodCompletedHandler.returnObjectAsJson;
			coreWebView2CallDevToolsProtocolMethodCompletedHandler = null;
			return str;
		}

		public async Task<String> CallDevToolsProtocolMethodForSessionAsync(String sessionId, String methodName, String parametersAsJson)
		{
			CoreWebView2CallDevToolsProtocolMethodCompletedHandler coreWebView2CallDevToolsProtocolMethodCompletedHandler;
			try
			{
				coreWebView2CallDevToolsProtocolMethodCompletedHandler = new CoreWebView2CallDevToolsProtocolMethodCompletedHandler();
				this._nativeICoreWebView2_11.CallDevToolsProtocolMethodForSession(sessionId, methodName, parametersAsJson, coreWebView2CallDevToolsProtocolMethodCompletedHandler);
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
			await coreWebView2CallDevToolsProtocolMethodCompletedHandler;
			Marshal.ThrowExceptionForHR(coreWebView2CallDevToolsProtocolMethodCompletedHandler.errCode);
			String str = coreWebView2CallDevToolsProtocolMethodCompletedHandler.returnObjectAsJson;
			coreWebView2CallDevToolsProtocolMethodCompletedHandler = null;
			return str;
		}

		public async Task CapturePreviewAsync(CoreWebView2CapturePreviewImageFormat imageFormat, Stream imageStream)
		{
			IStream managedIStream;
			CoreWebView2CapturePreviewCompletedHandler coreWebView2CapturePreviewCompletedHandler;
			try
			{
				coreWebView2CapturePreviewCompletedHandler = new CoreWebView2CapturePreviewCompletedHandler();
				ICoreWebView2 variable = this._nativeICoreWebView2;
				CoreWebView2CapturePreviewImageFormat coreWebView2CapturePreviewImageFormat = imageFormat;
				if (imageStream == null)
				{
					managedIStream = null;
				}
				else
				{
					managedIStream = new ManagedIStream(imageStream);
				}
				variable.CapturePreview((COREWEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT)coreWebView2CapturePreviewImageFormat, managedIStream, coreWebView2CapturePreviewCompletedHandler);
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
			await coreWebView2CapturePreviewCompletedHandler;
			Marshal.ThrowExceptionForHR(coreWebView2CapturePreviewCompletedHandler.errCode);
			coreWebView2CapturePreviewCompletedHandler = null;
		}

		public async Task ClearServerCertificateErrorActionsAsync()
		{
			CoreWebView2ClearServerCertificateErrorActionsCompletedHandler coreWebView2ClearServerCertificateErrorActionsCompletedHandler;
			try
			{
				coreWebView2ClearServerCertificateErrorActionsCompletedHandler = new CoreWebView2ClearServerCertificateErrorActionsCompletedHandler();
				this._nativeICoreWebView2_14.ClearServerCertificateErrorActions(coreWebView2ClearServerCertificateErrorActionsCompletedHandler);
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
			await coreWebView2ClearServerCertificateErrorActionsCompletedHandler;
			Marshal.ThrowExceptionForHR(coreWebView2ClearServerCertificateErrorActionsCompletedHandler.errCode);
			coreWebView2ClearServerCertificateErrorActionsCompletedHandler = null;
		}

		public Void ClearVirtualHostNameToFolderMapping(String hostName)
		{
			try
			{
				this._nativeICoreWebView2_3.ClearVirtualHostNameToFolderMapping(hostName);
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

		public Void CloseDefaultDownloadDialog()
		{
			try
			{
				this._nativeICoreWebView2_9.CloseDefaultDownloadDialog();
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

		public async Task<String> ExecuteScriptAsync(String javaScript)
		{
			CoreWebView2ExecuteScriptCompletedHandler coreWebView2ExecuteScriptCompletedHandler;
			try
			{
				coreWebView2ExecuteScriptCompletedHandler = new CoreWebView2ExecuteScriptCompletedHandler();
				this._nativeICoreWebView2.ExecuteScript(javaScript, coreWebView2ExecuteScriptCompletedHandler);
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

		public CoreWebView2DevToolsProtocolEventReceiver GetDevToolsProtocolEventReceiver(String eventName)
		{
			CoreWebView2DevToolsProtocolEventReceiver coreWebView2DevToolsProtocolEventReceiver;
			try
			{
				coreWebView2DevToolsProtocolEventReceiver = new CoreWebView2DevToolsProtocolEventReceiver(this._nativeICoreWebView2.GetDevToolsProtocolEventReceiver(eventName));
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
			return coreWebView2DevToolsProtocolEventReceiver;
		}

		public async Task<Stream> GetFaviconAsync(CoreWebView2FaviconImageFormat format)
		{
			CoreWebView2GetFaviconCompletedHandler coreWebView2GetFaviconCompletedHandler;
			try
			{
				coreWebView2GetFaviconCompletedHandler = new CoreWebView2GetFaviconCompletedHandler();
				this._nativeICoreWebView2_15.GetFavicon((COREWEBVIEW2_FAVICON_IMAGE_FORMAT)format, coreWebView2GetFaviconCompletedHandler);
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
			await coreWebView2GetFaviconCompletedHandler;
			Marshal.ThrowExceptionForHR(coreWebView2GetFaviconCompletedHandler.errCode);
			Stream stream = coreWebView2GetFaviconCompletedHandler.faviconStream;
			coreWebView2GetFaviconCompletedHandler = null;
			return stream;
		}

		public Void GoBack()
		{
			try
			{
				this._nativeICoreWebView2.GoBack();
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

		public Void GoForward()
		{
			try
			{
				this._nativeICoreWebView2.GoForward();
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

		public Void Navigate(String uri)
		{
			try
			{
				this._nativeICoreWebView2.Navigate(uri);
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

		public Void NavigateToString(String htmlContent)
		{
			try
			{
				this._nativeICoreWebView2.NavigateToString(htmlContent);
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

		public Void NavigateWithWebResourceRequest(CoreWebView2WebResourceRequest Request)
		{
			try
			{
				this._nativeICoreWebView2_2.NavigateWithWebResourceRequest(Request._nativeICoreWebView2WebResourceRequest);
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

		internal Void OnBasicAuthenticationRequested(CoreWebView2BasicAuthenticationRequestedEventArgs args)
		{
			EventHandler<CoreWebView2BasicAuthenticationRequestedEventArgs> eventHandler = this.basicAuthenticationRequested;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnClientCertificateRequested(CoreWebView2ClientCertificateRequestedEventArgs args)
		{
			EventHandler<CoreWebView2ClientCertificateRequestedEventArgs> eventHandler = this.clientCertificateRequested;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnContainsFullScreenElementChanged(Object args)
		{
			EventHandler<Object> eventHandler = this.containsFullScreenElementChanged;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
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

		internal Void OnContextMenuRequested(CoreWebView2ContextMenuRequestedEventArgs args)
		{
			EventHandler<CoreWebView2ContextMenuRequestedEventArgs> eventHandler = this.contextMenuRequested;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnDocumentTitleChanged(Object args)
		{
			EventHandler<Object> eventHandler = this.documentTitleChanged;
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

		internal Void OnDownloadStarting(CoreWebView2DownloadStartingEventArgs args)
		{
			EventHandler<CoreWebView2DownloadStartingEventArgs> eventHandler = this.downloadStarting;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnFaviconChanged(Object args)
		{
			EventHandler<Object> eventHandler = this.faviconChanged;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnFrameCreated(CoreWebView2FrameCreatedEventArgs args)
		{
			EventHandler<CoreWebView2FrameCreatedEventArgs> eventHandler = this.frameCreated;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnFrameNavigationCompleted(CoreWebView2NavigationCompletedEventArgs args)
		{
			EventHandler<CoreWebView2NavigationCompletedEventArgs> eventHandler = this.frameNavigationCompleted;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnFrameNavigationStarting(CoreWebView2NavigationStartingEventArgs args)
		{
			EventHandler<CoreWebView2NavigationStartingEventArgs> eventHandler = this.frameNavigationStarting;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnHistoryChanged(Object args)
		{
			EventHandler<Object> eventHandler = this.historyChanged;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnIsDefaultDownloadDialogOpenChanged(Object args)
		{
			EventHandler<Object> eventHandler = this.isDefaultDownloadDialogOpenChanged;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnIsDocumentPlayingAudioChanged(Object args)
		{
			EventHandler<Object> eventHandler = this.isDocumentPlayingAudioChanged;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnIsMutedChanged(Object args)
		{
			EventHandler<Object> eventHandler = this.isMutedChanged;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnLaunchingExternalUriScheme(CoreWebView2LaunchingExternalUriSchemeEventArgs args)
		{
			EventHandler<CoreWebView2LaunchingExternalUriSchemeEventArgs> eventHandler = this.launchingExternalUriScheme;
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

		internal Void OnNewWindowRequested(CoreWebView2NewWindowRequestedEventArgs args)
		{
			EventHandler<CoreWebView2NewWindowRequestedEventArgs> eventHandler = this.newWindowRequested;
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

		internal Void OnProcessFailed(CoreWebView2ProcessFailedEventArgs args)
		{
			EventHandler<CoreWebView2ProcessFailedEventArgs> eventHandler = this.processFailed;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnScriptDialogOpening(CoreWebView2ScriptDialogOpeningEventArgs args)
		{
			EventHandler<CoreWebView2ScriptDialogOpeningEventArgs> eventHandler = this.scriptDialogOpening;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnServerCertificateErrorDetected(CoreWebView2ServerCertificateErrorDetectedEventArgs args)
		{
			EventHandler<CoreWebView2ServerCertificateErrorDetectedEventArgs> eventHandler = this.serverCertificateErrorDetected;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnSourceChanged(CoreWebView2SourceChangedEventArgs args)
		{
			EventHandler<CoreWebView2SourceChangedEventArgs> eventHandler = this.sourceChanged;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnStatusBarTextChanged(Object args)
		{
			EventHandler<Object> eventHandler = this.statusBarTextChanged;
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

		internal Void OnWebResourceRequested(CoreWebView2WebResourceRequestedEventArgs args)
		{
			EventHandler<CoreWebView2WebResourceRequestedEventArgs> eventHandler = this.webResourceRequested;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnWebResourceResponseReceived(CoreWebView2WebResourceResponseReceivedEventArgs args)
		{
			EventHandler<CoreWebView2WebResourceResponseReceivedEventArgs> eventHandler = this.webResourceResponseReceived;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnWindowCloseRequested(Object args)
		{
			EventHandler<Object> eventHandler = this.windowCloseRequested;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		public Void OpenDefaultDownloadDialog()
		{
			try
			{
				this._nativeICoreWebView2_9.OpenDefaultDownloadDialog();
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

		public Void OpenDevToolsWindow()
		{
			try
			{
				this._nativeICoreWebView2.OpenDevToolsWindow();
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

		public Void OpenTaskManagerWindow()
		{
			try
			{
				this._nativeICoreWebView2_6.OpenTaskManagerWindow();
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

		public Void PostSharedBufferToScript(CoreWebView2SharedBuffer sharedBuffer, CoreWebView2SharedBufferAccess access, String additionalDataAsJson)
		{
			try
			{
				this._nativeICoreWebView2_17.PostSharedBufferToScript(sharedBuffer._nativeICoreWebView2SharedBuffer, (COREWEBVIEW2_SHARED_BUFFER_ACCESS)access, additionalDataAsJson);
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
				this._nativeICoreWebView2.PostWebMessageAsJson(webMessageAsJson);
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
				this._nativeICoreWebView2.PostWebMessageAsString(webMessageAsString);
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

		public async Task<CoreWebView2PrintStatus> PrintAsync(CoreWebView2PrintSettings printSettings)
		{
			ICoreWebView2PrintSettings variable;
			CoreWebView2PrintCompletedHandler coreWebView2PrintCompletedHandler;
			try
			{
				coreWebView2PrintCompletedHandler = new CoreWebView2PrintCompletedHandler();
				ICoreWebView2_16 _nativeICoreWebView216 = this._nativeICoreWebView2_16;
				if (printSettings == null)
				{
					variable = null;
				}
				else
				{
					variable = printSettings._nativeICoreWebView2PrintSettings;
				}
				_nativeICoreWebView216.Print(variable, coreWebView2PrintCompletedHandler);
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
			await coreWebView2PrintCompletedHandler;
			Marshal.ThrowExceptionForHR(coreWebView2PrintCompletedHandler.errCode);
			CoreWebView2PrintStatus coreWebView2PrintStatu = coreWebView2PrintCompletedHandler.printStatus;
			coreWebView2PrintCompletedHandler = null;
			return coreWebView2PrintStatu;
		}

		public async Task<Boolean> PrintToPdfAsync(String ResultFilePath, CoreWebView2PrintSettings printSettings = null)
		{
			ICoreWebView2PrintSettings variable;
			CoreWebView2PrintToPdfCompletedHandler coreWebView2PrintToPdfCompletedHandler;
			try
			{
				coreWebView2PrintToPdfCompletedHandler = new CoreWebView2PrintToPdfCompletedHandler();
				if (printSettings != null)
				{
					variable = printSettings._nativeICoreWebView2PrintSettings;
				}
				else
				{
					variable = null;
				}
				this._nativeICoreWebView2_7.PrintToPdf(ResultFilePath, variable, coreWebView2PrintToPdfCompletedHandler);
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
			await coreWebView2PrintToPdfCompletedHandler;
			Marshal.ThrowExceptionForHR(coreWebView2PrintToPdfCompletedHandler.errCode);
			Boolean flag = coreWebView2PrintToPdfCompletedHandler.isSuccessful;
			coreWebView2PrintToPdfCompletedHandler = null;
			return flag;
		}

		public async Task<Stream> PrintToPdfStreamAsync(CoreWebView2PrintSettings printSettings)
		{
			ICoreWebView2PrintSettings variable;
			CoreWebView2PrintToPdfStreamCompletedHandler coreWebView2PrintToPdfStreamCompletedHandler;
			try
			{
				coreWebView2PrintToPdfStreamCompletedHandler = new CoreWebView2PrintToPdfStreamCompletedHandler();
				ICoreWebView2_16 _nativeICoreWebView216 = this._nativeICoreWebView2_16;
				if (printSettings == null)
				{
					variable = null;
				}
				else
				{
					variable = printSettings._nativeICoreWebView2PrintSettings;
				}
				_nativeICoreWebView216.PrintToPdfStream(variable, coreWebView2PrintToPdfStreamCompletedHandler);
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
			await coreWebView2PrintToPdfStreamCompletedHandler;
			Marshal.ThrowExceptionForHR(coreWebView2PrintToPdfStreamCompletedHandler.errCode);
			Stream stream = coreWebView2PrintToPdfStreamCompletedHandler.pdfStream;
			coreWebView2PrintToPdfStreamCompletedHandler = null;
			return stream;
		}

		public Void Reload()
		{
			try
			{
				this._nativeICoreWebView2.Reload();
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
				this._nativeICoreWebView2.RemoveHostObjectFromScript(name);
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

		public Void RemoveScriptToExecuteOnDocumentCreated(String id)
		{
			try
			{
				this._nativeICoreWebView2.RemoveScriptToExecuteOnDocumentCreated(id);
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

		public Void RemoveWebResourceRequestedFilter(String uri, CoreWebView2WebResourceContext ResourceContext)
		{
			try
			{
				this._nativeICoreWebView2.RemoveWebResourceRequestedFilter(uri, (COREWEBVIEW2_WEB_RESOURCE_CONTEXT)ResourceContext);
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

		public Void Resume()
		{
			try
			{
				this._nativeICoreWebView2_3.Resume();
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

		public Void SetVirtualHostNameToFolderMapping(String hostName, String folderPath, CoreWebView2HostResourceAccessKind accessKind)
		{
			try
			{
				this._nativeICoreWebView2_3.SetVirtualHostNameToFolderMapping(hostName, folderPath, (COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND)accessKind);
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

		public Void ShowPrintUI()
		{
			try
			{
				this._nativeICoreWebView2_16.ShowPrintUI(COREWEBVIEW2_PRINT_DIALOG_KIND.COREWEBVIEW2_PRINT_DIALOG_KIND_BROWSER);
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

		public Void ShowPrintUI(CoreWebView2PrintDialogKind printDialogKind)
		{
			try
			{
				this._nativeICoreWebView2_16.ShowPrintUI((COREWEBVIEW2_PRINT_DIALOG_KIND)printDialogKind);
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

		public Void Stop()
		{
			try
			{
				this._nativeICoreWebView2.Stop();
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

		public async Task<Boolean> TrySuspendAsync()
		{
			CoreWebView2TrySuspendCompletedHandler coreWebView2TrySuspendCompletedHandler;
			try
			{
				coreWebView2TrySuspendCompletedHandler = new CoreWebView2TrySuspendCompletedHandler();
				this._nativeICoreWebView2_3.TrySuspend(coreWebView2TrySuspendCompletedHandler);
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
			await coreWebView2TrySuspendCompletedHandler;
			Marshal.ThrowExceptionForHR(coreWebView2TrySuspendCompletedHandler.errCode);
			Boolean flag = coreWebView2TrySuspendCompletedHandler.isSuccessful;
			coreWebView2TrySuspendCompletedHandler = null;
			return flag;
		}

		public event EventHandler<CoreWebView2BasicAuthenticationRequestedEventArgs> BasicAuthenticationRequested
		{
			add
			{
				if (this.basicAuthenticationRequested == null)
				{
					try
					{
						this._nativeICoreWebView2_10.add_BasicAuthenticationRequested(new CoreWebView2BasicAuthenticationRequestedEventHandler(new CoreWebView2BasicAuthenticationRequestedEventHandler.CallbackType(this.OnBasicAuthenticationRequested)), out this._basicAuthenticationRequestedToken);
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
				this.basicAuthenticationRequested = (EventHandler<CoreWebView2BasicAuthenticationRequestedEventArgs>)Delegate.Combine(this.basicAuthenticationRequested, value);
			}
			remove
			{
				this.basicAuthenticationRequested = (EventHandler<CoreWebView2BasicAuthenticationRequestedEventArgs>)Delegate.Remove(this.basicAuthenticationRequested, value);
				if (this.basicAuthenticationRequested == null)
				{
					try
					{
						this._nativeICoreWebView2_10.remove_BasicAuthenticationRequested(this._basicAuthenticationRequestedToken);
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

		public event EventHandler<CoreWebView2ClientCertificateRequestedEventArgs> ClientCertificateRequested
		{
			add
			{
				if (this.clientCertificateRequested == null)
				{
					try
					{
						this._nativeICoreWebView2_5.add_ClientCertificateRequested(new CoreWebView2ClientCertificateRequestedEventHandler(new CoreWebView2ClientCertificateRequestedEventHandler.CallbackType(this.OnClientCertificateRequested)), out this._clientCertificateRequestedToken);
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
				this.clientCertificateRequested = (EventHandler<CoreWebView2ClientCertificateRequestedEventArgs>)Delegate.Combine(this.clientCertificateRequested, value);
			}
			remove
			{
				this.clientCertificateRequested = (EventHandler<CoreWebView2ClientCertificateRequestedEventArgs>)Delegate.Remove(this.clientCertificateRequested, value);
				if (this.clientCertificateRequested == null)
				{
					try
					{
						this._nativeICoreWebView2_5.remove_ClientCertificateRequested(this._clientCertificateRequestedToken);
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

		public event EventHandler<Object> ContainsFullScreenElementChanged
		{
			add
			{
				if (this.containsFullScreenElementChanged == null)
				{
					try
					{
						this._nativeICoreWebView2.add_ContainsFullScreenElementChanged(new CoreWebView2ContainsFullScreenElementChangedEventHandler(new CoreWebView2ContainsFullScreenElementChangedEventHandler.CallbackType(this.OnContainsFullScreenElementChanged)), out this._containsFullScreenElementChangedToken);
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
				this.containsFullScreenElementChanged = (EventHandler<Object>)Delegate.Combine(this.containsFullScreenElementChanged, value);
			}
			remove
			{
				this.containsFullScreenElementChanged = (EventHandler<Object>)Delegate.Remove(this.containsFullScreenElementChanged, value);
				if (this.containsFullScreenElementChanged == null)
				{
					try
					{
						this._nativeICoreWebView2.remove_ContainsFullScreenElementChanged(this._containsFullScreenElementChangedToken);
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

		public event EventHandler<CoreWebView2ContentLoadingEventArgs> ContentLoading
		{
			add
			{
				if (this.contentLoading == null)
				{
					try
					{
						this._nativeICoreWebView2.add_ContentLoading(new CoreWebView2ContentLoadingEventHandler(new CoreWebView2ContentLoadingEventHandler.CallbackType(this.OnContentLoading)), out this._contentLoadingToken);
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
						this._nativeICoreWebView2.remove_ContentLoading(this._contentLoadingToken);
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

		public event EventHandler<CoreWebView2ContextMenuRequestedEventArgs> ContextMenuRequested
		{
			add
			{
				if (this.contextMenuRequested == null)
				{
					try
					{
						this._nativeICoreWebView2_11.add_ContextMenuRequested(new CoreWebView2ContextMenuRequestedEventHandler(new CoreWebView2ContextMenuRequestedEventHandler.CallbackType(this.OnContextMenuRequested)), out this._contextMenuRequestedToken);
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
				this.contextMenuRequested = (EventHandler<CoreWebView2ContextMenuRequestedEventArgs>)Delegate.Combine(this.contextMenuRequested, value);
			}
			remove
			{
				this.contextMenuRequested = (EventHandler<CoreWebView2ContextMenuRequestedEventArgs>)Delegate.Remove(this.contextMenuRequested, value);
				if (this.contextMenuRequested == null)
				{
					try
					{
						this._nativeICoreWebView2_11.remove_ContextMenuRequested(this._contextMenuRequestedToken);
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

		public event EventHandler<Object> DocumentTitleChanged
		{
			add
			{
				if (this.documentTitleChanged == null)
				{
					try
					{
						this._nativeICoreWebView2.add_DocumentTitleChanged(new CoreWebView2DocumentTitleChangedEventHandler(new CoreWebView2DocumentTitleChangedEventHandler.CallbackType(this.OnDocumentTitleChanged)), out this._documentTitleChangedToken);
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
				this.documentTitleChanged = (EventHandler<Object>)Delegate.Combine(this.documentTitleChanged, value);
			}
			remove
			{
				this.documentTitleChanged = (EventHandler<Object>)Delegate.Remove(this.documentTitleChanged, value);
				if (this.documentTitleChanged == null)
				{
					try
					{
						this._nativeICoreWebView2.remove_DocumentTitleChanged(this._documentTitleChangedToken);
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
						this._nativeICoreWebView2_2.add_DOMContentLoaded(new CoreWebView2DOMContentLoadedEventHandler(new CoreWebView2DOMContentLoadedEventHandler.CallbackType(this.OnDOMContentLoaded)), out this._dOMContentLoadedToken);
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
						this._nativeICoreWebView2_2.remove_DOMContentLoaded(this._dOMContentLoadedToken);
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

		public event EventHandler<CoreWebView2DownloadStartingEventArgs> DownloadStarting
		{
			add
			{
				if (this.downloadStarting == null)
				{
					try
					{
						this._nativeICoreWebView2_4.add_DownloadStarting(new CoreWebView2DownloadStartingEventHandler(new CoreWebView2DownloadStartingEventHandler.CallbackType(this.OnDownloadStarting)), out this._downloadStartingToken);
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
				this.downloadStarting = (EventHandler<CoreWebView2DownloadStartingEventArgs>)Delegate.Combine(this.downloadStarting, value);
			}
			remove
			{
				this.downloadStarting = (EventHandler<CoreWebView2DownloadStartingEventArgs>)Delegate.Remove(this.downloadStarting, value);
				if (this.downloadStarting == null)
				{
					try
					{
						this._nativeICoreWebView2_4.remove_DownloadStarting(this._downloadStartingToken);
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

		public event EventHandler<Object> FaviconChanged
		{
			add
			{
				if (this.faviconChanged == null)
				{
					try
					{
						this._nativeICoreWebView2_15.add_FaviconChanged(new CoreWebView2FaviconChangedEventHandler(new CoreWebView2FaviconChangedEventHandler.CallbackType(this.OnFaviconChanged)), out this._faviconChangedToken);
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
				this.faviconChanged = (EventHandler<Object>)Delegate.Combine(this.faviconChanged, value);
			}
			remove
			{
				this.faviconChanged = (EventHandler<Object>)Delegate.Remove(this.faviconChanged, value);
				if (this.faviconChanged == null)
				{
					try
					{
						this._nativeICoreWebView2_15.remove_FaviconChanged(this._faviconChangedToken);
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

		public event EventHandler<CoreWebView2FrameCreatedEventArgs> FrameCreated
		{
			add
			{
				if (this.frameCreated == null)
				{
					try
					{
						this._nativeICoreWebView2_4.add_FrameCreated(new CoreWebView2FrameCreatedEventHandler(new CoreWebView2FrameCreatedEventHandler.CallbackType(this.OnFrameCreated)), out this._frameCreatedToken);
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
				this.frameCreated = (EventHandler<CoreWebView2FrameCreatedEventArgs>)Delegate.Combine(this.frameCreated, value);
			}
			remove
			{
				this.frameCreated = (EventHandler<CoreWebView2FrameCreatedEventArgs>)Delegate.Remove(this.frameCreated, value);
				if (this.frameCreated == null)
				{
					try
					{
						this._nativeICoreWebView2_4.remove_FrameCreated(this._frameCreatedToken);
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

		public event EventHandler<CoreWebView2NavigationCompletedEventArgs> FrameNavigationCompleted
		{
			add
			{
				if (this.frameNavigationCompleted == null)
				{
					try
					{
						this._nativeICoreWebView2.add_FrameNavigationCompleted(new CoreWebView2NavigationCompletedEventHandler(new CoreWebView2NavigationCompletedEventHandler.CallbackType(this.OnFrameNavigationCompleted)), out this._frameNavigationCompletedToken);
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
				this.frameNavigationCompleted = (EventHandler<CoreWebView2NavigationCompletedEventArgs>)Delegate.Combine(this.frameNavigationCompleted, value);
			}
			remove
			{
				this.frameNavigationCompleted = (EventHandler<CoreWebView2NavigationCompletedEventArgs>)Delegate.Remove(this.frameNavigationCompleted, value);
				if (this.frameNavigationCompleted == null)
				{
					try
					{
						this._nativeICoreWebView2.remove_FrameNavigationCompleted(this._frameNavigationCompletedToken);
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

		public event EventHandler<CoreWebView2NavigationStartingEventArgs> FrameNavigationStarting
		{
			add
			{
				if (this.frameNavigationStarting == null)
				{
					try
					{
						this._nativeICoreWebView2.add_FrameNavigationStarting(new CoreWebView2NavigationStartingEventHandler(new CoreWebView2NavigationStartingEventHandler.CallbackType(this.OnFrameNavigationStarting)), out this._frameNavigationStartingToken);
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
				this.frameNavigationStarting = (EventHandler<CoreWebView2NavigationStartingEventArgs>)Delegate.Combine(this.frameNavigationStarting, value);
			}
			remove
			{
				this.frameNavigationStarting = (EventHandler<CoreWebView2NavigationStartingEventArgs>)Delegate.Remove(this.frameNavigationStarting, value);
				if (this.frameNavigationStarting == null)
				{
					try
					{
						this._nativeICoreWebView2.remove_FrameNavigationStarting(this._frameNavigationStartingToken);
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

		public event EventHandler<Object> HistoryChanged
		{
			add
			{
				if (this.historyChanged == null)
				{
					try
					{
						this._nativeICoreWebView2.add_HistoryChanged(new CoreWebView2HistoryChangedEventHandler(new CoreWebView2HistoryChangedEventHandler.CallbackType(this.OnHistoryChanged)), out this._historyChangedToken);
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
				this.historyChanged = (EventHandler<Object>)Delegate.Combine(this.historyChanged, value);
			}
			remove
			{
				this.historyChanged = (EventHandler<Object>)Delegate.Remove(this.historyChanged, value);
				if (this.historyChanged == null)
				{
					try
					{
						this._nativeICoreWebView2.remove_HistoryChanged(this._historyChangedToken);
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

		public event EventHandler<Object> IsDefaultDownloadDialogOpenChanged
		{
			add
			{
				if (this.isDefaultDownloadDialogOpenChanged == null)
				{
					try
					{
						this._nativeICoreWebView2_9.add_IsDefaultDownloadDialogOpenChanged(new CoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler(new CoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler.CallbackType(this.OnIsDefaultDownloadDialogOpenChanged)), out this._isDefaultDownloadDialogOpenChangedToken);
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
				this.isDefaultDownloadDialogOpenChanged = (EventHandler<Object>)Delegate.Combine(this.isDefaultDownloadDialogOpenChanged, value);
			}
			remove
			{
				this.isDefaultDownloadDialogOpenChanged = (EventHandler<Object>)Delegate.Remove(this.isDefaultDownloadDialogOpenChanged, value);
				if (this.isDefaultDownloadDialogOpenChanged == null)
				{
					try
					{
						this._nativeICoreWebView2_9.remove_IsDefaultDownloadDialogOpenChanged(this._isDefaultDownloadDialogOpenChangedToken);
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

		public event EventHandler<Object> IsDocumentPlayingAudioChanged
		{
			add
			{
				if (this.isDocumentPlayingAudioChanged == null)
				{
					try
					{
						this._nativeICoreWebView2_8.add_IsDocumentPlayingAudioChanged(new CoreWebView2IsDocumentPlayingAudioChangedEventHandler(new CoreWebView2IsDocumentPlayingAudioChangedEventHandler.CallbackType(this.OnIsDocumentPlayingAudioChanged)), out this._isDocumentPlayingAudioChangedToken);
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
				this.isDocumentPlayingAudioChanged = (EventHandler<Object>)Delegate.Combine(this.isDocumentPlayingAudioChanged, value);
			}
			remove
			{
				this.isDocumentPlayingAudioChanged = (EventHandler<Object>)Delegate.Remove(this.isDocumentPlayingAudioChanged, value);
				if (this.isDocumentPlayingAudioChanged == null)
				{
					try
					{
						this._nativeICoreWebView2_8.remove_IsDocumentPlayingAudioChanged(this._isDocumentPlayingAudioChangedToken);
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

		public event EventHandler<Object> IsMutedChanged
		{
			add
			{
				if (this.isMutedChanged == null)
				{
					try
					{
						this._nativeICoreWebView2_8.add_IsMutedChanged(new CoreWebView2IsMutedChangedEventHandler(new CoreWebView2IsMutedChangedEventHandler.CallbackType(this.OnIsMutedChanged)), out this._isMutedChangedToken);
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
				this.isMutedChanged = (EventHandler<Object>)Delegate.Combine(this.isMutedChanged, value);
			}
			remove
			{
				this.isMutedChanged = (EventHandler<Object>)Delegate.Remove(this.isMutedChanged, value);
				if (this.isMutedChanged == null)
				{
					try
					{
						this._nativeICoreWebView2_8.remove_IsMutedChanged(this._isMutedChangedToken);
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

		public event EventHandler<CoreWebView2LaunchingExternalUriSchemeEventArgs> LaunchingExternalUriScheme
		{
			add
			{
				if (this.launchingExternalUriScheme == null)
				{
					try
					{
						this._nativeICoreWebView2_18.add_LaunchingExternalUriScheme(new CoreWebView2LaunchingExternalUriSchemeEventHandler(new CoreWebView2LaunchingExternalUriSchemeEventHandler.CallbackType(this.OnLaunchingExternalUriScheme)), out this._launchingExternalUriSchemeToken);
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
				this.launchingExternalUriScheme = (EventHandler<CoreWebView2LaunchingExternalUriSchemeEventArgs>)Delegate.Combine(this.launchingExternalUriScheme, value);
			}
			remove
			{
				this.launchingExternalUriScheme = (EventHandler<CoreWebView2LaunchingExternalUriSchemeEventArgs>)Delegate.Remove(this.launchingExternalUriScheme, value);
				if (this.launchingExternalUriScheme == null)
				{
					try
					{
						this._nativeICoreWebView2_18.remove_LaunchingExternalUriScheme(this._launchingExternalUriSchemeToken);
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
						this._nativeICoreWebView2.add_NavigationCompleted(new CoreWebView2NavigationCompletedEventHandler(new CoreWebView2NavigationCompletedEventHandler.CallbackType(this.OnNavigationCompleted)), out this._navigationCompletedToken);
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
						this._nativeICoreWebView2.remove_NavigationCompleted(this._navigationCompletedToken);
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
						this._nativeICoreWebView2.add_NavigationStarting(new CoreWebView2NavigationStartingEventHandler(new CoreWebView2NavigationStartingEventHandler.CallbackType(this.OnNavigationStarting)), out this._navigationStartingToken);
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
						this._nativeICoreWebView2.remove_NavigationStarting(this._navigationStartingToken);
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

		public event EventHandler<CoreWebView2NewWindowRequestedEventArgs> NewWindowRequested
		{
			add
			{
				if (this.newWindowRequested == null)
				{
					try
					{
						this._nativeICoreWebView2.add_NewWindowRequested(new CoreWebView2NewWindowRequestedEventHandler(new CoreWebView2NewWindowRequestedEventHandler.CallbackType(this.OnNewWindowRequested)), out this._newWindowRequestedToken);
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
				this.newWindowRequested = (EventHandler<CoreWebView2NewWindowRequestedEventArgs>)Delegate.Combine(this.newWindowRequested, value);
			}
			remove
			{
				this.newWindowRequested = (EventHandler<CoreWebView2NewWindowRequestedEventArgs>)Delegate.Remove(this.newWindowRequested, value);
				if (this.newWindowRequested == null)
				{
					try
					{
						this._nativeICoreWebView2.remove_NewWindowRequested(this._newWindowRequestedToken);
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
						this._nativeICoreWebView2.add_PermissionRequested(new CoreWebView2PermissionRequestedEventHandler(new CoreWebView2PermissionRequestedEventHandler.CallbackType(this.OnPermissionRequested)), out this._permissionRequestedToken);
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
						this._nativeICoreWebView2.remove_PermissionRequested(this._permissionRequestedToken);
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

		public event EventHandler<CoreWebView2ProcessFailedEventArgs> ProcessFailed
		{
			add
			{
				if (this.processFailed == null)
				{
					try
					{
						this._nativeICoreWebView2.add_ProcessFailed(new CoreWebView2ProcessFailedEventHandler(new CoreWebView2ProcessFailedEventHandler.CallbackType(this.OnProcessFailed)), out this._processFailedToken);
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
				this.processFailed = (EventHandler<CoreWebView2ProcessFailedEventArgs>)Delegate.Combine(this.processFailed, value);
			}
			remove
			{
				this.processFailed = (EventHandler<CoreWebView2ProcessFailedEventArgs>)Delegate.Remove(this.processFailed, value);
				if (this.processFailed == null)
				{
					try
					{
						this._nativeICoreWebView2.remove_ProcessFailed(this._processFailedToken);
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

		public event EventHandler<CoreWebView2ScriptDialogOpeningEventArgs> ScriptDialogOpening
		{
			add
			{
				if (this.scriptDialogOpening == null)
				{
					try
					{
						this._nativeICoreWebView2.add_ScriptDialogOpening(new CoreWebView2ScriptDialogOpeningEventHandler(new CoreWebView2ScriptDialogOpeningEventHandler.CallbackType(this.OnScriptDialogOpening)), out this._scriptDialogOpeningToken);
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
				this.scriptDialogOpening = (EventHandler<CoreWebView2ScriptDialogOpeningEventArgs>)Delegate.Combine(this.scriptDialogOpening, value);
			}
			remove
			{
				this.scriptDialogOpening = (EventHandler<CoreWebView2ScriptDialogOpeningEventArgs>)Delegate.Remove(this.scriptDialogOpening, value);
				if (this.scriptDialogOpening == null)
				{
					try
					{
						this._nativeICoreWebView2.remove_ScriptDialogOpening(this._scriptDialogOpeningToken);
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

		public event EventHandler<CoreWebView2ServerCertificateErrorDetectedEventArgs> ServerCertificateErrorDetected
		{
			add
			{
				if (this.serverCertificateErrorDetected == null)
				{
					try
					{
						this._nativeICoreWebView2_14.add_ServerCertificateErrorDetected(new CoreWebView2ServerCertificateErrorDetectedEventHandler(new CoreWebView2ServerCertificateErrorDetectedEventHandler.CallbackType(this.OnServerCertificateErrorDetected)), out this._serverCertificateErrorDetectedToken);
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
				this.serverCertificateErrorDetected = (EventHandler<CoreWebView2ServerCertificateErrorDetectedEventArgs>)Delegate.Combine(this.serverCertificateErrorDetected, value);
			}
			remove
			{
				this.serverCertificateErrorDetected = (EventHandler<CoreWebView2ServerCertificateErrorDetectedEventArgs>)Delegate.Remove(this.serverCertificateErrorDetected, value);
				if (this.serverCertificateErrorDetected == null)
				{
					try
					{
						this._nativeICoreWebView2_14.remove_ServerCertificateErrorDetected(this._serverCertificateErrorDetectedToken);
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

		public event EventHandler<CoreWebView2SourceChangedEventArgs> SourceChanged
		{
			add
			{
				if (this.sourceChanged == null)
				{
					try
					{
						this._nativeICoreWebView2.add_SourceChanged(new CoreWebView2SourceChangedEventHandler(new CoreWebView2SourceChangedEventHandler.CallbackType(this.OnSourceChanged)), out this._sourceChangedToken);
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
				this.sourceChanged = (EventHandler<CoreWebView2SourceChangedEventArgs>)Delegate.Combine(this.sourceChanged, value);
			}
			remove
			{
				this.sourceChanged = (EventHandler<CoreWebView2SourceChangedEventArgs>)Delegate.Remove(this.sourceChanged, value);
				if (this.sourceChanged == null)
				{
					try
					{
						this._nativeICoreWebView2.remove_SourceChanged(this._sourceChangedToken);
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

		public event EventHandler<Object> StatusBarTextChanged
		{
			add
			{
				if (this.statusBarTextChanged == null)
				{
					try
					{
						this._nativeICoreWebView2_12.add_StatusBarTextChanged(new CoreWebView2StatusBarTextChangedEventHandler(new CoreWebView2StatusBarTextChangedEventHandler.CallbackType(this.OnStatusBarTextChanged)), out this._statusBarTextChangedToken);
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
				this.statusBarTextChanged = (EventHandler<Object>)Delegate.Combine(this.statusBarTextChanged, value);
			}
			remove
			{
				this.statusBarTextChanged = (EventHandler<Object>)Delegate.Remove(this.statusBarTextChanged, value);
				if (this.statusBarTextChanged == null)
				{
					try
					{
						this._nativeICoreWebView2_12.remove_StatusBarTextChanged(this._statusBarTextChangedToken);
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
						this._nativeICoreWebView2.add_WebMessageReceived(new CoreWebView2WebMessageReceivedEventHandler(new CoreWebView2WebMessageReceivedEventHandler.CallbackType(this.OnWebMessageReceived)), out this._webMessageReceivedToken);
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
						this._nativeICoreWebView2.remove_WebMessageReceived(this._webMessageReceivedToken);
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

		public event EventHandler<CoreWebView2WebResourceRequestedEventArgs> WebResourceRequested
		{
			add
			{
				if (this.webResourceRequested == null)
				{
					try
					{
						this._nativeICoreWebView2.add_WebResourceRequested(new CoreWebView2WebResourceRequestedEventHandler(new CoreWebView2WebResourceRequestedEventHandler.CallbackType(this.OnWebResourceRequested)), out this._webResourceRequestedToken);
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
				this.webResourceRequested = (EventHandler<CoreWebView2WebResourceRequestedEventArgs>)Delegate.Combine(this.webResourceRequested, value);
			}
			remove
			{
				this.webResourceRequested = (EventHandler<CoreWebView2WebResourceRequestedEventArgs>)Delegate.Remove(this.webResourceRequested, value);
				if (this.webResourceRequested == null)
				{
					try
					{
						this._nativeICoreWebView2.remove_WebResourceRequested(this._webResourceRequestedToken);
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

		public event EventHandler<CoreWebView2WebResourceResponseReceivedEventArgs> WebResourceResponseReceived
		{
			add
			{
				if (this.webResourceResponseReceived == null)
				{
					try
					{
						this._nativeICoreWebView2_2.add_WebResourceResponseReceived(new CoreWebView2WebResourceResponseReceivedEventHandler(new CoreWebView2WebResourceResponseReceivedEventHandler.CallbackType(this.OnWebResourceResponseReceived)), out this._webResourceResponseReceivedToken);
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
				this.webResourceResponseReceived = (EventHandler<CoreWebView2WebResourceResponseReceivedEventArgs>)Delegate.Combine(this.webResourceResponseReceived, value);
			}
			remove
			{
				this.webResourceResponseReceived = (EventHandler<CoreWebView2WebResourceResponseReceivedEventArgs>)Delegate.Remove(this.webResourceResponseReceived, value);
				if (this.webResourceResponseReceived == null)
				{
					try
					{
						this._nativeICoreWebView2_2.remove_WebResourceResponseReceived(this._webResourceResponseReceivedToken);
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

		public event EventHandler<Object> WindowCloseRequested
		{
			add
			{
				if (this.windowCloseRequested == null)
				{
					try
					{
						this._nativeICoreWebView2.add_WindowCloseRequested(new CoreWebView2WindowCloseRequestedEventHandler(new CoreWebView2WindowCloseRequestedEventHandler.CallbackType(this.OnWindowCloseRequested)), out this._windowCloseRequestedToken);
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
				this.windowCloseRequested = (EventHandler<Object>)Delegate.Combine(this.windowCloseRequested, value);
			}
			remove
			{
				this.windowCloseRequested = (EventHandler<Object>)Delegate.Remove(this.windowCloseRequested, value);
				if (this.windowCloseRequested == null)
				{
					try
					{
						this._nativeICoreWebView2.remove_WindowCloseRequested(this._windowCloseRequestedToken);
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