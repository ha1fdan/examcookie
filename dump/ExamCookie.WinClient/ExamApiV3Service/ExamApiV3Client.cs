using ExamCookie.Library;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace ExamCookie.WinClient.ExamApiV3Service
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class ExamApiV3Client : ClientBase<IExamApiV3>, IExamApiV3
	{
		public ExamApiV3Client()
		{
		}

		public ExamApiV3Client(String endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public ExamApiV3Client(String endpointConfigurationName, String remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public ExamApiV3Client(String endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public ExamApiV3Client(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		public Int32 AddAdapter(String token, DateTime timeStamp, String data)
		{
			return base.get_Channel().AddAdapter(token, timeStamp, data);
		}

		public Task<Int32> AddAdapterAsync(String token, DateTime timeStamp, String data)
		{
			return base.get_Channel().AddAdapterAsync(token, timeStamp, data);
		}

		public Int32 AddClipboard(String token, DateTime timeStamp, eDataFormat format, Byte[] data)
		{
			Int32 num = base.get_Channel().AddClipboard(token, timeStamp, format, data);
			return num;
		}

		public Task<Int32> AddClipboardAsync(String token, DateTime timeStamp, eDataFormat format, Byte[] data)
		{
			Task<Int32> task = base.get_Channel().AddClipboardAsync(token, timeStamp, format, data);
			return task;
		}

		public Int32 AddFrontApp(String token, DateTime timeStamp, eApplicationType type, String name, String document, Int32 deniedBrowserType)
		{
			Int32 num = base.get_Channel().AddFrontApp(token, timeStamp, type, name, document, deniedBrowserType);
			return num;
		}

		public Task<Int32> AddFrontAppAsync(String token, DateTime timeStamp, eApplicationType type, String name, String document, Int32 deniedBrowserType)
		{
			Task<Int32> task = base.get_Channel().AddFrontAppAsync(token, timeStamp, type, name, document, deniedBrowserType);
			return task;
		}

		public Int32 AddImage(Byte[] data)
		{
			return base.get_Channel().AddImage(data);
		}

		public Task<Int32> AddImageAsync(Byte[] data)
		{
			return base.get_Channel().AddImageAsync(data);
		}

		public Int32 AddProcess(String token, DateTime timeStamp, String data)
		{
			return base.get_Channel().AddProcess(token, timeStamp, data);
		}

		public Task<Int32> AddProcessAsync(String token, DateTime timeStamp, String data)
		{
			return base.get_Channel().AddProcessAsync(token, timeStamp, data);
		}

		public Int32 AddScreenShot(String token, DateTime timeStamp, Int32 screenNumber, Byte[] data)
		{
			Int32 num = base.get_Channel().AddScreenShot(token, timeStamp, screenNumber, data);
			return num;
		}

		public Task<Int32> AddScreenShotAsync(String token, DateTime timeStamp, Int32 screenNumber, Byte[] data)
		{
			Task<Int32> task = base.get_Channel().AddScreenShotAsync(token, timeStamp, screenNumber, data);
			return task;
		}

		public Int32 CheckVersion(String version, eClientType type)
		{
			return base.get_Channel().CheckVersion(version, type);
		}

		public Task<Int32> CheckVersionAsync(String version, eClientType type)
		{
			return base.get_Channel().CheckVersionAsync(version, type);
		}

		public Int32 Echo(String text, ref String result)
		{
			EchoRequest echoRequest = new EchoRequest()
			{
				text = text,
				result = result
			};
			EchoResponse echoResponse = ((IExamApiV3)this).Echo(echoRequest);
			result = echoResponse.result;
			return echoResponse.EchoResult;
		}

		public Task<EchoResponse> EchoAsync(EchoRequest request)
		{
			return base.get_Channel().EchoAsync(request);
		}

		[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
		public EchoResponse ExamApiV3Service_IExamApiV3_Echo(EchoRequest request)
		{
			return base.get_Channel().Echo(request);
		}

		[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
		public GetExamInformationResponse ExamApiV3Service_IExamApiV3_GetExamInformation(GetExamInformationRequest request)
		{
			return base.get_Channel().GetExamInformation(request);
		}

		[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
		public GetRequirementsResponse ExamApiV3Service_IExamApiV3_GetRequirements(GetRequirementsRequest request)
		{
			return base.get_Channel().GetRequirements(request);
		}

		[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
		public HeartBeatResponse ExamApiV3Service_IExamApiV3_HeartBeat(HeartBeatRequest request)
		{
			return base.get_Channel().HeartBeat(request);
		}

		[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
		public SignInResponse ExamApiV3Service_IExamApiV3_SignIn(SignInRequest request)
		{
			return base.get_Channel().SignIn(request);
		}

		public Int32 GetExamInformation(String token, ref String information)
		{
			GetExamInformationRequest getExamInformationRequest = new GetExamInformationRequest()
			{
				token = token,
				information = information
			};
			GetExamInformationResponse examInformation = ((IExamApiV3)this).GetExamInformation(getExamInformationRequest);
			information = examInformation.information;
			return examInformation.GetExamInformationResult;
		}

		public Task<GetExamInformationResponse> GetExamInformationAsync(GetExamInformationRequest request)
		{
			return base.get_Channel().GetExamInformationAsync(request);
		}

		public Int32 GetRequirements(eClientType type, ref String requirements)
		{
			GetRequirementsRequest getRequirementsRequest = new GetRequirementsRequest()
			{
				type = type,
				requirements = requirements
			};
			GetRequirementsResponse getRequirementsResponse = ((IExamApiV3)this).GetRequirements(getRequirementsRequest);
			requirements = getRequirementsResponse.requirements;
			return getRequirementsResponse.GetRequirementsResult;
		}

		public Task<GetRequirementsResponse> GetRequirementsAsync(GetRequirementsRequest request)
		{
			return base.get_Channel().GetRequirementsAsync(request);
		}

		public String GetWebLoginUrl(eWebLoginType type, String redirectUrl)
		{
			return base.get_Channel().GetWebLoginUrl(type, redirectUrl);
		}

		public Task<String> GetWebLoginUrlAsync(eWebLoginType type, String redirectUrl)
		{
			return base.get_Channel().GetWebLoginUrlAsync(type, redirectUrl);
		}

		public Int32 HeartBeat(String token, ref DateTime currentTime)
		{
			HeartBeatRequest heartBeatRequest = new HeartBeatRequest()
			{
				token = token,
				currentTime = currentTime
			};
			HeartBeatResponse heartBeatResponse = ((IExamApiV3)this).HeartBeat(heartBeatRequest);
			currentTime = heartBeatResponse.currentTime;
			return heartBeatResponse.HeartBeatResult;
		}

		public Task<HeartBeatResponse> HeartBeatAsync(HeartBeatRequest request)
		{
			return base.get_Channel().HeartBeatAsync(request);
		}

		public Int32 SaveSessionLog(String token, Byte[] data)
		{
			return base.get_Channel().SaveSessionLog(token, data);
		}

		public Task<Int32> SaveSessionLogAsync(String token, Byte[] data)
		{
			return base.get_Channel().SaveSessionLogAsync(token, data);
		}

		public Int32 SignIn(String code, String username, String password, String parameterIn, ref String parameterOut)
		{
			SignInRequest signInRequest = new SignInRequest()
			{
				code = code,
				username = username,
				password = password,
				parameterIn = parameterIn,
				parameterOut = parameterOut
			};
			SignInResponse signInResponse = ((IExamApiV3)this).SignIn(signInRequest);
			parameterOut = signInResponse.parameterOut;
			return signInResponse.SignInResult;
		}

		public Task<SignInResponse> SignInAsync(SignInRequest request)
		{
			return base.get_Channel().SignInAsync(request);
		}

		public Int32 SignOut(String token, eSignOutMethod state, String metadata)
		{
			return base.get_Channel().SignOut(token, state, metadata);
		}

		public Task<Int32> SignOutAsync(String token, eSignOutMethod state, String metadata)
		{
			return base.get_Channel().SignOutAsync(token, state, metadata);
		}
	}
}