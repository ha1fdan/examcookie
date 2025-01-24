using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Microsoft.Web.WebView2.Core
{
	internal class COMStreamWrapper : Stream
	{
		private IStream _istream;

		private IntPtr _mInt64;

		private Int64 _size;

		public override Boolean CanRead
		{
			get
			{
				return true;
			}
		}

		public override Boolean CanSeek
		{
			get
			{
				return false;
			}
		}

		public override Boolean CanWrite
		{
			get
			{
				return true;
			}
		}

		public override Int64 Length
		{
			get
			{
				STATSTG sTATSTG = new STATSTG();
				this._istream.Stat(ref sTATSTG, 1);
				return sTATSTG.cbSize;
			}
		}

		public override Int64 Position
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		public COMStreamWrapper(IStream source)
		{
			this._istream = source;
			this._mInt64 = Marshal.AllocCoTaskMem(8);
			try
			{
				this._size = this.get_Length();
				if (this._size > (Int64)0)
				{
					GC.AddMemoryPressure(this._size);
				}
			}
			catch (Exception exception)
			{
				String.Concat("Warning: The stream does not implement Stat properly, therefore it will not be possible to detect its size and report to .NET GC so it can be cleaned up. If it uses any unmanaged memory this may cause out of memory issues. Exception message: ", exception.get_Message());
			}
		}

		protected override Void Finalize()
		{
			try
			{
				this._istream = null;
				Marshal.FreeCoTaskMem(this._mInt64);
				if (this._size > (Int64)0)
				{
					GC.RemoveMemoryPressure(this._size);
					this._size = (Int64)0;
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		public override Void Flush()
		{
			this._istream.Commit(0);
		}

		public override Int32 Read(Byte[] buffer, Int32 offset, Int32 count)
		{
			if (offset != 0)
			{
				throw new NotImplementedException();
			}
			this._istream.Read(buffer, count, this._mInt64);
			return Marshal.ReadInt32(this._mInt64);
		}

		public override Int64 Seek(Int64 offset, SeekOrigin origin)
		{
			this._istream.Seek(offset, origin, this._mInt64);
			return Marshal.ReadInt64(this._mInt64);
		}

		public override Void SetLength(Int64 value)
		{
			this._istream.SetSize(value);
		}

		public override Void Write(Byte[] buffer, Int32 offset, Int32 count)
		{
			if (offset != 0)
			{
				throw new NotImplementedException();
			}
			this._istream.Write(buffer, count, IntPtr.Zero);
		}
	}
}