using System;

namespace ExamCookie.Library
{
	[Serializable]
	public class Student
	{
		public Int32 Id;

		public Int32 SiteId;

		public String Name;

		public String Classname;

		public String[] Teams;

		public String Username;

		public String Password;

		public Int32 TimeExt;

		public DateTime Updated;

		public String Email;

		public Student()
		{
			this.Id = 0;
			this.SiteId = 0;
			this.Name = "";
			this.Classname = "";
			this.Teams = null;
			this.Username = "";
			this.Password = "";
			this.TimeExt = 0;
			this.Updated = DateTime.MinValue;
			this.Email = "";
		}

		public Student(Int32 id, String username, String password)
		{
			this.Id = 0;
			this.SiteId = 0;
			this.Name = "";
			this.Classname = "";
			this.Teams = null;
			this.Username = "";
			this.Password = "";
			this.TimeExt = 0;
			this.Updated = DateTime.MinValue;
			this.Email = "";
			this.Id = id;
			this.Username = username;
			this.Password = password;
		}

		public Student(Int32 id, String classname, String[] teams, String name, String username, String password)
		{
			this.Id = 0;
			this.SiteId = 0;
			this.Name = "";
			this.Classname = "";
			this.Teams = null;
			this.Username = "";
			this.Password = "";
			this.TimeExt = 0;
			this.Updated = DateTime.MinValue;
			this.Email = "";
			this.Id = id;
			this.Classname = classname;
			this.Teams = teams;
			this.Name = name;
			this.Username = username;
			this.Password = password;
		}
	}
}