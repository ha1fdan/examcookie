using System;
using System.Collections.Generic;

namespace ExamCookie.Library
{
	public class SignInLog
	{
		public ExamCookie.Library.SignIn SignIn;

		public List<ExamCookie.Library.Clipboard> Clipboard;

		public List<ExamCookie.Library.FrontApp> FrontApp;

		public List<ExamCookie.Library.Machine> Machine;

		public List<ExamCookie.Library.Process> Process;

		public List<ExamCookie.Library.ScreenShot> ScreenShot;

		public SignInLog()
		{
			this.SignIn = null;
			this.Clipboard = new List<ExamCookie.Library.Clipboard>();
			this.FrontApp = new List<ExamCookie.Library.FrontApp>();
			this.Machine = new List<ExamCookie.Library.Machine>();
			this.Process = new List<ExamCookie.Library.Process>();
			this.ScreenShot = new List<ExamCookie.Library.ScreenShot>();
		}

		public SignInLog(ExamCookie.Library.SignIn signIn)
		{
			this.SignIn = null;
			this.Clipboard = new List<ExamCookie.Library.Clipboard>();
			this.FrontApp = new List<ExamCookie.Library.FrontApp>();
			this.Machine = new List<ExamCookie.Library.Machine>();
			this.Process = new List<ExamCookie.Library.Process>();
			this.ScreenShot = new List<ExamCookie.Library.ScreenShot>();
			this.SignIn = signIn;
		}
	}
}