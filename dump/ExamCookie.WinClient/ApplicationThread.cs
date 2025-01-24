using ExamCookie.Library;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using UIAutomationClient;

namespace ExamCookie.WinClient
{
	public class ApplicationThread
	{
		private const Int32 THREAD_SLEEP = 1000;

		private Boolean _Started;

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

		public ApplicationThread()
		{
			this._Started = false;
		}

		public ApplicationThread(Int32 polltime)
		{
			Int32 num = polltime;
			base();
			ApplicationThread._Closureu0024__21u002d0 variable = null;
			this._Started = false;
			if (num > 0)
			{
				if (num < 1000)
				{
					num = 1000;
				}
				Thread thread = new Thread(new ThreadStart(variable, () => this.u0024VBu0024Me.Main(this.u0024VBu0024Local_polltime)));
				this.Started = true;
				thread.Start();
			}
		}

		private Int32 GetBrowserUrl(System.Diagnostics.Process process, String name, ref String result)
		{
			Int32 num;
			try
			{
				if (Enumerable.Contains<String>(new String[] { "iexplore", "chrome", "brave", "firefox", "msedge", "opera" }, name.ToLower()))
				{
					CUIAutomation variable = (CUIAutomation)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("FF48DBA4-60EF-4201-AA87-54103EEF594E")));
					List<IUIAutomationCondition> list = new List<IUIAutomationCondition>();
					list.Add(variable.CreatePropertyCondition(30002, process.get_Id()));
					list.Add(variable.CreatePropertyCondition(30003, 50004));
					String lower = name.ToLower();
					if (Operators.CompareString(lower, "iexplore", false) == 0)
					{
						list.Add(variable.CreatePropertyCondition(30012, "Edit"));
					}
					else if (Operators.CompareString(lower, "chrome", false) == 0 || Operators.CompareString(lower, "brave", false) == 0)
					{
						list.Add(variable.CreatePropertyCondition(30007, "Ctrl+L"));
					}
					else if (Operators.CompareString(lower, "firefox", false) == 0)
					{
						list.Add(variable.CreatePropertyCondition(30024, "Gecko"));
					}
					else if (Operators.CompareString(lower, "msedge", false) == 0)
					{
						list.Add(variable.CreatePropertyCondition(30012, "OmniboxViewViews"));
					}
					else if (Operators.CompareString(lower, "opera", false) == 0)
					{
						list.Add(variable.CreateOrCondition(variable.CreatePropertyCondition(30005, "Adressefelt"), variable.CreatePropertyCondition(30005, "Address field")));
					}
					IUIAutomationElement rootElement = variable.GetRootElement();
					IUIAutomationElement variable1 = rootElement.FindFirst(TreeScope.TreeScope_Subtree, variable.CreateAndConditionFromArray(list.ToArray()));
					if (variable1 == null)
					{
						result = "Adresse felt ikke fundet";
					}
					else
					{
						IUIAutomationValuePattern currentPattern = (IUIAutomationValuePattern)variable1.GetCurrentPattern(10002);
						if (currentPattern == null)
						{
							result = "Mønster ikke fundet";
						}
						else
						{
							result = currentPattern.CurrentValue.ToUri();
							num = 0;
							return num;
						}
					}
					num = 2;
				}
				else
				{
					result = "Ukendt browser";
					num = 1;
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				result = exception.ToString();
				num = 3;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		[DllImport("user32.dll", CharSet=1, ExactSpelling=false)]
		private static extern IntPtr GetForegroundWindow();

		public Rectangle GetFrontWindowRect()
		{
			Rectangle rectangle;
			try
			{
				IntPtr foregroundWindow = (IntPtr)0;
				Int32 num = 0;
				ApplicationThread.RECT rECT = new ApplicationThread.RECT();
				foregroundWindow = ApplicationThread.GetForegroundWindow();
				ApplicationThread.GetWindowThreadProcessId(foregroundWindow, ref num);
				ApplicationThread.GetWindowRect(foregroundWindow, ref rECT);
				rectangle = ((object)System.Diagnostics.Process.GetProcessById(num) == (object)null ? new Rectangle() : this.RECTToRectangle(rECT));
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				rectangle = new Rectangle();
				ProjectData.ClearProjectError();
			}
			return rectangle;
		}

		[DllImport("user32.dll", CharSet=1, ExactSpelling=false)]
		private static extern Boolean GetWindowRect(IntPtr hWnd, ref ApplicationThread.RECT lpRect);

		[DllImport("user32.dll", CharSet=1, ExactSpelling=false)]
		private static extern IntPtr GetWindowThreadProcessId(IntPtr hwnd, ref Int32 processId);

		private Void Main(Int32 polltime)
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			IntPtr intPtr = (IntPtr)0;
			IntPtr foregroundWindow = (IntPtr)0;
			Int32 num = 0;
			ApplicationThread.RECT rECT = new ApplicationThread.RECT();
			Boolean browserUrl = false;
			String str = "";
			String str1 = "¤";
			System.Diagnostics.Process processById = null;
			List<String> list = new List<String>();
			list.AddRange(new String[] { "devenv", "ExamCookie.WinClient", "ExamCookie.WinIEClient", "ExamCookie.WinClient.vshost", "wermgr", "ShellExperienceHost" });
			while (this.Started)
			{
				try
				{
					try
					{
						if (stopwatch.get_ElapsedMilliseconds() >= (Int64)polltime)
						{
							stopwatch.Restart();
							foregroundWindow = ApplicationThread.GetForegroundWindow();
							if (intPtr == foregroundWindow)
							{
								browserUrl = this.GetBrowserUrl(processById, processById.get_ProcessName(), ref str) == 0;
							}
							else
							{
								intPtr = foregroundWindow;
								ApplicationThread.GetWindowThreadProcessId(intPtr, ref num);
								ApplicationThread.GetWindowRect(intPtr, ref rECT);
								processById = System.Diagnostics.Process.GetProcessById(num);
								if ((object)processById != (object)null)
								{
									Int32 browserUrl1 = this.GetBrowserUrl(processById, processById.get_ProcessName(), ref str);
									if (browserUrl1 == 0)
									{
										browserUrl = true;
									}
									else if (browserUrl1 == 1)
									{
										str1 = "¤";
										if (!Enumerable.Contains<String>(list, processById.get_ProcessName(), StringComparer.get_OrdinalIgnoreCase()))
										{
											ApplicationThread.OnApplicationChangedEventHandler onApplicationChangedEventHandler = this.OnApplicationChanged;
											if (onApplicationChangedEventHandler != null)
											{
												onApplicationChangedEventHandler(new ApplicationThread.ApplicationChanged(this.RECTToRectangle(rECT), eApplicationType.APPLICATION, processById.get_ProcessName(), processById.get_MainWindowTitle()));
											}
										}
									}
									else
									{
										Module1.DebugPrint(String.Format("BROWSER [{0}]. (Fejl = {1})", processById.get_ProcessName(), str), new Object[0]);
									}
								}
							}
							if (browserUrl)
							{
								browserUrl = false;
								if (Operators.CompareString(str1, str, false) != 0)
								{
									str1 = str;
									ApplicationThread.OnApplicationChangedEventHandler onApplicationChangedEventHandler1 = this.OnApplicationChanged;
									if (onApplicationChangedEventHandler1 != null)
									{
										onApplicationChangedEventHandler1(new ApplicationThread.ApplicationChanged(this.RECTToRectangle(rECT), eApplicationType.BROWSER, processById.get_ProcessName(), str));
									}
								}
							}
							Thread.Sleep(1000);
						}
					}
					catch (Exception exception1)
					{
						ProjectData.SetProjectError(exception1);
						Exception exception = exception1;
						ApplicationThread.OnExceptionEventHandler onExceptionEventHandler = this.OnException;
						if (onExceptionEventHandler != null)
						{
							onExceptionEventHandler(exception);
						}
						ProjectData.ClearProjectError();
					}
				}
				finally
				{
					Thread.Sleep(1000);
				}
			}
		}

