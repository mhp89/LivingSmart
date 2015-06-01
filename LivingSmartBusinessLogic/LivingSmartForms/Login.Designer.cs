namespace LivingSmartForms
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.pnlTopHolder = new System.Windows.Forms.Panel();
			this.pibLogo = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.chbAutoLogin = new System.Windows.Forms.CheckBox();
			this.pnlLoginForm = new System.Windows.Forms.Panel();
			this.stbUsername = new SmartControls.SmartTextBox();
			this.stbPassword = new SmartControls.SmartTextBox();
			this.btnLogin = new SmartControls.SmartButton();
			this.pnlTopHolder.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pibLogo)).BeginInit();
			this.pnlLoginForm.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTopHolder
			// 
			this.pnlTopHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.pnlTopHolder.Controls.Add(this.pibLogo);
			this.pnlTopHolder.Controls.Add(this.label1);
			this.pnlTopHolder.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTopHolder.Location = new System.Drawing.Point(0, 0);
			this.pnlTopHolder.Name = "pnlTopHolder";
			this.pnlTopHolder.Size = new System.Drawing.Size(534, 50);
			this.pnlTopHolder.TabIndex = 2;
			// 
			// pibLogo
			// 
			this.pibLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pibLogo.Image = global::LivingSmartForms.Properties.Resources.Logo;
			this.pibLogo.Location = new System.Drawing.Point(489, 5);
			this.pibLogo.Margin = new System.Windows.Forms.Padding(5);
			this.pibLogo.Name = "pibLogo";
			this.pibLogo.Size = new System.Drawing.Size(40, 40);
			this.pibLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pibLogo.TabIndex = 1;
			this.pibLogo.TabStop = false;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.label1.Size = new System.Drawing.Size(534, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "Log ind";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chbAutoLogin
			// 
			this.chbAutoLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chbAutoLogin.AutoSize = true;
			this.chbAutoLogin.Checked = true;
			this.chbAutoLogin.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbAutoLogin.FlatAppearance.BorderSize = 0;
			this.chbAutoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chbAutoLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.chbAutoLogin.Location = new System.Drawing.Point(89, 88);
			this.chbAutoLogin.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.chbAutoLogin.Name = "chbAutoLogin";
			this.chbAutoLogin.Size = new System.Drawing.Size(109, 17);
			this.chbAutoLogin.TabIndex = 4;
			this.chbAutoLogin.Text = "Automatisk log ind";
			this.chbAutoLogin.UseVisualStyleBackColor = true;
			// 
			// pnlLoginForm
			// 
			this.pnlLoginForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlLoginForm.Controls.Add(this.stbUsername);
			this.pnlLoginForm.Controls.Add(this.chbAutoLogin);
			this.pnlLoginForm.Controls.Add(this.stbPassword);
			this.pnlLoginForm.Controls.Add(this.btnLogin);
			this.pnlLoginForm.Location = new System.Drawing.Point(117, 100);
			this.pnlLoginForm.Margin = new System.Windows.Forms.Padding(142, 0, 142, 0);
			this.pnlLoginForm.Name = "pnlLoginForm";
			this.pnlLoginForm.Size = new System.Drawing.Size(300, 135);
			this.pnlLoginForm.TabIndex = 5;
			// 
			// stbUsername
			// 
			this.stbUsername.AllowComma = false;
			this.stbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.stbUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbUsername.AutomaticValidation = true;
			this.stbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbUsername.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbUsername.Location = new System.Drawing.Point(0, 0);
			this.stbUsername.Margin = new System.Windows.Forms.Padding(0);
			this.stbUsername.MaxLength = 32767;
			this.stbUsername.MinLength = -1;
			this.stbUsername.Name = "stbUsername";
			this.stbUsername.NumericOnly = false;
			this.stbUsername.Placeholder = "Brugernavn";
			this.stbUsername.RegularExpression = null;
			this.stbUsername.Required = true;
			this.stbUsername.Size = new System.Drawing.Size(300, 30);
			this.stbUsername.Suffix = null;
			this.stbUsername.TabIndex = 0;
			this.stbUsername.TabStop = false;
			this.stbUsername.UseSystemPasswordChar = false;
			this.stbUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLogin_KeyDown);
			// 
			// stbPassword
			// 
			this.stbPassword.AllowComma = false;
			this.stbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.stbPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbPassword.AutomaticValidation = false;
			this.stbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbPassword.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbPassword.Location = new System.Drawing.Point(0, 40);
			this.stbPassword.MaxLength = 32767;
			this.stbPassword.MinLength = -1;
			this.stbPassword.Name = "stbPassword";
			this.stbPassword.NumericOnly = false;
			this.stbPassword.Placeholder = "Adgangskode";
			this.stbPassword.RegularExpression = null;
			this.stbPassword.Required = true;
			this.stbPassword.Size = new System.Drawing.Size(300, 30);
			this.stbPassword.Suffix = null;
			this.stbPassword.TabIndex = 1;
			this.stbPassword.TabStop = false;
			this.stbPassword.UseSystemPasswordChar = true;
			this.stbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLogin_KeyDown);
			// 
			// btnLogin
			// 
			this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLogin.AutoSize = true;
			this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnLogin.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnLogin.Location = new System.Drawing.Point(208, 80);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(92, 30);
			this.btnLogin.TabIndex = 3;
			this.btnLogin.Text = "Log ind";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// Login
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.ClientSize = new System.Drawing.Size(534, 286);
			this.Controls.Add(this.pnlLoginForm);
			this.Controls.Add(this.pnlTopHolder);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(600, 350);
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "Login";
			this.Text = "Log ind";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
			this.Load += new System.EventHandler(this.Login_Load);
			this.SizeChanged += new System.EventHandler(this.Login_SizeChanged);
			this.pnlTopHolder.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pibLogo)).EndInit();
			this.pnlLoginForm.ResumeLayout(false);
			this.pnlLoginForm.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private SmartControls.SmartTextBox stbUsername;
		private SmartControls.SmartTextBox stbPassword;
		private SmartControls.SmartButton btnLogin;
		private System.Windows.Forms.CheckBox chbAutoLogin;
		private System.Windows.Forms.Panel pnlTopHolder;
		private System.Windows.Forms.PictureBox pibLogo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pnlLoginForm;
	}
}
