using System;
using System.Collections.Generic;
using System.Text;

namespace ExamCookie.Library
{
	[Serializable]
	public class AnchorLink
	{
		public String Name;

		public List<Anchor> Anchors;

		public AnchorLink()
		{
			this.Name = "";
			this.Anchors = new List<Anchor>();
		}

		public AnchorLink(String name)
		{
			this.Name = "";
			this.Anchors = new List<Anchor>();
			this.Name = name;
		}

		public String ToHtml()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("{0}:", this.Name);
			Int32 count = checked(this.Anchors.get_Count() - 1);
			for (Int32 i = 0; i <= count; i = checked(i + 1))
			{
				stringBuilder.AppendFormat(" <a href='#{0}-{1}'>{2}</a>", this.Anchors.get_Item(i).Type.ToString(), this.Anchors.get_Item(i).Id, checked(i + 1));
			}
			return stringBuilder.ToString();
		}
	}
}