using System;

namespace ExamCookie.Library
{
	[Serializable]
	public class SignIn
	{
		public Int32 Id;

		public Int32 ExamId;

		public Int32 StudentId;

		public eSignInStatus Status;

		public String ErrorText;

		public DateTime CurrentTime;

		public DateTime StartTime;

		public DateTime EndTime;

		public DateTime TimeSignIn;

		public DateTime TimeSignOut;

		public DateTime TimeHeartBeat;

		public SignIn()
		{
			this.Id = 0;
			this.ExamId = 0;
			this.StudentId = 0;
			this.Status = eSignInStatus.STUDENT_NOT_FOUND;
			this.ErrorText = "";
			this.CurrentTime = DateTime.MinValue;
			this.StartTime = DateTime.MinValue;
			this.EndTime = DateTime.MinValue;
			this.TimeSignIn = DateTime.MinValue;
			this.TimeSignOut = DateTime.MinValue;
			this.TimeHeartBeat = DateTime.MinValue;
		}

		public SignIn(Int32 id, Int32 examId, Int32 studentId, DateTime timeSignIn)
		{
			this.Id = 0;
			this.ExamId = 0;
			this.StudentId = 0;
			this.Status = eSignInStatus.STUDENT_NOT_FOUND;
			this.ErrorText = "";
			this.CurrentTime = DateTime.MinValue;
			this.StartTime = DateTime.MinValue;
			this.EndTime = DateTime.MinValue;
			this.TimeSignIn = DateTime.MinValue;
			this.TimeSignOut = DateTime.MinValue;
			this.TimeHeartBeat = DateTime.MinValue;
			this.Id = id;
			this.ExamId = examId;
			this.StudentId = studentId;
			this.TimeSignIn = timeSignIn;
		}
	}
}