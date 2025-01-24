using System;

namespace ExamCookie.Library
{
	[Serializable]
	public class Site
	{
		public Int32 Id;

		public String Name;

		public String Address;

		public String ZipCode;

		public String City;

		public String Phone;

		public Site()
		{
			this.Id = 0;
			this.Name = "";
			this.Address = "";
			this.ZipCode = "";
			this.City = "";
			this.Phone = "";
		}

		public Site(Int32 id, String name, String address, String zipCode, String city, String phone)
		{
			this.Id = 0;
			this.Name = "";
			this.Address = "";
			this.ZipCode = "";
			this.City = "";
			this.Phone = "";
			this.Id = id;
			this.Name = name;
			this.Address = address;
			this.ZipCode = zipCode;
			this.City = city;
			this.Phone = phone;
		}
	}
}