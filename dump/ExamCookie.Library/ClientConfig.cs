using System;

namespace ExamCookie.Library
{
	[Serializable]
	public class ClientConfig
	{
		public String MinimumClientVersionWindows;

		public String MinimumClientVersionMac;

		public String MinimumClientVersionLinux;

		public String MinimumClientVersionChromeBook;

		public String[] OperatingSystemsWindows;

		public String[] OperatingSystemsMac;

		public String[] OperatingSystemsLinux;

		public String[] OperatingSystemsChromeBook;

		public Int32 MinimumHarddiskSpace;

		public Int32 NotifyBoxDisplayTime;

		public Boolean IncludeLogfile;

		public Int32 ThreadsDelayedMin;

		public Int32 ThreadsDelayedMax;

		public Int32 HeartbeatPulseMin;

		public Int32 HeartbeatPulseMax;

		public Int32 ScreenPolltime;

		public Int32 ScreenChangedPercent;

		public Int32 ScreenChangedPercentWindows;

		public Int32 ScreenChangedPercentMac;

		public Int32 ScreenChangedPercentLinux;

		public Int32 ScreenChangedPercentChromeBook;

		public Int32 ScreenSendDelay;

		public Int32 ScreenForceSendTime;

		public Int32 ImageQuality;

		public Int32 ClipboardPolltime;

		public Int32 FrontAppPolltime;

		public Int32 ProcessPolltime;

		public String[] ProcessIgnoreWindows;

		public String[] ProcessIgnoreMac;

		public String[] ProcessIgnoreLinux;

		public String[] ProcessIgnoreChromeBook;

		public Int32 AdapterPolltime;

		public ClientConfig()
		{
			this.MinimumClientVersionWindows = "1.0.0.0";
			this.MinimumClientVersionMac = "1.0.0.0";
			this.MinimumClientVersionLinux = "1.0.0.0";
			this.MinimumClientVersionChromeBook = "1.0.0.0";
			this.OperatingSystemsWindows = new String[0];
			this.OperatingSystemsMac = new String[0];
			this.OperatingSystemsLinux = new String[0];
			this.OperatingSystemsChromeBook = new String[0];
			this.MinimumHarddiskSpace = 500000000;
			this.NotifyBoxDisplayTime = 10;
			this.IncludeLogfile = false;
			this.ThreadsDelayedMin = 5;
			this.ThreadsDelayedMax = 20;
			this.HeartbeatPulseMin = 30;
			this.HeartbeatPulseMax = 60;
			this.ScreenPolltime = 5000;
			this.ScreenChangedPercent = 5;
			this.ScreenChangedPercentWindows = 5;
			this.ScreenChangedPercentMac = 5;
			this.ScreenChangedPercentLinux = 5;
			this.ScreenChangedPercentChromeBook = 5;
			this.ScreenSendDelay = 1;
			this.ScreenForceSendTime = 300;
			this.ImageQuality = 20;
			this.ClipboardPolltime = 500;
			this.FrontAppPolltime = 1000;
			this.ProcessPolltime = 5000;
			this.ProcessIgnoreWindows = new String[0];
			this.ProcessIgnoreMac = new String[0];
			this.ProcessIgnoreLinux = new String[0];
			this.ProcessIgnoreChromeBook = new String[0];
			this.AdapterPolltime = 20000;
		}
	}
}