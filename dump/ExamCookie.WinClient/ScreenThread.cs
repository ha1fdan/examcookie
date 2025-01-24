using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ExamCookie.WinClient
{
	public class ScreenThread
	{
		private const Int32 THREAD_SLEEP = 500;

		private Boolean _Started;

		private Single _ScreenChangedPercent;

		private Int32 _ImageQuality;

		private Int32 _PostSendDelay;

		private Stopwatch _ForceScreenshotStopwatch;

		private Int32 _ForceScreenshotDelay;

		private Boolean _TakeScreenshot;

		private Rectangle _TakeScreenshotAtPoint;

		private List<ScreenThread.Monitor> _Monitors;

		public Int32 ForceScreenshotDelay
		{
			get
			{
				return this._ForceScreenshotDelay;
			}
			set
			{
				if (value != 0)
				{
					this._ForceScreenshotStopwatch.Restart();
				}
				else
				{
					this._ForceScreenshotStopwatch.Stop();
				}
				this._ForceScreenshotDelay = value;
			}
		}

		public Int32 ImageQuality
		{
			get
			{
				return this._ImageQuality;
			}
			set
			{
				if (value < 5)
				{
					this._ImageQuality = 5;
				}
				else if (value <= 100)
				{
					this._ImageQuality = value;
				}
				else
				{
					this._ImageQuality = 100;
				}
			}
		}

		public Int32 PostSendDelay
		{
			get
			{
				return this._PostSendDelay;
			}
			set
			{
				this._PostSendDelay = value;
			}
		}

		public Single ScreenChangedPercent
		{
			get
			{
				return this._ScreenChangedPercent;
			}
			set
			{
				if (value != 0f)
				{
					if ((Double)value < 3)
					{
						value = 3f;
					}
					else if ((Double)value > 50)
					{
						value = 50f;
					}
				}
				this._ScreenChangedPercent = value;
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
				this._Started = value;
			}
		}

		private virtual Timer TakeScreenshotAtPointDelay
		{
			get
			{
				stackVariable1 = this._TakeScreenshotAtPointDelay;
				return stackVariable1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this, ScreenThread.OnTakeScreenshotAtPointDelay);
				Timer timer = this._TakeScreenshotAtPointDelay;
				if (timer != null)
				{
					timer.remove_Tick(eventHandler);
				}
				this._TakeScreenshotAtPointDelay = value;
				timer = this._TakeScreenshotAtPointDelay;
				if (timer != null)
				{
					timer.add_Tick(eventHandler);
				}
			}
		}

		private virtual Timer TakeScreenshotDelay
		{
			get
			{
				stackVariable1 = this._TakeScreenshotDelay;
				return stackVariable1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this, ScreenThread.OnTakeScreenshotDelay);
				Timer timer = this._TakeScreenshotDelay;
				if (timer != null)
				{
					timer.remove_Tick(eventHandler);
				}
				this._TakeScreenshotDelay = value;
				timer = this._TakeScreenshotDelay;
				if (timer != null)
				{
					timer.add_Tick(eventHandler);
				}
			}
		}

		public ScreenThread()
		{
			this._Started = false;
			this._ScreenChangedPercent = 0f;
			this._ImageQuality = 20;
			this._PostSendDelay = 0;
			this._ForceScreenshotStopwatch = new Stopwatch();
			this._ForceScreenshotDelay = 0;
			this._TakeScreenshot = false;
			this.TakeScreenshotDelay = new Timer();
			this._TakeScreenshotAtPoint = Rectangle.Empty;
			this.TakeScreenshotAtPointDelay = new Timer();
			this._Monitors = new List<ScreenThread.Monitor>();
		}

		public ScreenThread(Int32 polltime)
		{
			Int32 num = polltime;
			base();
			ScreenThread._Closureu0024__17u002d0 variable = null;
			this._Started = false;
			this._ScreenChangedPercent = 0f;
			this._ImageQuality = 20;
			this._PostSendDelay = 0;
			this._ForceScreenshotStopwatch = new Stopwatch();
			this._ForceScreenshotDelay = 0;
			this._TakeScreenshot = false;
			this.TakeScreenshotDelay = new Timer();
			this._TakeScreenshotAtPoint = Rectangle.Empty;
			this.TakeScreenshotAtPointDelay = new Timer();
			this._Monitors = new List<ScreenThread.Monitor>();
			if (num > 0)
			{
				if (num < 500)
				{
					num = 500;
				}
				Thread thread = new Thread(new ThreadStart(variable, () => this.u0024VBu0024Me.Main(this.u0024VBu0024Local_polltime)));
				this.Started = true;
				thread.Start();
			}
		}

		private Int64[] CalculateRgbSum(Image image)
		{
			// 
			// Current member / type: System.Int64[] ExamCookie.WinClient.ScreenThread::CalculateRgbSum(System.Drawing.Image)
			// File path: /home/halfdan/Downloads/ExamCookie1414.WinClient.exe
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Int64[] CalculateRgbSum(System.Drawing.Image)
			// 
			// Managed pointer usage not in SSA
			//    at Telerik.JustDecompiler.Steps.ManagedPointersRemovalStep.CheckForAssignment(BinaryExpression node) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Steps/ManagedPointersRemovalStep.cs:line 100
			//    at Telerik.JustDecompiler.Steps.ManagedPointersRemovalStep.VisitBinaryExpression(BinaryExpression node) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Steps/ManagedPointersRemovalStep.cs:line 76
			//    at Telerik.JustDecompiler.Ast.BaseCodeVisitor.Visit(ICodeNode node) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Ast/BaseCodeVisitor.cs:line 141
			//    at Telerik.JustDecompiler.Steps.ManagedPointersRemovalStep.VisitExpressions() in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Steps/ManagedPointersRemovalStep.cs:line 38
			//    at Telerik.JustDecompiler.Steps.ManagedPointersRemovalStep.Process(DecompilationContext context, BlockStatement body) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Steps/ManagedPointersRemovalStep.cs:line 22
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/DecompilationPipeline.cs:line 88
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.Run(MethodBody body, ILanguage language) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.RunPipeline(DecompilationPipeline pipeline, ILanguage language, MethodBody body, DecompilationContext& context) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.Decompile(MethodBody body, ILanguage language, DecompilationContext& context, TypeSpecificContext typeContext) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/Extensions.cs:line 61
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/WriterContextServices/BaseWriterContextService.cs:line 118
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		private Int32 CaptureScreen(Int32 x, Int32 y, Int32 width, Int32 height, ref Image image)
		{
			Int32 num;
			try
			{
				Bitmap bitmap = new Bitmap(width, height);
				try
				{
					Graphics graphic = Graphics.FromImage(bitmap);
					try
					{
						graphic.CopyFromScreen(x, y, 0, 0, new Size(width, height));
						image = (Image)bitmap.Clone();
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
			catch (Win32Exception win32Exception1)
			{
				ProjectData.SetProjectError(win32Exception1);
				Win32Exception win32Exception = win32Exception1;
				ScreenThread.OnExceptionEventHandler onExceptionEventHandler = this.OnException;
				if (onExceptionEventHandler != null)
				{
					onExceptionEventHandler(win32Exception);
				}
				num = -2;
				ProjectData.ClearProjectError();
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				ScreenThread.OnExceptionEventHandler onExceptionEventHandler1 = this.OnException;
				if (onExceptionEventHandler1 != null)
				{
					onExceptionEventHandler1(exception);
				}
				num = -1;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		private Int32 CaptureScreen(ref ScreenThread.Monitor monitor)
		{
			Int32 num;
			try
			{
				if (monitor.Changed)
				{
					Int32 width = monitor.Bounds().get_Width();
					Rectangle rectangle = monitor.Bounds();
					Bitmap bitmap = new Bitmap(width, rectangle.get_Height());
					try
					{
						Graphics graphic = Graphics.FromImage(bitmap);
						try
						{
							Int32 x = monitor.Bounds().get_X();
							Int32 y = monitor.Bounds().get_Y();
							Int32 width1 = monitor.Bounds().get_Width();
							rectangle = monitor.Bounds();
							graphic.CopyFromScreen(x, y, 0, 0, new Size(width1, rectangle.get_Height()));
							monitor.Frame = (Image)bitmap.Clone();
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
				else
				{
					num = 0;
				}
			}
			catch (Win32Exception win32Exception1)
			{
				ProjectData.SetProjectError(win32Exception1);
				Win32Exception win32Exception = win32Exception1;
				ScreenThread.OnExceptionEventHandler onExceptionEventHandler = this.OnException;
				if (onExceptionEventHandler != null)
				{
					onExceptionEventHandler(win32Exception);
				}
				num = -2;
				ProjectData.ClearProjectError();
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				ScreenThread.OnExceptionEventHandler onExceptionEventHandler1 = this.OnException;
				if (onExceptionEventHandler1 != null)
				{
					onExceptionEventHandler1(exception);
				}
				num = -1;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		private Single CompareImagesPixelBased(Image image1, Image image2, Byte threshold = 3)
		{
			Byte[,] differences = image1.GetDifferences(image2);
			Int32 num = 0;
			IEnumerator enumerator = differences.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (Conversions.ToByte(enumerator.get_Current()) > threshold)
				{
					num = checked(num + 1);
				}
			}
			return (Single)num / 256f * 100f;
		}

		private Single CompareImagesRgbBased(Image image1, Image image2)
		{
			Single single;
			try
			{
				Int64[] numArray = this.CalculateRgbSum(image1);
				Int64[] numArray1 = this.CalculateRgbSum(image2);
				UInt64 num = (UInt64)0;
				UInt64 num1 = (UInt64)0;
				Single single1 = 0f;
				if ((Int32)numArray.Length == (Int32)numArray1.Length)
				{
					Int32 length = checked((Int32)numArray.Length - 1);
					for (Int32 i = 0; i <= length; i = checked(i + 1))
					{
						num = Convert.ToUInt64(Decimal.Add(new Decimal(num), new Decimal(Math.Abs(checked(numArray[i] - numArray1[i])))));
						num1 = Convert.ToUInt64(Decimal.Add(new Decimal(num1), new Decimal(numArray[i])));
					}
					if (num <= num1)
					{
						single1 = (num1 <= num ? 1f : (Single)((Double)((Single)num) / (Double)((Single)num1)));
					}
					else
					{
						single1 = (Single)((Double)((Single)num1) / (Double)((Single)num));
					}
				}
				single = single1 * 100f;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				single = 0f;
				ProjectData.ClearProjectError();
			}
			return single;
		}

		public Int32 CompressImage(Int64 quality, Image image, ref Byte[] compressed)
		{
			Int32 num;
			try
			{
				MemoryStream memoryStream = new MemoryStream();
				try
				{
					EncoderParameters encoderParameter = new EncoderParameters(1);
					encoderParameter.get_Param()[0] = new EncoderParameter(Encoder.Quality, quality);
					ImageCodecInfo encoderInfo = this.GetEncoderInfo("image/jpeg");
					if ((object)encoderInfo == (object)null)
					{
						ScreenThread.OnExceptionEventHandler onExceptionEventHandler = this.OnException;
						if (onExceptionEventHandler != null)
						{
							onExceptionEventHandler(new Exception("CompressImage, encoder ikke fundet"));
						}
						num = 1;
					}
					else
					{
						image.Save(memoryStream, encoderInfo, encoderParameter);
						compressed = memoryStream.ToArray();
						num = 0;
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						memoryStream.Dispose();
					}
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				ScreenThread.OnExceptionEventHandler onExceptionEventHandler1 = this.OnException;
				if (onExceptionEventHandler1 != null)
				{
					onExceptionEventHandler1(exception);
				}
				num = -1;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		private ImageCodecInfo GetEncoderInfo(String mimeType)
		{
			ScreenThread._Closureu0024__61u002d0 variable = null;
			ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
			ImageCodecInfo imageCodecInfo = Enumerable.FirstOrDefault<ImageCodecInfo>(imageEncoders, new Func<ImageCodecInfo, Boolean>(variable, (ImageCodecInfo codec) => Operators.CompareString(codec.get_MimeType().ToLower(), this.u0024VBu0024Local_mimeType.ToLower(), false) == 0));
			return imageCodecInfo;
		}

		private Int32 GetMonitors()
		{
			Int32 count;
			try
			{
				this._Monitors.Clear();
				Screen[] allScreens = Screen.get_AllScreens();
				for (Int32 i = 0; i < (Int32)allScreens.Length; i = checked(i + 1))
				{
					Screen screen = allScreens[i];
					Module1.DEVMODE dEVMODE = new Module1.DEVMODE()
					{
						dmSize = checked((Int16)Marshal.SizeOf(typeof(Module1.DEVMODE)))
					};
					Module1.EnumDisplaySettings(screen.get_DeviceName(), -1, ref dEVMODE);
					Decimal num = new Decimal(dEVMODE.dmPelsWidth);
					Rectangle bounds = screen.get_Bounds();
					Decimal num1 = Math.Round(Decimal.Divide(num, new Decimal(bounds.get_Width())), 2);
					List<ScreenThread.Monitor> list = this._Monitors;
					Int32 count1 = checked(this._Monitors.get_Count() + 1);
					Point point = new Point(dEVMODE.dmPositionX, dEVMODE.dmPositionY);
					bounds = screen.get_Bounds();
					list.Add(new ScreenThread.Monitor(count1, num1, point, bounds.get_Size()));
					String str = String.Concat("SCREEN ", Enumerable.Last<ScreenThread.Monitor>(this._Monitors).ToString());
					ScreenThread.OnDebugEventHandler onDebugEventHandler = this.OnDebug;
					if (onDebugEventHandler != null)
					{
						onDebugEventHandler(str);
					}
					ScreenThread.OnExceptionEventHandler onExceptionEventHandler = this.OnException;
					if (onExceptionEventHandler != null)
					{
						onExceptionEventHandler(new Exception(str));
					}
				}
				count = this._Monitors.get_Count();
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				ScreenThread.OnExceptionEventHandler onExceptionEventHandler1 = this.OnException;
				if (onExceptionEventHandler1 != null)
				{
					onExceptionEventHandler1(exception);
				}
				count = this._Monitors.get_Count();
				ProjectData.ClearProjectError();
			}
			return count;
		}

		private Int32 ImageToByteArray(Image image, ref Byte[] result)
		{
			Int32 num;
			try
			{
				MemoryStream memoryStream = new MemoryStream();
				try
				{
					image.Save(memoryStream, ImageFormat.get_Jpeg());
					result = memoryStream.ToArray();
					num = 0;
				}
				finally
				{
					if (memoryStream != null)
					{
						memoryStream.Dispose();
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

		private Void Main(Int32 polltime)
		{
			List<ScreenThread.Monitor>.Enumerator enumerator = new List<ScreenThread.Monitor>.Enumerator();
			List<ScreenThread.Monitor>.Enumerator enumerator1 = new List<ScreenThread.Monitor>.Enumerator();
			List<ScreenThread.Monitor>.Enumerator enumerator2 = new List<ScreenThread.Monitor>.Enumerator();
			List<ScreenThread.Monitor>.Enumerator enumerator3 = new List<ScreenThread.Monitor>.Enumerator();
			List<ScreenThread.Monitor>.Enumerator enumerator4 = new List<ScreenThread.Monitor>.Enumerator();
			List<ScreenThread.Monitor>.Enumerator enumerator5 = new List<ScreenThread.Monitor>.Enumerator();
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			while (this.Started)
			{
				try
				{
					try
					{
						if (stopwatch.get_ElapsedMilliseconds() >= (Int64)polltime)
						{
							stopwatch.Restart();
							if (Enumerable.Count<Screen>(Screen.get_AllScreens()) == 0)
							{
								this._Monitors.Clear();
							}
							else if (this.ScreenSetupChanged())
							{
								this.GetMonitors();
								try
								{
									enumerator = this._Monitors.GetEnumerator();
									while (enumerator.MoveNext())
									{
										ScreenThread.Monitor current = enumerator.get_Current();
										current.Changed = true;
										this.CaptureScreen(ref current);
									}
								}
								finally
								{
									enumerator.Dispose();
								}
								ScreenThread.OnDebugEventHandler onDebugEventHandler = this.OnDebug;
								if (onDebugEventHandler != null)
								{
									onDebugEventHandler("SCREEN_SETUP_CHANGED");
								}
							}
							else if (this._ForceScreenshotStopwatch.get_ElapsedMilliseconds() >= (Int64)this.ForceScreenshotDelay)
							{
								try
								{
									enumerator1 = this._Monitors.GetEnumerator();
									while (enumerator1.MoveNext())
									{
										ScreenThread.Monitor monitor = enumerator1.get_Current();
										monitor.Changed = true;
										this.CaptureScreen(ref monitor);
									}
								}
								finally
								{
									enumerator1.Dispose();
								}
								ScreenThread.OnDebugEventHandler onDebugEventHandler1 = this.OnDebug;
								if (onDebugEventHandler1 != null)
								{
									onDebugEventHandler1("FORCE_SCREENSHOT_ALL");
								}
							}
							else if (!this._TakeScreenshotAtPoint.get_IsEmpty())
							{
								try
								{
									enumerator2 = this._Monitors.GetEnumerator();
									while (enumerator2.MoveNext())
									{
										ScreenThread.Monitor current1 = enumerator2.get_Current();
										if (current1.Bounds().IntersectsWith(this._TakeScreenshotAtPoint))
										{
											current1.Changed = true;
											this.CaptureScreen(ref current1);
											ScreenThread.OnDebugEventHandler onDebugEventHandler2 = this.OnDebug;
											if (onDebugEventHandler2 != null)
											{
												onDebugEventHandler2(String.Format("POINT_SCREENSHOT{0}. X={1}, Y={2}", current1.Index, this._TakeScreenshotAtPoint.get_X(), this._TakeScreenshotAtPoint.get_Y()));
											}
										}
									}
								}
								finally
								{
									enumerator2.Dispose();
								}
								this._TakeScreenshotAtPoint = Rectangle.Empty;
							}
							else if (!this._TakeScreenshot)
							{
								if (this.ScreenChangedPercent >= 1f)
								{
									Image image = null;
									try
									{
										enumerator4 = this._Monitors.GetEnumerator();
										while (enumerator4.MoveNext())
										{
											ScreenThread.Monitor monitor1 = enumerator4.get_Current();
											if (this.CaptureScreen(monitor1.Bounds().get_X(), monitor1.Bounds().get_Y(), monitor1.Bounds().get_Width(), monitor1.Bounds().get_Height(), ref image) == 0)
											{
												Single single = this.CompareImagesPixelBased(monitor1.Frame, image, 3);
												if (single > this.ScreenChangedPercent)
												{
													monitor1.Changed = true;
													monitor1.Frame = image;
													ScreenThread.OnDebugEventHandler onDebugEventHandler3 = this.OnDebug;
													if (onDebugEventHandler3 != null)
													{
														onDebugEventHandler3(String.Format("SCREEN{0}_DIFFERENCE={1}%", monitor1.Index, single));
													}
												}
											}
										}
									}
									finally
									{
										enumerator4.Dispose();
									}
								}
								Module1.OptimizeMemoryConsumption();
							}
							else
							{
								this._TakeScreenshot = false;
								try
								{
									enumerator3 = this._Monitors.GetEnumerator();
									while (enumerator3.MoveNext())
									{
										ScreenThread.Monitor current2 = enumerator3.get_Current();
										this.CaptureScreen(ref current2);
									}
								}
								finally
								{
									enumerator3.Dispose();
								}
								ScreenThread.OnDebugEventHandler onDebugEventHandler4 = this.OnDebug;
								if (onDebugEventHandler4 != null)
								{
									onDebugEventHandler4("MANUEL_SCREENSHOT");
								}
							}
							Byte[] numArray = null;
							try
							{
								enumerator5 = this._Monitors.GetEnumerator();
								while (enumerator5.MoveNext())
								{
									ScreenThread.Monitor monitor2 = enumerator5.get_Current();
									if (monitor2.Changed)
									{
										monitor2.Changed = false;
										if (this.CompressImage((Int64)this.ImageQuality, monitor2.Frame, ref numArray) == 0)
										{
											ScreenThread.OnScreenChangedEventHandler onScreenChangedEventHandler = this.OnScreenChanged;
											if (onScreenChangedEventHandler != null)
											{
												onScreenChangedEventHandler(new ScreenThread.ScreenChanged(monitor2.Index, monitor2.Bounds(), numArray));
											}
										}
										this._ForceScreenshotStopwatch.Restart();
									}
								}
							}
							finally
							{
								enumerator5.Dispose();
							}
						}
					}
					catch (Exception exception1)
					{
						ProjectData.SetProjectError(exception1);
						Exception exception = exception1;
						ScreenThread.OnExceptionEventHandler onExceptionEventHandler = this.OnException;
						if (onExceptionEventHandler != null)
						{
							onExceptionEventHandler(exception);
						}
						ProjectData.ClearProjectError();
					}
				}
				finally
				{
					Thread.Sleep(500);
				}
			}
		}

		private Void OnTakeScreenshotAtPointDelay(Object sender, EventArgs e)
		{
			Rectangle rectangle;
			this.TakeScreenshotAtPointDelay.Stop();
			if (this.TakeScreenshotAtPointDelay.get_Tag() is Rectangle)
			{
				Object tag = this.TakeScreenshotAtPointDelay.get_Tag();
				if (tag != null)
				{
					rectangle = (Rectangle)tag;
				}
				else
				{
					rectangle = new Rectangle();
				}
				this.TakeScreenshot(rectangle);
				this.TakeScreenshotAtPointDelay.set_Tag(null);
			}
		}

		private Void OnTakeScreenshotDelay(Object sender, EventArgs e)
		{
			this.TakeScreenshotDelay.Stop();
			this._TakeScreenshot = true;
		}

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

		private Boolean ScreenSetupChanged()
		{
			Boolean flag;
			if (this.u0024STATICu0024ScreenSetupChangedu00242002u0024screensu0024Init == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref this.u0024STATICu0024ScreenSetupChangedu00242002u0024screensu0024Init, new StaticLocalInitFlag(), null);
			}
			Boolean flag1 = false;
			try
			{
				System.Threading.Monitor.Enter(this.u0024STATICu0024ScreenSetupChangedu00242002u0024screensu0024Init, ref flag1);
				if (this.u0024STATICu0024ScreenSetupChangedu00242002u0024screensu0024Init.State == 0)
				{
					this.u0024STATICu0024ScreenSetupChangedu00242002u0024screensu0024Init.State = 2;
					this.u0024STATICu0024ScreenSetupChangedu00242002u0024screens = null;
				}
				else if (this.u0024STATICu0024ScreenSetupChangedu00242002u0024screensu0024Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				this.u0024STATICu0024ScreenSetupChangedu00242002u0024screensu0024Init.State = 1;
				if (flag1)
				{
					System.Threading.Monitor.Exit(this.u0024STATICu0024ScreenSetupChangedu00242002u0024screensu0024Init);
				}
			}
			try
			{
				if (this.u0024STATICu0024ScreenSetupChangedu00242002u0024screens == null)
				{
					this.u0024STATICu0024ScreenSetupChangedu00242002u0024screens = Screen.get_AllScreens();
					flag = true;
				}
				else if (Enumerable.Count<Screen>(this.u0024STATICu0024ScreenSetupChangedu00242002u0024screens) == Enumerable.Count<Screen>(Screen.get_AllScreens()))
				{
					Int32 num = checked(Enumerable.Count<Screen>(Screen.get_AllScreens()) - 1);
					Int32 num1 = 0;
					while (num1 <= num)
					{
						if (Operators.CompareString(this.u0024STATICu0024ScreenSetupChangedu00242002u0024screens[num1].ToString(), Screen.get_AllScreens()[num1].ToString(), false) == 0)
						{
							num1 = checked(num1 + 1);
						}
						else
						{
							this.u0024STATICu0024ScreenSetupChangedu00242002u0024screens = Screen.get_AllScreens();
							flag = true;
							return flag;
						}
					}
					flag = false;
				}
				else
				{
					this.u0024STATICu0024ScreenSetupChangedu00242002u0024screens = Screen.get_AllScreens();
					flag = true;
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public Void TakeScreenshot(Int32 index)
		{
			List<ScreenThread.Monitor>.Enumerator enumerator = new List<ScreenThread.Monitor>.Enumerator();
			try
			{
				enumerator = this._Monitors.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ScreenThread.Monitor current = enumerator.get_Current();
					if (current.Index == index | index == 0)
					{
						current.Changed = true;
					}
				}
			}
			finally
			{
				enumerator.Dispose();
			}
			this._TakeScreenshot = true;
		}

		public Void TakeScreenshot(Int32 index, Int32 delay)
		{
			List<ScreenThread.Monitor>.Enumerator enumerator = new List<ScreenThread.Monitor>.Enumerator();
			try
			{
				enumerator = this._Monitors.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ScreenThread.Monitor current = enumerator.get_Current();
					if (current.Index == index | index == 0)
					{
						current.Changed = true;
					}
				}
			}
			finally
			{
				enumerator.Dispose();
			}
			this.TakeScreenshotDelay.set_Interval(delay);
			this.TakeScreenshotDelay.Start();
		}

		public Void TakeScreenshot(Rectangle rectangle)
		{
			this._TakeScreenshotAtPoint = rectangle;
		}

		public Void TakeScreenshot(Rectangle rectangle, Int32 delay)
		{
			this.TakeScreenshotAtPointDelay.set_Interval(delay);
			this.TakeScreenshotAtPointDelay.set_Tag(rectangle);
			this.TakeScreenshotAtPointDelay.Start();
		}

		public event ScreenThread.OnDebugEventHandler OnDebug;

		public event ScreenThread.OnExceptionEventHandler OnException;

		public event ScreenThread.OnScreenChangedEventHandler OnScreenChanged;

		private class Monitor
		{
			public Int32 Index;

			public Point Location;

			public Decimal Scale;

			public Size Resolution;

			public Image Frame;

			public Boolean Changed;

			public Monitor()
			{
				this.Index = 0;
				this.Location = new Point();
				this.Scale = Decimal.One;
				this.Resolution = new Size();
				this.Frame = null;
				this.Changed = false;
			}

			public Monitor(Int32 index, Decimal scale, Point location, Size resolution)
			{
				this.Index = 0;
				this.Location = new Point();
				this.Scale = Decimal.One;
				this.Resolution = new Size();
				this.Frame = null;
				this.Changed = false;
				this.Index = index;
				this.Scale = scale;
				this.Location = location;
				this.Resolution = new Size(Convert.ToInt32(Decimal.Multiply(new Decimal(resolution.get_Width()), this.Scale)), Convert.ToInt32(Decimal.Multiply(new Decimal(resolution.get_Height()), this.Scale)));
			}

			public Rectangle Bounds()
			{
				return new Rectangle(this.Location, this.Resolution);
			}

			public override String ToString()
			{
				return String.Format("{0}: Scale={1}, Resolution={2}, Location={3}", new Object[] { this.Index, this.Scale, this.Resolution.ToString(), this.Location.ToString() });
			}
		}

		public delegate Void OnDebugEventHandler(String message);

		public delegate Void OnExceptionEventHandler(Exception ex);

		public delegate Void OnScreenChangedEventHandler(ScreenThread.ScreenChanged sender);

		[Serializable]
		public class ScreenChanged
		{
			public String Reference;

			public String Token;

			public DateTime CanSend;

			public Int32 ScreenNumber;

			public Rectangle Bounds;

			public DateTime TimeStamp;

			public Byte[] Data;

			public ScreenChanged()
			{
				this.Reference = Guid.NewGuid().ToString();
				this.Token = "";
				this.CanSend = DateTime.MinValue;
				this.ScreenNumber = 0;
				this.Bounds = new Rectangle();
				this.TimeStamp = DateTime.MinValue;
				this.Data = null;
			}

			public ScreenChanged(Int32 screenNumber, Rectangle bounds, Byte[] data)
			{
				this.Reference = Guid.NewGuid().ToString();
				this.Token = "";
				this.CanSend = DateTime.MinValue;
				this.ScreenNumber = 0;
				this.Bounds = new Rectangle();
				this.TimeStamp = DateTime.MinValue;
				this.Data = null;
				this.ScreenNumber = screenNumber;
				this.Bounds = bounds;
				this.Data = data;
			}
		}
	}
}