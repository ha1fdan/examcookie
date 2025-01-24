using ExamCookie.WinClient;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ExamCookie.WinClient.My
{
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	[HideModuleName]
	internal static class MyProject
	{
		private readonly static MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider;

		private readonly static MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider;

		private readonly static MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User> m_UserObjectProvider;

		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider;

		private readonly static MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider;

		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.User")]
		internal static Microsoft.VisualBasic.ApplicationServices.User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		static MyProject()
		{
			MyProject.m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
			MyProject.m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
			MyProject.m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User>();
			MyProject.m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
			MyProject.m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();
		}

		[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class MyForms
		{
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;

			[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
			public FormInfo m_FormInfo;

			[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
			public FormLogin m_FormLogin;

			[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
			public FormLogin2 m_FormLogin2;

			[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
			public FormMain m_FormMain;

			[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
			public FormNotify m_FormNotify;

			public FormInfo FormInfo
			{
				[DebuggerHidden]
				get
				{
					this.m_FormInfo = MyProject.MyForms.Create__Instance__<FormInfo>(this.m_FormInfo);
					return this.m_FormInfo;
				}
				[DebuggerHidden]
				set
				{
					if ((object)value != (object)this.m_FormInfo)
					{
						if ((object)value != (object)null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FormInfo>(ref this.m_FormInfo);
					}
				}
			}

			public FormLogin FormLogin
			{
				[DebuggerHidden]
				get
				{
					this.m_FormLogin = MyProject.MyForms.Create__Instance__<FormLogin>(this.m_FormLogin);
					return this.m_FormLogin;
				}
				[DebuggerHidden]
				set
				{
					if ((object)value != (object)this.m_FormLogin)
					{
						if ((object)value != (object)null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FormLogin>(ref this.m_FormLogin);
					}
				}
			}

			public FormLogin2 FormLogin2
			{
				[DebuggerHidden]
				get
				{
					this.m_FormLogin2 = MyProject.MyForms.Create__Instance__<FormLogin2>(this.m_FormLogin2);
					return this.m_FormLogin2;
				}
				[DebuggerHidden]
				set
				{
					if ((object)value != (object)this.m_FormLogin2)
					{
						if ((object)value != (object)null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FormLogin2>(ref this.m_FormLogin2);
					}
				}
			}

			public FormMain FormMain
			{
				[DebuggerHidden]
				get
				{
					this.m_FormMain = MyProject.MyForms.Create__Instance__<FormMain>(this.m_FormMain);
					return this.m_FormMain;
				}
				[DebuggerHidden]
				set
				{
					if ((object)value != (object)this.m_FormMain)
					{
						if ((object)value != (object)null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FormMain>(ref this.m_FormMain);
					}
				}
			}

			public FormNotify FormNotify
			{
				[DebuggerHidden]
				get
				{
					this.m_FormNotify = MyProject.MyForms.Create__Instance__<FormNotify>(this.m_FormNotify);
					return this.m_FormNotify;
				}
				[DebuggerHidden]
				set
				{
					if ((object)value != (object)this.m_FormNotify)
					{
						if ((object)value != (object)null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FormNotify>(ref this.m_FormNotify);
					}
				}
			}

			[DebuggerHidden]
			[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
			public MyForms()
			{
			}

			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance)
			where T : Form, new()
			{
				T instance;
				if ((Instance == null ? false : !Instance.get_IsDisposed()))
				{
					instance = Instance;
				}
				else
				{
					if ((object)MyProject.MyForms.m_FormBeingCreated == (object)null)
					{
						MyProject.MyForms.m_FormBeingCreated = new Hashtable();
					}
					else if (MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new String[0]));
					}
					MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						try
						{
							instance = Activator.CreateInstance<T>();
						}
						catch (TargetInvocationException targetInvocationException) when ((object)targetInvocationException.get_InnerException() != (object)null)
						{
							String resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new String[] { targetInvocationException.get_InnerException().get_Message() });
							throw new InvalidOperationException(resourceString, targetInvocationException.get_InnerException());
						}
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return instance;
			}

			[DebuggerHidden]
			private Void Dispose__Instance__<T>(ref T instance)
			where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
			public override Boolean Equals(Object o)
			{
				return this.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
			public override Int32 GetHashCode()
			{
				return this.GetHashCode();
			}

			[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
			internal Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
			public override String ToString()
			{
				return this.ToString();
			}
		}

		[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			[DebuggerHidden]
			[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
			public MyWebServices()
			{
			}

			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance)
			where T : new()
			{
				T t;
				t = (instance != null ? instance : Activator.CreateInstance<T>());
				return t;
			}

			[DebuggerHidden]
			private Void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			[DebuggerHidden]
			[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
			public override Boolean Equals(Object o)
			{
				return this.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			[DebuggerHidden]
			[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
			public override Int32 GetHashCode()
			{
				return this.GetHashCode();
			}

			[DebuggerHidden]
			[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
			internal Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			[DebuggerHidden]
			[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
			public override String ToString()
			{
				return this.ToString();
			}
		}

		[ComVisible(false)]
		[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
		internal sealed class ThreadSafeObjectProvider<T>
		where T : new()
		{
			[CompilerGenerated]
			[ThreadStatic]
			private static T m_ThreadStaticValue;

			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					if (MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			[DebuggerHidden]
			[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
			public ThreadSafeObjectProvider()
			{
			}
		}
	}
}