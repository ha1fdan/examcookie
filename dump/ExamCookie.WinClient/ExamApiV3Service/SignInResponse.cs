using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;

namespace ExamCookie.WinClient.ExamApiV3Service
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[MessageContract(WrapperName="SignInResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
	public class SignInResponse
	{
		[MessageBodyMember(Namespace="http://tempuri.org/", Order=0)]
		public Int32 SignInResult;

		[MessageBodyMember(Namespace="http://tempuri.org/", Order=1)]
		public String parameterOut;

		public SignInResponse()
		{
		}

		public SignInResponse(Int32 SignInResult, String parameterOut)
		{
			this.SignInResult = SignInResult;
			this.parameterOut = parameterOut;
		}
	}
}