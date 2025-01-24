using Microsoft.Web.WebView2.Core;
using NativeWifi;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microsoft.Web.WebView2.WinForms
{
	[ComVisible(true)]
	public class WebView2 : Control, ISupportInitialize
	{
		private const String _designText = "WebView2";

		private const Int32 _designBorderWidth = 2;

		private CoreWebView2CreationProperties _creationProperties;

		internal Task _initTask;

		private Boolean _browserHitTransparent;

		private Boolean _isExplicitEnvironment;

		private Boolean _isExplicitControllerOptions;

		private CoreWebView2MoveFocusReason _lastMoveFocusReason;

		private Form _parentForm;

		private CoreWebView2Controller _coreWebView2Controller;

		private Double _zoomFactor = 1;

		private Boolean _allowExternalDrop = true;

		private Boolean _inInit;

		private Uri _source;

		private Color _defaultBackgroundColor = Color.get_White();

		private Boolean _browserCrashed;

		private IContainer components;

		[Browsable(false)]
		[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
		public Boolean AllowDrop
		{
			get
			{
				return base.get_AllowDrop();
			}
		}

		public Boolean AllowExternalDrop
		{
			get
			{
				if (this._coreWebView2Controller == null)
				{
					return this._allowExternalDrop;
				}
				return this._coreWebView2Controller.AllowExternalDrop;
			}
			set
			{
				this._allowExternalDrop = value;
				if (this._coreWebView2Controller != null)
				{
					this._coreWebView2Controller.AllowExternalDrop = value;
				}
			}
		}

		[Browsable(false)]
		public Boolean CanGoBack
		{
			get
			{
				Microsoft.Web.WebView2.Core.CoreWebView2 coreWebView2 = this.CoreWebView2;
				if (coreWebView2 != null)
				{
					return coreWebView2.CanGoBack;
				}
				return false;
			}
		}

		[Browsable(false)]
		public Boolean CanGoForward
		{
			get
			{
				Microsoft.Web.WebView2.Core.CoreWebView2 coreWebView2 = this.CoreWebView2;
				if (coreWebView2 != null)
				{
					return coreWebView2.CanGoForward;
				}
				return false;
			}
		}

		[Browsable(false)]
		[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
		public System.Windows.Forms.ContextMenu ContextMenu
		{
			get
			{
				return base.get_ContextMenu();
			}
		}

		[Browsable(false)]
		[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
		public System.Windows.Forms.ContextMenuStrip ContextMenuStrip
		{
			get
			{
				return base.get_ContextMenuStrip();
			}
		}

		private CoreWebView2ControllerOptions ControllerOptions
		{
			get;
			set;
		}

		public Microsoft.Web.WebView2.Core.CoreWebView2 CoreWebView2
		{
			get
			{
				Microsoft.Web.WebView2.Core.CoreWebView2 coreWebView2;
				Microsoft.Web.WebView2.Core.CoreWebView2 coreWebView21;
				try
				{
					CoreWebView2Controller coreWebView2Controller = this._coreWebView2Controller;
					if (coreWebView2Controller != null)
					{
						coreWebView21 = coreWebView2Controller.CoreWebView2;
					}
					else
					{
						coreWebView21 = null;
					}
					coreWebView2 = coreWebView21;
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					if (base.get_InvokeRequired())
					{
						throw new InvalidOperationException("CoreWebView2 can only be accessed from the UI thread.", exception);
					}
					throw;
				}
				return coreWebView2;
			}
		}

		protected override System.Windows.Forms.CreateParams CreateParams
		{
			get
			{
				System.Windows.Forms.CreateParams createParams = base.get_CreateParams();
				createParams.set_ExStyle(createParams.get_ExStyle() | 32);
				return createParams;
			}
		}

		[Browsable(false)]
		public CoreWebView2CreationProperties CreationProperties
		{
			get
			{
				return this._creationProperties;
			}
			set
			{
				if (this._initTask != null)
				{
					throw new InvalidOperationException("CreationProperties cannot be modified after the initialization of CoreWebView2 has begun.");
				}
				this._creationProperties = value;
			}
		}

		public Color DefaultBackgroundColor
		{
			get
			{
				if (this._coreWebView2Controller == null)
				{
					return this._defaultBackgroundColor;
				}
				return this._coreWebView2Controller.DefaultBackgroundColor;
			}
			set
			{
				if (this._coreWebView2Controller == null)
				{
					this._defaultBackgroundColor = value;
					return;
				}
				this._coreWebView2Controller.DefaultBackgroundColor = value;
			}
		}

		private CoreWebView2Environment Environment
		{
			get;
			set;
		}

		[Browsable(false)]
		[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
		public System.Drawing.Font Font
		{
			get
			{
				return base.get_Font();
			}
		}

		private Boolean IsInDesignMode
		{
			get
			{
				ISite sitedParentSite = this.GetSitedParentSite(this);
				if (sitedParentSite == null)
				{
					return false;
				}
				return sitedParentSite.get_DesignMode();
			}
		}

		private Boolean IsInitialized
		{
			get;
			set;
		}

		[Browsable(true)]
		public Uri Source
		{
			get
			{
				return this._source;
			}
			set
			{
				if (value == null)
				{
					if (this._source != null)
					{
						throw new NotImplementedException("Setting Source to null is not implemented yet.");
					}
					return;
				}
				if (!value.get_IsAbsoluteUri())
				{
					throw new ArgumentException("Only absolute URI is allowed", "Source");
				}
				if (this.IsInitialized && this._source != null && this._source.get_AbsoluteUri() == value.get_AbsoluteUri())
				{
					return;
				}
				this._source = value;
				if (this._inInit)
				{
					return;
				}
				if (!this.IsInitialized)
				{
					this.EnsureCoreWebView2Async(null, null);
					return;
				}
				this.CoreWebView2.Navigate(value.get_AbsoluteUri());
			}
		}

		[Browsable(false)]
		[EditorBrowsable(,)]    // JustDecompile was unable to locate the assembly where attribute parameters types are defined. Generating parameters values is impossible.
		public String Text
		{
			get
			{
				return base.get_Text();
			}
		}

		public Double ZoomFactor
		{
			get
			{
				if (this._coreWebView2Controller == null)
				{
					return this._zoomFactor;
				}
				return this._coreWebView2Controller.ZoomFactor;
			}
			set
			{
				this._zoomFactor = value;
				if (this._coreWebView2Controller != null)
				{
					this._coreWebView2Controller.ZoomFactor = value;
				}
			}
		}

		private Void _coreWebView2Controller_AcceleratorKeyPressed(Object sender, CoreWebView2AcceleratorKeyPressedEventArgs e)
		{
			switch (e.KeyEventKind)
			{
				case CoreWebView2KeyEventKind.KeyDown:
				case CoreWebView2KeyEventKind.SystemKeyDown:
				{
					KeyEventArgs keyEventArg = new KeyEventArgs(e.VirtualKey);
					this.OnKeyDown(keyEventArg);
					e.Handled = keyEventArg.get_Handled();
					return;
				}
				case CoreWebView2KeyEventKind.KeyUp:
				case CoreWebView2KeyEventKind.SystemKeyUp:
				{
					KeyEventArgs keyEventArg1 = new KeyEventArgs(e.VirtualKey);
					this.OnKeyUp(keyEventArg1);
					e.Handled = keyEventArg1.get_Handled();
					return;
				}
				default:
				{
					return;
				}
			}
		}

		private Void _coreWebView2Controller_KeyPressed(Object sender, CoreWebView2PrivateKeyPressedEventArgs e)
		{
			switch (e.KeyEventKind)
			{
				case CoreWebView2KeyEventKind.KeyDown:
				case CoreWebView2KeyEventKind.SystemKeyDown:
				{
					KeyEventArgs keyEventArg = new KeyEventArgs(e.VirtualKey);
					this.OnKeyDown(keyEventArg);
					e.Handled = keyEventArg.get_Handled();
					return;
				}
				case CoreWebView2KeyEventKind.KeyUp:
				case CoreWebView2KeyEventKind.SystemKeyUp:
				{
					KeyEventArgs keyEventArg1 = new KeyEventArgs(e.VirtualKey);
					this.OnKeyUp(keyEventArg1);
					e.Handled = keyEventArg1.get_Handled();
					return;
				}
				default:
				{
					return;
				}
			}
		}

		private Void _coreWebView2Controller_ZoomFactorChanged(Object sender, Object e)
		{
			this._zoomFactor = this._coreWebView2Controller.ZoomFactor;
			EventHandler<EventArgs> eventHandler = this.ZoomFactorChanged;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, EventArgs.Empty);
		}

		[ToolboxItem(true)]
		public WebView2()
		{
			this.InitializeComponent();
			base.SetStyle(2, true);
			base.SetStyle(8192, true);
		}

		private Void CoreWebView2_ContentLoading(Object sender, CoreWebView2ContentLoadingEventArgs e)
		{
			EventHandler<CoreWebView2ContentLoadingEventArgs> eventHandler = this.ContentLoading;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, e);
		}

		private Void CoreWebView2_NavigationCompleted(Object sender, CoreWebView2NavigationCompletedEventArgs e)
		{
			EventHandler<CoreWebView2NavigationCompletedEventArgs> eventHandler = this.NavigationCompleted;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, e);
		}

		private Void CoreWebView2_NavigationStarting(Object sender, CoreWebView2NavigationStartingEventArgs e)
		{
			EventHandler<CoreWebView2NavigationStartingEventArgs> eventHandler = this.NavigationStarting;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, e);
		}

		private Void CoreWebView2_ProcessFailed(Object sender, CoreWebView2ProcessFailedEventArgs e)
		{
			if (e.ProcessFailedKind == CoreWebView2ProcessFailedKind.BrowserProcessExited)
			{
				this.UnsubscribeHandlersAndCloseController(true);
			}
		}

		private Void CoreWebView2_SourceChanged(Object sender, CoreWebView2SourceChangedEventArgs e)
		{
			this._source = new Uri(this.CoreWebView2.Source);
			EventHandler<CoreWebView2SourceChangedEventArgs> eventHandler = this.SourceChanged;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, e);
		}

		private Void CoreWebView2_WebMessageReceived(Object sender, CoreWebView2WebMessageReceivedEventArgs e)
		{
			EventHandler<CoreWebView2WebMessageReceivedEventArgs> eventHandler = this.WebMessageReceived;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.Invoke(this, e);
		}

		private Void CoreWebView2Controller_MoveFocusRequested(Object sender, CoreWebView2MoveFocusRequestedEventArgs e)
		{
			// 
			// Current member / type: System.Void Microsoft.Web.WebView2.WinForms.WebView2::CoreWebView2Controller_MoveFocusRequested(System.Object,Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusRequestedEventArgs)
			// File path: /home/halfdan/Downloads/ExamCookie1414.WinClient.exe
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void CoreWebView2Controller_MoveFocusRequested(System.Object,Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusRequestedEventArgs)
			// 
			// Object reference not set to an instance of an object.
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FindLowestCommonAncestor(ICollection`1 typeNodes) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/TypeInference/TypeInferer.cs:line 515
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.MergeWithLowestCommonAncestor() in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/TypeInference/TypeInferer.cs:line 445
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.ProcessSingleConstraints() in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/TypeInference/TypeInferer.cs:line 363
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.InferTypes() in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/TypeInference/TypeInferer.cs:line 307
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/ExpressionDecompilerStep.cs:line 86
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/DecompilationPipeline.cs:line 88
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.Run(MethodBody body, ILanguage language) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.RunPipeline(DecompilationPipeline pipeline, ILanguage language, MethodBody body, DecompilationContext& context) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.Decompile(MethodBody body, ILanguage language, DecompilationContext& context, TypeSpecificContext typeContext) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/Extensions.cs:line 61
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in /home/runner/work/CodemerxDecompile/CodemerxDecompile/src/JustDecompileEngine/src/JustDecompiler.Shared/Decompiler/WriterContextServices/BaseWriterContextService.cs:line 118
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		protected override Void Dispose(Boolean disposing)
		{
			if (!disposing || base.get_IsDisposed())
			{
				return;
			}
			if (this.IsInitialized)
			{
				this.UnsubscribeHandlersAndCloseController(false);
			}
			if (this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		public Task EnsureCoreWebView2Async(CoreWebView2Environment environment = null, CoreWebView2ControllerOptions controllerOptions = null)
		{
			if (this.IsInDesignMode)
			{
				return Task.FromResult<Int32>(0);
			}
			this.VerifyNotClosedGuard();
			this.VerifyBrowserNotCrashedGuard();
			if (base.get_InvokeRequired())
			{
				throw new InvalidOperationException("The method EnsureCoreWebView2Async can be invoked only from the UI thread.");
			}
			if (this._initTask == null || this._initTask.get_IsFaulted())
			{
				this._initTask = this.InitCoreWebView2Async(environment, controllerOptions);
			}
			else
			{
				if (!this._isExplicitEnvironment && environment != null || this._isExplicitEnvironment && environment != null && (object)this.Environment != (object)environment)
				{
					throw new ArgumentException("WebView2 was already initialized with a different CoreWebView2Environment. Check to see if the Source property was already set or EnsureCoreWebView2Async was previously called with different values.");
				}
				if (!this._isExplicitControllerOptions && controllerOptions != null || this._isExplicitControllerOptions && controllerOptions != null && (object)this.ControllerOptions != (object)controllerOptions)
				{
					throw new ArgumentException("WebView2 was already initialized with a different CoreWebView2ControllerOptions. Check to see if the Source property was already set or EnsureCoreWebView2Async was previously called with different values.");
				}
			}
			return this._initTask;
		}

		public Task EnsureCoreWebView2Async(CoreWebView2Environment environment)
		{
			return this.EnsureCoreWebView2Async(environment, null);
		}

		public async Task<String> ExecuteScriptAsync(String script)
		{
			this.VerifyInitializedGuard();
			this.VerifyBrowserNotCrashedGuard();
			return await this.CoreWebView2.ExecuteScriptAsync(script);
		}

		private ISite GetSitedParentSite(Control control)
		{
			if (control == null)
			{
				throw new ArgumentNullException("control");
			}
			if (control.get_Site() != null || control.get_Parent() == null)
			{
				return control.get_Site();
			}
			return this.GetSitedParentSite(control.get_Parent());
		}

		public Void GoBack()
		{
			Microsoft.Web.WebView2.Core.CoreWebView2 coreWebView2 = this.CoreWebView2;
			if (coreWebView2 == null)
			{
				return;
			}
			coreWebView2.GoBack();
		}

		public Void GoForward()
		{
			Microsoft.Web.WebView2.Core.CoreWebView2 coreWebView2 = this.CoreWebView2;
			if (coreWebView2 == null)
			{
				return;
			}
			coreWebView2.GoForward();
		}

		private async Task InitCoreWebView2Async(CoreWebView2Environment environment = null, CoreWebView2ControllerOptions controllerOptions = null)
		{
			try
			{
				if (environment != null)
				{
					this.Environment = environment;
					this._isExplicitEnvironment = true;
				}
				else if (this.CreationProperties != null)
				{
					this.Environment = await this.CreationProperties.CreateEnvironmentAsync();
				}
				if (this.Environment == null)
				{
					this.Environment = await CoreWebView2Environment.CreateAsync(null, null, null);
				}
				if (controllerOptions != null)
				{
					this.ControllerOptions = controllerOptions;
					this._isExplicitControllerOptions = true;
				}
				else if (this.CreationProperties != null)
				{
					this.ControllerOptions = this.CreationProperties.CreateCoreWebView2ControllerOptions(this.Environment);
				}
				if (this._defaultBackgroundColor != Color.get_White())
				{
					Color color = Color.FromArgb(this.DefaultBackgroundColor.ToArgb());
					System.Environment.SetEnvironmentVariable("WEBVIEW2_DEFAULT_BACKGROUND_COLOR", color.get_Name());
				}
				if (this.ControllerOptions == null)
				{
					this._coreWebView2Controller = await this.Environment.CreateCoreWebView2ControllerAsync(base.get_Handle());
				}
				else
				{
					this._coreWebView2Controller = await this.Environment.CreateCoreWebView2ControllerAsync(base.get_Handle(), this.ControllerOptions);
				}
				try
				{
					this._browserHitTransparent = this._coreWebView2Controller.IsBrowserHitTransparent;
				}
				catch (NotImplementedException notImplementedException)
				{
				}
				this._coreWebView2Controller.ZoomFactor = this._zoomFactor;
				this._coreWebView2Controller.DefaultBackgroundColor = this._defaultBackgroundColor;
				this._coreWebView2Controller.Bounds = new Rectangle(0, 0, base.get_Width(), base.get_Height());
				this._coreWebView2Controller.IsVisible = base.get_Visible();
				try
				{
					this._coreWebView2Controller.AllowExternalDrop = this._allowExternalDrop;
				}
				catch (NotImplementedException notImplementedException1)
				{
				}
				this._coreWebView2Controller.MoveFocusRequested += new EventHandler<CoreWebView2MoveFocusRequestedEventArgs>(this, WebView2.CoreWebView2Controller_MoveFocusRequested);
				if (this._browserHitTransparent)
				{
					this._coreWebView2Controller.KeyPressed += new EventHandler<CoreWebView2PrivateKeyPressedEventArgs>(this, WebView2._coreWebView2Controller_KeyPressed);
				}
				else
				{
					this._coreWebView2Controller.AcceleratorKeyPressed += new EventHandler<CoreWebView2AcceleratorKeyPressedEventArgs>(this, WebView2._coreWebView2Controller_AcceleratorKeyPressed);
				}
				this._coreWebView2Controller.ZoomFactorChanged += new EventHandler<Object>(this, WebView2._coreWebView2Controller_ZoomFactorChanged);
				this.CoreWebView2.NavigationCompleted += new EventHandler<CoreWebView2NavigationCompletedEventArgs>(this, WebView2.CoreWebView2_NavigationCompleted);
				this.CoreWebView2.NavigationStarting += new EventHandler<CoreWebView2NavigationStartingEventArgs>(this, WebView2.CoreWebView2_NavigationStarting);
				this.CoreWebView2.SourceChanged += new EventHandler<CoreWebView2SourceChangedEventArgs>(this, WebView2.CoreWebView2_SourceChanged);
				this.CoreWebView2.WebMessageReceived += new EventHandler<CoreWebView2WebMessageReceivedEventArgs>(this, WebView2.CoreWebView2_WebMessageReceived);
				this.CoreWebView2.ContentLoading += new EventHandler<CoreWebView2ContentLoadingEventArgs>(this, WebView2.CoreWebView2_ContentLoading);
				this.CoreWebView2.ProcessFailed += new EventHandler<CoreWebView2ProcessFailedEventArgs>(this, WebView2.CoreWebView2_ProcessFailed);
				try
				{
					this.RegisterProfileDeletedEvent(true);
				}
				catch (Exception exception)
				{
				}
				base.add_HandleDestroyed(new EventHandler(this, WebView2.WebView2_HandleDestroyed));
				base.add_HandleCreated(new EventHandler(this, WebView2.WebView2_HandleCreated));
				if (this.get_Focused())
				{
					this._coreWebView2Controller.MoveFocus(CoreWebView2MoveFocusReason.Programmatic);
				}
				Boolean flag = this._source != null;
				if (this._source == null)
				{
					this._source = new Uri(this.CoreWebView2.Source);
				}
				this.IsInitialized = true;
				EventHandler<CoreWebView2InitializationCompletedEventArgs> coreWebView2InitializationCompleted = this.CoreWebView2InitializationCompleted;
				if (coreWebView2InitializationCompleted != null)
				{
					coreWebView2InitializationCompleted.Invoke(this, new CoreWebView2InitializationCompletedEventArgs(null));
				}
				else
				{
				}
				if (flag)
				{
					this.CoreWebView2.Navigate(this._source.get_AbsoluteUri());
				}
			}
			catch (Exception exception2)
			{
				Exception exception1 = exception2;
				EventHandler<CoreWebView2InitializationCompletedEventArgs> eventHandler = this.CoreWebView2InitializationCompleted;
				if (eventHandler != null)
				{
					eventHandler.Invoke(this, new CoreWebView2InitializationCompletedEventArgs(exception1));
				}
				else
				{
				}
				throw;
			}
		}

		private Void InitializeComponent()
		{
			this.components = new Container();
		}

		public Void NavigateToString(String htmlContent)
		{
			this.VerifyInitializedGuard();
			this.VerifyBrowserNotCrashedGuard();
			this.CoreWebView2.NavigateToString(htmlContent);
		}

		protected override Void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			if (this.IsInitialized && !this._browserCrashed)
			{
				try
				{
					this._coreWebView2Controller.MoveFocus(this._lastMoveFocusReason);
				}
				catch (InvalidOperationException invalidOperationException1)
				{
					InvalidOperationException invalidOperationException = invalidOperationException1;
					if (invalidOperationException.get_InnerException().get_HResult() != -2147019873)
					{
						throw invalidOperationException;
					}
				}
			}
			this._lastMoveFocusReason = CoreWebView2MoveFocusReason.Programmatic;
		}

		protected override Void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			if (this.IsInDesignMode)
			{
				e.get_Graphics().FillRectangle(new SolidBrush(this.get_BackColor()), base.get_ClientRectangle());
				e.get_Graphics().DrawRectangle(new Pen(new SolidBrush(this.get_ForeColor()), 2f), base.get_ClientRectangle());
				SizeF sizeF = e.get_Graphics().MeasureString("WebView2", this.Font);
				if (this.get_BackgroundImage() != null)
				{
					e.get_Graphics().DrawImage(this.get_BackgroundImage(), new Rectangle(Point.Empty, base.get_ClientSize()));
				}
				Graphics graphics = e.get_Graphics();
				System.Drawing.Font font = this.Font;
				SolidBrush solidBrush = new SolidBrush(this.get_ForeColor());
				Size clientSize = base.get_ClientSize();
				Single width = (Single)(clientSize.get_Width() / 2) - sizeF.get_Width() / 2f;
				clientSize = base.get_ClientSize();
				graphics.DrawString("WebView2", font, solidBrush, width, (Single)(clientSize.get_Height() / 2) - sizeF.get_Height() / 2f);
			}
		}

		protected override Void OnParentChanged(EventArgs e)
		{
			base.OnParentChanged(e);
			Form form = base.FindForm();
			if (form != null && (object)form != (object)this._parentForm)
			{
				form.add_LocationChanged(new EventHandler(this, WebView2.WebView2_WindowPositionChanged));
				if (this._parentForm != null)
				{
					this._parentForm.remove_LocationChanged(new EventHandler(this, WebView2.WebView2_WindowPositionChanged));
				}
				this._parentForm = form;
			}
		}

		protected override Void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			if (this.IsInitialized && !this._browserCrashed)
			{
				this._coreWebView2Controller.Bounds = new Rectangle(0, 0, base.get_Width(), base.get_Height());
			}
		}

		protected override Void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged(e);
			if (this.IsInitialized && !this._browserCrashed)
			{
				this._coreWebView2Controller.IsVisible = base.get_Visible();
			}
		}

		private Void Profile_Deleted(Object sender, Object e)
		{
			this.UnsubscribeHandlersAndCloseController(false);
		}

		private Void RegisterProfileDeletedEvent(Boolean register)
		{
			if (register)
			{
				this.CoreWebView2.Profile.add_Deleted(new EventHandler<Object>(this, WebView2.Profile_Deleted));
				return;
			}
			this.CoreWebView2.Profile.remove_Deleted(new EventHandler<Object>(this, WebView2.Profile_Deleted));
		}

		public Void Reload()
		{
			this.VerifyInitializedGuard();
			this.VerifyBrowserNotCrashedGuard();
			this.CoreWebView2.Reload();
		}

		private Void ResetSource()
		{
			this._source = null;
		}

		protected override Void Select(Boolean directed, Boolean forward)
		{
			if (directed)
			{
				this._lastMoveFocusReason = (forward ? CoreWebView2MoveFocusReason.Next : CoreWebView2MoveFocusReason.Previous);
			}
			base.Select(directed, forward);
		}

		private Boolean ShouldSerializeSource()
		{
			Int32? nullable;
			Int32? nullable1;
			Uri uri = this._source;
			if (uri != null)
			{
				String absoluteUri = uri.get_AbsoluteUri();
				if (absoluteUri != null)
				{
					nullable1 = new Int32?(absoluteUri.get_Length());
				}
				else
				{
					nullable = null;
					nullable1 = nullable;
				}
			}
			else
			{
				nullable = null;
				nullable1 = nullable;
			}
			nullable = nullable1;
			return nullable.GetValueOrDefault() > 0;
		}

		public Void Stop()
		{
			Microsoft.Web.WebView2.Core.CoreWebView2 coreWebView2 = this.CoreWebView2;
			if (coreWebView2 == null)
			{
				return;
			}
			coreWebView2.Stop();
		}

		Void System.ComponentModel.ISupportInitialize.BeginInit()
		{
			this._inInit = true;
		}

		Void System.ComponentModel.ISupportInitialize.EndInit()
		{
			this._inInit = false;
			if (this._source == null)
			{
				return;
			}
			if (!this.IsInitialized)
			{
				this.EnsureCoreWebView2Async(null, null);
				return;
			}
			this.CoreWebView2.Navigate(this._source.get_AbsoluteUri());
		}

		private Void UnsubscribeHandlersAndCloseController(Boolean browserCrashed = false)
		{
			this.IsInitialized = false;
			this._browserCrashed = browserCrashed;
			base.remove_HandleDestroyed(new EventHandler(this, WebView2.WebView2_HandleDestroyed));
			base.remove_HandleCreated(new EventHandler(this, WebView2.WebView2_HandleCreated));
			if (this._parentForm != null)
			{
				this._parentForm.remove_LocationChanged(new EventHandler(this, WebView2.WebView2_WindowPositionChanged));
			}
			if (!this._browserCrashed)
			{
				this.CoreWebView2.NavigationCompleted -= new EventHandler<CoreWebView2NavigationCompletedEventArgs>(this, WebView2.CoreWebView2_NavigationCompleted);
				this.CoreWebView2.NavigationStarting -= new EventHandler<CoreWebView2NavigationStartingEventArgs>(this, WebView2.CoreWebView2_NavigationStarting);
				this.CoreWebView2.SourceChanged -= new EventHandler<CoreWebView2SourceChangedEventArgs>(this, WebView2.CoreWebView2_SourceChanged);
				this.CoreWebView2.WebMessageReceived -= new EventHandler<CoreWebView2WebMessageReceivedEventArgs>(this, WebView2.CoreWebView2_WebMessageReceived);
				this.CoreWebView2.ContentLoading -= new EventHandler<CoreWebView2ContentLoadingEventArgs>(this, WebView2.CoreWebView2_ContentLoading);
				this.CoreWebView2.ProcessFailed -= new EventHandler<CoreWebView2ProcessFailedEventArgs>(this, WebView2.CoreWebView2_ProcessFailed);
				try
				{
					this.RegisterProfileDeletedEvent(false);
				}
				catch (Exception exception)
				{
				}
				this._coreWebView2Controller.ZoomFactorChanged -= new EventHandler<Object>(this, WebView2._coreWebView2Controller_ZoomFactorChanged);
				this._coreWebView2Controller.MoveFocusRequested -= new EventHandler<CoreWebView2MoveFocusRequestedEventArgs>(this, WebView2.CoreWebView2Controller_MoveFocusRequested);
				if (this._browserHitTransparent)
				{
					this._coreWebView2Controller.KeyPressed -= new EventHandler<CoreWebView2PrivateKeyPressedEventArgs>(this, WebView2._coreWebView2Controller_KeyPressed);
				}
				else
				{
					this._coreWebView2Controller.AcceleratorKeyPressed -= new EventHandler<CoreWebView2AcceleratorKeyPressedEventArgs>(this, WebView2._coreWebView2Controller_AcceleratorKeyPressed);
				}
				this._coreWebView2Controller.Close();
			}
			this._coreWebView2Controller = null;
		}

		private Void VerifyBrowserNotCrashedGuard()
		{
			if (this._browserCrashed)
			{
				throw new InvalidOperationException("The instance of CoreWebView2 is no longer valid because the browser process crashed.To work around this, please listen for the ProcessFailed event to explicitly manage the lifetime of the WebView2 control in the event of a browser failure.https://docs.microsoft.com/en-us/dotnet/api/microsoft.web.webview2.core.corewebview2.processfailed");
			}
		}

		private Void VerifyInitializedGuard()
		{
			if (!this.IsInitialized)
			{
				throw new InvalidOperationException("The instance of CoreWebView2 is uninitialized and unable to complete this operation. See EnsureCoreWebView2Async.");
			}
		}

		private Void VerifyNotClosedGuard()
		{
			if (base.get_IsDisposed())
			{
				throw new InvalidOperationException("The instance of CoreWebView2 is disposed and unable to complete this operation.");
			}
		}

		private Void WebView2_HandleCreated(Object sender, EventArgs e)
		{
			this._coreWebView2Controller.ParentWindow = base.get_Handle();
			this._coreWebView2Controller.IsVisible = base.get_Visible();
		}

		private Void WebView2_HandleDestroyed(Object sender, EventArgs e)
		{
			this._coreWebView2Controller.IsVisible = false;
			this._coreWebView2Controller.ParentWindow = IntPtr.Zero;
		}

		private Void WebView2_WindowPositionChanged(Object sender, EventArgs e)
		{
			CoreWebView2Controller coreWebView2Controller = this._coreWebView2Controller;
			if (coreWebView2Controller == null)
			{
				return;
			}
			coreWebView2Controller.NotifyParentWindowPositionChanged();
		}

		protected override Void WndProc(ref Message m)
		{
			WebView2.NativeMethods.PaintStruct paintStruct;
			if (m.get_Msg() != 15 || this.IsInDesignMode)
			{
				base.WndProc(ref m);
				return;
			}
			WebView2.NativeMethods.BeginPaint(m.get_HWnd(), out paintStruct);
			WebView2.NativeMethods.EndPaint(m.get_HWnd(), ref paintStruct);
			m.set_Result(IntPtr.Zero);
		}

		public event EventHandler<CoreWebView2ContentLoadingEventArgs> ContentLoading;

		public event EventHandler<CoreWebView2InitializationCompletedEventArgs> CoreWebView2InitializationCompleted;

		public event EventHandler<CoreWebView2NavigationCompletedEventArgs> NavigationCompleted;

		public event EventHandler<CoreWebView2NavigationStartingEventArgs> NavigationStarting;

		public event EventHandler<CoreWebView2SourceChangedEventArgs> SourceChanged;

		public event EventHandler<CoreWebView2WebMessageReceivedEventArgs> WebMessageReceived;

		public event EventHandler<EventArgs> ZoomFactorChanged;

		private static class NativeMethods
		{
			[DllImport("user32.dll", CharSet=1, ExactSpelling=false, SetLastError=true)]
			public static extern IntPtr BeginPaint(IntPtr hwnd, out WebView2.NativeMethods.PaintStruct lpPaint);

			[DllImport("user32.dll", CharSet=1, ExactSpelling=false, SetLastError=true)]
			public static extern Boolean EndPaint(IntPtr hwnd, ref WebView2.NativeMethods.PaintStruct lpPaint);

			public struct PaintStruct
			{
				public IntPtr hdc;

				public Boolean fErase;

				public WebView2.NativeMethods.Rect rcPaint;

				public Boolean fRestore;

				public Boolean fIncUpdate;

				public Byte[] rgbReserved;
			}

			public struct Rect
			{
				public Int32 left;

				public Int32 top;

				public Int32 right;

				public Int32 bottom;
			}

			public enum WM : UInt32
			{
				PAINT = 15
			}

			[Flags]
			public enum WS_EX : UInt32
			{
				None = 0,
				TRANSPARENT = 32
			}
		}
	}
}