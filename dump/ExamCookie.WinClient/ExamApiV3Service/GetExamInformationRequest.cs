using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;

namespace ExamCookie.WinClient.ExamApiV3Service
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[MessageContract(WrapperName="GetExamInformation", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
	public class GetExamInformationRequest
	{
		[MessageBodyMember(Namespace="http://tempuri.org/", Order=0)]
		public String token;

		[MessageBodyMember(Namespace="http://tempuri.org/", Order=1)]
		public String information;

		public GetExamInformationRequest()
		{
		}

		public GetExamInformationRequest(String token, String information)
		{
			this.token = token;
			this.information = information;
		}
	}
}