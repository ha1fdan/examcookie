using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Microsoft.Web.WebView2.Core
{
	internal class JSHandlerWrapper
	{
		private Object _JSHandler;

		public JSHandlerWrapper(Object JSHandler)
		{
			this._JSHandler = JSHandler;
		}

		public Delegate CreateDelegate(EventInfo eventInfo)
		{
			Delegate @delegate;
			try
			{
				MethodInfo method = eventInfo.get_EventHandlerType().GetMethod("Invoke");
				Type returnType = method.get_ReturnType();
				if (returnType != typeof(Void))
				{
					throw new Exception(String.Concat("The", eventInfo.get_Name(), "'s return type should be void."));
				}
				ParameterInfo[] parameters = method.GetParameters();
				Func<ParameterInfo, Int32, Type> u003cu003e9_30 = JSHandlerWrapper.u003cu003ec.u003cu003e9__3_0;
				if (u003cu003e9_30 == null)
				{
					u003cu003e9_30 = new Func<ParameterInfo, Int32, Type>(JSHandlerWrapper.u003cu003ec.u003cu003e9, (ParameterInfo p, Int32 i) => p.get_ParameterType());
					JSHandlerWrapper.u003cu003ec.u003cu003e9__3_0 = u003cu003e9_30;
				}
				Type[] array = Enumerable.ToArray<Type>(Enumerable.Select<ParameterInfo, Type>(parameters, u003cu003e9_30));
				Type[] typeArray = new Type[(Int32)array.Length + 1];
				typeArray[0] = typeof(JSHandlerWrapper);
				array.CopyTo(typeArray, 1);
				DynamicMethod dynamicMethod = new DynamicMethod("DelegateHandler", 22, 1, returnType, typeArray, typeof(JSHandlerWrapper).get_Module(), true);
				ILGenerator lGenerator = dynamicMethod.GetILGenerator();
				lGenerator.DeclareLocal(typeof(Object).MakeArrayType());
				lGenerator.Emit(OpCodes.Ldc_I4, (Int32)array.Length);
				lGenerator.Emit(OpCodes.Newarr, typeof(Object));
				lGenerator.Emit(OpCodes.Stloc_0);
				for (Int32 num = 0; num < (Int32)array.Length; num++)
				{
					lGenerator.Emit(OpCodes.Ldloc_0);
					lGenerator.Emit(OpCodes.Ldc_I4, num);
					lGenerator.Emit(OpCodes.Ldarg_S, num + 1);
					if (array[num].get_IsValueType())
					{
						lGenerator.Emit(OpCodes.Box, array[num]);
					}
					lGenerator.Emit(OpCodes.Stelem_Ref);
				}
				lGenerator.Emit(OpCodes.Ldarg_0);
				lGenerator.Emit(OpCodes.Ldloc_0);
				lGenerator.Emit(OpCodes.Call, typeof(JSHandlerWrapper).GetMethod("Invoke"));
				lGenerator.Emit(OpCodes.Ret);
				@delegate = dynamicMethod.CreateDelegate(eventInfo.get_EventHandlerType(), this);
			}
			catch (Exception exception)
			{
				throw exception;
			}
			return @delegate;
		}

		public Void Invoke(params Object[] args)
		{
			// 
			// Current member / type: System.Void Microsoft.Web.WebView2.Core.JSHandlerWrapper::Invoke(System.Object[])
			// File path: /home/halfdan/Downloads/ExamCookie1414.WinClient.exe
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void Invoke(System.Object[])
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

		[DllImport("oleaut32.dll", CharSet=1, ExactSpelling=false, PreserveSig=false)]
		internal static extern Void VariantClear(IntPtr variant);
	}
}