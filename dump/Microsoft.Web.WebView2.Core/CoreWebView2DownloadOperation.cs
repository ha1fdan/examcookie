using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2DownloadOperation
	{
		internal ICoreWebView2DownloadOperation _nativeICoreWebView2DownloadOperationValue;

		internal Object _rawNative;

		private EventRegistrationToken _bytesReceivedChangedToken;

		private EventHandler<Object> bytesReceivedChanged;

		private EventRegistrationToken _estimatedEndTimeChangedToken;

		private EventHandler<Object> estimatedEndTimeChanged;

		private EventRegistrationToken _stateChangedToken;

		private EventHandler<Object> stateChanged;

		internal ICoreWebView2DownloadOperation _nativeICoreWebView2DownloadOperation
		{
			get
			{
				if (this._nativeICoreWebView2DownloadOperationValue == null)
				{
					try
					{
						this._nativeICoreWebView2DownloadOperationValue = (ICoreWebView2DownloadOperation)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DownloadOperation.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2DownloadOperationValue;
			}
			set
			{
				this._nativeICoreWebView2DownloadOperationValue = value;
			}
		}

		public Int64 BytesReceived
		{
			get
			{
				Int64 bytesReceived;
				try
				{
					bytesReceived = this._nativeICoreWebView2DownloadOperation.BytesReceived;
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
				return bytesReceived;
			}
		}

		public Boolean CanResume
		{
			get
			{
				Boolean canResume;
				try
				{
					canResume = this._nativeICoreWebView2DownloadOperation.CanResume != 0;
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
				return canResume;
			}
		}

		public String ContentDisposition
		{
			get
			{
				String contentDisposition;
				try
				{
					contentDisposition = this._nativeICoreWebView2DownloadOperation.ContentDisposition;
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
				return contentDisposition;
			}
		}

		public DateTime EstimatedEndTime
		{
			get
			{
				return DateTime.Parse(this._nativeICoreWebView2DownloadOperation.EstimatedEndTime);
			}
		}

		public CoreWebView2DownloadInterruptReason InterruptReason
		{
			get
			{
				CoreWebView2DownloadInterruptReason interruptReason;
				try
				{
					interruptReason = (CoreWebView2DownloadInterruptReason)this._nativeICoreWebView2DownloadOperation.InterruptReason;
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
				return interruptReason;
			}
		}

		public String MimeType
		{
			get
			{
				String mimeType;
				try
				{
					mimeType = this._nativeICoreWebView2DownloadOperation.MimeType;
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
				return mimeType;
			}
		}

		public String ResultFilePath
		{
			get
			{
				String resultFilePath;
				try
				{
					resultFilePath = this._nativeICoreWebView2DownloadOperation.ResultFilePath;
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
				return resultFilePath;
			}
		}

		public CoreWebView2DownloadState State
		{
			get
			{
				CoreWebView2DownloadState state;
				try
				{
					state = (CoreWebView2DownloadState)this._nativeICoreWebView2DownloadOperation.State;
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
				return state;
			}
		}

		public UInt64? TotalBytesToReceive
		{
			get
			{
				if (this._nativeICoreWebView2DownloadOperation.TotalBytesToReceive < (Int64)0)
				{
					return null;
				}
				return new UInt64?((UInt64)this._nativeICoreWebView2DownloadOperation.TotalBytesToReceive);
			}
		}

		public String Uri
		{
			get
			{
				String uri;
				try
				{
					uri = this._nativeICoreWebView2DownloadOperation.Uri;
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

		internal CoreWebView2DownloadOperation(Object rawCoreWebView2DownloadOperation)
		{
			this._rawNative = rawCoreWebView2DownloadOperation;
		}

		public Void Cancel()
		{
			try
			{
				this._nativeICoreWebView2DownloadOperation.Cancel();
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

		internal Void OnBytesReceivedChanged(Object args)
		{
			EventHandler<Object> eventHandler = this.bytesReceivedChanged;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnEstimatedEndTimeChanged(Object args)
		{
			EventHandler<Object> eventHandler = this.estimatedEndTimeChanged;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		internal Void OnStateChanged(Object args)
		{
			EventHandler<Object> eventHandler = this.stateChanged;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, args);
		}

		public Void Pause()
		{
			try
			{
				this._nativeICoreWebView2DownloadOperation.Pause();
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
				this._nativeICoreWebView2DownloadOperation.Resume();
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

		public event EventHandler<Object> BytesReceivedChanged
		{
			add
			{
				if (this.bytesReceivedChanged == null)
				{
					try
					{
						this._nativeICoreWebView2DownloadOperation.add_BytesReceivedChanged(new CoreWebView2BytesReceivedChangedEventHandler(new CoreWebView2BytesReceivedChangedEventHandler.CallbackType(this.OnBytesReceivedChanged)), out this._bytesReceivedChangedToken);
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
				this.bytesReceivedChanged = (EventHandler<Object>)Delegate.Combine(this.bytesReceivedChanged, value);
			}
			remove
			{
				this.bytesReceivedChanged = (EventHandler<Object>)Delegate.Remove(this.bytesReceivedChanged, value);
				if (this.bytesReceivedChanged == null)
				{
					try
					{
						this._nativeICoreWebView2DownloadOperation.remove_BytesReceivedChanged(this._bytesReceivedChangedToken);
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

		public event EventHandler<Object> EstimatedEndTimeChanged
		{
			add
			{
				if (this.estimatedEndTimeChanged == null)
				{
					try
					{
						this._nativeICoreWebView2DownloadOperation.add_EstimatedEndTimeChanged(new CoreWebView2EstimatedEndTimeChangedEventHandler(new CoreWebView2EstimatedEndTimeChangedEventHandler.CallbackType(this.OnEstimatedEndTimeChanged)), out this._estimatedEndTimeChangedToken);
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
				this.estimatedEndTimeChanged = (EventHandler<Object>)Delegate.Combine(this.estimatedEndTimeChanged, value);
			}
			remove
			{
				this.estimatedEndTimeChanged = (EventHandler<Object>)Delegate.Remove(this.estimatedEndTimeChanged, value);
				if (this.estimatedEndTimeChanged == null)
				{
					try
					{
						this._nativeICoreWebView2DownloadOperation.remove_EstimatedEndTimeChanged(this._estimatedEndTimeChangedToken);
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

		public event EventHandler<Object> StateChanged
		{
			add
			{
				if (this.stateChanged == null)
				{
					try
					{
						this._nativeICoreWebView2DownloadOperation.add_StateChanged(new CoreWebView2StateChangedEventHandler(new CoreWebView2StateChangedEventHandler.CallbackType(this.OnStateChanged)), out this._stateChangedToken);
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
				this.stateChanged = (EventHandler<Object>)Delegate.Combine(this.stateChanged, value);
			}
			remove
			{
				this.stateChanged = (EventHandler<Object>)Delegate.Remove(this.stateChanged, value);
				if (this.stateChanged == null)
				{
					try
					{
						this._nativeICoreWebView2DownloadOperation.remove_StateChanged(this._stateChangedToken);
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