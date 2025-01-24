using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security;

namespace Microsoft.Web.WebView2.Core
{
	internal class ManagedIStream : IStream
	{
		private Stream _ioStream;

		private const Int32 STGTY_STREAM = 2;

		private const Int32 STGM_READ = 0;

		private const Int32 STGM_WRITE = 1;

		private const Int32 STGM_READWRITE = 2;

		private const Int32 STREAM_SEEK_SET = 0;

		private const Int32 STREAM_SEEK_CUR = 1;

		private const Int32 STREAM_SEEK_END = 2;

		private const Int32 STATFLAG_DEFAULT = 0;

		private const Int32 STATFLAG_NONAME = 1;

		private const Int32 STATFLAG_NOOPEN = 2;

		internal ManagedIStream(Stream ioStream)
		{
			if (ioStream == null)
			{
				throw new ArgumentNullException("ioStream");
			}
			this._ioStream = ioStream;
		}

		Void System.Runtime.InteropServices.ComTypes.IStream.Clone(out IStream streamCopy)
		{
			streamCopy = null;
			throw new NotSupportedException();
		}

		Void System.Runtime.InteropServices.ComTypes.IStream.Commit(Int32 flags)
		{
			throw new NotSupportedException();
		}

		Void System.Runtime.InteropServices.ComTypes.IStream.CopyTo(IStream targetStream, Int64 bufferSize, IntPtr buffer, IntPtr bytesWrittenPtr)
		{
			throw new NotSupportedException();
		}

		Void System.Runtime.InteropServices.ComTypes.IStream.LockRegion(Int64 offset, Int64 byteCount, Int32 lockType)
		{
			throw new NotSupportedException();
		}

		[SecurityCritical]
		Void System.Runtime.InteropServices.ComTypes.IStream.Read(Byte[] buffer, Int32 bufferSize, IntPtr bytesReadPtr)
		{
			Int32 num = this._ioStream.Read(buffer, 0, bufferSize);
			if (bytesReadPtr != IntPtr.Zero)
			{
				Marshal.WriteInt32(bytesReadPtr, num);
			}
		}

		Void System.Runtime.InteropServices.ComTypes.IStream.Revert()
		{
			throw new NotSupportedException();
		}

		[SecurityCritical]
		Void System.Runtime.InteropServices.ComTypes.IStream.Seek(Int64 offset, Int32 origin, IntPtr newPositionPtr)
		{
			SeekOrigin seekOrigin;
			switch (origin)
			{
				case 0:
				{
					seekOrigin = 0;
					break;
				}
				case 1:
				{
					seekOrigin = 1;
					break;
				}
				case 2:
				{
					seekOrigin = 2;
					break;
				}
				default:
				{
					throw new ArgumentOutOfRangeException("origin");
				}
			}
			Int64 num = this._ioStream.Seek(offset, seekOrigin);
			if (newPositionPtr != IntPtr.Zero)
			{
				Marshal.WriteInt64(newPositionPtr, num);
			}
		}

		Void System.Runtime.InteropServices.ComTypes.IStream.SetSize(Int64 libNewSize)
		{
			this._ioStream.SetLength(libNewSize);
		}

		Void System.Runtime.InteropServices.ComTypes.IStream.Stat(out STATSTG streamStats, Int32 grfStatFlag)
		{
			// 
			// Current member / type: System.Void Microsoft.Web.WebView2.Core.ManagedIStream::System.Runtime.InteropServices.ComTypes.IStream.Stat(System.Runtime.InteropServices.ComTypes.STATSTG&,System.Int32)
			// File path: /home/halfdan/Downloads/ExamCookie1414.WinClient.exe
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void System.Runtime.InteropServices.ComTypes.IStream.Stat(System.Runtime.InteropServices.ComTypes.STATSTG&,System.Int32)
			// 
			// Object reference not set to an instance of an object.
			//    at Telerik.JustDecompiler.Steps.CodePatterns.ObjectInitialisationPattern.TryMatchInternal(StatementCollection statements, Int32 startIndex, Statement& result, Int32& replacedStatementsCount) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Steps/CodePatterns/ObjectInitialisationPattern.cs:line 84
			//    at Telerik.JustDecompiler.Steps.CodePatterns.BaseInitialisationPattern.TryMatch(StatementCollection statements, Int32& startIndex, Statement& result, Int32& replacedStatementsCount) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Steps/CodePatterns/BaseInitialisationPattern.cs:line 33
			//    at Telerik.JustDecompiler.Steps.CodePatternsStep.VisitBlockStatement(BlockStatement node) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Steps/CodePatternsStep.cs:line 55
			//    at Telerik.JustDecompiler.Ast.BaseCodeTransformer.DoVisit(ICodeNode node) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Ast/BaseCodeTransformer.cs:line 49
			//    at Telerik.JustDecompiler.Ast.BaseCodeTransformer.Visit(ICodeNode node) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Ast/BaseCodeTransformer.cs:line 276
			//    at Telerik.JustDecompiler.Steps.CodePatternsStep.Process(DecompilationContext context, BlockStatement body) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Steps/CodePatternsStep.cs:line 33
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/DecompilationPipeline.cs:line 88
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.Run(MethodBody body, ILanguage language) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.RunPipeline(DecompilationPipeline pipeline, ILanguage language, MethodBody body, DecompilationContext& context) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.Decompile(MethodBody body, ILanguage language, DecompilationContext& context, TypeSpecificContext typeContext) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/Extensions.cs:line 61
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/WriterContextServices/BaseWriterContextService.cs:line 118
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		Void System.Runtime.InteropServices.ComTypes.IStream.UnlockRegion(Int64 offset, Int64 byteCount, Int32 lockType)
		{
			throw new NotSupportedException();
		}

		[SecurityCritical]
		Void System.Runtime.InteropServices.ComTypes.IStream.Write(Byte[] buffer, Int32 bufferSize, IntPtr bytesWrittenPtr)
		{
			this._ioStream.Write(buffer, 0, bufferSize);
			if (bytesWrittenPtr != IntPtr.Zero)
			{
				Marshal.WriteInt32(bytesWrittenPtr, bufferSize);
			}
		}
	}
}