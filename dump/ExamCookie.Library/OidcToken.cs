using System;
using System.Runtime.CompilerServices;

namespace ExamCookie.Library
{
	[Serializable]
	public class OidcToken
	{
		public String IdTokenHint
		{
			get;
			set;
		}

		public String PostLogoutRedirectUri
		{
			get;
			set;
		}

		public String PostLogoutUri
		{
			get;
			set;
		}

		public String UniId
		{
			get;
			set;
		}

		public String UniToken
		{
			get;
			set;
		}

		public OidcToken(String uniId, String uniToken, String postLogoutUri, String postLogoutRedirectUri, String idTokenHint)
		{
			this.UniId = "";
			this.UniToken = "";
			this.PostLogoutUri = "";
			this.PostLogoutRedirectUri = "";
			this.IdTokenHint = "";
			this.UniId = uniId;
			this.PostLogoutUri = postLogoutUri;
			this.PostLogoutRedirectUri = postLogoutRedirectUri;
			this.IdTokenHint = idTokenHint;
		}
	}
}