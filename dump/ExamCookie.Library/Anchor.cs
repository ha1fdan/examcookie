using System;

namespace ExamCookie.Library
{
	[Serializable]
	public class Anchor
	{
		public Int32 Id;

		public eReportSource Type;

		public Anchor()
		{
			this.Id = 0;
			this.Type = eReportSource.NONE;
		}

		public Anchor(Int32 id, eReportSource type)
		{
			this.Id = 0;
			this.Type = eReportSource.NONE;
			this.Id = id;
			this.Type = type;
		}
	}
}