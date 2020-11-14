namespace MechaSquirrelInterface
{
	partial class MainMenu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnSend = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.txtChatInput = new System.Windows.Forms.TextBox();
			this.lblConsole = new System.Windows.Forms.Label();
			this.txtChannel = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.lblChannel = new System.Windows.Forms.Label();
			this.lblUserName = new System.Windows.Forms.Label();
			this.lblCode = new System.Windows.Forms.Label();
			this.btnShow = new System.Windows.Forms.Button();
			this.btnHide = new System.Windows.Forms.Button();
			this.ckbIsMultiplier = new System.Windows.Forms.CheckBox();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.txtReadout = new System.Windows.Forms.TextBox();
			this.ckbIsSpamControl = new System.Windows.Forms.CheckBox();
			this.ckbIsMulti = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// btnSend
			// 
			this.btnSend.Enabled = false;
			this.btnSend.Location = new System.Drawing.Point(56, 167);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(120, 70);
			this.btnSend.TabIndex = 0;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(56, 70);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(120, 65);
			this.btnStart.TabIndex = 2;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// txtChatInput
			// 
			this.txtChatInput.Location = new System.Drawing.Point(56, 141);
			this.txtChatInput.Name = "txtChatInput";
			this.txtChatInput.Size = new System.Drawing.Size(120, 20);
			this.txtChatInput.TabIndex = 3;
			// 
			// lblConsole
			// 
			this.lblConsole.AutoSize = true;
			this.lblConsole.Location = new System.Drawing.Point(53, 252);
			this.lblConsole.Name = "lblConsole";
			this.lblConsole.Size = new System.Drawing.Size(45, 13);
			this.lblConsole.TabIndex = 4;
			this.lblConsole.Text = "Console";
			// 
			// txtChannel
			// 
			this.txtChannel.Location = new System.Drawing.Point(538, 113);
			this.txtChannel.Name = "txtChannel";
			this.txtChannel.Size = new System.Drawing.Size(217, 20);
			this.txtChannel.TabIndex = 5;
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(538, 139);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.PasswordChar = '*';
			this.txtUsername.Size = new System.Drawing.Size(217, 20);
			this.txtUsername.TabIndex = 6;
			// 
			// txtCode
			// 
			this.txtCode.Location = new System.Drawing.Point(538, 163);
			this.txtCode.Name = "txtCode";
			this.txtCode.PasswordChar = '*';
			this.txtCode.Size = new System.Drawing.Size(217, 20);
			this.txtCode.TabIndex = 7;
			// 
			// lblChannel
			// 
			this.lblChannel.AutoSize = true;
			this.lblChannel.Location = new System.Drawing.Point(478, 113);
			this.lblChannel.Name = "lblChannel";
			this.lblChannel.Size = new System.Drawing.Size(49, 13);
			this.lblChannel.TabIndex = 8;
			this.lblChannel.Text = "Channel:";
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Location = new System.Drawing.Point(464, 139);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(63, 13);
			this.lblUserName.TabIndex = 9;
			this.lblUserName.Text = "User Name:";
			// 
			// lblCode
			// 
			this.lblCode.AutoSize = true;
			this.lblCode.Location = new System.Drawing.Point(467, 163);
			this.lblCode.Name = "lblCode";
			this.lblCode.Size = new System.Drawing.Size(60, 13);
			this.lblCode.TabIndex = 10;
			this.lblCode.Text = "Auth Code:";
			// 
			// btnShow
			// 
			this.btnShow.Location = new System.Drawing.Point(523, 76);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(113, 31);
			this.btnShow.TabIndex = 13;
			this.btnShow.Text = "Show";
			this.btnShow.UseVisualStyleBackColor = true;
			this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
			// 
			// btnHide
			// 
			this.btnHide.Location = new System.Drawing.Point(642, 76);
			this.btnHide.Name = "btnHide";
			this.btnHide.Size = new System.Drawing.Size(113, 31);
			this.btnHide.TabIndex = 14;
			this.btnHide.Text = "Hide";
			this.btnHide.UseVisualStyleBackColor = true;
			this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
			// 
			// ckbIsMultiplier
			// 
			this.ckbIsMultiplier.AutoSize = true;
			this.ckbIsMultiplier.Location = new System.Drawing.Point(467, 204);
			this.ckbIsMultiplier.Name = "ckbIsMultiplier";
			this.ckbIsMultiplier.Size = new System.Drawing.Size(67, 17);
			this.ckbIsMultiplier.TabIndex = 15;
			this.ckbIsMultiplier.Text = "Mutliplier";
			this.ckbIsMultiplier.UseVisualStyleBackColor = true;
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.Enabled = false;
			this.btnDisconnect.Location = new System.Drawing.Point(191, 70);
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(118, 65);
			this.btnDisconnect.TabIndex = 16;
			this.btnDisconnect.Text = "Disconnect";
			this.btnDisconnect.UseVisualStyleBackColor = true;
			this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
			// 
			// txtReadout
			// 
			this.txtReadout.Location = new System.Drawing.Point(56, 268);
			this.txtReadout.Multiline = true;
			this.txtReadout.Name = "txtReadout";
			this.txtReadout.ReadOnly = true;
			this.txtReadout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtReadout.Size = new System.Drawing.Size(699, 156);
			this.txtReadout.TabIndex = 17;
			this.txtReadout.TabStop = false;
			// 
			// ckbIsSpamControl
			// 
			this.ckbIsSpamControl.AutoSize = true;
			this.ckbIsSpamControl.Location = new System.Drawing.Point(467, 227);
			this.ckbIsSpamControl.Name = "ckbIsSpamControl";
			this.ckbIsSpamControl.Size = new System.Drawing.Size(89, 17);
			this.ckbIsSpamControl.TabIndex = 18;
			this.ckbIsSpamControl.Text = "Spam Control";
			this.ckbIsSpamControl.UseVisualStyleBackColor = true;
			// 
			// ckbIsMulti
			// 
			this.ckbIsMulti.AutoSize = true;
			this.ckbIsMulti.Location = new System.Drawing.Point(540, 204);
			this.ckbIsMulti.Name = "ckbIsMulti";
			this.ckbIsMulti.Size = new System.Drawing.Size(145, 17);
			this.ckbIsMulti.TabIndex = 24;
			this.ckbIsMulti.Text = "Allow Multiple Commands";
			this.ckbIsMulti.UseVisualStyleBackColor = true;
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ckbIsMulti);
			this.Controls.Add(this.ckbIsSpamControl);
			this.Controls.Add(this.txtReadout);
			this.Controls.Add(this.btnDisconnect);
			this.Controls.Add(this.ckbIsMultiplier);
			this.Controls.Add(this.btnHide);
			this.Controls.Add(this.btnShow);
			this.Controls.Add(this.lblCode);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.lblChannel);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.txtChannel);
			this.Controls.Add(this.lblConsole);
			this.Controls.Add(this.txtChatInput);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.btnSend);
			this.Name = "MainMenu";
			this.Text = "Isaac Chat Bot 1.5";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.TextBox txtChatInput;
		private System.Windows.Forms.Label lblConsole;
		private System.Windows.Forms.TextBox txtChannel;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.Label lblChannel;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Label lblCode;
		private System.Windows.Forms.Button btnShow;
		private System.Windows.Forms.Button btnHide;
		private System.Windows.Forms.CheckBox ckbIsMultiplier;
		private System.Windows.Forms.Button btnDisconnect;
		private System.Windows.Forms.TextBox txtReadout;
		private System.Windows.Forms.CheckBox ckbIsSpamControl;
		private System.Windows.Forms.CheckBox ckbIsMulti;
	}
}

