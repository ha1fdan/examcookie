using System;
using System.Collections.Generic;

namespace ExamCookie.Library
{
	[Serializable]
	public class Match
	{
		public Int32 Id;

		public eReportSource Type;

		public List<String> Search;

		public String Text;

		public Boolean Found;

		public Match()
		{
			this.Id = 0;
			this.Type = eReportSource.NONE;
			this.Search = new List<String>();
			this.Text = "";
			this.Found = false;
		}

		public Match(Int32 id, eReportSource type, String[] search, String text)
		{
			this.Id = 0;
			this.Type = eReportSource.NONE;
			this.Search = new List<String>();
			this.Text = "";
			this.Found = false;
			this.Id = id;
			this.Type = type;
			this.Search.AddRange(search);
			this.Text = text;
		}
	}
}