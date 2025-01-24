using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public enum CoreWebView2DownloadInterruptReason
	{
		None,
		FileFailed,
		FileAccessDenied,
		FileNoSpace,
		FileNameTooLong,
		FileTooLarge,
		FileMalicious,
		FileTransientError,
		FileBlockedByPolicy,
		FileSecurityCheckFailed,
		FileTooShort,
		FileHashMismatch,
		NetworkFailed,
		NetworkTimeout,
		NetworkDisconnected,
		NetworkServerDown,
		NetworkInvalidRequest,
		ServerFailed,
		ServerNoRange,
		ServerBadContent,
		ServerUnauthorized,
		ServerCertificateProblem,
		ServerForbidden,
		ServerUnexpectedResponse,
		ServerContentLengthMismatch,
		ServerCrossOriginRedirect,
		UserCanceled,
		UserShutdown,
		UserPaused,
		DownloadProcessCrashed
	}
}