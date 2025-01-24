using System;

namespace ExamCookie.Library
{
	[Serializable]
	public class ClientExam
	{
		public Int32 Id;

		public Int32 Status;

		public String Code;

		public String Description;

		public DateTime TimeBegin;

		public DateTime TimeEnd;

		public Int32 TimeEndExt;

		public Int32 StudentTimeExt;

		public Int32 TimeExt;

		public ClientExam()
		{
			this.Id = 0;
			this.Status = 0;
			this.Code = "";
			this.Description = "";
			this.TimeBegin = DateTime.MinValue;
			this.TimeEnd = DateTime.MinValue;
			this.TimeEndExt = 0;
			this.StudentTimeExt = 0;
			this.TimeExt = 0;
		}
	}
}