using ExamCookie.Library;
using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace ExamCookie.WinClient.ExamApiV3Service
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[ServiceContract(ConfigurationName="ExamApiV3Service.IExamApiV3")]
	public interface IExamApiV3
	{
		[OperationContract(Action="http://tempuri.org/IExamApiV3/AddAdapter", ReplyAction="http://tempuri.org/IExamApiV3/AddAdapterResponse")]
		Int32 AddAdapter(String token, DateTime timeStamp, String data);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/AddAdapter", ReplyAction="http://tempuri.org/IExamApiV3/AddAdapterResponse")]
		Task<Int32> AddAdapterAsync(String token, DateTime timeStamp, String data);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/AddClipboard", ReplyAction="http://tempuri.org/IExamApiV3/AddClipboardResponse")]
		Int32 AddClipboard(String token, DateTime timeStamp, eDataFormat format, Byte[] data);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/AddClipboard", ReplyAction="http://tempuri.org/IExamApiV3/AddClipboardResponse")]
		Task<Int32> AddClipboardAsync(String token, DateTime timeStamp, eDataFormat format, Byte[] data);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/AddFrontApp", ReplyAction="http://tempuri.org/IExamApiV3/AddFrontAppResponse")]
		Int32 AddFrontApp(String token, DateTime timeStamp, eApplicationType type, String name, String document, Int32 deniedBrowserType);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/AddFrontApp", ReplyAction="http://tempuri.org/IExamApiV3/AddFrontAppResponse")]
		Task<Int32> AddFrontAppAsync(String token, DateTime timeStamp, eApplicationType type, String name, String document, Int32 deniedBrowserType);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/AddImage", ReplyAction="http://tempuri.org/IExamApiV3/AddImageResponse")]
		Int32 AddImage(Byte[] data);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/AddImage", ReplyAction="http://tempuri.org/IExamApiV3/AddImageResponse")]
		Task<Int32> AddImageAsync(Byte[] data);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/AddProcess", ReplyAction="http://tempuri.org/IExamApiV3/AddProcessResponse")]
		Int32 AddProcess(String token, DateTime timeStamp, String data);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/AddProcess", ReplyAction="http://tempuri.org/IExamApiV3/AddProcessResponse")]
		Task<Int32> AddProcessAsync(String token, DateTime timeStamp, String data);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/AddScreenShot", ReplyAction="http://tempuri.org/IExamApiV3/AddScreenShotResponse")]
		Int32 AddScreenShot(String token, DateTime timeStamp, Int32 screenNumber, Byte[] data);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/AddScreenShot", ReplyAction="http://tempuri.org/IExamApiV3/AddScreenShotResponse")]
		Task<Int32> AddScreenShotAsync(String token, DateTime timeStamp, Int32 screenNumber, Byte[] data);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/CheckVersion", ReplyAction="http://tempuri.org/IExamApiV3/CheckVersionResponse")]
		Int32 CheckVersion(String version, eClientType type);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/CheckVersion", ReplyAction="http://tempuri.org/IExamApiV3/CheckVersionResponse")]
		Task<Int32> CheckVersionAsync(String version, eClientType type);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/Echo", ReplyAction="http://tempuri.org/IExamApiV3/EchoResponse")]
		EchoResponse Echo(EchoRequest request);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/Echo", ReplyAction="http://tempuri.org/IExamApiV3/EchoResponse")]
		Task<EchoResponse> EchoAsync(EchoRequest request);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/GetExamInformation", ReplyAction="http://tempuri.org/IExamApiV3/GetExamInformationResponse")]
		GetExamInformationResponse GetExamInformation(GetExamInformationRequest request);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/GetExamInformation", ReplyAction="http://tempuri.org/IExamApiV3/GetExamInformationResponse")]
		Task<GetExamInformationResponse> GetExamInformationAsync(GetExamInformationRequest request);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/GetRequirements", ReplyAction="http://tempuri.org/IExamApiV3/GetRequirementsResponse")]
		GetRequirementsResponse GetRequirements(GetRequirementsRequest request);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/GetRequirements", ReplyAction="http://tempuri.org/IExamApiV3/GetRequirementsResponse")]
		Task<GetRequirementsResponse> GetRequirementsAsync(GetRequirementsRequest request);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/GetWebLoginUrl", ReplyAction="http://tempuri.org/IExamApiV3/GetWebLoginUrlResponse")]
		String GetWebLoginUrl(eWebLoginType type, String redirectUrl);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/GetWebLoginUrl", ReplyAction="http://tempuri.org/IExamApiV3/GetWebLoginUrlResponse")]
		Task<String> GetWebLoginUrlAsync(eWebLoginType type, String redirectUrl);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/HeartBeat", ReplyAction="http://tempuri.org/IExamApiV3/HeartBeatResponse")]
		HeartBeatResponse HeartBeat(HeartBeatRequest request);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/HeartBeat", ReplyAction="http://tempuri.org/IExamApiV3/HeartBeatResponse")]
		Task<HeartBeatResponse> HeartBeatAsync(HeartBeatRequest request);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/SaveSessionLog", ReplyAction="http://tempuri.org/IExamApiV3/SaveSessionLogResponse")]
		Int32 SaveSessionLog(String token, Byte[] data);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/SaveSessionLog", ReplyAction="http://tempuri.org/IExamApiV3/SaveSessionLogResponse")]
		Task<Int32> SaveSessionLogAsync(String token, Byte[] data);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/SignIn", ReplyAction="http://tempuri.org/IExamApiV3/SignInResponse")]
		SignInResponse SignIn(SignInRequest request);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/SignIn", ReplyAction="http://tempuri.org/IExamApiV3/SignInResponse")]
		Task<SignInResponse> SignInAsync(SignInRequest request);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/SignOut", ReplyAction="http://tempuri.org/IExamApiV3/SignOutResponse")]
		Int32 SignOut(String token, eSignOutMethod state, String metadata);

		[OperationContract(Action="http://tempuri.org/IExamApiV3/SignOut", ReplyAction="http://tempuri.org/IExamApiV3/SignOutResponse")]
		Task<Int32> SignOutAsync(String token, eSignOutMethod state, String metadata);
	}
}