		private Rectangle RECTToRectangle(ApplicationThread.RECT rect)
		{
			this.ScaleWindowRect(ref rect);
			Rectangle rectangle = new Rectangle(rect.Left, rect.Top, checked(rect.Right - rect.Left), checked(rect.Bottom - rect.Top));
			return rectangle;
		}

		private Void ScaleWindowRect(ref ApplicationThread.RECT rect)
		{
			List<RectangleF>.Enumerator enumerator = new List<RectangleF>.Enumerator();
			try
			{
				Decimal num = new Decimal();
				Int32 num1 = 0;
				List<RectangleF> list = new List<RectangleF>();
				Screen[] allScreens = Screen.get_AllScreens();
				for (Int32 i = 0; i < (Int32)allScreens.Length; i = checked(i + 1))
				{
					Screen screen = allScreens[i];
					Module1.DEVMODE dEVMODE = new Module1.DEVMODE()
					{
						dmSize = checked((Int16)Marshal.SizeOf(typeof(Module1.DEVMODE)))
					};
					Module1.EnumDisplaySettings(screen.get_DeviceName(), -1, ref dEVMODE);
					Decimal num2 = new Decimal(dEVMODE.dmPelsWidth);
					Rectangle bounds = screen.get_Bounds();
					num = Math.Round(Decimal.Divide(num2, new Decimal(bounds.get_Width())), 2);
					bounds = screen.get_Bounds();
					list.Add(new RectangleF((Single)bounds.get_X(), Convert.ToSingle(num), (Single)num1, 0f));
					num1 = checked(num1 + dEVMODE.dmPelsWidth);
				}
				list.Reverse();
				try
				{
					enumerator = list.GetEnumerator();
					while (enumerator.MoveNext())
					{
						RectangleF current = enumerator.get_Current();
						if ((Single)rect.Left > current.get_X() - 15f)
						{
							rect.Left = checked((Int32)Math.Round((Double)(((Single)(checked(rect.Left + 12)) - current.get_X()) * current.get_Y() + current.get_Width())));
							rect.Right = checked((Int32)Math.Round((Double)(((Single)(checked(rect.Right - 12)) - current.get_X()) * current.get_Y() + current.get_Width())));
							rect.Top = checked((Int32)Math.Round((Double)((Single)(checked(rect.Top + 12)) * current.get_Y())));
							rect.Bottom = checked((Int32)Math.Round((Double)((Single)(checked(rect.Bottom - 12)) * current.get_Y())));
							break;
						}
					}
				}
				finally
				{
					enumerator.Dispose();
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				ProjectData.ClearProjectError();
			}
		}

		public event ApplicationThread.OnApplicationChangedEventHandler OnApplicationChanged;

		public event ApplicationThread.OnDebugEventHandler OnDebug;

		public event ApplicationThread.OnExceptionEventHandler OnException;

		[Serializable]
		public class ApplicationChanged
		{
			public String Reference;

			public String Token;

			public DateTime CanSend;

			public DateTime TimeStamp;

			public Rectangle Rectangle;

			public eApplicationType Type;

			public String Name;

			public String Document;

			public String FileDescription;

			public String InternalName;

			public ApplicationChanged()
			{
				this.Reference = Guid.NewGuid().ToString();
				this.Token = "";
				this.CanSend = DateTime.MinValue;
				this.TimeStamp = DateTime.MinValue;
				this.Rectangle = new Rectangle();
				this.Name = "";
				this.Document = "";
				this.FileDescription = "";
				this.InternalName = "";
			}

			public ApplicationChanged(Rectangle rectangle, eApplicationType type, String name, String document)
			{
				this.Reference = Guid.NewGuid().ToString();
				this.Token = "";
				this.CanSend = DateTime.MinValue;
				this.TimeStamp = DateTime.MinValue;
				this.Rectangle = new Rectangle();
				this.Name = "";
				this.Document = "";
				this.FileDescription = "";
				this.InternalName = "";
				this.Rectangle = rectangle;
				this.Type = type;
				this.Name = name;
				this.Document = document;
			}

			public ApplicationChanged(Rectangle rectangle, eApplicationType type, String name, String document, String fileDescription, String internalName)
			{
				this.Reference = Guid.NewGuid().ToString();
				this.Token = "";
				this.CanSend = DateTime.MinValue;
				this.TimeStamp = DateTime.MinValue;
				this.Rectangle = new Rectangle();
				this.Name = "";
				this.Document = "";
				this.FileDescription = "";
				this.InternalName = "";
				this.Rectangle = rectangle;
				this.Type = type;
				this.Name = name;
				this.Document = document;
				this.FileDescription = fileDescription;
				this.InternalName = internalName;
			}
		}

		public delegate Void OnApplicationChangedEventHandler(ApplicationThread.ApplicationChanged sender);

		public delegate Void OnDebugEventHandler(String message);

		public delegate Void OnExceptionEventHandler(Exception ex);

		public struct RECT
		{
			public Int32 Left;

			public Int32 Top;

			public Int32 Right;

			public Int32 Bottom;
		}
	}
}