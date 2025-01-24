using System;

namespace ExamCookie.Library
{
	[Serializable]
	public class ScreenShot
	{
		public Int32 SignInId;

		public DateTime TimeStamp;

		public Byte[] Data;

		public ScreenShot()
		{
			this.SignInId = 0;
			this.TimeStamp = DateTime.MinValue;
			this.Data = null;
		}

		public ScreenShot(Int32 signInId, DateTime timeStamp, Byte[] data)
		{
			this.SignInId = 0;
			this.TimeStamp = DateTime.MinValue;
			this.Data = null;
			this.SignInId = signInId;
			this.TimeStamp = timeStamp;
			this.Data = data;
		}

		public override String ToString()
		{
			return String.Format("{0} > IMAGE", this.TimeStamp.ToString());
		}
	}
}