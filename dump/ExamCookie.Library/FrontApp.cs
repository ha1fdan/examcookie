using System;

namespace ExamCookie.Library
{
	[Serializable]
	public class FrontApp
	{
		public Int32 SignInId;

		public DateTime TimeStamp;

		public eApplicationType Type;

		public String Name;

		public String Document;

		public FrontApp()
		{
			this.SignInId = 0;
			this.TimeStamp = DateTime.MinValue;
			this.Type = eApplicationType.APPLICATION;
			this.Name = "";
			this.Document = "";
		}

		public FrontApp(Int32 signInId, DateTime timeStamp, eApplicationType type, String name, String document)
		{
			this.SignInId = 0;
			this.TimeStamp = DateTime.MinValue;
			this.Type = eApplicationType.APPLICATION;
			this.Name = "";
			this.Document = "";
			this.SignInId = signInId;
			this.TimeStamp = timeStamp;
			this.Type = type;
			this.Name = name;
			this.Document = document;
		}
	}
}