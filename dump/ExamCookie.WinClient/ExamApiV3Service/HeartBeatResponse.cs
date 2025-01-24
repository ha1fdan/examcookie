using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;

namespace ExamCookie.WinClient.ExamApiV3Service
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[MessageContract(WrapperName="HeartBeatResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
	public class HeartBeatResponse
	{
		[MessageBodyMember(Namespace="http://tempuri.org/", Order=0)]
		public Int32 HeartBeatResult;

		[MessageBodyMember(Namespace="http://tempuri.org/", Order=1)]
		public DateTime currentTime;

		public HeartBeatResponse()
		{
		}

		public HeartBeatResponse(Int32 HeartBeatResult, DateTime currentTime)
		{
			this.HeartBeatResult = HeartBeatResult;
			this.currentTime = currentTime;
		}
	}
}