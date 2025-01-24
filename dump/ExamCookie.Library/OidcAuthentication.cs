using System;
using System.Runtime.CompilerServices;

namespace ExamCookie.Library
{
	[Serializable]
	public class OidcAuthentication
	{
		public String CodeVerifier
		{
			get;
			set;
		}

		public String Url
		{
			get;
			set;
		}

		public OidcAuthentication(String url, String codeVerifier)
		{
			this.Url = "";
			this.CodeVerifier = "";
			this.Url = url;
			this.CodeVerifier = codeVerifier;
		}
	}
}