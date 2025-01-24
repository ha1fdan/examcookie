using ExamCookie.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ExamCookie.WinClient
{
	public class ClipboardThread
	{
		private Int32 Polltime;

		private IntPtr Handle;

		private Stopwatch Delay1;

		private Stopwatch Delay2;

		private Boolean _Started;

		private Single _ImageScaling;

		public Single ImageScaling
		{
			get
			{
				return this._ImageScaling;
			}
			set
			{
				if ((Double)value < 0.5)
				{
					this._ImageScaling = 0.5f;
				}
				else if ((Double)value <= 1)
				{
					this._ImageScaling = value;
				}
				else
				{
					this._ImageScaling = 1f;
				}
			}
		}

		public Boolean Started
		{
			get
			{
				return this._Started;
			}
			set
			{
				if (!value)
				{
					this.Delay1.Stop();
					ClipboardThread.RemoveClipboardFormatListener(this.Handle);
				}
				this._Started = value;
			}
		}

		public ClipboardThread()
		{
			this.Polltime = 0;
			this.Handle = IntPtr.Zero;
			this.Delay1 = new Stopwatch();
			this.Delay2 = new Stopwatch();
			this._Started = false;
			this._ImageScaling = 0.6f;
		}

		public ClipboardThread(Int32 polltime, IntPtr handle)
		{
			this.Polltime = 0;
			this.Handle = IntPtr.Zero;
			this.Delay1 = new Stopwatch();
			this.Delay2 = new Stopwatch();
			this._Started = false;
			this._ImageScaling = 0.6f;
			if (polltime > 0)
			{
				this.Polltime = Conversions.ToInteger(Interaction.IIf(polltime < 500, 500, polltime));
				this.Handle = handle;
				ClipboardThread.OpenClipboard(IntPtr.Zero);
				ClipboardThread.EmptyClipboard();
				ClipboardThread.CloseClipboard();
				ClipboardThread.AddClipboardFormatListener(handle);
				this.Started = true;
				this.Delay1.Start();
				this.Delay2.Start();
			}
		}

		[DllImport("user32.dll", CharSet=1, ExactSpelling=false, SetLastError=true)]
		private static extern Boolean AddClipboardFormatListener(IntPtr hWnd);

		[DllImport("user32.dll", CharSet=1, ExactSpelling=false, SetLastError=true)]
		private static extern Boolean CloseClipboard();

		[DllImport("user32.dll", CharSet=1, ExactSpelling=false)]
		private static extern Boolean EmptyClipboard();

		public Void GetClipboardData()
		{
			Byte[] array;
			Byte[] numArray;
			String end;
			try
			{
				if (!(!this.Started | this.Polltime == 0 | this.Delay1.get_ElapsedMilliseconds() < (Int64)this.Polltime | this.Delay2.get_ElapsedMilliseconds() < (Int64)3000))
				{
					this.Delay1.Restart();
					this.Delay2.Restart();
					ClipboardThread.ClipboardChanged clipboardChanged = new ClipboardThread.ClipboardChanged();
					if (System.Windows.Forms.Clipboard.ContainsData(DataFormats.CommaSeparatedValue))
					{
						StreamReader streamReader = new StreamReader((Stream)System.Windows.Forms.Clipboard.GetData(DataFormats.CommaSeparatedValue));
						try
						{
							if (streamReader != null)
							{
								end = streamReader.ReadToEnd();
							}
							else
							{
								end = null;
							}
							clipboardChanged.Data = Encoding.get_UTF8().GetBytes(end);
						}
						finally
						{
							if (streamReader != null)
							{
								streamReader.Dispose();
							}
						}
						clipboardChanged.Format = eDataFormat.CSV;
					}
					else if (System.Windows.Forms.Clipboard.ContainsData(DataFormats.Bitmap))
					{
						MemoryStream memoryStream = new MemoryStream();
						try
						{
							((Bitmap)System.Windows.Forms.Clipboard.GetData(DataFormats.Bitmap)).Save(memoryStream, ImageFormat.get_Jpeg());
							ClipboardThread.ClipboardChanged clipboardChanged1 = clipboardChanged;
							if (memoryStream != null)
							{
								numArray = memoryStream.ToArray();
							}
							else
							{
								numArray = null;
							}
							clipboardChanged1.Data = numArray;
						}
						finally
						{
							if (memoryStream != null)
							{
								memoryStream.Dispose();
							}
						}
						clipboardChanged.Format = eDataFormat.IMAGE;
					}
					else if (System.Windows.Forms.Clipboard.ContainsImage())
					{
						MemoryStream memoryStream1 = new MemoryStream();
						try
						{
							System.Windows.Forms.Clipboard.GetImage().Save(memoryStream1, ImageFormat.get_Jpeg());
							ClipboardThread.ClipboardChanged clipboardChanged2 = clipboardChanged;
							if (memoryStream1 != null)
							{
								array = memoryStream1.ToArray();
							}
							else
							{
								array = null;
							}
							clipboardChanged2.Data = array;
						}
						finally
						{
							if (memoryStream1 != null)
							{
								memoryStream1.Dispose();
							}
						}
						clipboardChanged.Format = eDataFormat.IMAGE;
					}
					else if (System.Windows.Forms.Clipboard.ContainsData(DataFormats.FileDrop))
					{
						List<String> list = new List<String>();
						StringEnumerator enumerator = System.Windows.Forms.Clipboard.GetFileDropList().GetEnumerator();
						while (enumerator.MoveNext())
						{
							String current = enumerator.get_Current();
							if ((object)current != (object)null)
							{
								list.Add(current);
							}
						}
						clipboardChanged.Data = Encoding.get_UTF8().GetBytes(Strings.Join(list.ToArray(), "\r\n"));
						clipboardChanged.Format = eDataFormat.FILE_LIST;
					}
					else if (System.Windows.Forms.Clipboard.ContainsFileDropList())
					{
						List<String> list1 = new List<String>();
						StringEnumerator stringEnumerator = System.Windows.Forms.Clipboard.GetFileDropList().GetEnumerator();
						while (stringEnumerator.MoveNext())
						{
							String str = stringEnumerator.get_Current();
							if ((object)str != (object)null)
							{
								list1.Add(str);
							}
						}
						clipboardChanged.Data = Encoding.get_UTF8().GetBytes(Strings.Join(list1.ToArray(), "\r\n"));
						clipboardChanged.Format = eDataFormat.FILE_LIST;
					}
					else if (System.Windows.Forms.Clipboard.ContainsData(DataFormats.Rtf))
					{
						clipboardChanged.Data = (Byte[])NewLateBinding.LateGet(Encoding.get_UTF8(), null, "GetBytes", new Object[] { System.Windows.Forms.Clipboard.GetData(DataFormats.Rtf) }, null, null, null);
						clipboardChanged.Format = eDataFormat.RTF;
					}
					else if (System.Windows.Forms.Clipboard.ContainsData(DataFormats.Text))
					{
						clipboardChanged.Data = Encoding.get_UTF8().GetBytes(System.Windows.Forms.Clipboard.GetText());
						clipboardChanged.Format = eDataFormat.TEXT;
					}
					else if (System.Windows.Forms.Clipboard.ContainsText())
					{
						clipboardChanged.Data = Encoding.get_UTF8().GetBytes(System.Windows.Forms.Clipboard.GetText());
						clipboardChanged.Format = eDataFormat.TEXT;
					}
					else if (System.Windows.Forms.Clipboard.ContainsData(DataFormats.Dib))
					{
						Module1.DebugPrint("ContainsData.Dib", new Object[0]);
					}
					else if (System.Windows.Forms.Clipboard.ContainsData(DataFormats.Dif))
					{
						Module1.DebugPrint("ContainsData.Dif", new Object[0]);
					}
					else if (System.Windows.Forms.Clipboard.ContainsData(DataFormats.EnhancedMetafile))
					{
						Module1.DebugPrint("ContainsData.EnhancedMetafile", new Object[0]);
					}
					else if (System.Windows.Forms.Clipboard.ContainsData(DataFormats.Html))
					{
						Module1.DebugPrint("ContainsData.Html", new Object[0]);
					}
					else if (System.Windows.Forms.Clipboard.ContainsData(DataFormats.MetafilePict))
					{
						Module1.DebugPrint("ContainsData.MetafilePict", new Object[0]);
					}
					else if (System.Windows.Forms.Clipboard.ContainsData(DataFormats.Palette))
					{
						Module1.DebugPrint("ContainsData.Palette", new Object[0]);
					}
					else if (System.Windows.Forms.Clipboard.ContainsData(DataFormats.PenData))
					{
						Module1.DebugPrint("ContainsData.PenData", new Object[0]);
					}
					else if (System.Windows.Forms.Clipboard.ContainsData(DataFormats.Riff))
					{
						Module1.DebugPrint("ContainsData.Riff", new Object[0]);
					}
					else if (System.Windows.Forms.Clipboard.ContainsData(DataFormats.Serializable))
					{
						Module1.DebugPrint("ContainsData.Serializable", new Object[0]);
					}
					else if (System.Windows.Forms.Clipboard.ContainsData(DataFormats.StringFormat))
					{
						Module1.DebugPrint("ContainsData.StringFormat", new Object[0]);
					}
					else if (System.Windows.Forms.Clipboard.ContainsData(DataFormats.SymbolicLink))
					{
						Module1.DebugPrint("ContainsData.SymbolicLink", new Object[0]);
					}
					else if (System.Windows.Forms.Clipboard.ContainsData(DataFormats.Tiff))
					{
						Module1.DebugPrint("ContainsData.Tiff", new Object[0]);
					}
					else if (System.Windows.Forms.Clipboard.ContainsData(DataFormats.UnicodeText))
					{
						Module1.DebugPrint("ContainsData.UnicodeText", new Object[0]);
					}
					else if (!System.Windows.Forms.Clipboard.ContainsData(DataFormats.WaveAudio))
					{
						clipboardChanged.Data = null;
						clipboardChanged.Format = eDataFormat.NONE;
					}
					else
					{
						Module1.DebugPrint("ContainsData.WaveAudio", new Object[0]);
					}
					ClipboardThread.OnDebugEventHandler onDebugEventHandler = this.OnDebug;
					if (onDebugEventHandler != null)
					{
						onDebugEventHandler(String.Concat("CLIPBOARD: ", clipboardChanged.Format.ToString()));
					}
					ClipboardThread.OnClipboardChangedEventHandler onClipboardChangedEventHandler = this.OnClipboardChanged;
					if (onClipboardChangedEventHandler != null)
					{
						onClipboardChangedEventHandler(clipboardChanged);
					}
				}
				else
				{
					return;
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				ProjectData.ClearProjectError();
			}
		}

		[DllImport("user32.dll", CharSet=1, ExactSpelling=false)]
		private static extern IntPtr GetOpenClipboardWindow();

		[DllImport("user32.dll", CharSet=1, ExactSpelling=false)]
		private static extern Boolean OpenClipboard(IntPtr hWndNewOwner);

		[DllImport("user32.dll", CharSet=1, ExactSpelling=false, SetLastError=true)]
		private static extern Boolean RemoveClipboardFormatListener(IntPtr hWnd);

		private Int32 ResizeImage(Single scale, Image image, ref Image resized)
		{
			Int32 num;
			try
			{
				Int32 num1 = checked((Int32)Math.Round((Double)((Single)image.get_Width() * scale)));
				Int32 num2 = checked((Int32)Math.Round((Double)((Single)image.get_Height() * scale)));
				Bitmap bitmap = new Bitmap(num1, num2);
				try
				{
					Graphics graphic = Graphics.FromImage(bitmap);
					try
					{
						graphic.set_CompositingQuality(2);
						graphic.set_SmoothingMode(2);
						graphic.set_InterpolationMode(6);
						graphic.DrawImage(image, new Rectangle(0, 0, num1, num2));
						resized = (Image)bitmap.Clone();
						num = 0;
					}
					finally
					{
						if (graphic != null)
						{
							graphic.Dispose();
						}
					}
				}
				finally
				{
					if (bitmap != null)
					{
						bitmap.Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				num = -1;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		public event ClipboardThread.OnClipboardChangedEventHandler OnClipboardChanged;

		public event ClipboardThread.OnDebugEventHandler OnDebug;

		public event ClipboardThread.OnExceptionEventHandler OnException;

		[Serializable]
		public class ClipboardChanged
		{
			public String Reference;

			public String Token;

			public DateTime CanSend;

			public DateTime TimeStamp;

			public eDataFormat Format;

			public Byte[] Data;

			public ClipboardChanged()
			{
				this.Reference = Guid.NewGuid().ToString();
				this.Token = "";
				this.CanSend = DateTime.MinValue;
				this.TimeStamp = DateTime.MinValue;
				this.Format = eDataFormat.NONE;
				this.Data = null;
			}

			public ClipboardChanged(eDataFormat format, Byte[] data)
			{
				this.Reference = Guid.NewGuid().ToString();
				this.Token = "";
				this.CanSend = DateTime.MinValue;
				this.TimeStamp = DateTime.MinValue;
				this.Format = eDataFormat.NONE;
				this.Data = null;
				this.Format = format;
				this.Data = data;
			}
		}

		public delegate Void OnClipboardChangedEventHandler(ClipboardThread.ClipboardChanged sender);

		public delegate Void OnDebugEventHandler(String message);

		public delegate Void OnExceptionEventHandler(Exception ex);
	}
}