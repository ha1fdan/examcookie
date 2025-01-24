using ExamCookie.WinClient.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ExamCookie.WinClient
{
	[DesignerGenerated]
	public class FormNotify : Form
	{
		private IContainer components;

		internal virtual Label lblHeader
		{
			get;
			[MethodImpl(32)]
			set;
		}

		internal virtual Label lblMessage
		{
			get;
			[MethodImpl(32)]
			set;
		}

		internal virtual PictureBox PictureBox1
		{
			get;
			[MethodImpl(32)]
			set;
		}

		internal virtual Timer Timer1
		{
			get
			{
				stackVariable1 = this._Timer1;
				return stackVariable1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this, FormNotify.Timer1_Tick);
				Timer timer = this._Timer1;
				if (timer != null)
				{
					timer.remove_Tick(eventHandler);
				}
				this._Timer1 = value;
				timer = this._Timer1;
				if (timer != null)
				{
					timer.add_Tick(eventHandler);
				}
			}
		}

		public FormNotify()
		{
			base.add_Load(new EventHandler(this, FormNotify.FormNotify_Load));
			this.InitializeComponent();
		}

		private Void CustomNotify()
		{
			this.set_BackColor(Color.FromArgb(255, 35, 35, 35));
			Rectangle workingArea = Screen.get_PrimaryScreen().get_WorkingArea();
			Int32 width = checked(workingArea.get_Width() - base.get_Width());
			workingArea = Screen.get_PrimaryScreen().get_WorkingArea();
			Int32 height = checked(workingArea.get_Height() - 100);
			base.set_Location(new Point(width, height));
			base.set_TopMost(true);
			this.Refresh();
			this.Timer1.Start();
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

		private Void FormNotify_Load(Object sender, EventArgs e)
		{
			base.set_ShowInTaskbar(false);
			this.CustomNotify();
		}

		[DebuggerStepThrough]
		private Void InitializeComponent()
		{
			this.components = new Container();
			this.Timer1 = new Timer(this.components);
			this.PictureBox1 = new PictureBox();
			this.lblMessage = new Label();
			this.lblHeader = new Label();
			this.PictureBox1.BeginInit();
			base.SuspendLayout();
			this.PictureBox1.set_Image(Resources.ec_blue);
			this.PictureBox1.set_Location(new Point(0, 0));
			this.PictureBox1.set_Margin(new Padding(3, 4, 3, 4));
			this.PictureBox1.set_Name("PictureBox1");
			this.PictureBox1.set_Size(new Size(52, 59));
			this.PictureBox1.set_SizeMode(4);
			this.PictureBox1.set_TabIndex(0);
			this.PictureBox1.set_TabStop(false);
			this.lblMessage.set_AutoSize(true);
			this.lblMessage.set_BackColor(Color.get_Transparent());
			this.lblMessage.set_Font(new Font("Calibri", 11f, 0, 3, 0));
			this.lblMessage.set_ForeColor(Color.get_LightGray());
			this.lblMessage.set_Location(new Point(63, 52));
			this.lblMessage.set_Name("lblLine1");
			this.lblMessage.set_Size(new Size(60, 81));
			this.lblMessage.set_TabIndex(1);
			this.lblMessage.set_Text("Line1\r\nLine2\r\nLine3");
			this.lblHeader.set_AutoSize(true);
			this.lblHeader.set_BackColor(Color.get_Transparent());
			this.lblHeader.set_Font(new Font("Calibri", 13.8f, 0, 3, 0));
			this.lblHeader.set_ForeColor(Color.get_White());
			this.lblHeader.set_Location(new Point(62, 6));
			this.lblHeader.set_Name("lblHeader");
			this.lblHeader.set_Size(new Size(98, 35));
			this.lblHeader.set_TabIndex(2);
			this.lblHeader.set_Text("Header");
			base.set_AutoScaleDimensions(new SizeF(9f, 20f));
			base.set_AutoScaleMode(1);
			this.set_BackColor(Color.FromArgb(255, 35, 35, 35));
			base.set_ClientSize(new Size(530, 140));
			base.get_Controls().Add(this.lblHeader);
			base.get_Controls().Add(this.lblMessage);
			base.get_Controls().Add(this.PictureBox1);
			base.set_FormBorderStyle(0);
			base.set_Margin(new Padding(3, 4, 3, 4));
			base.set_Name("FormNotify");
			base.set_ShowIcon(false);
			base.set_ShowInTaskbar(false);
			this.set_Text("ExamCookie");
			this.PictureBox1.EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public Void Notify(String header, String[] message, Int32 timeout)
		{
			if (message != null)
			{
				this.lblHeader.set_Text(header);
				this.lblMessage.set_Text(Strings.Join(message, "\r\n"));
				this.Timer1.set_Interval(timeout);
			}
			else
			{
				base.Close();
			}
		}

		private Void Timer1_Tick(Object sender, EventArgs e)
		{
			this.Timer1.Stop();
			base.Close();
		}

		private Void ToastNotify()
		{
		}
	}
}