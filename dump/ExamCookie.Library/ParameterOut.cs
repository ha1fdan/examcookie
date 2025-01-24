using System;

namespace ExamCookie.Library
{
	[Serializable]
	public class ParameterOut
	{
		public String Token;

		public DateTime CurrentTime;

		public ClientStudent Student;

		public ClientExam Exam;

		public ClientConfig ClientConfiguration;

		public ParameterOut()
		{
			this.Token = "";
			this.CurrentTime = DateTime.MinValue;
			this.Student = new ClientStudent();
			this.Exam = new ClientExam();
			this.ClientConfiguration = new ClientConfig();
		}
	}
}