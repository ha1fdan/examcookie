using ExamCookie.Library;
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;

namespace ExamCookie.WinClient.ExamApiV3Service
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[MessageContract(WrapperName="GetRequirements", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
	public class GetRequirementsRequest
	{
		[MessageBodyMember(Namespace="http://tempuri.org/", Order=0)]
		public eClientType type;

		[MessageBodyMember(Namespace="http://tempuri.org/", Order=1)]
		public String requirements;

		public GetRequirementsRequest()
		{
		}

		public GetRequirementsRequest(eClientType type, String requirements)
		{
			this.type = type;
			this.requirements = requirements;
		}
	}
}