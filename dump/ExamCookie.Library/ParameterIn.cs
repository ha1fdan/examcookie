using System;

namespace ExamCookie.Library
{
	[Serializable]
	public class ParameterIn
	{
		public String OperatingSystem;

		public Int32 Virtualized;

		public eClientType ClientType;

		public String ClientVersion;

		public ParameterIn()
		{
			this.OperatingSystem = "";
			this.Virtualized = 0;
			this.ClientType = eClientType.UNKNOWN;
			this.ClientVersion = "";
		}

		public ParameterIn(String operatingSystem, Int32 virtualized, eClientType clientType, String clientVersion)
		{
			this.OperatingSystem = "";
			this.Virtualized = 0;
			this.ClientType = eClientType.UNKNOWN;
			this.ClientVersion = "";
			this.OperatingSystem = operatingSystem;
			this.Virtualized = virtualized;
			this.ClientType = clientType;
			this.ClientVersion = clientVersion;
		}
	}
}