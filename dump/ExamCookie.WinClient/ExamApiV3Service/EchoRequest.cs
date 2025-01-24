using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;

namespace ExamCookie.WinClient.ExamApiV3Service
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[MessageContract(WrapperName="Echo", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
	public class EchoRequest
	{
		[MessageBodyMember(Namespace="http://tempuri.org/", Order=0)]
		public String text;

		[MessageBodyMember(Namespace="http://tempuri.org/", Order=1)]
		public String result;

		public EchoRequest()
		{
		}

		public EchoRequest(String text, String result)
		{
			this.text = text;
			this.result = result;
		}
	}
}