using System;

namespace ExamCookie.WinClient
{
	[Serializable]
	public class ClientError
	{
		public Int32 Count;

		public String Message;

		public ClientError()
		{
			this.Count = 0;
			this.Message = "";
		}

		public ClientError(String message)
		{
			this.Count = 0;
			this.Message = "";
			this.Message = message;
			this.Count = 1;
		}
	}
}