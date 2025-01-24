using System;

namespace ExamCookie.Library
{
	[Serializable]
	public class Clipboard
	{
		public Int32 SignInId;

		public DateTime TimeStamp;

		public eDataFormat Type;

		public Byte[] Data;

		public Clipboard()
		{
			this.SignInId = 0;
			this.TimeStamp = DateTime.MinValue;
			this.Type = eDataFormat.NONE;
			this.Data = null;
		}

		public Clipboard(Int32 signInId, DateTime timeStamp, eDataFormat type, Byte[] data)
		{
			this.SignInId = 0;
			this.TimeStamp = DateTime.MinValue;
			this.Type = eDataFormat.NONE;
			this.Data = null;
			this.SignInId = signInId;
			this.TimeStamp = timeStamp;
			this.Type = type;
			this.Data = data;
		}

		public override String ToString()
		{
			String str = String.Format("{0} > {1}", this.TimeStamp.ToString(), this.Type.ToString());
			return str;
		}
	}
}