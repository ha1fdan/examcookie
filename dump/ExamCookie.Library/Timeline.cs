using System;

namespace ExamCookie.Library
{
	[Serializable]
	public class Timeline
	{
		public Int32 StudentId;

		public Int32 ItemId;

		public eEventType ItemType;

		public Int32 ItemSubType;

		public String TimeList;

		public Timeline()
		{
			this.StudentId = 0;
			this.ItemId = 0;
			this.ItemType = eEventType.NONE;
			this.ItemSubType = 0;
			this.TimeList = "";
		}

		public Timeline(Int32 studentId, Int32 itemId, eEventType itemType, Int32 itemSubType, String timeList)
		{
			this.StudentId = 0;
			this.ItemId = 0;
			this.ItemType = eEventType.NONE;
			this.ItemSubType = 0;
			this.TimeList = "";
			this.StudentId = studentId;
			this.ItemId = itemId;
			this.ItemType = itemType;
			this.ItemSubType = itemSubType;
			this.TimeList = timeList;
		}
	}
}