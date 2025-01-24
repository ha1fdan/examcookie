using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;

namespace ExamCookie.WinClient.ExamApiV3Service
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[MessageContract(WrapperName="HeartBeat", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
	public class HeartBeatRequest
	{
		[MessageBodyMember(Namespace="http://tempuri.org/", Order=0)]
		public String token;

		[MessageBodyMember(Namespace="http://tempuri.org/", Order=1)]
		public DateTime currentTime;

		public HeartBeatRequest()
		{
		}

		public HeartBeatRequest(String token, DateTime currentTime)
		{
			this.token = token;
			this.currentTime = currentTime;
		}
	}
}