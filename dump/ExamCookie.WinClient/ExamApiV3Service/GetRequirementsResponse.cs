using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;

namespace ExamCookie.WinClient.ExamApiV3Service
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[MessageContract(WrapperName="GetRequirementsResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
	public class GetRequirementsResponse
	{
		[MessageBodyMember(Namespace="http://tempuri.org/", Order=0)]
		public Int32 GetRequirementsResult;

		[MessageBodyMember(Namespace="http://tempuri.org/", Order=1)]
		public String requirements;

		public GetRequirementsResponse()
		{
		}

		public GetRequirementsResponse(Int32 GetRequirementsResult, String requirements)
		{
			this.GetRequirementsResult = GetRequirementsResult;
			this.requirements = requirements;
		}
	}
}