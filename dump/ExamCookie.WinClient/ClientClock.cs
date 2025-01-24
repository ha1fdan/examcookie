using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ExamCookie.WinClient
{
	public class ClientClock
	{
		private Stopwatch StopWatch;

		private DateTime InitialTime;

		public DateTime CurrentTime
		{
			get
			{
				DateTime dateTime = this.InitialTime.AddMilliseconds((Double)this.StopWatch.get_ElapsedMilliseconds());
				return dateTime;
			}
			set
			{
				try
				{
					this.InitialTime = value;
					this.StopWatch.Restart();
				}
				catch (Exception exception1)
				{
					ProjectData.SetProjectError(exception1);
					Exception exception = exception1;
					ClientClock.OnExceptionEventHandler onExceptionEventHandler = this.OnException;
					if (onExceptionEventHandler != null)
					{
						onExceptionEventHandler(exception);
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		public ClientClock()
		{
			this.StopWatch = new Stopwatch();
			this.InitialTime = DateTime.MinValue;
		}

		public ClientClock(DateTime initialTime)
		{
			this.StopWatch = new Stopwatch();
			this.InitialTime = DateTime.MinValue;
			this.InitialTime = initialTime;
			this.StopWatch.Start();
		}

		public event ClientClock.OnExceptionEventHandler OnException;

		public delegate Void OnExceptionEventHandler(Exception ex);
	}
}