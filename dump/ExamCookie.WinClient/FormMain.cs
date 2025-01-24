using ExamCookie.Library;
using ExamCookie.WinClient.ExamApiV3Service;
using ExamCookie.WinClient.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ExamCookie.WinClient
{
	[DesignerGenerated]
	public class FormMain : Form
	{
		private IContainer components;

		private Random _Random;

		private const Int32 WM_CLIPBOARDUPDATE = 797;

		private const Int32 WM_POWERBROADCAST = 536;

		private const Int32 PBT_APMSUSPEND = 4;

		private const Int32 PBT_APMRESUMESUSPEND = 7;

		private const Int32 PBT_APMRESUMEAUTOMATIC = 18;

		private const Int32 WH_MOUSE_LL = 14;

		private const Int32 WM_RBUTTONDOWN = 516;

		private IntPtr HookHandle;

		private FormMain.eSessionMode _SessionMode;

		private Dictionary<eEventType, Int32> SendDelays;

		private Stopwatch KillSwitch;

		private virtual AdapterThread AdapThread
		{
			get
			{
				stackVariable1 = this._AdapThread;
				return stackVariable1;
			}
			[MethodImpl(32)]
			set
			{
				AdapterThread.OnAdapterChangedEventHandler onAdapterChangedEventHandler = new AdapterThread.OnAdapterChangedEventHandler(this.OnAdapterChanged);
				AdapterThread.OnDebugEventHandler onDebugEventHandler = new AdapterThread.OnDebugEventHandler(this.OnThreadDebug);
				AdapterThread.OnExceptionEventHandler onExceptionEventHandler = new AdapterThread.OnExceptionEventHandler(this.OnThreadException);
				AdapterThread adapterThread = this._AdapThread;
				if (adapterThread != null)
				{
					adapterThread.OnAdapterChanged -= onAdapterChangedEventHandler;
					adapterThread.OnDebug -= onDebugEventHandler;
					adapterThread.OnException -= onExceptionEventHandler;
				}
				this._AdapThread = value;
				adapterThread = this._AdapThread;
				if (adapterThread != null)
				{
					adapterThread.OnAdapterChanged += onAdapterChangedEventHandler;
					adapterThread.OnDebug += onDebugEventHandler;
					adapterThread.OnException += onExceptionEventHandler;
				}
			}
		}

		private virtual ApplicationThread ApplThread
		{
			get
			{
				stackVariable1 = this._ApplThread;
				return stackVariable1;
			}
			[MethodImpl(32)]
			set
			{
				ApplicationThread.OnApplicationChangedEventHandler onApplicationChangedEventHandler = new ApplicationThread.OnApplicationChangedEventHandler(this.OnApplicationChanged);
				ApplicationThread.OnDebugEventHandler onDebugEventHandler = new ApplicationThread.OnDebugEventHandler(this.OnThreadDebug);
				ApplicationThread.OnExceptionEventHandler onExceptionEventHandler = new ApplicationThread.OnExceptionEventHandler(this.OnThreadException);
				ApplicationThread applicationThread = this._ApplThread;
				if (applicationThread != null)
				{
					applicationThread.OnApplicationChanged -= onApplicationChangedEventHandler;
					applicationThread.OnDebug -= onDebugEventHandler;
					applicationThread.OnException -= onExceptionEventHandler;
				}
				this._ApplThread = value;
				applicationThread = this._ApplThread;
				if (applicationThread != null)
				{
					applicationThread.OnApplicationChanged += onApplicationChangedEventHandler;
					applicationThread.OnDebug += onDebugEventHandler;
					applicationThread.OnException += onExceptionEventHandler;
				}
			}
		}

		private virtual ExamCookie.WinClient.ClientClock ClientClock
		{
			get;
			[MethodImpl(32)]
			set;
		}

		private virtual ClipboardThread ClipThread
		{
			get
			{
				stackVariable1 = this._ClipThread;
				return stackVariable1;
			}
			[MethodImpl(32)]
			set
			{
				ClipboardThread.OnClipboardChangedEventHandler onClipboardChangedEventHandler = new ClipboardThread.OnClipboardChangedEventHandler(this.OnClipboardChanged);
				ClipboardThread.OnDebugEventHandler onDebugEventHandler = new ClipboardThread.OnDebugEventHandler(this.OnThreadDebug);
				ClipboardThread.OnExceptionEventHandler onExceptionEventHandler = new ClipboardThread.OnExceptionEventHandler(this.OnThreadException);
				ClipboardThread clipboardThread = this._ClipThread;
				if (clipboardThread != null)
				{
					clipboardThread.OnClipboardChanged -= onClipboardChangedEventHandler;
					clipboardThread.OnDebug -= onDebugEventHandler;
					clipboardThread.OnException -= onExceptionEventHandler;
				}
				this._ClipThread = value;
				clipboardThread = this._ClipThread;
				if (clipboardThread != null)
				{
					clipboardThread.OnClipboardChanged += onClipboardChangedEventHandler;
					clipboardThread.OnDebug += onDebugEventHandler;
					clipboardThread.OnException += onExceptionEventHandler;
				}
			}
		}

		private virtual ConfigurationThread ConfThread
		{
			get
			{
				stackVariable1 = this._ConfThread;
				return stackVariable1;
			}
			[MethodImpl(32)]
			set
			{
				ConfigurationThread.OnConfigurationChangedEventHandler onConfigurationChangedEventHandler = new ConfigurationThread.OnConfigurationChangedEventHandler(this.OnConfigurationChanged);
				ConfigurationThread.OnDebugEventHandler onDebugEventHandler = new ConfigurationThread.OnDebugEventHandler(this.OnThreadDebug);
				ConfigurationThread.OnExceptionEventHandler onExceptionEventHandler = new ConfigurationThread.OnExceptionEventHandler(this.OnThreadException);
				ConfigurationThread configurationThread = this._ConfThread;
				if (configurationThread != null)
				{
					configurationThread.OnConfigurationChanged -= onConfigurationChangedEventHandler;
					configurationThread.OnDebug -= onDebugEventHandler;
					configurationThread.OnException -= onExceptionEventHandler;
				}
				this._ConfThread = value;
				configurationThread = this._ConfThread;
				if (configurationThread != null)
				{
					configurationThread.OnConfigurationChanged += onConfigurationChangedEventHandler;
					configurationThread.OnDebug += onDebugEventHandler;
					configurationThread.OnException += onExceptionEventHandler;
				}
			}
		}

		private virtual Form OverlayForm
		{
			get
			{
				stackVariable1 = this._OverlayForm;
				return stackVariable1;
			}
			[MethodImpl(32)]
			set
			{
				MouseEventHandler mouseEventHandler = new MouseEventHandler(this, FormMain.FormMain_MouseDown);
				Form form = this._OverlayForm;
				if (form != null)
				{
					form.remove_MouseDown(mouseEventHandler);
				}
				this._OverlayForm = value;
				form = this._OverlayForm;
				if (form != null)
				{
					form.add_MouseDown(mouseEventHandler);
				}
			}
		}

		internal virtual Panel Panel1
		{
			get
			{
				stackVariable1 = this._Panel1;
				return stackVariable1;
			}
			[MethodImpl(32)]
			set
			{
				MouseEventHandler mouseEventHandler = new MouseEventHandler(this, FormMain.FormMain_MouseDown);
				Panel panel = this._Panel1;
				if (panel != null)
				{
					panel.remove_MouseDown(mouseEventHandler);
				}
				this._Panel1 = value;
				panel = this._Panel1;
				if (panel != null)
				{
					panel.add_MouseDown(mouseEventHandler);
				}
			}
		}

		private virtual ProcessThread ProcThread
		{
			get
			{
				stackVariable1 = this._ProcThread;
				return stackVariable1;
			}
			[MethodImpl(32)]
			set
			{
				ProcessThread.OnProcessChangedEventHandler onProcessChangedEventHandler = new ProcessThread.OnProcessChangedEventHandler(this.OnProcessChanged);
				ProcessThread.OnDebugEventHandler onDebugEventHandler = new ProcessThread.OnDebugEventHandler(this.OnThreadDebug);
				ProcessThread.OnExceptionEventHandler onExceptionEventHandler = new ProcessThread.OnExceptionEventHandler(this.OnThreadException);
				ProcessThread processThread = this._ProcThread;
				if (processThread != null)
				{
					processThread.OnProcessChanged -= onProcessChangedEventHandler;
					processThread.OnDebug -= onDebugEventHandler;
					processThread.OnException -= onExceptionEventHandler;
				}
				this._ProcThread = value;
				processThread = this._ProcThread;
				if (processThread != null)
				{
					processThread.OnProcessChanged += onProcessChangedEventHandler;
					processThread.OnDebug += onDebugEventHandler;
					processThread.OnException += onExceptionEventHandler;
				}
			}
		}

		private virtual ScreenThread ScrnThread
		{
			get
			{
				stackVariable1 = this._ScrnThread;
				return stackVariable1;
			}
			[MethodImpl(32)]
			set
			{
				ScreenThread.OnScreenChangedEventHandler onScreenChangedEventHandler = new ScreenThread.OnScreenChangedEventHandler(this.OnScreenChanged);
				ScreenThread.OnDebugEventHandler onDebugEventHandler = new ScreenThread.OnDebugEventHandler(this.OnThreadDebug);
				ScreenThread.OnExceptionEventHandler onExceptionEventHandler = new ScreenThread.OnExceptionEventHandler(this.OnThreadException);
				ScreenThread screenThread = this._ScrnThread;
				if (screenThread != null)
				{
					screenThread.OnScreenChanged -= onScreenChangedEventHandler;
					screenThread.OnDebug -= onDebugEventHandler;
					screenThread.OnException -= onExceptionEventHandler;
				}
				this._ScrnThread = value;
				screenThread = this._ScrnThread;
				if (screenThread != null)
				{
					screenThread.OnScreenChanged += onScreenChangedEventHandler;
					screenThread.OnDebug += onDebugEventHandler;
					screenThread.OnException += onExceptionEventHandler;
				}
			}
		}

		public FormMain.eSessionMode SessionMode
		{
			get
			{
				return this._SessionMode;
			}
			set
			{
				Module1.Log(MethodBase.GetCurrentMethod(), value.ToString(), new Object[0]);
				this._SessionMode = value;
			}
		}

		internal virtual Timer TmrTick
		{
			get
			{
				stackVariable1 = this._TmrTick;
				return stackVariable1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this, FormMain.OnTimerTick);
				Timer timer = this._TmrTick;
				if (timer != null)
				{
					timer.remove_Tick(eventHandler);
				}
				this._TmrTick = value;
				timer = this._TmrTick;
				if (timer != null)
				{
					timer.add_Tick(eventHandler);
				}
			}
		}

		private virtual UploadThread UpldThread
		{
			get
			{
				stackVariable1 = this._UpldThread;
				return stackVariable1;
			}
			[MethodImpl(32)]
			set
			{
				UploadThread.OnOnlineChangedEventHandler onOnlineChangedEventHandler = new UploadThread.OnOnlineChangedEventHandler(this.OnOnlineChanged);
				UploadThread.OnHeartbeatEventHandler onHeartbeatEventHandler = new UploadThread.OnHeartbeatEventHandler(this.OnHeartbeat);
				UploadThread.OnDebugEventHandler onDebugEventHandler = new UploadThread.OnDebugEventHandler(this.OnThreadDebug);
				UploadThread.OnExceptionEventHandler onExceptionEventHandler = new UploadThread.OnExceptionEventHandler(this.OnThreadException);
				UploadThread uploadThread = this._UpldThread;
				if (uploadThread != null)
				{
					uploadThread.OnOnlineChanged -= onOnlineChangedEventHandler;
					uploadThread.OnHeartbeat -= onHeartbeatEventHandler;
					uploadThread.OnDebug -= onDebugEventHandler;
					uploadThread.OnException -= onExceptionEventHandler;
				}
				this._UpldThread = value;
				uploadThread = this._UpldThread;
				if (uploadThread != null)
				{
					uploadThread.OnOnlineChanged += onOnlineChangedEventHandler;
					uploadThread.OnHeartbeat += onHeartbeatEventHandler;
					uploadThread.OnDebug += onDebugEventHandler;
					uploadThread.OnException += onExceptionEventHandler;
				}
			}
		}

		public FormMain()
		{
			base.add_Load(new EventHandler(this, FormMain.FormMain_Load));
			base.add_FormClosing(new FormClosingEventHandler(this, FormMain.FormMain_FormClosing));
			base.add_Resize(new EventHandler(this, FormMain.FormMain_Resize));
			base.add_Move(new EventHandler(this, FormMain.FormMain_Move));
			base.add_SizeChanged(new EventHandler(this, FormMain.FormMain_Move));
			this._Random = new Random();
			this.OverlayForm = new Form();
			this.ClientClock = null;
			this.AdapThread = null;
			this.ApplThread = null;
			this.ClipThread = null;
			this.ProcThread = null;
			this.ScrnThread = null;
			this.UpldThread = null;
			this.ConfThread = null;
			this._SessionMode = FormMain.eSessionMode.INIT;
			this.SendDelays = new Dictionary<eEventType, Int32>();
			this.KillSwitch = new Stopwatch();
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		protected override Void Dispose(Boolean disposing)
		{
			try
			{
				if ((!disposing ? false : (object)this.components != (object)null))
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		private Void FormMain_FormClosing(Object sender, FormClosingEventArgs e)
		{
			// 
			// Current member / type: System.Void ExamCookie.WinClient.FormMain::FormMain_FormClosing(System.Object,System.Windows.Forms.FormClosingEventArgs)
			// File path: /home/halfdan/Downloads/ExamCookie1414.WinClient.exe
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void FormMain_FormClosing(System.Object,System.Windows.Forms.FormClosingEventArgs)
			// 
			// Object reference not set to an instance of an object.
			//    at Telerik.JustDecompiler.Decompiler.LogicFlow.DTree.BaseDominatorTreeBuilder.ComputeDominanceFrontiers() in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/LogicFlow/DTree/BaseDominatorTreeBuilder.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.LogicFlow.DTree.BaseDominatorTreeBuilder.BuildTreeInternal(BaseDominatorTreeBuilder theBuilder) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/LogicFlow/DTree/BaseDominatorTreeBuilder.cs:line 26
			//    at Telerik.JustDecompiler.Decompiler.LogicFlow.DTree.FastDominatorTreeBuilder.BuildTree(ISingleEntrySubGraph graph) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/LogicFlow/DTree/FastDominatorTreeBuilder.cs:line 25
			//    at Telerik.JustDecompiler.Decompiler.LogicFlow.DominatorTreeDependentStep.GetDominatorTreeFromContext(ILogicalConstruct construct) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/LogicFlow/DominatorTreeDependentStep.cs:line 20
			//    at Telerik.JustDecompiler.Decompiler.LogicFlow.Loops.LoopBuilder.ProcessLogicalConstruct(ILogicalConstruct construct) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/LogicFlow/Loops/LoopBuilder.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.LogicFlow.Loops.LoopBuilder.BuildLoops(ILogicalConstruct block) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/LogicFlow/Loops/LoopBuilder.cs:line 59
			//    at Telerik.JustDecompiler.Decompiler.LogicFlow.Loops.LoopBuilder.BuildLoops(ILogicalConstruct block) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/LogicFlow/Loops/LoopBuilder.cs:line 56
			//    at Telerik.JustDecompiler.Decompiler.LogicFlow.Loops.LoopBuilder.BuildLoops(ILogicalConstruct block) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/LogicFlow/Loops/LoopBuilder.cs:line 56
			//    at Telerik.JustDecompiler.Decompiler.LogicFlow.LogicalFlowBuilderStep.BuildLogicalConstructTree() in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/LogicFlow/LogicalFlowBuilderStep.cs:line 128
			//    at Telerik.JustDecompiler.Decompiler.LogicFlow.LogicalFlowBuilderStep.Process(DecompilationContext context, BlockStatement body) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/LogicFlow/LogicalFlowBuilderStep.cs:line 53
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/DecompilationPipeline.cs:line 88
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.Run(MethodBody body, ILanguage language) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.RunPipeline(DecompilationPipeline pipeline, ILanguage language, MethodBody body, DecompilationContext& context) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.Decompile(MethodBody body, ILanguage language, DecompilationContext& context, TypeSpecificContext typeContext) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/Extensions.cs:line 61
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/WriterContextServices/BaseWriterContextService.cs:line 118
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		private Void FormMain_Load(Object sender, EventArgs e)
		{
			try
			{
				Control.set_CheckForIllegalCrossThreadCalls(false);
				this.RegisterMSHTML();
				Module1.Log(MethodBase.GetCurrentMethod(), "ExamCookie Win Client starter...", new Object[0]);
				Module1.Log(MethodBase.GetCurrentMethod(), "APP_DATA_PATH={0}", new Object[] { Module1.APP_DATA_PATH });
				Module1.Log(MethodBase.GetCurrentMethod(), "APP_FILENAME={0}", new Object[] { Module1.APP_FILENAME });
				Module1.Log(MethodBase.GetCurrentMethod(), "APP_CURRENT_DIR={0}", new Object[] { Module1.APP_CURRENT_DIR });
				String[] commandLineArgs = Environment.GetCommandLineArgs();
				for (Int32 i = 0; i < (Int32)commandLineArgs.Length; i = checked(i + 1))
				{
					if (Operators.CompareString(commandLineArgs[i], "-L", false) == 0)
					{
						Module1.LOG_SESSION_LOCAL = true;
					}
				}
				base.set_TransparencyKey(this.get_BackColor());
				base.set_Owner(this.OverlayForm);
				base.set_ShowInTaskbar(false);
				this.OverlayForm.set_FormBorderStyle(0);
				this.OverlayForm.set_Opacity(0.01);
				this.OverlayForm.set_Icon(base.get_Icon());
				this.OverlayForm.set_Text(this.get_Text());
				this.OverlayForm.set_ShowInTaskbar(false);
				this.OverlayForm.Show();
				this.OverlayForm.set_TopMost(true);
				base.set_Size(this.Panel1.get_Size());
				this.SessionMode = FormMain.eSessionMode.BEGIN_SIGN_IN;
				this.SetIconStatus(Resources.ec_blue);
				Module1.SetComputerClock();
				this.TmrTick.Start();
				Module1.Log(MethodBase.GetCurrentMethod(), "ExamCookie Win Client startet", new Object[0]);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				Interaction.MsgBox(exception.get_Message(), 16, null);
				ProjectData.ClearProjectError();
			}
		}

		private Void FormMain_MouseDown(Object sender, MouseEventArgs e)
		{
			try
			{
				if (e.get_Button() == 1048576)
				{
					if (this.SessionMode == FormMain.eSessionMode.SIGNED_IN | this.SessionMode == FormMain.eSessionMode.EXAM_STARTED)
					{
						FormInfo formInfo = new FormInfo();
						try
						{
							formInfo.Config = Module1.Config;
							if ((object)this.ScrnThread != (object)null)
							{
								this.ScrnThread.TakeScreenshot(1);
							}
							if (formInfo.ShowDialog(this) == 6)
							{
								formInfo.Dispose();
								this.Notify("ExamCookie", new String[] { "Du har afsluttet eksamen", "og programmet lukker om et øjeblik." });
								Module1.USER_SIGNED_OUT = true;
								this.SessionMode = FormMain.eSessionMode.EXAM_ENDED;
								Module1.Log(MethodBase.GetCurrentMethod(), "Elev har valgt af afslutte før tid", new Object[0]);
							}
						}
						finally
						{
							if (formInfo != null)
							{
								formInfo.Dispose();
							}
						}
						base.Show();
						base.set_TopMost(true);
					}
				}
				else if (e.get_Button() == 2097152)
				{
					this.Notify("ExamCookie", null);
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				ProjectData.ClearProjectError();
			}
		}

		private Void FormMain_Move(Object sender, EventArgs e)
		{
			this.OverlayForm.set_Bounds(base.get_Bounds());
		}

		private Void FormMain_Resize(Object sender, EventArgs e)
		{
			Rectangle workingArea = Screen.get_PrimaryScreen().get_WorkingArea();
			Int32 width = checked(checked(workingArea.get_Width() - base.get_Width()) - 20);
			workingArea = Screen.get_PrimaryScreen().get_WorkingArea();
			base.set_Location(new Point(width, checked(workingArea.get_Height() - 95)));
		}

		private Boolean HasExamEnded(Boolean forceEnd = false)
		{
			Boolean flag;
			DateTime currentTime;
			if (this.u0024STATICu0024HasExamEndedu002420122u0024flagu0024Init == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref this.u0024STATICu0024HasExamEndedu002420122u0024flagu0024Init, new StaticLocalInitFlag(), null);
			}
			Boolean flag1 = false;
			try
			{
				Monitor.Enter(this.u0024STATICu0024HasExamEndedu002420122u0024flagu0024Init, ref flag1);
				if (this.u0024STATICu0024HasExamEndedu002420122u0024flagu0024Init.State == 0)
				{
					this.u0024STATICu0024HasExamEndedu002420122u0024flagu0024Init.State = 2;
					this.u0024STATICu0024HasExamEndedu002420122u0024flag = false;
				}
				else if (this.u0024STATICu0024HasExamEndedu002420122u0024flagu0024Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				this.u0024STATICu0024HasExamEndedu002420122u0024flagu0024Init.State = 1;
				if (flag1)
				{
					Monitor.Exit(this.u0024STATICu0024HasExamEndedu002420122u0024flagu0024Init);
				}
			}
			try
			{
				if (!this.u0024STATICu0024HasExamEndedu002420122u0024flag)
				{
					if (forceEnd)
					{
						Module1.Log(MethodBase.GetCurrentMethod(), "forceEnd=True", new Object[0]);
						this.u0024STATICu0024HasExamEndedu002420122u0024flag = true;
					}
					else if (this.ClientClock == null)
					{
						flag = false;
						return flag;
					}
					else if (!this.u0024STATICu0024HasExamEndedu002420122u0024flag & DateTime.Compare(this.ClientClock.CurrentTime, Module1.Config.Exam.TimeEnd.AddMinutes((Double)(checked(Module1.Config.Exam.TimeEndExt + Module1.Config.Exam.StudentTimeExt)))) >= 0)
					{
						MethodBase currentMethod = MethodBase.GetCurrentMethod();
						Object[] str = new Object[2];
						currentTime = this.ClientClock.CurrentTime;
						str[0] = currentTime.ToString();
						currentTime = Module1.Config.Exam.TimeEnd.AddMinutes((Double)(checked(Module1.Config.Exam.TimeEndExt + Module1.Config.Exam.StudentTimeExt)));
						str[1] = currentTime.ToString();
						Module1.Log(currentMethod, "CurrentTime: {0} > {1}", str);
						this.u0024STATICu0024HasExamEndedu002420122u0024flag = true;
					}
					else if (!Module1.USER_SIGNED_OUT)
					{
						currentTime = this.ClientClock.CurrentTime;
						if (!(!this.u0024STATICu0024HasExamEndedu002420122u0024flag & DateTime.Compare(currentTime.get_Date(), Module1.Config.Exam.TimeEnd.get_Date()) != 0))
						{
							flag = false;
							return flag;
						}
						else
						{
							MethodBase methodBase = MethodBase.GetCurrentMethod();
							Object[] objArray = new Object[2];
							currentTime = this.ClientClock.CurrentTime;
							currentTime = currentTime.get_Date();
							objArray[0] = currentTime.ToString();
							currentTime = Module1.Config.Exam.TimeEnd.get_Date();
							objArray[1] = currentTime.ToString();
							Module1.Log(methodBase, "CurrentDate: {0} > {1}", objArray);
							this.u0024STATICu0024HasExamEndedu002420122u0024flag = true;
						}
					}
					else
					{
						Module1.Log(MethodBase.GetCurrentMethod(), "USER_SIGNED_OUT", new Object[0]);
						this.u0024STATICu0024HasExamEndedu002420122u0024flag = true;
					}
				}
				flag = this.u0024STATICu0024HasExamEndedu002420122u0024flag;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		[DebuggerStepThrough]
		private Void InitializeComponent()
		{
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormMain));
			this.TmrTick = new Timer(this.components);
			this.Panel1 = new Panel();
			base.SuspendLayout();
			this.TmrTick.set_Interval(1000);
			this.Panel1.set_BackColor(Color.get_Transparent());
			this.Panel1.set_BackgroundImage(Resources.ec_blue);
			this.Panel1.set_BackgroundImageLayout(4);
			this.Panel1.set_ForeColor(SystemColors.get_ControlText());
			this.Panel1.set_Location(new Point(0, 0));
			this.Panel1.set_Margin(new Padding(3, 2, 3, 2));
			this.Panel1.set_Name("Panel1");
			this.Panel1.set_Size(new Size(72, 80));
			this.Panel1.set_TabIndex(9);
			base.set_AutoScaleDimensions(new SizeF(9f, 20f));
			base.set_AutoScaleMode(1);
			base.set_ClientSize(new Size(90, 100));
			base.get_Controls().Add(this.Panel1);
			base.set_FormBorderStyle(0);
			base.set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
			base.set_Margin(new Padding(3, 4, 3, 4));
			base.set_Name("FormMain");
			base.set_ShowInTaskbar(false);
			base.set_StartPosition(0);
			this.set_Text("ExamCookie");
			base.set_TopMost(true);
			base.ResumeLayout(false);
		}

		private Void InitSendDelay(eEventType eventType, Int32 polltime)
		{
			this.SendDelays.Add(eventType, checked(this._Random.Next(checked(Module1.Config.ClientConfiguration.ThreadsDelayedMin * 1000), checked(Module1.Config.ClientConfiguration.ThreadsDelayedMax * 1000)) + polltime));
		}

		private Void Login()
		{
			try
			{
				FormLogin2 formLogin2 = new FormLogin2();
				try
				{
					DialogResult dialogResult = formLogin2.ShowDialog(this);
					if (dialogResult == 1)
					{
						base.Show();
						base.set_TopMost(true);
						Module1.USER_SIGN_IN_TOKEN = Module1.Config.Token;
						Module1.LOG_SESSION = Module1.Config.ClientConfiguration.IncludeLogfile;
						this.ClientClock = new ExamCookie.WinClient.ClientClock(Module1.Config.CurrentTime.AddSeconds(2));
						this.UpldThread = new UploadThread(Module1.Config.ClientConfiguration.HeartbeatPulseMin, Module1.Config.ClientConfiguration.HeartbeatPulseMax);
						this.ConfThread = new ConfigurationThread();
						this.UpldThread.Token = Module1.Config.Token;
						if (DateTime.Compare(Module1.Config.CurrentTime, Module1.Config.Exam.TimeBegin) < 0)
						{
							this.SetIconStatus(Resources.ec_yellow);
							this.Notify("ExamCookie", new String[] { "Du er nu logget ind. Din eksamen er ikke", "startet og programmet er ikke aktivt.", String.Format("Eksamen begynder: {0}", Strings.Format(Module1.Config.Exam.TimeBegin, "dd-MM-yyyy HH:mm")) });
						}
						this.SessionMode = FormMain.eSessionMode.SIGNED_IN;
						Module1.Log(MethodBase.GetCurrentMethod(), "SIGN_IN_ID={0}", new Object[] { Module1.USER_SIGN_IN_TOKEN });
					}
					else if (dialogResult != 4)
					{
						this.SessionMode = FormMain.eSessionMode.CLOSE;
					}
				}
				finally
				{
					if (formLogin2 != null)
					{
						formLogin2.Dispose();
					}
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				ProjectData.ClearProjectError();
			}
		}

		private Void Notify(String header, String[] message = null)
		{
			FormMain._Closureu0024__78u002d0 variable = null;
			String[] strArray = message;
			if (this.u0024STATICu0024Notifyu00242021E1DEu0024lastu0024Init == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref this.u0024STATICu0024Notifyu00242021E1DEu0024lastu0024Init, new StaticLocalInitFlag(), null);
			}
			Boolean flag = false;
			try
			{
				Monitor.Enter(this.u0024STATICu0024Notifyu00242021E1DEu0024lastu0024Init, ref flag);
				if (this.u0024STATICu0024Notifyu00242021E1DEu0024lastu0024Init.State == 0)
				{
					this.u0024STATICu0024Notifyu00242021E1DEu0024lastu0024Init.State = 2;
					this.u0024STATICu0024Notifyu00242021E1DEu0024last = null;
				}
				else if (this.u0024STATICu0024Notifyu00242021E1DEu0024lastu0024Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				this.u0024STATICu0024Notifyu00242021E1DEu0024lastu0024Init.State = 1;
				if (flag)
				{
					Monitor.Exit(this.u0024STATICu0024Notifyu00242021E1DEu0024lastu0024Init);
				}
			}
			if (strArray != null)
			{
				this.u0024STATICu0024Notifyu00242021E1DEu0024last = strArray;
			}
			else if (this.u0024STATICu0024Notifyu00242021E1DEu0024last != null)
			{
				strArray = this.u0024STATICu0024Notifyu00242021E1DEu0024last;
			}
			if (strArray != null)
			{
				(new Thread(new ThreadStart(variable, () => this.u0024VBu0024Me.ShowNotify(this.u0024VBu0024Local_header, this.u0024VBu0024Local_message)))).Start();
				if ((object)this.ScrnThread != (object)null)
				{
					this.ScrnThread.TakeScreenshot(1, 1000);
				}
			}
		}

		private Void OnAdapterChanged(AdapterThread.AdapterChanged sender)
		{
			try
			{
				if (!this.HasExamEnded(false))
				{
					Module1.Log(MethodBase.GetCurrentMethod(), "", new Object[0]);
					sender.Token = Module1.Config.Token;
					sender.TimeStamp = this.ClientClock.CurrentTime;
					sender.CanSend = Module1.Config.Exam.TimeBegin.AddMilliseconds((Double)this.SendDelays.get_Item(eEventType.ADAPTER));
					this.UpldThread.AddDataPackage(sender);
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				ProjectData.ClearProjectError();
			}
		}

		private Void OnApplicationChanged(ApplicationThread.ApplicationChanged sender)
		{
			try
			{
				if (!this.HasExamEnded(false))
				{
					if (sender.Type != eApplicationType.APPLICATION)
					{
						Module1.Log(MethodBase.GetCurrentMethod(), "{0}='{1}', URL='{2}'", new Object[] { sender.Type.ToString(), sender.Name, sender.Document });
					}
					else
					{
						Module1.Log(MethodBase.GetCurrentMethod(), "{0}='{1}', DOC='{2}'", new Object[] { sender.Type.ToString(), sender.Name, sender.Document });
					}
					sender.Token = Module1.Config.Token;
					sender.TimeStamp = this.ClientClock.CurrentTime;
					sender.CanSend = Module1.Config.Exam.TimeBegin.AddMilliseconds((Double)this.SendDelays.get_Item(eEventType.FRONT_APP));
					this.UpldThread.AddDataPackage(sender);
					this.ScrnThread.TakeScreenshot(sender.Rectangle);
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				ProjectData.ClearProjectError();
			}
		}

		private Void OnClipboardChanged(ClipboardThread.ClipboardChanged sender)
		{
			try
			{
				if (!this.HasExamEnded(false))
				{
					Module1.Log(MethodBase.GetCurrentMethod(), sender.Format.ToString(), new Object[0]);
					if (sender.Format != eDataFormat.NONE)
					{
						if (sender.Data != null)
						{
							sender.Token = Module1.Config.Token;
							sender.TimeStamp = this.ClientClock.CurrentTime;
							sender.CanSend = Module1.Config.Exam.TimeBegin.AddMilliseconds((Double)this.SendDelays.get_Item(eEventType.CLIPBOARD));
							this.UpldThread.AddDataPackage(sender);
						}
					}
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				ProjectData.ClearProjectError();
			}
		}

		private Void OnConfigurationChanged(String[] message)
		{
			this.Notify("ExamCookie", message);
		}

		private Void OnHeartbeat(DateTime currentTime, Int32 result)
		{
			try
			{
				Module1.Log(MethodBase.GetCurrentMethod(), "Servertime: {0}, ClientClock: {1}, PC time: {2}", new Object[] { currentTime, this.ClientClock.CurrentTime, DateAndTime.get_Now() });
				if (Math.Abs(DateAndTime.DateDiff(9, this.ClientClock.CurrentTime, currentTime, 1, 1)) > (Int64)5)
				{
					this.ClientClock.CurrentTime = currentTime;
				}
				if (this.SessionMode == FormMain.eSessionMode.EXAM_STARTED & result == 5)
				{
					this.SessionMode = FormMain.eSessionMode.EXAM_ENDED;
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				ProjectData.ClearProjectError();
			}
		}

		private Void OnOnlineChanged(Boolean online)
		{
			try
			{
				Module1.Log(MethodBase.GetCurrentMethod(), "Online={0}", new Object[] { online });
				if (!online)
				{
					this.SetIconStatus(Resources.ec_red);
				}
				else if (DateTime.Compare(this.ClientClock.CurrentTime, Module1.Config.Exam.TimeEnd.AddMinutes((Double)(checked(Module1.Config.Exam.TimeEndExt + Module1.Config.Exam.StudentTimeExt)))) >= 0)
				{
					this.SetIconStatus(null);
				}
				else if (DateTime.Compare(this.ClientClock.CurrentTime, Module1.Config.Exam.TimeBegin) < 0)
				{
					this.SetIconStatus(Resources.ec_yellow);
				}
				else
				{
					this.SetIconStatus(Resources.ec_green);
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				ProjectData.ClearProjectError();
			}
		}

		private Void OnPowerChange(Int32 mode)
		{
			if (this.u0024STATICu0024OnPowerChangeu002420118u0024ThisTimeu0024Init == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref this.u0024STATICu0024OnPowerChangeu002420118u0024ThisTimeu0024Init, new StaticLocalInitFlag(), null);
			}
			Boolean flag = false;
			try
			{
				Monitor.Enter(this.u0024STATICu0024OnPowerChangeu002420118u0024ThisTimeu0024Init, ref flag);
				if (this.u0024STATICu0024OnPowerChangeu002420118u0024ThisTimeu0024Init.State == 0)
				{
					this.u0024STATICu0024OnPowerChangeu002420118u0024ThisTimeu0024Init.State = 2;
					this.u0024STATICu0024OnPowerChangeu002420118u0024ThisTime = DateAndTime.get_Now();
				}
				else if (this.u0024STATICu0024OnPowerChangeu002420118u0024ThisTimeu0024Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				this.u0024STATICu0024OnPowerChangeu002420118u0024ThisTimeu0024Init.State = 1;
				if (flag)
				{
					Monitor.Exit(this.u0024STATICu0024OnPowerChangeu002420118u0024ThisTimeu0024Init);
				}
			}
			try
			{
				if (mode == 4)
				{
					Module1.Log(MethodBase.GetCurrentMethod(), "PowerModes.Suspend: {0}", new Object[] { DateAndTime.get_Now() });
					this.u0024STATICu0024OnPowerChangeu002420118u0024ThisTime = DateAndTime.get_Now();
				}
				if ((object)this.ClientClock != (object)null)
				{
					if ((object)this.UpldThread != (object)null)
					{
						Int32 num = mode;
						if (num == 4)
						{
							this.UpldThread.IsOnline = false;
						}
						else
						{
							if (num != 7)
							{
								if (num == 18)
								{
									goto Label1;
								}
								goto Label0;
							}
						Label1:
							MethodBase currentMethod = MethodBase.GetCurrentMethod();
							Module1.Log(currentMethod, "PowerModes.Resume: {0}", new Object[] { DateAndTime.get_Now() });
							this.TmrTick.Stop();
							this.TmrTick.Start();
							if (this.KillSwitch.get_IsRunning())
							{
								this.KillSwitch.Restart();
							}
							if ((object)this.ClientClock != (object)null)
							{
								Int64 num1 = DateAndTime.DateDiff(9, this.u0024STATICu0024OnPowerChangeu002420118u0024ThisTime, DateAndTime.get_Now(), 1, 1);
								this.ClientClock.CurrentTime.AddSeconds((Double)num1);
								Module1.Log(MethodBase.GetCurrentMethod(), "ClientClock.CurrentTime adjusted by {0} seconds to {1}. ThisTime={2}, Now={3}", new Object[] { num1, this.ClientClock.CurrentTime, this.u0024STATICu0024OnPowerChangeu002420118u0024ThisTime, DateAndTime.get_Now() });
								this.u0024STATICu0024OnPowerChangeu002420118u0024ThisTime = DateAndTime.get_Now();
							}
						}
					Label0:
					}
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				ProjectData.ClearProjectError();
			}
		}

		private Void OnProcessChanged(ProcessThread.ProcessChanged sender)
		{
			try
			{
				if (!this.HasExamEnded(false))
				{
					Module1.Log(MethodBase.GetCurrentMethod(), "", new Object[0]);
					sender.Token = Module1.Config.Token;
					sender.TimeStamp = this.ClientClock.CurrentTime;
					sender.CanSend = Module1.Config.Exam.TimeBegin.AddMilliseconds((Double)this.SendDelays.get_Item(eEventType.PROCESS));
					this.UpldThread.AddDataPackage(sender);
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				ProjectData.ClearProjectError();
			}
		}

		private Void OnScreenChanged(ScreenThread.ScreenChanged sender)
		{
			try
			{
				if (!this.HasExamEnded(false))
				{
					Module1.Log(MethodBase.GetCurrentMethod(), "Screen {0}: Bounds={1}, Filesize: {2:##,#} KB", new Object[] { sender.ScreenNumber, sender.Bounds.ToString(), (Double)((Int32)sender.Data.Length) / 1000 });
					if ((Int32)sender.Data.Length > 0)
					{
						sender.Token = Module1.Config.Token;
						sender.TimeStamp = this.ClientClock.CurrentTime;
						sender.CanSend = Module1.Config.Exam.TimeBegin.AddMilliseconds((Double)this.SendDelays.get_Item(eEventType.SCREENSHOT));
						this.UpldThread.AddDataPackage(sender);
					}
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				ProjectData.ClearProjectError();
			}
		}

		private Void OnThreadDebug(String message)
		{
			Module1.Log(MethodBase.GetCurrentMethod(), message, new Object[0]);
		}

		private Void OnThreadException(Exception ex)
		{
			Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), ex.ToString(), new Object[0]);
		}

		private Void OnTimerTick(Object sender, EventArgs e)
		{
			if (this.u0024STATICu0024OnTimerTicku002420211C1280A5u0024ticksu0024Init == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref this.u0024STATICu0024OnTimerTicku002420211C1280A5u0024ticksu0024Init, new StaticLocalInitFlag(), null);
			}
			Boolean flag = false;
			try
			{
				Monitor.Enter(this.u0024STATICu0024OnTimerTicku002420211C1280A5u0024ticksu0024Init, ref flag);
				if (this.u0024STATICu0024OnTimerTicku002420211C1280A5u0024ticksu0024Init.State == 0)
				{
					this.u0024STATICu0024OnTimerTicku002420211C1280A5u0024ticksu0024Init.State = 2;
					this.u0024STATICu0024OnTimerTicku002420211C1280A5u0024ticks = 0;
				}
				else if (this.u0024STATICu0024OnTimerTicku002420211C1280A5u0024ticksu0024Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				this.u0024STATICu0024OnTimerTicku002420211C1280A5u0024ticksu0024Init.State = 1;
				if (flag)
				{
					Monitor.Exit(this.u0024STATICu0024OnTimerTicku002420211C1280A5u0024ticksu0024Init);
				}
			}
			try
			{
				try
				{
					this.TmrTick.Stop();
					this.u0024STATICu0024OnTimerTicku002420211C1280A5u0024ticks = checked(this.u0024STATICu0024OnTimerTicku002420211C1280A5u0024ticks + 1);
					switch (this.SessionMode)
					{
						case FormMain.eSessionMode.BEGIN_SIGN_IN:
						{
							this.SessionMode = FormMain.eSessionMode.AWAIT_SIGN_IN;
							this.Login();
							break;
						}
						case FormMain.eSessionMode.AWAIT_SIGN_IN:
						{
							break;
						}
						case FormMain.eSessionMode.SIGNED_IN:
						{
							if (DateTime.Compare(this.ClientClock.CurrentTime, Module1.Config.Exam.TimeBegin) >= 0)
							{
								this.SessionMode = FormMain.eSessionMode.EXAM_STARTED;
								this.Notify("ExamCookie", new String[] { "Eksamen er nu begyndt", "og programmet er aktivt." });
								this.SetIconStatus(Resources.ec_green);
								this.StartThreads();
							}
							break;
						}
						case FormMain.eSessionMode.SIGN_IN_FAILED:
						case FormMain.eSessionMode.BEGIN_SIGN_IN | FormMain.eSessionMode.AWAIT_SIGN_IN | FormMain.eSessionMode.SIGNED_IN | FormMain.eSessionMode.SIGN_IN_FAILED | FormMain.eSessionMode.EXAM_STARTED | FormMain.eSessionMode.EXAM_ENDED:
						case 8:
						case 9:
						{
							MethodBase currentMethod = MethodBase.GetCurrentMethod();
							FormMain.eSessionMode sessionMode = this.SessionMode;
							Module1.Log(currentMethod, sessionMode.ToString(), new Object[0]);
							break;
						}
						case FormMain.eSessionMode.EXAM_STARTED:
						{
							if (DateTime.Compare(this.ClientClock.CurrentTime, Module1.Config.Exam.TimeEnd.AddMinutes((Double)(checked(Module1.Config.Exam.TimeEndExt + Module1.Config.Exam.StudentTimeExt)))) >= 0)
							{
								this.SessionMode = FormMain.eSessionMode.EXAM_ENDED;
								this.Notify("ExamCookie", new String[] { "Eksamen er slut", "og programmet lukker om et øjeblik." });
							}
							break;
						}
						case FormMain.eSessionMode.EXAM_ENDED:
						{
							this.SessionMode = FormMain.eSessionMode.CLOSE_DELAY;
							this.KillSwitch.Start();
							this.SetIconStatus(null);
							this.StopThreads(FormMain.eThreadStopMode.STOP_THREADS);
							Module1.Log(MethodBase.GetCurrentMethod(), "Offline files count = {0}", new Object[] { this.UpldThread.DataPackageOfflineCount });
							break;
						}
						case FormMain.eSessionMode.CLOSE:
						case FormMain.eSessionMode.CLOSE_AND_PRESERVE:
						case FormMain.eSessionMode.CLOSE_AND_DELETE:
						{
							this.TmrTick.Stop();
							this.OverlayForm.Close();
							break;
						}
						case FormMain.eSessionMode.CLOSE_DELAY:
						{
							if (!this.UpldThread.UploadDataPackagesComplete)
							{
								if (this.KillSwitch.get_ElapsedMilliseconds() > (Int64)(checked(Module1.FORCE_CLOSE_DELAY * 60000)))
								{
									this.SessionMode = FormMain.eSessionMode.CLOSE_AND_PRESERVE;
								}
							}
							else if (!this.UpldThread.IsOnline)
							{
								if (this.KillSwitch.get_ElapsedMilliseconds() > (Int64)12000)
								{
									this.SessionMode = FormMain.eSessionMode.CLOSE_AND_PRESERVE;
								}
							}
							else if (this.KillSwitch.get_ElapsedMilliseconds() > (Int64)12000)
							{
								this.SessionMode = FormMain.eSessionMode.CLOSE_AND_DELETE;
							}
							break;
						}
						default:
						{
							goto case 9;
						}
					}
					if ((object)this.UpldThread != (object)null)
					{
						this.UpldThread.CurrentTime = this.ClientClock.CurrentTime;
						this.SignOut();
					}
					if (this.u0024STATICu0024OnTimerTicku002420211C1280A5u0024ticks > 60)
					{
						this.u0024STATICu0024OnTimerTicku002420211C1280A5u0024ticks = 0;
						Module1.OptimizeMemoryConsumption();
						DateTime minValue = DateTime.MinValue;
						if (Module1.GetNetworkTime(ref minValue) == 0)
						{
							if (Math.Abs(DateAndTime.DateDiff(8, minValue.ToLocalTime(), DateAndTime.get_Now(), 1, 1)) > (Int64)3)
							{
								Module1.SetComputerClock();
							}
						}
						if ((object)this.UpldThread != (object)null)
						{
							if (!this.UpldThread.IsOnline)
							{
								this.SetIconStatus(Resources.ec_red);
							}
						}
					}
				}
				catch (Exception exception1)
				{
					ProjectData.SetProjectError(exception1);
					Exception exception = exception1;
					Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
					ProjectData.ClearProjectError();
				}
			}
			finally
			{
				this.TmrTick.Start();
			}
		}

		private Void RegisterMSHTML()
		{
			try
			{
				if (Operators.CompareString(Module1.GetWindowsReleaseId(), "1709", false) == 0)
				{
					String str = String.Format("{0}RegAsm.exe", RuntimeEnvironment.GetRuntimeDirectory());
					String str1 = String.Format("{0}Windows\\assembly\\GAC\\Microsoft.mshtml\\7.0.3300.0__b03f5f7f11d50a3a\\Microsoft.mshtml.dll", Path.GetPathRoot(Environment.get_SystemDirectory()));
					if (File.Exists(str))
					{
						if (File.Exists(str1))
						{
							String str2 = Module1.RunCommand(String.Format("CD {0} & {1} Microsoft.mshtml.dll", Path.GetDirectoryName(str1), str), "");
							Module1.Log(MethodBase.GetCurrentMethod(), "Result={0}", new Object[] { str2 });
						}
					}
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				ProjectData.ClearProjectError();
			}
		}

		private Void SetIconStatus(Image icon)
		{
			this.Panel1.set_BackgroundImage(icon);
		}

		private Void ShowNotify(String header, String[] message)
		{
			Module1.Log(MethodBase.GetCurrentMethod(), Strings.Join(message, " | "), new Object[0]);
			FormNotify formNotify = new FormNotify();
			try
			{
				Int32 notifyBoxDisplayTime = checked(Module1.Config.ClientConfiguration.NotifyBoxDisplayTime * 1000);
				formNotify.Notify(header, message, notifyBoxDisplayTime);
				formNotify.ShowDialog(this);
			}
			finally
			{
				if (formNotify != null)
				{
					formNotify.Dispose();
				}
			}
		}

		private Void SignOut()
		{
			try
			{
				if ((object)this.UpldThread != (object)null)
				{
					if (this.UpldThread.IsOnline)
					{
						if (this.HasExamEnded(false) & !Module1.USER_SIGN_OUT_SUCCESS)
						{
							ExamApiV3Client examApiV3Client = Module1.ExamClient();
							try
							{
								ExamApiV3Client examApiV3Client1 = examApiV3Client;
								Module1.SetCredentials(ref examApiV3Client1);
								eSignOutMethod integer = Conversions.ToInteger(Interaction.IIf(Module1.USER_SIGNED_OUT, eSignOutMethod.USER_CHOICE, eSignOutMethod.EXAM_ENDED));
								Int32 num = examApiV3Client.SignOut(Module1.Config.Token, integer, Module1.GetClientErrorLog());
								Module1.USER_SIGN_OUT_SUCCESS = num >= 0;
								Module1.Log(MethodBase.GetCurrentMethod(), "SignOut: {0}. Result={1}", new Object[] { integer.ToString(), num });
							}
							finally
							{
								if (examApiV3Client != null)
								{
									examApiV3Client.Dispose();
								}
							}
						}
					}
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				ProjectData.ClearProjectError();
			}
		}

		private Void StartThreads()
		{
			Module1.Log(MethodBase.GetCurrentMethod(), "StartThreads", new Object[0]);
			try
			{
				ClientConfig clientConfiguration = Module1.Config.ClientConfiguration;
				this.InitSendDelay(eEventType.SCREENSHOT, clientConfiguration.ScreenPolltime);
				this.ScrnThread = new ScreenThread(clientConfiguration.ScreenPolltime)
				{
					ScreenChangedPercent = (Single)clientConfiguration.ScreenChangedPercentWindows,
					PostSendDelay = checked(clientConfiguration.ScreenSendDelay * 1000),
					ForceScreenshotDelay = checked(clientConfiguration.ScreenForceSendTime * 1000),
					ImageQuality = clientConfiguration.ImageQuality
				};
				this.InitSendDelay(eEventType.ADAPTER, clientConfiguration.AdapterPolltime);
				this.AdapThread = new AdapterThread(clientConfiguration.AdapterPolltime);
				this.InitSendDelay(eEventType.FRONT_APP, clientConfiguration.FrontAppPolltime);
				this.ApplThread = new ApplicationThread(clientConfiguration.FrontAppPolltime);
				this.InitSendDelay(eEventType.CLIPBOARD, clientConfiguration.ClipboardPolltime);
				this.ClipThread = new ClipboardThread(clientConfiguration.ClipboardPolltime, base.get_Handle());
				this.InitSendDelay(eEventType.PROCESS, clientConfiguration.ProcessPolltime);
				this.ProcThread = new ProcessThread(clientConfiguration.ProcessPolltime)
				{
					IgnoreList = Enumerable.ToList<String>(clientConfiguration.ProcessIgnoreWindows)
				};
				clientConfiguration = null;
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				ProjectData.ClearProjectError();
			}
		}

		private Void StopThreads(FormMain.eThreadStopMode mode)
		{
			Module1.Log(MethodBase.GetCurrentMethod(), "StopThreads (Mode={0})", new Object[] { mode });
			try
			{
				if (mode == FormMain.eThreadStopMode.STOP_THREADS | mode == FormMain.eThreadStopMode.STOP_ALL)
				{
					if ((object)this.AdapThread != (object)null)
					{
						this.AdapThread.Started = false;
					}
					if ((object)this.ApplThread != (object)null)
					{
						this.ApplThread.Started = false;
					}
					if ((object)this.ProcThread != (object)null)
					{
						this.ProcThread.Started = false;
					}
					if ((object)this.ScrnThread != (object)null)
					{
						this.ScrnThread.Started = false;
					}
					if ((object)this.ConfThread != (object)null)
					{
						this.ConfThread.Started = false;
					}
					if ((object)this.ClipThread != (object)null)
					{
						this.ClipThread.Started = false;
					}
				}
				if (mode == FormMain.eThreadStopMode.STOP_UPLOAD | mode == FormMain.eThreadStopMode.STOP_ALL)
				{
					if ((object)this.UpldThread != (object)null)
					{
						this.UpldThread.Started = false;
					}
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				ProjectData.ClearProjectError();
			}
		}

		private Void Uninstall(FormMain.eSessionMode mode)
		{
			try
			{
				String str = "";
				if (mode == FormMain.eSessionMode.CLOSE_AND_DELETE)
				{
					str = String.Format("{0}\\{1}", Module1.APP_DATA_PATH, Module1.OFFLINE_PACKAGE_FOLDER);
					if (Directory.Exists(str))
					{
						String[] files = Directory.GetFiles(str);
						for (Int32 i = 0; i < (Int32)files.Length; i = checked(i + 1))
						{
							String str1 = files[i];
							try
							{
								File.Delete(str1);
							}
							catch (Exception exception)
							{
								ProjectData.SetProjectError(exception);
								ProjectData.ClearProjectError();
							}
						}
						try
						{
							Directory.Delete(str);
						}
						catch (Exception exception1)
						{
							ProjectData.SetProjectError(exception1);
							ProjectData.ClearProjectError();
						}
					}
				}
				if (mode == FormMain.eSessionMode.CLOSE_AND_PRESERVE | mode == FormMain.eSessionMode.CLOSE_AND_DELETE)
				{
					System.Diagnostics.Process process = new System.Diagnostics.Process();
					try
					{
						ProcessStartInfo processStartInfo = new ProcessStartInfo();
						processStartInfo.set_Arguments(String.Format(" /K timeout 3 & del \"{0}\\ExamCookie*.exe\"", Module1.APP_CURRENT_DIR));
						processStartInfo.set_FileName("cmd.exe");
						processStartInfo.set_CreateNoWindow(true);
						processStartInfo.set_UseShellExecute(false);
						process.set_StartInfo(processStartInfo);
						process.Start();
					}
					finally
					{
						if (process != null)
						{
							process.Dispose();
						}
					}
				}
			}
			catch (Exception exception2)
			{
				ProjectData.SetProjectError(exception2);
				ProjectData.ClearProjectError();
			}
		}

		private Void UploadSessionLog()
		{
			List<String>.Enumerator enumerator = new List<String>.Enumerator();
			try
			{
				MemoryStream memoryStream = new MemoryStream();
				try
				{
					StreamWriter streamWriter = new StreamWriter(memoryStream, Encoding.get_UTF8());
					try
					{
						try
						{
							enumerator = Module1.SessionLog.GetEnumerator();
							while (enumerator.MoveNext())
							{
								streamWriter.WriteLine(enumerator.get_Current());
							}
						}
						finally
						{
							enumerator.Dispose();
						}
					}
					finally
					{
						if (streamWriter != null)
						{
							streamWriter.Dispose();
						}
					}
					Module1.Log(MethodBase.GetCurrentMethod(), "Upload session log filen til storage", new Object[0]);
					ExamApiV3Client examApiV3Client = Module1.ExamClient();
					try
					{
						ExamApiV3Client examApiV3Client1 = examApiV3Client;
						Module1.SetCredentials(ref examApiV3Client1);
						examApiV3Client.SaveSessionLog(Module1.Config.Token, memoryStream.ToArray());
					}
					finally
					{
						if (examApiV3Client != null)
						{
							examApiV3Client.Dispose();
						}
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						memoryStream.Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				ProjectData.ClearProjectError();
			}
		}

		protected override Void WndProc(ref Message m)
		{
			Int32 msg = m.get_Msg();
			if (msg == 536)
			{
				Module1.Log(MethodBase.GetCurrentMethod(), "WM_POWERBROADCAST", new Object[0]);
				this.OnPowerChange(m.get_WParam().ToInt32());
			}
			else if (msg == 797)
			{
				try
				{
					if ((object)this.ClipThread != (object)null)
					{
						Module1.Log(MethodBase.GetCurrentMethod(), "WM_CLIPBOARDUPDATE", new Object[0]);
						this.ClipThread.GetClipboardData();
					}
				}
				catch (Exception exception1)
				{
					ProjectData.SetProjectError(exception1);
					Exception exception = exception1;
					Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
					ProjectData.ClearProjectError();
				}
			}
			base.WndProc(ref m);
		}

		public enum eSessionMode
		{
			INIT = 0,
			BEGIN_SIGN_IN = 1,
			AWAIT_SIGN_IN = 2,
			SIGNED_IN = 3,
			SIGN_IN_FAILED = 4,
			EXAM_STARTED = 5,
			EXAM_ENDED = 6,
			CLOSE = 10,
			CLOSE_DELAY = 11,
			CLOSE_AND_PRESERVE = 12,
			CLOSE_AND_DELETE = 13
		}

		private enum eThreadStopMode
		{
			STOP_THREADS = 1,
			STOP_UPLOAD = 2,
			STOP_ALL = 3
		}
	}
}