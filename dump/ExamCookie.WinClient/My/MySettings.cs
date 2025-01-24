using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ExamCookie.WinClient.My
{
	[CompilerGenerated]
	[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
	internal sealed class MySettings : ApplicationSettingsBase
	{
		private static MySettings defaultInstance;

		private static Boolean addedHandler;

		private static Object addedHandlerLockObject;

		public static MySettings Default
		{
			get
			{
				if (!MySettings.addedHandler)
				{
					Object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					Boolean flag = false;
					try
					{
						Monitor.Enter(obj, ref flag);
						if (!MySettings.addedHandler)
						{
							MyProject.Application.add_Shutdown(new ShutdownEventHandler(null, MySettings.AutoSaveSettings));
							MySettings.addedHandler = true;
						}
					}
					finally
					{
						if (flag)
						{
							Monitor.Exit(obj);
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		static MySettings()
		{
			MySettings.defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());
			MySettings.addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new Object());
		}

		public MySettings()
		{
		}

		[DebuggerNonUserCode]
		[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
		private static Void AutoSaveSettings(Object sender, EventArgs e)
		{
			if (MyProject.Application.get_SaveMySettingsOnExit())
			{
				MySettingsProperty.Settings.Save();
			}
		}
	}
}