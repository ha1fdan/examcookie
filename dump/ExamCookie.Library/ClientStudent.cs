using System;

namespace ExamCookie.Library
{
	[Serializable]
	public class ClientStudent
	{
		public String Name;

		public String Username;

		public String Classname;

		public ClientStudent()
		{
			this.Name = "";
			this.Username = "";
			this.Classname = "";
		}
	}
}