using ExamCookie.Library;
using ExamCookie.WinClient.ExamApiV3Service;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web.Script.Serialization;

namespace ExamCookie.WinClient
{
	public class ConfigurationThread
	{
		private const Int32 THREAD_SLEEP = 500;

		private Boolean _Started;

		private Boolean _IsOnline;

		private Random _Random;

		public Boolean IsOnline
		{
			get
			{
				return this._IsOnline;
			}
			set
			{
				this._IsOnline = value;
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

		public ConfigurationThread()
		{
			this._Started = false;
			this._IsOnline = false;
			this._Random = new Random();
			Thread thread = new Thread(new ThreadStart(this, ConfigurationThread.Main));
			this.Started = true;
			thread.Start();
		}

		private Int32 GetNextPolltime()
		{
			return this._Random.Next(30000, 90000);
		}

		private Void Main()
		{
			Int32 nextPolltime = this.GetNextPolltime();
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			while (this.Started)
			{
				try
				{
					try
					{
						if (stopwatch.get_ElapsedMilliseconds() >= (Int64)nextPolltime)
						{
							stopwatch.Restart();
							nextPolltime = this.GetNextPolltime();
							ExamApiV3Client examApiV3Client = Module1.ExamClient();
							try
							{
								ExamApiV3Client examApiV3Client1 = examApiV3Client;
								Module1.SetCredentials(ref examApiV3Client1);
								String str = "";
								if (examApiV3Client.GetExamInformation(Module1.Config.Token, ref str) == 0)
								{
									ExamInformation examInformation = (ExamInformation)(new JavaScriptSerializer()).Deserialize(str, typeof(ExamInformation));
									if ((object)examInformation != (object)null)
									{
										if (DateTime.Compare(Module1.Config.Exam.TimeBegin, examInformation.Exam.TimeBegin) != 0)
										{
											Module1.Config.Exam.TimeBegin = examInformation.Exam.TimeBegin;
											ConfigurationThread.OnConfigurationChangedEventHandler onConfigurationChangedEventHandler = this.OnConfigurationChanged;
											if (onConfigurationChangedEventHandler != null)
											{
												onConfigurationChangedEventHandler(new String[] { "Eksamens starttidspunkt er ændret.", String.Concat("Eksamen begynder: ", Strings.Format(Module1.Config.Exam.TimeBegin, "dd-MM-yyyy HH:mm")) });
											}
										}
										else if (DateTime.Compare(Module1.Config.Exam.TimeEnd, examInformation.Exam.TimeEnd) != 0)
										{
											Module1.Config.Exam.TimeEnd = examInformation.Exam.TimeEnd;
											ConfigurationThread.OnConfigurationChangedEventHandler onConfigurationChangedEventHandler1 = this.OnConfigurationChanged;
											if (onConfigurationChangedEventHandler1 != null)
											{
												onConfigurationChangedEventHandler1(new String[] { "Eksamens sluttidspunkt er ændret.", String.Concat("Eksamen slutter: ", Module1.FormatExamEndTime(Module1.Config.Exam.TimeEnd, Module1.Config.Exam.TimeEndExt, "dd-MM-yyyy HH:mm")) });
											}
										}
										else if (Module1.Config.Exam.TimeEndExt != examInformation.Exam.TimeEndExt)
										{
											Module1.Config.Exam.TimeEndExt = examInformation.Exam.TimeEndExt;
											ConfigurationThread.OnConfigurationChangedEventHandler onConfigurationChangedEventHandler2 = this.OnConfigurationChanged;
											if (onConfigurationChangedEventHandler2 != null)
											{
												onConfigurationChangedEventHandler2(new String[] { "Eksamen er tildelt ekstra tid.", String.Concat("Eksamen slutter: ", Module1.FormatExamEndTime(Module1.Config.Exam.TimeEnd, Module1.Config.Exam.TimeEndExt, "dd-MM-yyyy HH:mm")) });
											}
										}
										else if (Module1.Config.Exam.StudentTimeExt != examInformation.Exam.StudentTimeExt)
										{
											Module1.Config.Exam.StudentTimeExt = examInformation.Exam.StudentTimeExt;
											ConfigurationThread.OnConfigurationChangedEventHandler onConfigurationChangedEventHandler3 = this.OnConfigurationChanged;
											if (onConfigurationChangedEventHandler3 != null)
											{
												onConfigurationChangedEventHandler3(new String[] { "Eleven er tildelt ekstra tid.", String.Concat("Eksamen slutter: ", Module1.FormatExamEndTime(Module1.Config.Exam.TimeEnd, Module1.Config.Exam.TimeEndExt, "dd-MM-yyyy HH:mm")), String.Format("Ekstra elev tid: {0} minutter.", Module1.Config.Exam.StudentTimeExt) });
											}
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
					}
					catch (Exception exception1)
					{
						ProjectData.SetProjectError(exception1);
						Exception exception = exception1;
						ConfigurationThread.OnExceptionEventHandler onExceptionEventHandler = this.OnException;
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

		public event ConfigurationThread.OnConfigurationChangedEventHandler OnConfigurationChanged;

		public event ConfigurationThread.OnDebugEventHandler OnDebug;

		public event ConfigurationThread.OnExceptionEventHandler OnException;

		public delegate Void OnConfigurationChangedEventHandler(String[] message);

		public delegate Void OnDebugEventHandler(String message);

		public delegate Void OnExceptionEventHandler(Exception ex);
	}
}