using System;

namespace ExamCookie.Library
{
	[Serializable]
	public class Machine
	{
		public Int32 SignInId;

		public DateTime TimeStamp;

		public String Data;

		public Machine()
		{
			this.SignInId = 0;
			this.TimeStamp = DateTime.MinValue;
			this.Data = "";
		}

		public Machine(Int32 signInId, DateTime timeStamp, String data)
		{
			this.SignInId = 0;
			this.TimeStamp = DateTime.MinValue;
			this.Data = "";
			this.SignInId = signInId;
			this.TimeStamp = timeStamp;
			this.Data = data;
		}
	}
}