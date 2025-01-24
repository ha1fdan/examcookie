using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ExamCookie.WinClient.My
{
	[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	internal class MyApplication : WindowsFormsApplicationBase
	{
		[DebuggerStepThrough]
		public MyApplication() : base(0)
		{
			base.set_IsSingleInstance(true);
			base.set_EnableVisualStyles(true);
			base.set_SaveMySettingsOnExit(true);
			base.set_ShutdownStyle(0);
		}

		[DebuggerHidden]
		[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
		[MethodImpl(72)]
		[STAThread]
		internal static void Main(String[] Args)
		{
			try
			{
				Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
			}
			finally
			{
			}
			MyProject.Application.Run(Args);
		}

		[DebuggerStepThrough]
		protected override void OnCreateMainForm()
		{
			base.set_MainForm(MyProject.Forms.FormMain);
		}
	}
}