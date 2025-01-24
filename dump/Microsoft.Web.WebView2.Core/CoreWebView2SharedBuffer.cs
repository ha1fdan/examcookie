using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2SharedBuffer : IDisposable
	{
		private Boolean _disposed;

		private CoreWebView2SharedBuffer.WebView2SharedBufferSafeHandle _safeFileMappingHandle;

		internal ICoreWebView2SharedBuffer _nativeICoreWebView2SharedBufferValue;

		internal Object _rawNative;

		internal ICoreWebView2SharedBuffer _nativeICoreWebView2SharedBuffer
		{
			get
			{
				if (this._nativeICoreWebView2SharedBufferValue == null)
				{
					try
					{
						this._nativeICoreWebView2SharedBufferValue = (ICoreWebView2SharedBuffer)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2SharedBuffer.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2SharedBufferValue;
			}
			set
			{
				this._nativeICoreWebView2SharedBufferValue = value;
			}
		}

		public IntPtr Buffer
		{
			get
			{
				IntPtr buffer;
				try
				{
					buffer = this._nativeICoreWebView2SharedBuffer.Buffer;
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
				return buffer;
			}
		}

		public SafeHandle FileMappingHandle
		{
			get
			{
				if (!this._disposed && this._safeFileMappingHandle == null)
				{
					this._safeFileMappingHandle = new CoreWebView2SharedBuffer.WebView2SharedBufferSafeHandle(this);
				}
				return this._safeFileMappingHandle;
			}
		}

		public UInt64 Size
		{
			get
			{
				UInt64 size;
				try
				{
					size = this._nativeICoreWebView2SharedBuffer.Size;
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
				return size;
			}
		}

		internal IntPtr UnsafeFileMappingHandle
		{
			get
			{
				IntPtr fileMappingHandle;
				try
				{
					fileMappingHandle = this._nativeICoreWebView2SharedBuffer.FileMappingHandle;
				}
				catch (Exception exception)
				{
					fileMappingHandle = IntPtr.Zero;
				}
				return fileMappingHandle;
			}
		}

		internal CoreWebView2SharedBuffer(Object rawCoreWebView2SharedBuffer)
		{
			this._rawNative = rawCoreWebView2SharedBuffer;
		}

		public Void Close()
		{
			try
			{
				this._nativeICoreWebView2SharedBuffer.Close();
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

		public Void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual Void Dispose(Boolean disposing)
		{
			if (this._disposed)
			{
				return;
			}
			this._disposed = true;
			this.Close();
			if (disposing && this._safeFileMappingHandle != null)
			{
				this._safeFileMappingHandle.SetHandleAsInvalid();
				this._safeFileMappingHandle = null;
			}
		}

		public Stream OpenStream()
		{
			Stream net;
			try
			{
				net = COMDotNetTypeConverter.StreamCOMToNet(this._nativeICoreWebView2SharedBuffer.OpenStream());
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

		internal class WebView2SharedBufferSafeHandle : SafeHandle
		{
			protected CoreWebView2SharedBuffer _shared_buffer;

			public override Boolean IsInvalid
			{
				get
				{
					if (base.get_IsClosed() || this._shared_buffer == null)
					{
						return true;
					}
					return this._shared_buffer.UnsafeFileMappingHandle == IntPtr.Zero;
				}
			}

			public WebView2SharedBufferSafeHandle(CoreWebView2SharedBuffer shared_buffer) : base(IntPtr.Zero, false)
			{
				IntPtr unsafeFileMappingHandle = shared_buffer.UnsafeFileMappingHandle;
				if (unsafeFileMappingHandle != IntPtr.Zero)
				{
					base.SetHandle(unsafeFileMappingHandle);
					this._shared_buffer = shared_buffer;
				}
			}

			protected override Boolean ReleaseHandle()
			{
				this._shared_buffer = null;
				return true;
			}
		}
	}
}