using System;

namespace ExamCookie.Library
{
	[Serializable]
	public class ClientRequirements
	{
		public String[] OperatingSystems;

		public String MinimumClientVersion;

		public Int32 MinimumHarddiskSpace;

		public ClientRequirements()
		{
			this.OperatingSystems = new String[0];
			this.MinimumClientVersion = "";
			this.MinimumHarddiskSpace = 0;
		}
	}
}