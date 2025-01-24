using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;

namespace ExamCookie.WinClient.ExamApiV3Service
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[MessageContract(WrapperName="SignIn", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
	public class SignInRequest
	{
		[MessageBodyMember(Namespace="http://tempuri.org/", Order=0)]
		public String code;

		[MessageBodyMember(Namespace="http://tempuri.org/", Order=1)]
		public String username;

		[MessageBodyMember(Namespace="http://tempuri.org/", Order=2)]
		public String password;

		[MessageBodyMember(Namespace="http://tempuri.org/", Order=3)]
		public String parameterIn;

		[MessageBodyMember(Namespace="http://tempuri.org/", Order=4)]
		public String parameterOut;

		public SignInRequest()
		{
		}

		public SignInRequest(String code, String username, String password, String parameterIn, String parameterOut)
		{
			this.code = code;
			this.username = username;
			this.password = password;
			this.parameterIn = parameterIn;
			this.parameterOut = parameterOut;
		}
	}
}