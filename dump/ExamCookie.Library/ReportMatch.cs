using System;
using System.Collections.Generic;

namespace ExamCookie.Library
{
	[Serializable]
	public class ReportMatch
	{
		public Int32 ExamId;

		public Int32 StudentId;

		public List<Match> Matches;

		public ReportMatch()
		{
			this.Matches = new List<Match>();
		}

		public ReportMatch(Int32 examId, Int32 studentId)
		{
			this.Matches = new List<Match>();
			this.ExamId = examId;
			this.StudentId = studentId;
		}
	}
}