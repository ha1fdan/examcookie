using ExamCookie.WinClient.ExamApiV3Service;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ExamCookie.WinClient
{
	public class UploadThread
	{
		private const Int32 THREAD_SLEEP = 100;

		private Int32 HeartbeatPulseMin;

		private Int32 HeartbeatPulseMax;

		private Boolean _Started;

		private DateTime _CurrentTime;

		private String _Token;

		private Int32 _IsOnline;

		private Int32 _AcceptOnline;

		private Boolean _IsWsOnline;

		private List<Object> _PackageBuffer;

		private Int32 _Heartbeat;

		private Random _Random;

		public Boolean AcceptOnline
		{
			get
			{
				return this._AcceptOnline >= 5;
			}
			set
			{
				if (value)
				{
					if (this._AcceptOnline < 10)
					{
						ref Int32 numPointer = ref this._AcceptOnline;
						numPointer = checked(numPointer + 1);
					}
				}
				else if (this._AcceptOnline > 0)
				{
					ref Int32 numPointer1 = ref this._AcceptOnline;
					numPointer1 = checked(numPointer1 - 1);
				}
			}
		}

		public DateTime CurrentTime
		{
			get
			{
				return this._CurrentTime;
			}
			set
			{
				this._CurrentTime = value;
			}
		}

		public Int32 DataPackageCount
		{
			get
			{
				return Enumerable.ToList<Object>(this._PackageBuffer).get_Count();
			}
		}

		public Int32 DataPackageOfflineCount
		{
			get
			{
				Int32 num;
				try
				{
					num = (!Directory.Exists(this.GetOfflineDirectoryName()) ? 0 : Enumerable.Count<String>(Directory.GetFiles(this.GetOfflineDirectoryName(), String.Concat("*.", RuntimeHelpers.GetObjectValue(Module1.PACKAGE_FILE_EXTENSION)))));
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					num = 0;
					ProjectData.ClearProjectError();
				}
				return num;
			}
		}

		public Boolean IsOnline
		{
			get
			{
				Boolean flag = Conversions.ToBoolean(Interaction.IIf(this._IsOnline == 1, true, false));
				return flag;
			}
			set
			{
				if (this._IsOnline == 2)
				{
					UploadThread.OnOnlineChangedEventHandler onOnlineChangedEventHandler = this.OnOnlineChanged;
					if (onOnlineChangedEventHandler != null)
					{
						onOnlineChangedEventHandler(value);
					}
				}
				else if (value & this._IsOnline == 0)
				{
					UploadThread.OnOnlineChangedEventHandler onOnlineChangedEventHandler1 = this.OnOnlineChanged;
					if (onOnlineChangedEventHandler1 != null)
					{
						onOnlineChangedEventHandler1(value);
					}
				}
				else if (!value & this._IsOnline == 1)
				{
					UploadThread.OnOnlineChangedEventHandler onOnlineChangedEventHandler2 = this.OnOnlineChanged;
					if (onOnlineChangedEventHandler2 != null)
					{
						onOnlineChangedEventHandler2(value);
					}
				}
				this._IsOnline = Conversions.ToInteger(Interaction.IIf(value, 1, 0));
				if (!value)
				{
					this.IsWsOnline = false;
				}
			}
		}

		public Boolean IsWsOnline
		{
			get
			{
				return this._IsWsOnline;
			}
			set
			{
				this._IsWsOnline = value;
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

		public String Token
		{
			get
			{
				return this._Token;
			}
			set
			{
				this._Token = value;
			}
		}

		public Boolean UploadDataPackagesComplete
		{
			get
			{
				Boolean flag;
				if (this.u0024STATICu0024get_UploadDataPackagesCompleteu00242002u0024tsu0024Init == null)
				{
					Interlocked.CompareExchange<StaticLocalInitFlag>(ref this.u0024STATICu0024get_UploadDataPackagesCompleteu00242002u0024tsu0024Init, new StaticLocalInitFlag(), null);
				}
				Boolean flag1 = false;
				try
				{
					Monitor.Enter(this.u0024STATICu0024get_UploadDataPackagesCompleteu00242002u0024tsu0024Init, ref flag1);
					if (this.u0024STATICu0024get_UploadDataPackagesCompleteu00242002u0024tsu0024Init.State == 0)
					{
						this.u0024STATICu0024get_UploadDataPackagesCompleteu00242002u0024tsu0024Init.State = 2;
						this.u0024STATICu0024get_UploadDataPackagesCompleteu00242002u0024ts = DateAndTime.get_Now();
					}
					else if (this.u0024STATICu0024get_UploadDataPackagesCompleteu00242002u0024tsu0024Init.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					this.u0024STATICu0024get_UploadDataPackagesCompleteu00242002u0024tsu0024Init.State = 1;
					if (flag1)
					{
						Monitor.Exit(this.u0024STATICu0024get_UploadDataPackagesCompleteu00242002u0024tsu0024Init);
					}
				}
				if (!(this.DataPackageCount > 0 | this.DataPackageOfflineCount > 0))
				{
					flag = (DateTime.Compare(DateAndTime.get_Now(), this.u0024STATICu0024get_UploadDataPackagesCompleteu00242002u0024ts.AddSeconds(10)) >= 0 ? true : false);
				}
				else
				{
					this.u0024STATICu0024get_UploadDataPackagesCompleteu00242002u0024ts = DateAndTime.get_Now();
					flag = false;
				}
				return flag;
			}
		}

		public UploadThread()
		{
			this.HeartbeatPulseMin = 30;
			this.HeartbeatPulseMax = 60;
			this._Started = false;
			this._CurrentTime = DateTime.MinValue;
			this._Token = "";
			this._IsOnline = 2;
			this._AcceptOnline = 0;
			this._IsWsOnline = false;
			this._PackageBuffer = new List<Object>();
			this._Heartbeat = 0;
			this._Random = new Random();
		}

		public UploadThread(Int32 heartbeatPulseMin, Int32 heartbeatPulseMax)
		{
			this.HeartbeatPulseMin = 30;
			this.HeartbeatPulseMax = 60;
			this._Started = false;
			this._CurrentTime = DateTime.MinValue;
			this._Token = "";
			this._IsOnline = 2;
			this._AcceptOnline = 0;
			this._IsWsOnline = false;
			this._PackageBuffer = new List<Object>();
			this._Heartbeat = 0;
			this._Random = new Random();
			this.HeartbeatPulseMin = heartbeatPulseMin;
			this.HeartbeatPulseMax = heartbeatPulseMax;
			this.CreateOfflineDirectory();
			this.Started = true;
			(new Thread(new ThreadStart(this, () => this.UploadDataPackages()))).Start();
			(new Thread(new ThreadStart(this, () => this.OnlineMonitor()))).Start();
		}

		public Void AddDataPackage(Object package)
		{
			try
			{
				if (this.ValidateDataPackage(RuntimeHelpers.GetObjectValue(package)))
				{
					if (this.DataPackageCount >= 250)
					{
						this.SaveDataPackageToDisk(RuntimeHelpers.GetObjectValue(package));
					}
					else
					{
						this._PackageBuffer.Add(RuntimeHelpers.GetObjectValue(package));
					}
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				UploadThread.OnExceptionEventHandler onExceptionEventHandler = this.OnException;
				if (onExceptionEventHandler != null)
				{
					onExceptionEventHandler(exception);
				}
				ProjectData.ClearProjectError();
			}
		}

		private Boolean CanDataPackageSend(DateTime value)
		{
			Boolean flag;
			try
			{
				flag = DateTime.Compare(this.CurrentTime, value) > 0;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		private Void CreateOfflineDirectory()
		{
			try
			{
				if (!Directory.Exists(String.Format("{0}\\{1}", Module1.APP_DATA_PATH, Module1.OFFLINE_PACKAGE_FOLDER)))
				{
					Directory.CreateDirectory(String.Format("{0}\\{1}", Module1.APP_DATA_PATH, Module1.OFFLINE_PACKAGE_FOLDER));
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				UploadThread.OnExceptionEventHandler onExceptionEventHandler = this.OnException;
				if (onExceptionEventHandler != null)
				{
					onExceptionEventHandler(exception);
				}
				ProjectData.ClearProjectError();
			}
		}

		private String GetNewFilename()
		{
			this.CreateOfflineDirectory();
			String offlineDirectoryName = this.GetOfflineDirectoryName();
			Guid guid = Guid.NewGuid();
			String str = String.Format("{0}\\{1}.{2}", offlineDirectoryName, guid.ToString(), RuntimeHelpers.GetObjectValue(Module1.PACKAGE_FILE_EXTENSION));
			return str;
		}

		private Int32 GetNextHeartbeat()
		{
			Int32 num = this._Random.Next(checked(this.HeartbeatPulseMin * 1000), checked(this.HeartbeatPulseMax * 1000));
			return num;
		}

		private Boolean GetNextPackage(ref Object package)
		{
			Boolean flag;
			try
			{
				if (this.DataPackageCount <= 0)
				{
					flag = false;
				}
				else
				{
					package = RuntimeHelpers.GetObjectValue(this._PackageBuffer.Pop(0));
					if (!this.CanDataPackageSend(Conversions.ToDate(NewLateBinding.LateGet(package, null, "CanSend", new Object[0], null, null, null))))
					{
						this._PackageBuffer.Add(RuntimeHelpers.GetObjectValue(package));
						flag = false;
					}
					else
					{
						flag = true;
					}
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

		private String GetOfflineDirectoryName()
		{
			String str;
			try
			{
				str = String.Format("{0}\\{1}", Module1.APP_DATA_PATH, Module1.OFFLINE_PACKAGE_FOLDER);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				str = "";
				ProjectData.ClearProjectError();
			}
			return str;
		}

		private Void LoadDataPackageFromDisk()
		{
			try
			{
				if (Directory.Exists(this.GetOfflineDirectoryName()))
				{
					String[] files = Directory.GetFiles(this.GetOfflineDirectoryName(), String.Concat("*.", RuntimeHelpers.GetObjectValue(Module1.PACKAGE_FILE_EXTENSION)));
					Int32 num = 0;
					while (num < (Int32)files.Length)
					{
						String str = files[num];
						if (this.DataPackageCount >= 10)
						{
							break;
						}
						else
						{
							Object obj = null;
							if (Module1.DeserializeFromFileDecrypted(str, ref obj) == 0)
							{
								if (DateAndTime.DateDiff(4, Conversions.ToDate(NewLateBinding.LateGet(obj, null, "TimeStamp", new Object[0], null, null, null)), DateAndTime.get_Now(), 1, 1) <= (Int64)90)
								{
									this.AddDataPackage(RuntimeHelpers.GetObjectValue(obj));
								}
							}
							try
							{
								if (File.Exists(str))
								{
									File.Delete(str);
								}
							}
							catch (Exception exception1)
							{
								ProjectData.SetProjectError(exception1);
								Exception exception = exception1;
								UploadThread.OnExceptionEventHandler onExceptionEventHandler = this.OnException;
								if (onExceptionEventHandler != null)
								{
									onExceptionEventHandler(exception);
								}
								ProjectData.ClearProjectError();
							}
							num = checked(num + 1);
						}
					}
				}
			}
			catch (Exception exception3)
			{
				ProjectData.SetProjectError(exception3);
				Exception exception2 = exception3;
				UploadThread.OnExceptionEventHandler onExceptionEventHandler1 = this.OnException;
				if (onExceptionEventHandler1 != null)
				{
					onExceptionEventHandler1(exception2);
				}
				ProjectData.ClearProjectError();
			}
		}

		private Void OnlineMonitor()
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			Module1.NetConnectType netConnectType = Module1.NetConnectType.INTERNET_CONNECTION_OFFLINE;
			Module1.NetConnectType netConnectType1 = netConnectType;
			while (this.Started)
			{
				try
				{
					try
					{
						if (stopwatch.get_ElapsedMilliseconds() >= (Int64)500)
						{
							stopwatch.Restart();
							if (!Module1.IsInternetConnected(ref netConnectType))
							{
								this.AcceptOnline = false;
							}
							else if (netConnectType == Module1.NetConnectType.INTERNET_CONNECTION_ONLINE)
							{
								this.AcceptOnline = true;
							}
							else
							{
								this.AcceptOnline = false;
							}
							this.IsOnline = this.AcceptOnline;
						}
						if (netConnectType1 != netConnectType)
						{
							netConnectType1 = netConnectType;
							UploadThread.OnDebugEventHandler onDebugEventHandler = this.OnDebug;
							if (onDebugEventHandler != null)
							{
								onDebugEventHandler(String.Concat("NetConnectType = ", netConnectType.ToString()));
							}
						}
						if (!this.IsOnline)
						{
							this._Heartbeat = 0;
							this.IsWsOnline = false;
						}
						else if (this._Heartbeat >= 0)
						{
							ref Int32 numPointer = ref this._Heartbeat;
							numPointer = checked(numPointer - 100);
						}
						else
						{
							this._Heartbeat = this.GetNextHeartbeat();
							try
							{
								ExamApiV3Client examApiV3Client = Module1.ExamClient();
								try
								{
									ExamApiV3Client examApiV3Client1 = examApiV3Client;
									Module1.SetCredentials(ref examApiV3Client1);
									DateTime minValue = DateTime.MinValue;
									Int32 num = examApiV3Client.HeartBeat(this.Token, ref minValue);
									if (num < 0)
									{
										this.IsWsOnline = false;
									}
									else
									{
										this.IsWsOnline = true;
										if (DateTime.Compare(minValue, DateTime.MinValue) != 0)
										{
											UploadThread.OnHeartbeatEventHandler onHeartbeatEventHandler = this.OnHeartbeat;
											if (onHeartbeatEventHandler != null)
											{
												onHeartbeatEventHandler(minValue, num);
											}
										}
									}
								}
								finally
								{
									if (examApiV3Client != null)
									{
										examApiV3Client.Dispose();
									}
								}
							}
							catch (Exception exception1)
							{
								ProjectData.SetProjectError(exception1);
								Exception exception = exception1;
								this.IsWsOnline = false;
								UploadThread.OnExceptionEventHandler onExceptionEventHandler = this.OnException;
								if (onExceptionEventHandler != null)
								{
									onExceptionEventHandler(exception);
								}
								ProjectData.ClearProjectError();
							}
						}
					}
					catch (Exception exception3)
					{
						ProjectData.SetProjectError(exception3);
						Exception exception2 = exception3;
						UploadThread.OnExceptionEventHandler onExceptionEventHandler1 = this.OnException;
						if (onExceptionEventHandler1 != null)
						{
							onExceptionEventHandler1(exception2);
						}
						ProjectData.ClearProjectError();
					}
				}
				finally
				{
					Thread.Sleep(100);
				}
			}
		}

		private Void SaveDataPackageToDisk(Object package)
		{
			Module1.SerializeToFileEncrypted(this.GetNewFilename(), RuntimeHelpers.GetObjectValue(package));
		}

		private Void UploadDataPackages()
		{
			Int32 num = 0;
			Stopwatch stopwatch = new Stopwatch();
			Object obj = null;
		Label4:
			while (this.Started)
			{
				try
				{
					try
					{
						if (this.DataPackageCount > 0)
						{
							if (this.GetNextPackage(ref obj))
							{
								if (this.IsWsOnline)
								{
									try
									{
										ExamApiV3Client examApiV3Client = Module1.ExamClient();
										try
										{
											ExamApiV3Client examApiV3Client1 = examApiV3Client;
											Module1.SetCredentials(ref examApiV3Client1);
											stopwatch.Restart();
											if ((object)obj == (object)null)
											{
												num = 999;
											}
											else if (obj is AdapterThread.AdapterChanged)
											{
												AdapterThread.AdapterChanged adapterChanged = (AdapterThread.AdapterChanged)obj;
												num = examApiV3Client.AddAdapter(adapterChanged.Token, adapterChanged.TimeStamp, adapterChanged.Data);
												UploadThread.OnDebugEventHandler onDebugEventHandler = this.OnDebug;
												if (onDebugEventHandler != null)
												{
													onDebugEventHandler(String.Format("WS:AddAdapter > {0} ms", stopwatch.get_ElapsedMilliseconds()));
												}
											}
											else if (obj is ApplicationThread.ApplicationChanged)
											{
												ApplicationThread.ApplicationChanged applicationChanged = (ApplicationThread.ApplicationChanged)obj;
												num = examApiV3Client.AddFrontApp(applicationChanged.Token, applicationChanged.TimeStamp, applicationChanged.Type, applicationChanged.Name, applicationChanged.Document, 0);
												UploadThread.OnDebugEventHandler onDebugEventHandler1 = this.OnDebug;
												if (onDebugEventHandler1 != null)
												{
													onDebugEventHandler1(String.Format("WS:AddFrontApp > {0} ms", stopwatch.get_ElapsedMilliseconds()));
												}
											}
											else if (obj is ClipboardThread.ClipboardChanged)
											{
												ClipboardThread.ClipboardChanged clipboardChanged = (ClipboardThread.ClipboardChanged)obj;
												num = examApiV3Client.AddClipboard(clipboardChanged.Token, clipboardChanged.TimeStamp, clipboardChanged.Format, clipboardChanged.Data);
												UploadThread.OnDebugEventHandler onDebugEventHandler2 = this.OnDebug;
												if (onDebugEventHandler2 != null)
												{
													onDebugEventHandler2(String.Format("WS:AddClipboard > {0} ms", stopwatch.get_ElapsedMilliseconds()));
												}
											}
											else if (obj is ProcessThread.ProcessChanged)
											{
												ProcessThread.ProcessChanged processChanged = (ProcessThread.ProcessChanged)obj;
												num = examApiV3Client.AddProcess(processChanged.Token, processChanged.TimeStamp, processChanged.Data());
												UploadThread.OnDebugEventHandler onDebugEventHandler3 = this.OnDebug;
												if (onDebugEventHandler3 != null)
												{
													onDebugEventHandler3(String.Format("WS:AddProcess > {0} ms", stopwatch.get_ElapsedMilliseconds()));
												}
											}
											else if (obj is ScreenThread.ScreenChanged)
											{
												ScreenThread.ScreenChanged screenChanged = (ScreenThread.ScreenChanged)obj;
												num = examApiV3Client.AddScreenShot(screenChanged.Token, screenChanged.TimeStamp, screenChanged.ScreenNumber, screenChanged.Data);
												UploadThread.OnDebugEventHandler onDebugEventHandler4 = this.OnDebug;
												if (onDebugEventHandler4 != null)
												{
													onDebugEventHandler4(String.Format("WS:AddScreenShot > {0} ms", stopwatch.get_ElapsedMilliseconds()));
												}
											}
										}
										finally
										{
											if (examApiV3Client != null)
											{
												examApiV3Client.Dispose();
											}
										}
										if (num > 2)
										{
											if (num != 999)
											{
												goto Label2;
											}
											UploadThread.OnDebugEventHandler onDebugEventHandler5 = this.OnDebug;
											if (onDebugEventHandler5 != null)
											{
												onDebugEventHandler5("Data pakke er ugyldig");
											}
											goto Label4;
										}
										else if (num != 0)
										{
											if (num == 2)
											{
												goto Label3;
											}
											goto Label1;
										}
									Label3:
										this._Heartbeat = this.GetNextHeartbeat();
										goto Label4;
									}
									catch (Exception exception1)
									{
										ProjectData.SetProjectError(exception1);
										Exception exception = exception1;
										this.SaveDataPackageToDisk(RuntimeHelpers.GetObjectValue(obj));
										UploadThread.OnExceptionEventHandler onExceptionEventHandler = this.OnException;
										if (onExceptionEventHandler != null)
										{
											onExceptionEventHandler(exception);
										}
										ProjectData.ClearProjectError();
									}
								}
								else
								{
									UploadThread.OnDebugEventHandler onDebugEventHandler6 = this.OnDebug;
									if (onDebugEventHandler6 != null)
									{
										onDebugEventHandler6("Maskinen er offline. Data pakke gemmes på disk.");
									}
									this.SaveDataPackageToDisk(RuntimeHelpers.GetObjectValue(obj));
								}
							}
						}
						else if (this.IsWsOnline)
						{
							this.LoadDataPackageFromDisk();
						}
					}
					catch (Exception exception3)
					{
						ProjectData.SetProjectError(exception3);
						Exception exception2 = exception3;
						UploadThread.OnExceptionEventHandler onExceptionEventHandler1 = this.OnException;
						if (onExceptionEventHandler1 != null)
						{
							onExceptionEventHandler1(exception2);
						}
						ProjectData.ClearProjectError();
					}
				}
				finally
				{
					Thread.Sleep(100);
				}
			}
			return;
			goto Label4;
		Label1:
			this.SaveDataPackageToDisk(RuntimeHelpers.GetObjectValue(obj));
			goto Label4;
		Label2:
			if (num == 2627)
			{
				goto Label3;
			}
			goto Label1;
		}

		private Boolean ValidateDataPackage(Object package)
		{
			Boolean flag;
			try
			{
				Boolean flag1 = false;
				if ((object)package == (object)null)
				{
					flag1 = false;
				}
				else if (package is AdapterThread.AdapterChanged)
				{
					flag1 = true;
				}
				else if (package is ApplicationThread.ApplicationChanged)
				{
					flag1 = true;
				}
				else if (package is ClipboardThread.ClipboardChanged)
				{
					flag1 = true;
				}
				else if (package is ProcessThread.ProcessChanged)
				{
					flag1 = true;
				}
				else if (package is ScreenThread.ScreenChanged)
				{
					flag1 = true;
				}
				if (flag1)
				{
					if ((object)package.GetType().GetField("Data") != (object)null)
					{
						flag = !Information.IsNothing(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(package, null, "Data", new Object[0], null, null, null)));
						return flag;
					}
				}
				flag = flag1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public event UploadThread.OnDebugEventHandler OnDebug;

		public event UploadThread.OnExceptionEventHandler OnException;

		public event UploadThread.OnHeartbeatEventHandler OnHeartbeat;

		public event UploadThread.OnOnlineChangedEventHandler OnOnlineChanged;

		public delegate Void OnDebugEventHandler(String message);

		public delegate Void OnExceptionEventHandler(Exception ex);

		public delegate Void OnHeartbeatEventHandler(DateTime currentTime, Int32 result);

		public delegate Void OnOnlineChangedEventHandler(Boolean online);
	}
}