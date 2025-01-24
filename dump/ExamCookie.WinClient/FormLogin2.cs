using ExamCookie.Library;
using ExamCookie.WinClient.ExamApiV3Service;
using ExamCookie.WinClient.My;
using ExamCookie.WinClient.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ExamCookie.WinClient
{
	[DesignerGenerated]
	public class FormLogin2 : Form
	{
		private IContainer components;

		internal virtual LinkLabel BtnTerms
		{
			get
			{
				stackVariable1 = this._BtnTerms;
				return stackVariable1;
			}
			[MethodImpl(32)]
			set
			{
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(this, FormLogin2.OnTermsClicked);
				LinkLabel linkLabel = this._BtnTerms;
				if (linkLabel != null)
				{
					linkLabel.remove_LinkClicked(linkLabelLinkClickedEventHandler);
				}
				this._BtnTerms = value;
				linkLabel = this._BtnTerms;
				if (linkLabel != null)
				{
					linkLabel.add_LinkClicked(linkLabelLinkClickedEventHandler);
				}
			}
		}

		internal virtual Panel PanelExamCookie
		{
			get;
			[MethodImpl(32)]
			set;
		}

		internal virtual Panel PanelHeader
		{
			get;
			[MethodImpl(32)]
			set;
		}

		internal virtual Panel PanelTabButton
		{
			get;
			[MethodImpl(32)]
			set;
		}

		internal virtual Panel PanelWebView
		{
			get;
			[MethodImpl(32)]
			set;
		}

		internal virtual RadioButton TabManuelLogin
		{
			get
			{
				stackVariable1 = this._TabManuelLogin;
				return stackVariable1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this, FormLogin2.OnTabChanged);
				RadioButton radioButton = this._TabManuelLogin;
				if (radioButton != null)
				{
					radioButton.remove_CheckedChanged(eventHandler);
				}
				this._TabManuelLogin = value;
				radioButton = this._TabManuelLogin;
				if (radioButton != null)
				{
					radioButton.add_CheckedChanged(eventHandler);
				}
			}
		}

		internal virtual RadioButton TabTest
		{
			get
			{
				stackVariable1 = this._TabTest;
				return stackVariable1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this, FormLogin2.OnTabChanged);
				RadioButton radioButton = this._TabTest;
				if (radioButton != null)
				{
					radioButton.remove_CheckedChanged(eventHandler);
				}
				this._TabTest = value;
				radioButton = this._TabTest;
				if (radioButton != null)
				{
					radioButton.add_CheckedChanged(eventHandler);
				}
			}
		}

		internal virtual RadioButton TabUniLogin
		{
			get
			{
				stackVariable1 = this._TabUniLogin;
				return stackVariable1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this, FormLogin2.OnTabChanged);
				RadioButton radioButton = this._TabUniLogin;
				if (radioButton != null)
				{
					radioButton.remove_CheckedChanged(eventHandler);
				}
				this._TabUniLogin = value;
				radioButton = this._TabUniLogin;
				if (radioButton != null)
				{
					radioButton.add_CheckedChanged(eventHandler);
				}
			}
		}

		private FormLogin2.eAction TimerAction
		{
			get
			{
				return Conversions.ToInteger(this.TmrAction.get_Tag());
			}
			set
			{
				this.TmrAction.set_Tag(value);
			}
		}

		internal virtual Timer TmrAction
		{
			get
			{
				stackVariable1 = this._TmrAction;
				return stackVariable1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this, FormLogin2.OnTmrAction);
				Timer timer = this._TmrAction;
				if (timer != null)
				{
					timer.remove_Tick(eventHandler);
				}
				this._TmrAction = value;
				timer = this._TmrAction;
				if (timer != null)
				{
					timer.add_Tick(eventHandler);
				}
			}
		}

		internal virtual WebView2 WebView1
		{
			get
			{
				stackVariable1 = this._WebView1;
				return stackVariable1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler<CoreWebView2NavigationCompletedEventArgs> eventHandler = new EventHandler<CoreWebView2NavigationCompletedEventArgs>(this, FormLogin2.OnNavigationCompleted);
				EventHandler<CoreWebView2InitializationCompletedEventArgs> eventHandler1 = new EventHandler<CoreWebView2InitializationCompletedEventArgs>(this, FormLogin2.OnCoreWebView2InitializationCompleted);
				WebView2 webView2 = this._WebView1;
				if (webView2 != null)
				{
					webView2.NavigationCompleted -= eventHandler;
					webView2.CoreWebView2InitializationCompleted -= eventHandler1;
				}
				this._WebView1 = value;
				webView2 = this._WebView1;
				if (webView2 != null)
				{
					webView2.NavigationCompleted += eventHandler;
					webView2.CoreWebView2InitializationCompleted += eventHandler1;
				}
			}
		}

		public FormLogin2()
		{
			base.add_Load(new EventHandler(this, FormLogin2.FormLogin_Load));
			base.add_FormClosing(new FormClosingEventHandler(this, FormLogin2.FormLogin_FormClosing));
			base.add_Resize(new EventHandler(this, FormLogin2.FormLogin_Resize));
			this.InitializeComponent();
		}

		public Int32 CheckFileSignature(String filename)
		{
			Int32 num;
			X509Certificate2 x509Certificate2;
			try
			{
				if (File.Exists(filename))
				{
					try
					{
						x509Certificate2 = new X509Certificate2(X509Certificate.CreateFromSignedFile(filename));
					}
					catch (Exception exception)
					{
						ProjectData.SetProjectError(exception);
						num = 2;
						ProjectData.ClearProjectError();
						return num;
					}
					if (!x509Certificate2.get_Subject().Contains("CN=EXAMCOOKIE APS, O=EXAMCOOKIE APS, L=Aalborg, C=DK"))
					{
						num = 3;
					}
					else if (Operators.CompareString(x509Certificate2.get_SerialNumber(), "0DDBCC532605343EB5A7E38F83B504FD", false) == 0)
					{
						num = (Operators.CompareString(x509Certificate2.get_Thumbprint(), "9A7635A149B3841485992ACFC92066E73A9FFE3D", false) == 0 ? 0 : 5);
					}
					else
					{
						num = 4;
					}
				}
				else
				{
					num = 1;
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				num = -1;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		private Void CheckWebView2RuntimeInstalled()
		{
			try
			{
				String[] strArray = new String[] { "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall", "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall" };
				for (Int32 i = 0; i < (Int32)strArray.Length; i = checked(i + 1))
				{
					String str = strArray[i];
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(str);
					try
					{
						if ((object)registryKey != (object)null)
						{
							String[] subKeyNames = registryKey.GetSubKeyNames();
							for (Int32 j = 0; j < (Int32)subKeyNames.Length; j = checked(j + 1))
							{
								RegistryKey registryKey1 = registryKey.OpenSubKey(subKeyNames[j]);
								try
								{
									String value = registryKey1.GetValue("DisplayName") as String;
									if ((object)value != (object)null)
									{
										if (value.Contains("Microsoft Edge WebView2 Runtime"))
										{
											return;
										}
									}
								}
								finally
								{
									if (registryKey1 != null)
									{
										registryKey1.Dispose();
									}
								}
							}
						}
					}
					finally
					{
						if (registryKey != null)
						{
							registryKey.Dispose();
						}
					}
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.DebugPrint(exception.ToString(), new Object[0]);
				Interaction.MsgBox(exception.ToString(), 0, null);
				ProjectData.ClearProjectError();
			}
			try
			{
				String str1 = String.Concat(Module1.APP_CURRENT_DIR, "\\MicrosoftEdgeWebview2Setup.exe");
				if (!File.Exists(str1))
				{
					File.WriteAllBytes(str1, Resources.MicrosoftEdgeWebview2Setup);
				}
				System.Diagnostics.Process process = new System.Diagnostics.Process();
				try
				{
					process.get_StartInfo().set_FileName(str1);
					process.Start();
					process.WaitForExit();
				}
				finally
				{
					if (process != null)
					{
						process.Dispose();
					}
				}
				File.Delete(str1);
			}
			catch (Exception exception3)
			{
				ProjectData.SetProjectError(exception3);
				Exception exception2 = exception3;
				Module1.DebugPrint(exception2.ToString(), new Object[0]);
				Interaction.MsgBox(exception2.ToString(), 0, null);
				ProjectData.ClearProjectError();
			}
		}

		private Int32 ClientSignIn(String examcode, String username, String password, ref String result)
		{
			Int32 num;
			Boolean flag;
			try
			{
				Module1.Log(MethodBase.GetCurrentMethod(), "Starter signin...", new Object[0]);
				ExamApiV3Client examApiV3Client = Module1.ExamClient();
				try
				{
					ExamApiV3Client examApiV3Client1 = examApiV3Client;
					Module1.SetCredentials(ref examApiV3Client1);
					String str = "";
					String str1 = "";
					JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
					str = javaScriptSerializer.Serialize(new ParameterIn(Module1.GetOperatingSystem(), Module1.WM_DETECT, eClientType.WINDOWS, Module1.GetFileversion()));
					Int32 num1 = examApiV3Client.SignIn("", username, password, str, ref str1);
					Int32 num2 = num1;
					if ((num2 == 0 ? true : num2 == 1))
					{
						Module1.Config = (ParameterOut)javaScriptSerializer.Deserialize(str1, typeof(ParameterOut));
						if (Module1.Config == null || Module1.Config.Token == null)
						{
							flag = true;
						}
						else
						{
							String token = Module1.Config.Token;
							Guid guid = new Guid();
							flag = !Guid.TryParse(token, ref guid);
						}
						if (flag)
						{
							result = "Ugyldig token ved Sign-in.<br />Forsøg at logge ind igen.";
							num1 = 20;
						}
						else if (DateTime.Compare(Module1.Config.CurrentTime.get_Date(), Module1.Config.Exam.TimeBegin.get_Date()) == 0)
						{
							result = "Du er nu logget ind.";
							num1 = 0;
						}
						else
						{
							result = "Eksamensdato er ikke i dag.<br />Forsøg at logge ind igen.";
							num1 = 21;
						}
					}
					else if (num2 == 2)
					{
						result = "Eleven blev ikke fundet.<br />Brugernavn eller adgangskode er ugyldig.";
					}
					else if (num2 == 3)
					{
						result = "Eksamens kode ikke fundet.";
					}
					else if (num2 == 4)
					{
						result = "Eksamen er afsluttet.";
					}
					else if (num2 == 5)
					{
						result = "Tilmelding kan kun ske på samme dato som eksamen er berammet.";
					}
					else if (num2 == 6)
					{
						result = "Tilmeldingsfrist er overskredet.";
					}
					else if (num2 == 7)
					{
						result = "Eksamen er slettet.";
					}
					else if (num2 == 8)
					{
						result = "Elev ikke tilmeldt eksamen i dag.<br />Login er kun muligt på eksamensdagen.";
					}
					else if (num2 == 10)
					{
						result = "Klient version ikke tilladt.<br />Download nyeste version på www.examcookie.dk";
					}
					else if (num2 == 11)
					{
						result = "ParameterIn kunne ikke de-serialiseres.";
					}
					else if (num2 == 12)
					{
						result = "Klient konfiguration kunne ikke hentes.";
					}
					else if (num2 >= 0)
					{
						result = String.Format("Der er sket en ukendt fejl, login ikke muligt. Fejlkode = {0}", num1);
					}
					else
					{
						result = String.Format("Der er sket en ukendt fejl, login ikke muligt. Fejlkode = {0}", num1);
					}
					Module1.Log(MethodBase.GetCurrentMethod(), "Sign-in afsluttet. Result={0}", new Object[] { result });
					num = num1;
				}
				finally
				{
					if (examApiV3Client != null)
					{
						examApiV3Client.Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				Interaction.MsgBox(exception.ToString(), 16, null);
				result = "Runtime fejl";
				num = -1;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		private Int32 CompareVersion(String value1, String value2)
		{
			Int32 num;
			try
			{
				if (!(Operators.CompareString(value1, "0", false) == 0 | Operators.CompareString(value2, "0", false) == 0))
				{
					Int32 num1 = (new Version(value1)).CompareTo(new Version(value2));
					if (num1 != 0)
					{
						num = (num1 <= 0 ? 1 : 2);
					}
					else
					{
						num = 0;
					}
				}
				else
				{
					num = 0;
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				num = -1;
				ProjectData.ClearProjectError();
			}
			return num;
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

		private Void FormLogin_FormClosing(Object sender, FormClosingEventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "DialogResult", new Object[0], null, null, null), (DialogResult)4, false))
			{
				e.set_Cancel(true);
			}
		}

		private Void FormLogin_Load(Object sender, EventArgs e)
		{
			Control.set_CheckForIllegalCrossThreadCalls(false);
			base.set_TopMost(true);
			this.set_Text(String.Format("ExamCookie Login v{0}", Module1.GetFileversion()));
			this.SetTimerAction(FormLogin2.eAction.INIT_LOGIN, 0, false);
			this.CheckWebView2RuntimeInstalled();
			this.SetWebViewLoaderPath(Module1.APP_DATA_PATH);
			Environment.SetEnvironmentVariable("WEBVIEW2_USER_DATA_FOLDER", Module1.APP_DATA_PATH);
			this.WebView1.set_Visible(false);
			this.WebView1.Source = new Uri(String.Concat(new Object[] { this.GetClientUIPage("message"), "?icon=", 2, "&text=", "Vent venligst..." }));
			this.ShowTabs(false, false, false);
			Module1.WM_DETECT = checked((Int32)Math.Round(Conversion.Val(this.VmDetect())));
		}

		private Void FormLogin_Resize(Object sender, EventArgs e)
		{
			base.set_Height(checked(checked(checked(this.PanelHeader.get_Height() + this.PanelTabButton.get_Height()) + this.PanelWebView.get_Height()) + 60));
			base.set_Width(this.PanelHeader.get_Width());
		}

		private String GetClientUIPage(String page)
		{
			return String.Concat("https://examcookieclientui.azurewebsites.net/", page, ".html");
		}

		private String[] GetUniLoginToken(String url)
		{
			String[] str;
			try
			{
				ExamApiV3Client examApiV3Client = Module1.ExamClient();
				try
				{
					ExamApiV3Client examApiV3Client1 = examApiV3Client;
					Module1.SetCredentials(ref examApiV3Client1);
					Dictionary<String, String> urlParameters = url.GetUrlParameters();
					Dictionary<String, Object> dictionary = new Dictionary<String, Object>();
					dictionary.Add("Code", urlParameters.get_Item("code"));
					dictionary.Add("CodeVerifier", Module1.UNI_CODE_VERIFIER);
					JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
					Debug.Print(javaScriptSerializer.Serialize(dictionary));
					String webLoginUrl = examApiV3Client.GetWebLoginUrl(eWebLoginType.OIDC_TOKEN, javaScriptSerializer.Serialize(dictionary));
					dictionary = (Dictionary<String, Object>)javaScriptSerializer.DeserializeObject(webLoginUrl);
					if (!(dictionary.ContainsKey("UniToken") & dictionary.ContainsKey("PostLogoutUri")))
					{
						str = new String[] { "" };
					}
					else
					{
						Module1.UNI_REDIRECT_LOGOUT_URL = dictionary.get_Item("PostLogoutUri").ToString();
						str = new String[] { dictionary.get_Item("UniToken").ToString(), dictionary.get_Item("IdTokenHint").ToString() };
					}
				}
				finally
				{
					if (examApiV3Client != null)
					{
						examApiV3Client.Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				str = new String[] { "" };
				ProjectData.ClearProjectError();
			}
			return str;
		}

		private String GetUniLoginUrl()
		{
			String str;
			try
			{
				ExamApiV3Client examApiV3Client = Module1.ExamClient();
				try
				{
					ExamApiV3Client examApiV3Client1 = examApiV3Client;
					Module1.SetCredentials(ref examApiV3Client1);
					String webLoginUrl = examApiV3Client.GetWebLoginUrl(eWebLoginType.OIDC_AUTH, "");
					Dictionary<String, Object> dictionary = (Dictionary<String, Object>)(new JavaScriptSerializer()).DeserializeObject(webLoginUrl);
					if (!(dictionary.ContainsKey("Url") & dictionary.ContainsKey("CodeVerifier")))
					{
						str = "";
					}
					else
					{
						Module1.UNI_CODE_VERIFIER = dictionary.get_Item("CodeVerifier").ToString();
						str = dictionary.get_Item("Url").ToString();
					}
				}
				finally
				{
					if (examApiV3Client != null)
					{
						examApiV3Client.Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				str = "";
				ProjectData.ClearProjectError();
			}
			return str;
		}

		[DebuggerStepThrough]
		private Void InitializeComponent()
		{
			this.components = new Container();
			this.PanelHeader = new Panel();
			this.PanelExamCookie = new Panel();
			this.PanelWebView = new Panel();
			this.WebView1 = new WebView2();
			this.TmrAction = new Timer(this.components);
			this.PanelTabButton = new Panel();
			this.TabTest = new RadioButton();
			this.TabManuelLogin = new RadioButton();
			this.TabUniLogin = new RadioButton();
			this.BtnTerms = new LinkLabel();
			this.PanelHeader.SuspendLayout();
			this.PanelWebView.SuspendLayout();
			this.WebView1.BeginInit();
			this.PanelTabButton.SuspendLayout();
			base.SuspendLayout();
			this.PanelHeader.set_Anchor(13);
			this.PanelHeader.set_BackColor(SystemColors.get_ControlLight());
			this.PanelHeader.get_Controls().Add(this.PanelExamCookie);
			this.PanelHeader.set_Location(new Point(0, 0));
			this.PanelHeader.set_Margin(new Padding(3, 4, 3, 4));
			this.PanelHeader.set_Name("PanelHeader");
			this.PanelHeader.set_Size(new Size(615, 109));
			this.PanelHeader.set_TabIndex(1);
			this.PanelExamCookie.set_BackgroundImage(Resources.ec_logo);
			this.PanelExamCookie.set_BackgroundImageLayout(4);
			this.PanelExamCookie.set_Location(new Point(129, 16));
			this.PanelExamCookie.set_Margin(new Padding(3, 4, 3, 4));
			this.PanelExamCookie.set_Name("PanelExamCookie");
			this.PanelExamCookie.set_Size(new Size(356, 74));
			this.PanelExamCookie.set_TabIndex(20);
			this.PanelWebView.set_Anchor(15);
			this.PanelWebView.set_BorderStyle(1);
			this.PanelWebView.get_Controls().Add(this.WebView1);
			this.PanelWebView.set_Location(new Point(14, 182));
			this.PanelWebView.set_Margin(new Padding(3, 4, 3, 4));
			this.PanelWebView.set_Name("PanelWebView");
			this.PanelWebView.set_Size(new Size(566, 559));
			this.PanelWebView.set_TabIndex(17);
			this.WebView1.AllowExternalDrop = true;
			this.WebView1.CreationProperties = null;
			this.WebView1.DefaultBackgroundColor = Color.get_White();
			this.WebView1.set_Dock(5);
			this.WebView1.set_Location(new Point(0, 0));
			this.WebView1.set_Name("WebView1");
			this.WebView1.set_Size(new Size(564, 557));
			this.WebView1.set_TabIndex(7);
			this.WebView1.ZoomFactor = 1;
			this.TmrAction.set_Interval(500);
			this.PanelTabButton.set_Anchor(13);
			this.PanelTabButton.get_Controls().Add(this.TabTest);
			this.PanelTabButton.get_Controls().Add(this.TabManuelLogin);
			this.PanelTabButton.get_Controls().Add(this.TabUniLogin);
			this.PanelTabButton.set_Location(new Point(0, 101));
			this.PanelTabButton.set_Margin(new Padding(3, 4, 3, 4));
			this.PanelTabButton.set_Name("PanelTabButton");
			this.PanelTabButton.set_Size(new Size(615, 74));
			this.PanelTabButton.set_TabIndex(12);
			this.TabTest.set_Appearance(1);
			this.TabTest.set_Font(new Font("Corbel", 10f, 1, 3, 0));
			this.TabTest.set_Location(new Point(389, 19));
			this.TabTest.set_Margin(new Padding(3, 4, 3, 4));
			this.TabTest.set_Name("TabTest");
			this.TabTest.set_Size(new Size(172, 42));
			this.TabTest.set_TabIndex(18);
			this.TabTest.set_Text("Test");
			this.TabTest.set_TextAlign(32);
			this.TabTest.set_UseVisualStyleBackColor(true);
			this.TabManuelLogin.set_Appearance(1);
			this.TabManuelLogin.set_Font(new Font("Corbel", 10f, 1, 3, 0));
			this.TabManuelLogin.set_Location(new Point(213, 19));
			this.TabManuelLogin.set_Margin(new Padding(3, 4, 3, 4));
			this.TabManuelLogin.set_Name("TabManuelLogin");
			this.TabManuelLogin.set_Size(new Size(172, 42));
			this.TabManuelLogin.set_TabIndex(17);
			this.TabManuelLogin.set_Text("Manuel-Login");
			this.TabManuelLogin.set_TextAlign(32);
			this.TabManuelLogin.set_UseVisualStyleBackColor(true);
			this.TabUniLogin.set_Appearance(1);
			this.TabUniLogin.set_Font(new Font("Corbel", 10f, 1, 3, 0));
			this.TabUniLogin.set_Location(new Point(38, 19));
			this.TabUniLogin.set_Margin(new Padding(3, 4, 3, 4));
			this.TabUniLogin.set_Name("TabUniLogin");
			this.TabUniLogin.set_Size(new Size(172, 42));
			this.TabUniLogin.set_TabIndex(16);
			this.TabUniLogin.set_Text("UNI-Login");
			this.TabUniLogin.set_TextAlign(32);
			this.TabUniLogin.set_UseVisualStyleBackColor(true);
			this.BtnTerms.set_Anchor(10);
			this.BtnTerms.set_AutoSize(true);
			this.BtnTerms.set_Font(new Font("Corbel", 10f, 0, 3, 0));
			this.BtnTerms.set_LinkBehavior(2);
			this.BtnTerms.set_Location(new Point(392, 745));
			this.BtnTerms.set_Name("BtnTerms");
			this.BtnTerms.set_Size(new Size(184, 24));
			this.BtnTerms.set_TabIndex(18);
			this.BtnTerms.set_TabStop(true);
			this.BtnTerms.set_Text("Vilkår og betingelser");
			base.set_AutoScaleDimensions(new SizeF(9f, 20f));
			base.set_AutoScaleMode(1);
			this.set_BackColor(SystemColors.get_Control());
			base.set_ClientSize(new Size(615, 794));
			base.get_Controls().Add(this.BtnTerms);
			base.get_Controls().Add(this.PanelTabButton);
			base.get_Controls().Add(this.PanelWebView);
			base.get_Controls().Add(this.PanelHeader);
			base.set_FormBorderStyle(5);
			base.set_Margin(new Padding(3, 4, 3, 4));
			base.set_Name("FormLogin");
			base.set_ShowInTaskbar(false);
			base.set_StartPosition(1);
			this.set_Text("ExamCookie Login");
			this.PanelHeader.ResumeLayout(false);
			this.PanelWebView.ResumeLayout(false);
			this.WebView1.EndInit();
			this.PanelTabButton.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private String InjectCssStyle()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("document.head.innerHTML += \"");
			stringBuilder.Append("<style> ");
			stringBuilder.Append("h3.h5 { visibility: hidden; } ");
			stringBuilder.Append(".footerlogo { visibility: hidden; } ");
			stringBuilder.Append(".header-content { display: none; visibility: hidden; } ");
			stringBuilder.Append("[id=mobile-info-collapse-group] { visibility: hidden; } ");
			stringBuilder.Append(".alert.alert-warning { visibility: hidden; } ");
			stringBuilder.Append("</style>;\"");
			return stringBuilder.ToString();
		}

		private Void NavigateTo(String uri)
		{
			if (uri.HasAny(new String[] { "http://", "https://" }))
			{
				Module1.Log(MethodBase.GetCurrentMethod(), uri, new Object[0]);
				this.WebView1.CoreWebView2.Navigate(uri);
			}
		}

		private Void OnCoreWebView2InitializationCompleted(Object sender, CoreWebView2InitializationCompletedEventArgs e)
		{
			this.WebView1.CoreWebView2.Settings.IsPasswordAutosaveEnabled = true;
		}

		private Void OnNavigationCompleted(Object sender, CoreWebView2NavigationCompletedEventArgs e)
		{
			String str = NewLateBinding.LateGet(sender, null, "source", new Object[0], null, null, null).ToString();
			Module1.Log(MethodBase.GetCurrentMethod(), str, new Object[0]);
			if (str.HasAny(new String[] { "broker.unilogin.dk", "nemlog-in.mitid.dk", "idp.unilogin.dk" }))
			{
				this.WebView1.CoreWebView2.ExecuteScriptAsync(this.InjectCssStyle());
			}
			if (str.Has("azurewebsites.net/message"))
			{
				if (this.TimerAction != FormLogin2.eAction.INIT_LOGIN)
				{
					this.TmrAction.Start();
				}
				else
				{
					this.WebView1.set_Visible(true);
					this.SetTimerAction(FormLogin2.eAction.UNI_LOGIN_BEGIN, 500, true);
				}
			}
			else if (str.Has("azurewebsites.net/index"))
			{
				if (this.TimerAction == FormLogin2.eAction.MAN_LOGIN_BEGIN | this.TimerAction == FormLogin2.eAction.UNI_LOGIN_BEGIN)
				{
					this.SetTimerAction(this.TimerAction, 50, true);
				}
			}
			else if (str.Has("azurewebsites.net/systest"))
			{
				this.WebView1.CoreWebView2.ExecuteScriptAsync(String.Concat("setStatus(", 768, ", null);"));
				this.WebView1.CoreWebView2.ExecuteScriptAsync(String.Concat("setStatus(", 3072, ", null);"));
				this.SetTimerAction(FormLogin2.eAction.TEST_OS, 250, true);
			}
			else if (str.Has("azurewebsites.net/manlogin.html?user="))
			{
				this.SetTimerAction(FormLogin2.eAction.MAN_LOGIN_IN_PROGRESS, 50, true);
				this.SignInWithManuelLogin(new Uri(str));
			}
			else if (str.Has("unilogin.dk/auth/realms/broker/protocol/openid-connect") & !str.Has("logout"))
			{
				if (this.TimerAction == FormLogin2.eAction.UNI_LOGIN_BEGIN)
				{
					this.WebView1.set_Visible(true);
					this.ShowTabs(true, true, true);
					this.TabUniLogin.set_Checked(true);
				}
			}
			else if (str.HasAll(new String[] { Module1.UNI_REDIRECT_SUCCESS_URL, "state=", "code=" }))
			{
				if (this.TimerAction == FormLogin2.eAction.UNI_LOGIN_BEGIN)
				{
					String[] uniLoginToken = this.GetUniLoginToken(str);
					if ((Int32)uniLoginToken.Length == 2)
					{
						Module1.UNI_SIGNIN_TOKEN = uniLoginToken[0];
						Module1.ID_TOKEN_HINT = uniLoginToken[1];
						this.SetTimerAction(FormLogin2.eAction.UNI_LOGIN_IN_PROGRESS, 50, true);
					}
				}
			}
			else if (str.HasAll(new String[] { "unilogin.dk/auth/realms", "/broker/broker/", "/endpoint" }))
			{
				if (this.TimerAction == FormLogin2.eAction.UNI_LOGIN_IN_PROGRESS)
				{
					this.SignInWithUniLogin(Module1.UNI_SIGNIN_TOKEN);
				}
			}
			else if (str.HasOnly(Module1.UNI_REDIRECT_SUCCESS_URL))
			{
				if (this.TimerAction == FormLogin2.eAction.UNI_LOGIN_IN_PROGRESS)
				{
					this.SignInWithUniLogin(Module1.UNI_SIGNIN_TOKEN);
				}
			}
			else if (str.HasAll(new String[] { "unilogin.dk/auth/realms/idp", "authenticate?execution", "broker.unilogin.dk" }))
			{
				this.SetTimerAction(FormLogin2.eAction.UNI_LOGIN_BEGIN, 30000, true);
			}
			else if (str.Has("nemlog-in.mitid.dk/error"))
			{
				this.SetTimerAction(FormLogin2.eAction.UNI_LOGIN_BEGIN, 30000, true);
			}
		}

		private Void OnTabChanged(Object sender, EventArgs e)
		{
			this.SetHtmlMessage(null, "", "");
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "Checked", new Object[0], null, null, null), true, false))
			{
				String name = ((RadioButton)sender).get_Name();
				if (Operators.CompareString(name, "TabUniLogin", false) == 0)
				{
					this.SetTimerAction(FormLogin2.eAction.UNI_LOGIN_BEGIN, 50, true);
				}
				else if (Operators.CompareString(name, "TabManuelLogin", false) == 0)
				{
					this.SetTimerAction(FormLogin2.eAction.MAN_LOGIN_BEGIN, 50, true);
				}
				else if (Operators.CompareString(name, "TabTest", false) == 0)
				{
					this.NavigateTo(this.GetClientUIPage("systest"));
				}
			}
		}

		private Void OnTermsClicked(Object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.examcookie.dk/vilkaar-betingelser/");
		}

		private Void OnTmrAction(Object sender, EventArgs e)
		{
			this.TmrAction.Stop();
			this.TmrAction.set_Interval(50);
			Module1.Log(MethodBase.GetCurrentMethod(), "{0}", new Object[] { this.TimerAction.ToString() });
			FormLogin2.eAction timerAction = this.TimerAction;
			switch (timerAction)
			{
				case FormLogin2.eAction.MAN_LOGIN_BEGIN:
				{
					this.NavigateTo(this.GetClientUIPage("manlogin"));
					break;
				}
				case FormLogin2.eAction.MAN_LOGIN_IN_PROGRESS:
				{
					this.SetHtmlMessage(2, "Vent venligst...", "");
					break;
				}
				case FormLogin2.eAction.MAN_LOGIN_SUCCESS:
				{
				Label0:
					base.set_DialogResult(1);
					break;
				}
				default:
				{
					switch (timerAction)
					{
						case FormLogin2.eAction.UNI_LOGIN_BEGIN:
						{
							this.NavigateTo(this.GetUniLoginUrl());
							break;
						}
						case FormLogin2.eAction.UNI_LOGIN_IN_PROGRESS:
						{
							this.NavigateTo(String.Concat(new String[] { Module1.UNI_REDIRECT_LOGOUT_URL, "?post_logout_redirect_uri=", Module1.UNI_REDIRECT_SUCCESS_URL, "&id_token_hint=", Module1.ID_TOKEN_HINT }));
							break;
						}
						case FormLogin2.eAction.UNI_LOGIN_SUCCESS:
						{
							goto Label0;
						}
						default:
						{
							if (timerAction == FormLogin2.eAction.TEST_OS)
							{
								this.RunSystemCheck(FormLogin2.eAction.TEST_OS);
							}
							break;
						}
					}
					break;
				}
			}
		}

		private Void RunSystemCheck(FormLogin2.eAction action)
		{
			try
			{
				Int32[] numArray = new Int32[] { 2, 8, 16, 128 };
				String[] message = new String[] { "", "", "", "" };
				if (action == FormLogin2.eAction.TEST_OS)
				{
					try
					{
						ExamApiV3Client examApiV3Client = Module1.ExamClient();
						try
						{
							ExamApiV3Client examApiV3Client1 = examApiV3Client;
							Module1.SetCredentials(ref examApiV3Client1);
							String str = "";
							if (examApiV3Client.GetRequirements(eClientType.WINDOWS, ref str) == 0)
							{
								ClientRequirements clientRequirement = (ClientRequirements)(new JavaScriptSerializer()).Deserialize(str, typeof(ClientRequirements));
								String operatingSystem = Module1.GetOperatingSystem();
								if (!operatingSystem.HasAny(clientRequirement.OperatingSystems))
								{
									message[0] = String.Format("Operativ systemet \"{0}\" understøttes muligvis ikke!", operatingSystem);
								}
								else
								{
									numArray[0] = 1;
								}
								if (MyProject.Computer.get_FileSystem().GetDriveInfo("C:\\").get_TotalFreeSpace() <= (Int64)clientRequirement.MinimumHarddiskSpace)
								{
									message[1] = String.Format("Der er mindre end {0} MB harddisk plads!<br />Forsøg at frigøre lidt mere plads.", Strings.FormatNumber((Double)clientRequirement.MinimumHarddiskSpace / 1000000, 0, -2, -2, -2));
								}
								else
								{
									numArray[1] = 4;
								}
								if (this.CompareVersion(Module1.GetFileversion(), clientRequirement.MinimumClientVersion) != 1)
								{
									numArray[3] = 64;
								}
							}
							else
							{
								numArray = new Int32[] { 3, 12, 32, 192 };
							}
						}
						finally
						{
							if (examApiV3Client != null)
							{
								examApiV3Client.Dispose();
							}
						}
					}
					catch (Exception exception)
					{
						ProjectData.SetProjectError(exception);
						message[2] = exception.get_Message();
						ProjectData.ClearProjectError();
					}
				}
				Int32 length = checked((Int32)numArray.Length - 1);
				for (Int32 i = 0; i <= length; i = checked(i + 1))
				{
					this.WebView1.CoreWebView2.ExecuteScriptAsync(String.Concat(new Object[] { "setStatus(", numArray[i], ", '", message[i], "');" }));
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Interaction.MsgBox(exception1.ToString(), 16, null);
				ProjectData.ClearProjectError();
			}
		}

		private Void SetHtmlMessage(Object icon, String text = "", String confirm = "")
		{
			if ((icon == null ? false : Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(icon))))
			{
				text = text.Replace("\r\n", "<br />");
				this.NavigateTo(String.Concat(new Object[] { this.GetClientUIPage("message"), "?icon=", icon, "&text=", text, "&confirm=", confirm }));
			}
		}

		private Void SetTimerAction(FormLogin2.eAction action, Int32 interval, Boolean start = false)
		{
			this.TmrAction.Stop();
			this.TimerAction = action;
			if (interval > 0)
			{
				this.TmrAction.set_Interval(interval);
			}
			if (start)
			{
				this.TmrAction.Start();
			}
			Module1.Log(MethodBase.GetCurrentMethod(), "{0}: {1} ({2})", new Object[] { action.ToString(), interval, start });
		}

		private Void SetWebViewLoaderPath(String appdata)
		{
			String[] strArray = new String[] { "\\runtimes\\win-x86\\native\\WebView2Loader.dll", "\\runtimes\\win-x64\\native\\WebView2Loader.dll", "\\runtimes\\win-arm64\\native\\WebView2Loader.dll" };
			Byte[][] x86WebView2Loader = new Byte[][] { Resources.x86_WebView2Loader, Resources.x64_WebView2Loader, Resources.arm64_WebView2Loader };
			String str = String.Concat(appdata, "\\EBWebView");
			try
			{
				if (Directory.Exists(str))
				{
					Directory.Delete(str, true);
				}
				if (!Directory.Exists(str))
				{
					Directory.CreateDirectory(str);
				}
				Module1.SetFolderHidden(appdata, true);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				ProjectData.ClearProjectError();
			}
			Int32 length = checked((Int32)strArray.Length - 1);
			for (Int32 i = 0; i <= length; i = checked(i + 1))
			{
				try
				{
					str = String.Concat(appdata, strArray[i]);
					if (!Directory.Exists(Path.GetDirectoryName(str)))
					{
						Directory.CreateDirectory(Path.GetDirectoryName(str));
					}
					File.WriteAllBytes(str, x86WebView2Loader[i]);
				}
				catch (Exception exception1)
				{
					ProjectData.SetProjectError(exception1);
					ProjectData.ClearProjectError();
				}
			}
			try
			{
				if (!Environment.get_Is64BitProcess())
				{
					CoreWebView2Environment.SetLoaderDllFolderPath(String.Format("{0}\\runtimes\\win-x86\\native", appdata));
				}
				else
				{
					CoreWebView2Environment.SetLoaderDllFolderPath(String.Format("{0}\\runtimes\\win-x64\\native", appdata));
				}
			}
			catch (Exception exception2)
			{
				ProjectData.SetProjectError(exception2);
				ProjectData.ClearProjectError();
			}
		}

		private Void ShowTabs(Boolean tab1, Boolean tab2, Boolean tab3)
		{
			this.TabUniLogin.set_Enabled(tab1);
			this.TabManuelLogin.set_Enabled(tab2);
			this.TabTest.set_Enabled(tab3);
			this.Refresh();
		}

		private Void SignInWithManuelLogin(Uri uri)
		{
			String str = "";
			Int32 num = this.ClientSignIn("", uri.GetQueryString("user"), uri.GetQueryString("pass"), ref str);
			if (num != 0)
			{
				this.SetHtmlMessage(1, str, "Tilbage");
				this.SetTimerAction(FormLogin2.eAction.MAN_LOGIN_BEGIN, 10000, true);
				base.set_DialogResult(4);
			}
			else
			{
				this.SetHtmlMessage(num, str, "");
				this.SetTimerAction(FormLogin2.eAction.MAN_LOGIN_SUCCESS, 2000, true);
			}
		}

		private Void SignInWithUniLogin(String username)
		{
			String str = String.Concat(new String[] { "Autorisation fejlet.<br />Prøv at logge ind igen." });
			if (Operators.CompareString(username, "", false) == 0)
			{
				this.SetTimerAction(FormLogin2.eAction.UNI_LOGIN_BEGIN, 10000, true);
				this.SetHtmlMessage(1, str, "Tilbage");
			}
			else
			{
				Int32 num = this.ClientSignIn("", username, "", ref str);
				if (num != 0)
				{
					this.SetTimerAction(FormLogin2.eAction.UNI_LOGIN_BEGIN, 10000, true);
					this.SetHtmlMessage(1, str, "Tilbage");
				}
				else
				{
					this.SetTimerAction(FormLogin2.eAction.UNI_LOGIN_SUCCESS, 2000, true);
					this.SetHtmlMessage(num, str, "");
				}
			}
		}

		private String VmDetect()
		{
			String str;
			try
			{
				String str1 = "ecvmd.exe";
				DirectoryInfo directoryInfo = new DirectoryInfo(Environment.get_SystemDirectory());
				String[] strArray = new String[] { String.Format("{0}", Module1.APP_DATA_PATH), String.Format("{0}{1}\\System32", directoryInfo.get_Root(), directoryInfo.get_Parent()), String.Format("{0}{1}\\SysWOW64", directoryInfo.get_Root(), directoryInfo.get_Parent()) };
				Byte[] vmDetect = Resources.VmDetect;
				String str2 = "";
				String[] strArray1 = strArray;
				for (Int32 i = 0; i < (Int32)strArray1.Length; i = checked(i + 1))
				{
					str2 = String.Format("{0}\\{1}", strArray1[i], str1);
					Module1.Log(Module1.LogType.DEBUG, MethodBase.GetCurrentMethod(), "Try at gemme filen her: {0}", new Object[] { str2 });
					if (!File.Exists(str2))
					{
						try
						{
							File.WriteAllBytes(str2, vmDetect);
						}
						catch (Exception exception1)
						{
							ProjectData.SetProjectError(exception1);
							Exception exception = exception1;
							Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
							ProjectData.ClearProjectError();
						}
					}
					else
					{
						try
						{
							File.Delete(str2);
							File.WriteAllBytes(str2, vmDetect);
						}
						catch (Exception exception3)
						{
							ProjectData.SetProjectError(exception3);
							Exception exception2 = exception3;
							Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception2.ToString(), new Object[0]);
							ProjectData.ClearProjectError();
						}
					}
				}
				String end = "";
				String[] strArray2 = strArray;
				for (Int32 j = 0; j < (Int32)strArray2.Length; j = checked(j + 1))
				{
					str2 = String.Format("{0}\\{1}", strArray2[j], str1);
					if (!File.Exists(str2))
					{
						Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), "VM Detect kunne ikke kopieres her: {0}", new Object[] { str2 });
					}
					else if (this.CheckFileSignature(str2) != 0)
					{
						Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), "VM Detect er ikke signeret med ExamCookie certifikatet: {0}", new Object[] { str2 });
					}
					else
					{
						Module1.Log(Module1.LogType.DEBUG, MethodBase.GetCurrentMethod(), "Try execute VM Detect her: {0}", new Object[] { str2 });
						System.Diagnostics.Process process = new System.Diagnostics.Process();
						try
						{
							ProcessStartInfo processStartInfo = new ProcessStartInfo(str2, "-d");
							processStartInfo.set_CreateNoWindow(true);
							processStartInfo.set_UseShellExecute(false);
							processStartInfo.set_RedirectStandardOutput(true);
							process.set_StartInfo(processStartInfo);
							process.Start();
							try
							{
								StreamReader standardOutput = process.get_StandardOutput();
								try
								{
									end = standardOutput.ReadToEnd();
									end = end.Replace("\r\n", "");
								}
								finally
								{
									if (standardOutput != null)
									{
										standardOutput.Dispose();
									}
								}
							}
							catch (Exception exception4)
							{
								ProjectData.SetProjectError(exception4);
								end = "-5";
								ProjectData.ClearProjectError();
							}
						}
						finally
						{
							if (process != null)
							{
								process.Dispose();
							}
						}
						Module1.Log(Module1.LogType.DEBUG, MethodBase.GetCurrentMethod(), "VM Detect result={0}", new Object[] { end });
						Thread.Sleep(500);
						try
						{
							File.Delete(str2);
						}
						catch (Exception exception5)
						{
							ProjectData.SetProjectError(exception5);
							ProjectData.ClearProjectError();
						}
						if (Operators.CompareString(end, "", false) == 0)
						{
							str = "-3";
							return str;
						}
						else if (Versioned.IsNumeric(end))
						{
							str = end;
							return str;
						}
						else
						{
							str = "-4";
							return str;
						}
					}
				}
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), "ecvmd.exe filen findes ikke", new Object[0]);
				str = "-2";
			}
			catch (Exception exception6)
			{
				ProjectData.SetProjectError(exception6);
				str = "-1";
				ProjectData.ClearProjectError();
			}
			return str;
		}

		private enum eAction
		{
			INIT_LOGIN = 0,
			MAN_LOGIN_BEGIN = 1,
			MAN_LOGIN_IN_PROGRESS = 2,
			MAN_LOGIN_SUCCESS = 3,
			UNI_LOGIN_BEGIN = 11,
			UNI_LOGIN_IN_PROGRESS = 12,
			UNI_LOGIN_SUCCESS = 13,
			TEST_OS = 21,
			TEST_HD = 22,
			TEST_WEB_SERVICE = 23,
			TEST_CLIENT_VERSION = 24
		}
	}
}