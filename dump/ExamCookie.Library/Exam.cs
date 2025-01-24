using System;

namespace ExamCookie.Library
{
	[Serializable]
	public class Exam
	{
		[NonSerialized]
		public Int32 Id;

		public Int32 Status;

		public String Code;

		public String Description;

		public DateTime TimeBegin;

		public DateTime TimeEnd;

		public Exam()
		{
			this.Id = 0;
			this.Status = 0;
			this.Code = "";
			this.Description = "";
			this.TimeBegin = DateTime.MinValue;
			this.TimeEnd = DateTime.MinValue;
		}

		public Exam(Int32 id, Int32 status, String code, String description, DateTime timeBegin, DateTime timeEnd)
		{
			this.Id = 0;
			this.Status = 0;
			this.Code = "";
			this.Description = "";
			this.TimeBegin = DateTime.MinValue;
			this.TimeEnd = DateTime.MinValue;
			this.Id = id;
			this.Status = status;
			this.Code = code;
			this.Description = description;
			this.TimeBegin = timeBegin;
			this.TimeEnd = timeEnd;
		}
	}
}