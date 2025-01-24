using System;

namespace ExamCookie.Library
{
	[Serializable]
	public class ExamInformation
	{
		public ClientStudent Student;

		public ClientExam Exam;

		public ExamInformation()
		{
			this.Student = new ClientStudent();
			this.Exam = new ClientExam();
		}
	}
}