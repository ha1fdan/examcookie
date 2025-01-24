using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ExamCookie.Library.My.Resources
{
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[HideModuleName]
	internal static class Resources
	{
		private static System.Resources.ResourceManager resourceMan;

		private static CultureInfo resourceCulture;

		[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
		internal static CultureInfo Culture
		{
			get
			{
				return ExamCookie.Library.My.Resources.Resources.resourceCulture;
			}
			set
			{
				ExamCookie.Library.My.Resources.Resources.resourceCulture = value;
			}
		}

		[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
		internal static System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (Object.ReferenceEquals(ExamCookie.Library.My.Resources.Resources.resourceMan, null))
				{
					ExamCookie.Library.My.Resources.Resources.resourceMan = new System.Resources.ResourceManager("ExamCookie.Library.Resources", typeof(ExamCookie.Library.My.Resources.Resources).get_Assembly());
				}
				return ExamCookie.Library.My.Resources.Resources.resourceMan;
			}
		}
	}
}