using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;

namespace ExamCookie.WinClient.ExamApiV3Service
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[MessageContract(WrapperName="GetExamInformationResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
	public class GetExamInformationResponse
	{
		[MessageBodyMember(Namespace="http://tempuri.org/", Order=0)]
		public Int32 GetExamInformationResult;

		[MessageBodyMember(Namespace="http://tempuri.org/", Order=1)]
		public String information;

		public GetExamInformationResponse()
		{
		}

		public GetExamInformationResponse(Int32 GetExamInformationResult, String information)
		{
			this.GetExamInformationResult = GetExamInformationResult;
			this.information = information;
		}
	}
}