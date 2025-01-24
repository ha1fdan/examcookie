using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Microsoft.Web.WebView2.Core
{
	[Guid("00020400-0000-0000-C000-000000000046")]
	[InterfaceType(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
	internal interface IDispatch
	{
		[MethodImpl(128)]
		Int32 GetIDsOfNames(ref Guid riid, String[] rgsNames, Int32 cNames, Int32 lcid, Int32[] rgDispId);

		[MethodImpl(128)]
		Int32 GetTypeInfo(Int32 iTInfo, Int32 lcid, out ITypeInfo typeInfo);

		[MethodImpl(128)]
		Int32 GetTypeInfoCount(out Int32 Count);

		[MethodImpl(128)]
		Int32 Invoke(Int32 dispIdMember, ref Guid riid, UInt32 lcid, UInt16 wFlags, ref DISPPARAMS pDispParams, out Object pVarResult, ref EXCEPINFO pExcepInfo, out UInt32 pArgErr);
	}
}