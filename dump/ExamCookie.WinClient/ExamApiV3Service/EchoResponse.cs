using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;

namespace ExamCookie.WinClient.ExamApiV3Service
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[MessageContract(WrapperName="EchoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
	public class EchoResponse
	{
		[MessageBodyMember(Namespace="http://tempuri.org/", Order=0)]
		public Int32 EchoResult;

		[MessageBodyMember(Namespace="http://tempuri.org/", Order=1)]
		public String result;

		public EchoResponse()
		{
		}

		public EchoResponse(Int32 EchoResult, String result)
		{
			this.EchoResult = EchoResult;
			this.result = result;
		}
	}
}