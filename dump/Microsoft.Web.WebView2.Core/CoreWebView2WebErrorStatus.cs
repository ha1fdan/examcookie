using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public enum CoreWebView2WebErrorStatus
	{
		Unknown,
		CertificateCommonNameIsIncorrect,
		CertificateExpired,
		ClientCertificateContainsErrors,
		CertificateRevoked,
		CertificateIsInvalid,
		ServerUnreachable,
		Timeout,
		ErrorHttpInvalidServerResponse,
		ConnectionAborted,
		ConnectionReset,
		Disconnected,
		CannotConnect,
		HostNameNotResolved,
		OperationCanceled,
		RedirectFailed,
		UnexpectedError,
		ValidAuthenticationCredentialsRequired,
		ValidProxyAuthenticationRequired
	}
}