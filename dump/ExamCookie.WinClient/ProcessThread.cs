using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ExamCookie.WinClient
{
	public class ProcessThread
	{
		private const Int32 THREAD_SLEEP = 500;

		private Boolean _Started;

		private List<String> _IgnoreList;

		public List<String> IgnoreList
		{
			get
			{
				return this._IgnoreList;
			}
			set
			{
				this._IgnoreList = value;
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

		public ProcessThread()
		{
			this._Started = false;
			this._IgnoreList = new List<String>();
		}

		public ProcessThread(Int32 polltime)
		{
			Int32 num = polltime;
			base();
			ProcessThread._Closureu0024__17u002d0 variable = null;
			this._Started = false;
			this._IgnoreList = new List<String>();
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

		private Void Main(Int32 polltime)
		{
			ProcessThread._Closureu0024__26u002d0 variable = null;
			ProcessThread._Closureu0024__26u002d1 variable1 = null;
			List<ProcessThread.Process>.Enumerator enumerator = new List<ProcessThread.Process>.Enumerator();
			ProcessThread._Closureu0024__26u002d2 variable2 = null;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			List<ProcessThread.Process> list = new List<ProcessThread.Process>();
			List<ProcessThread.Process> list1 = new List<ProcessThread.Process>();
			List<ProcessThread.Process> list2 = new List<ProcessThread.Process>();
			while (this.Started)
			{
				try
				{
					try
					{
						if (stopwatch.get_ElapsedMilliseconds() >= (Int64)polltime)
						{
							stopwatch.Restart();
							if (list.get_Count() != 0)
							{
								list1.Clear();
								System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcesses();
								for (Int32 i = 0; i < (Int32)processes.Length; i = checked(i + 1))
								{
									variable1 = new ProcessThread._Closureu0024__26u002d1(variable1)
									{
										u0024VBu0024Local_proc = processes[i]
									};
									if (list1.Find(new Predicate<ProcessThread.Process>(variable1, (ProcessThread.Process x) => Operators.CompareString(x.Name, this.u0024VBu0024Local_proc.get_ProcessName(), false) == 0)) == null)
									{
										list1.Add(new ProcessThread.Process(variable1.u0024VBu0024Local_proc.get_Id(), variable1.u0024VBu0024Local_proc.get_ProcessName(), ""));
									}
								}
								list2.Clear();
								try
								{
									enumerator = list1.GetEnumerator();
									while (enumerator.MoveNext())
									{
										variable2 = new ProcessThread._Closureu0024__26u002d2(variable2)
										{
											u0024VBu0024Local_proc = enumerator.get_Current()
										};
										if (list.Find(new Predicate<ProcessThread.Process>(variable2, (ProcessThread.Process x) => Operators.CompareString(x.Name, this.u0024VBu0024Local_proc.Name, false) == 0)) == null)
										{
											if (!Enumerable.Contains<String>(this.IgnoreList, variable2.u0024VBu0024Local_proc.Name, StringComparer.get_OrdinalIgnoreCase()))
											{
												list2.Add(variable2.u0024VBu0024Local_proc);
											}
										}
									}
								}
								finally
								{
									enumerator.Dispose();
								}
								list.Clear();
								list.AddRange(list1);
								if (list2.get_Count() > 0)
								{
									ProcessThread.OnProcessChangedEventHandler onProcessChangedEventHandler = this.OnProcessChanged;
									if (onProcessChangedEventHandler != null)
									{
										onProcessChangedEventHandler(new ProcessThread.ProcessChanged(list2.ToArray()));
									}
								}
							}
							else
							{
								System.Diagnostics.Process[] processArray = System.Diagnostics.Process.GetProcesses();
								for (Int32 j = 0; j < (Int32)processArray.Length; j = checked(j + 1))
								{
									variable = new ProcessThread._Closureu0024__26u002d0(variable)
									{
										u0024VBu0024Local_proc = processArray[j]
									};
									if (list.Find(new Predicate<ProcessThread.Process>(variable, (ProcessThread.Process x) => Operators.CompareString(x.Name, this.u0024VBu0024Local_proc.get_ProcessName(), false) == 0)) == null)
									{
										list.Add(new ProcessThread.Process(variable.u0024VBu0024Local_proc.get_Id(), variable.u0024VBu0024Local_proc.get_ProcessName(), ""));
									}
								}
								ProcessThread.OnProcessChangedEventHandler onProcessChangedEventHandler1 = this.OnProcessChanged;
								if (onProcessChangedEventHandler1 != null)
								{
									onProcessChangedEventHandler1(new ProcessThread.ProcessChanged(list.ToArray()));
								}
							}
						}
					}
					catch (Exception exception1)
					{
						ProjectData.SetProjectError(exception1);
						Exception exception = exception1;
						ProcessThread.OnExceptionEventHandler onExceptionEventHandler = this.OnException;
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

		public event ProcessThread.OnDebugEventHandler OnDebug;

		public event ProcessThread.OnExceptionEventHandler OnException;

		public event ProcessThread.OnProcessChangedEventHandler OnProcessChanged;

		public delegate Void OnDebugEventHandler(String message);

		public delegate Void OnExceptionEventHandler(Exception ex);

		public delegate Void OnProcessChangedEventHandler(ProcessThread.ProcessChanged sender);

		[Serializable]
		public class Process
		{
			public Int32 Pid;

			public String Name;

			public String OriginalFilename;

			public Process()
			{
				this.Pid = 0;
				this.Name = "";
				this.OriginalFilename = "";
			}

			public Process(Int32 pid, String name, String originalFilename)
			{
				this.Pid = 0;
				this.Name = "";
				this.OriginalFilename = "";
				this.Pid = pid;
				if ((object)name != (object)null)
				{
					name = name.Replace("\0", "");
					this.Name = name;
					this.OriginalFilename = originalFilename;
				}
			}
		}

		[Serializable]
		public class ProcessChanged
		{
			public String Reference;

			public String Token;

			public DateTime CanSend;

			public DateTime TimeStamp;

			public ProcessThread.Process[] Processes;

			public ProcessChanged()
			{
				this.Reference = Guid.NewGuid().ToString();
				this.Token = "";
				this.CanSend = DateTime.MinValue;
				this.TimeStamp = DateTime.MinValue;
				this.Processes = null;
			}

			public ProcessChanged(ProcessThread.Process[] processes)
			{
				this.Reference = Guid.NewGuid().ToString();
				this.Token = "";
				this.CanSend = DateTime.MinValue;
				this.TimeStamp = DateTime.MinValue;
				this.Processes = null;
				this.Processes = processes;
			}

			public String Data()
			{
				List<String> list = new List<String>();
				ProcessThread.Process[] processes = this.Processes;
				for (Int32 i = 0; i < (Int32)processes.Length; i = checked(i + 1))
				{
					ProcessThread.Process process = processes[i];
					if ((object)process.Name != (object)null)
					{
						if (!list.Contains(process.Name))
						{
							list.Add(process.Name);
						}
					}
				}
				return Strings.Join(list.ToArray(), "\r\n");
			}
		}
	}
}