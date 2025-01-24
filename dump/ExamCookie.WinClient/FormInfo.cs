using ExamCookie.Library;
using ExamCookie.WinClient.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace ExamCookie.WinClient
{
	[DesignerGenerated]
	public class FormInfo : Form
	{
		private IContainer components;

		private ParameterOut _Config;

		internal virtual Button btnNo
		{
			get;
			[MethodImpl(32)]
			set;
		}

		internal virtual Button btnYes
		{
			get;
			[MethodImpl(32)]
			set;
		}

		public ParameterOut Config
		{
			get
			{
				return this._Config;
			}
			set
			{
				this._Config = value;
			}
		}

		internal virtual Label lblInfo1
		{
			get;
			[MethodImpl(32)]
			set;
		}

		internal virtual Label lblInfo2
		{
			get;
			[MethodImpl(32)]
			set;
		}

		internal virtual PictureBox PicLogo
		{
			get;
			[MethodImpl(32)]
			set;
		}

		public FormInfo()
		{
			base.add_Load(new EventHandler(this, FormInfo.FormInfo_Load));
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

		private Void FormInfo_Load(Object sender, EventArgs e)
		{
			StringBuilder stringBuilder = new StringBuilder();
			this.lblInfo1.set_Text("Vil du stoppe og afslutte ExamCookie?");
			stringBuilder.AppendFormat("Eksamen: {0}", this.Config.Exam.Description).AppendLine();
			stringBuilder.AppendFormat("Starter: {0}", Strings.Format(this.Config.Exam.TimeBegin, "dd-MM-yyyy HH:mm")).AppendLine();
			stringBuilder.AppendFormat("Slutter: {0}", Module1.FormatExamEndTime(this.Config.Exam.TimeEnd, this.Config.Exam.TimeEndExt, "dd-MM-yyyy HH:mm")).AppendLine();
			stringBuilder.AppendFormat("Ekstra elev tid: {0} minutter.", this.Config.Exam.StudentTimeExt).AppendLine();
			stringBuilder.AppendLine();
			stringBuilder.AppendFormat("Elev: {0}", this.Config.Student.Name).AppendLine();
			stringBuilder.AppendFormat("Klasse: {0}", this.Config.Student.Classname).AppendLine();
			this.lblInfo2.set_Text(stringBuilder.ToString());
			this.btnNo.Select();
		}

		[DebuggerStepThrough]
		private Void InitializeComponent()
		{
			this.PicLogo = new PictureBox();
			this.btnYes = new Button();
			this.btnNo = new Button();
			this.lblInfo2 = new Label();
			this.lblInfo1 = new Label();
			this.PicLogo.BeginInit();
			base.SuspendLayout();
			this.PicLogo.set_Image(Resources.ec_blue);
			this.PicLogo.set_Location(new Point(14, 30));
			this.PicLogo.set_Margin(new Padding(3, 4, 3, 4));
			this.PicLogo.set_Name("PicLogo");
			this.PicLogo.set_Size(new Size(72, 80));
			this.PicLogo.set_SizeMode(1);
			this.PicLogo.set_TabIndex(0);
			this.PicLogo.set_TabStop(false);
			this.btnYes.set_DialogResult(6);
			this.btnYes.set_Font(new Font("Microsoft Sans Serif", 7.8f, 1, 3, 0));
			this.btnYes.set_Location(new Point(433, 298));
			this.btnYes.set_Margin(new Padding(3, 4, 3, 4));
			this.btnYes.set_Name("btnYes");
			this.btnYes.set_Size(new Size(394, 52));
			this.btnYes.set_TabIndex(2);
			this.btnYes.set_Text("JA - Luk og afslut ExamCookie");
			this.btnYes.set_UseVisualStyleBackColor(true);
			this.btnNo.set_DialogResult(7);
			this.btnNo.set_Font(new Font("Microsoft Sans Serif", 7.8f, 1, 3, 0));
			this.btnNo.set_Location(new Point(14, 298));
			this.btnNo.set_Margin(new Padding(3, 4, 3, 4));
			this.btnNo.set_Name("btnNo");
			this.btnNo.set_Size(new Size(394, 52));
			this.btnNo.set_TabIndex(3);
			this.btnNo.set_Text("NEJ - Fortsæt med at bruge ExamCookie");
			this.btnNo.set_UseVisualStyleBackColor(true);
			this.lblInfo2.set_Font(new Font("Consolas", 11f, 0, 3, 0));
			this.lblInfo2.set_ForeColor(Color.get_DarkSlateGray());
			this.lblInfo2.set_Location(new Point(107, 70));
			this.lblInfo2.set_Name("lblInfo2");
			this.lblInfo2.set_Size(new Size(567, 194));
			this.lblInfo2.set_TabIndex(4);
			this.lblInfo2.set_Text("Label1\r\nLabel2\r\nLabel3\r\nLabel31\r\n\r\nLabel4\r\nLabel5");
			this.lblInfo2.set_TextAlign(16);
			this.lblInfo1.set_AutoSize(true);
			this.lblInfo1.set_Font(new Font("Microsoft Sans Serif", 10.2f, 1, 3, 0));
			this.lblInfo1.set_Location(new Point(107, 30));
			this.lblInfo1.set_Name("lblInfo1");
			this.lblInfo1.set_Size(new Size(83, 25));
			this.lblInfo1.set_TabIndex(5);
			this.lblInfo1.set_Text("Label1");
			base.set_AcceptButton(this.btnNo);
			base.set_AutoScaleDimensions(new SizeF(9f, 20f));
			base.set_AutoScaleMode(1);
			base.set_ClientSize(new Size(840, 365));
			base.get_Controls().Add(this.lblInfo1);
			base.get_Controls().Add(this.lblInfo2);
			base.get_Controls().Add(this.btnNo);
			base.get_Controls().Add(this.btnYes);
			base.get_Controls().Add(this.PicLogo);
			base.set_FormBorderStyle(5);
			base.set_Margin(new Padding(3, 4, 3, 4));
			base.set_Name("FormInfo");
			base.set_ShowIcon(false);
			base.set_StartPosition(1);
			this.set_Text("Fortsæt eller Afslut eksamen");
			this.PicLogo.EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}