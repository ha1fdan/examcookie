using System;

namespace ExamCookie.Library
{
	[Serializable]
	public class User
	{
		public Int32 Id;

		public Int32 SiteId;

		public String Name;

		public String Username;

		public String Password;

		public eUserType TypeValue;

		public String Phone;

		public User()
		{
			this.Id = 0;
			this.SiteId = 0;
			this.Name = "";
			this.Username = "";
			this.Password = "";
			this.TypeValue = eUserType.STUDENT;
			this.Phone = "";
		}

		public User(Int32 id, Int32 siteId, String name, String username, String password, eUserType typeValue, String phone)
		{
			this.Id = 0;
			this.SiteId = 0;
			this.Name = "";
			this.Username = "";
			this.Password = "";
			this.TypeValue = eUserType.STUDENT;
			this.Phone = "";
			this.Id = id;
			this.SiteId = siteId;
			this.Name = name;
			this.Username = username;
			this.Password = password;
			this.TypeValue = typeValue;
			this.Phone = phone;
		}
	}
}