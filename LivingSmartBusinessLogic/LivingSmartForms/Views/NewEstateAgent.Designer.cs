using SmartControls;

namespace LivingSmartForms.Views
{
    partial class NewEstateAgent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.tlpNewEstateAgent = new System.Windows.Forms.TableLayoutPanel();
			this.stbEmail = new SmartControls.SmartTextBox();
			this.stbPhone = new SmartControls.SmartTextBox();
			this.lblEstateAgentTerminationDate = new System.Windows.Forms.Label();
			this.lblEstateAgentName = new System.Windows.Forms.Label();
			this.lblEstateAgentPhone = new System.Windows.Forms.Label();
			this.lblEstateAgentEmail = new System.Windows.Forms.Label();
			this.lblEstateAgentStartDate = new System.Windows.Forms.Label();
			this.stbName = new SmartControls.SmartTextBox();
			this.dafStartDate = new LivingSmartForms.UserControls.DateField();
			this.dafTerminationDate = new LivingSmartForms.UserControls.DateField();
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.stbUsername = new SmartControls.SmartTextBox();
			this.stbPassword = new SmartControls.SmartTextBox();
			this.tlpNewEstateAgent.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpNewEstateAgent
			// 
			this.tlpNewEstateAgent.ColumnCount = 2;
			this.tlpNewEstateAgent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpNewEstateAgent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.tlpNewEstateAgent.Controls.Add(this.stbPassword, 1, 6);
			this.tlpNewEstateAgent.Controls.Add(this.stbUsername, 1, 5);
			this.tlpNewEstateAgent.Controls.Add(this.lblPassword, 0, 6);
			this.tlpNewEstateAgent.Controls.Add(this.lblUsername, 0, 5);
			this.tlpNewEstateAgent.Controls.Add(this.stbEmail, 1, 2);
			this.tlpNewEstateAgent.Controls.Add(this.stbPhone, 1, 1);
			this.tlpNewEstateAgent.Controls.Add(this.lblEstateAgentTerminationDate, 0, 4);
			this.tlpNewEstateAgent.Controls.Add(this.lblEstateAgentName, 0, 0);
			this.tlpNewEstateAgent.Controls.Add(this.lblEstateAgentPhone, 0, 1);
			this.tlpNewEstateAgent.Controls.Add(this.lblEstateAgentEmail, 0, 2);
			this.tlpNewEstateAgent.Controls.Add(this.lblEstateAgentStartDate, 0, 3);
			this.tlpNewEstateAgent.Controls.Add(this.stbName, 1, 0);
			this.tlpNewEstateAgent.Controls.Add(this.dafStartDate, 1, 3);
			this.tlpNewEstateAgent.Controls.Add(this.dafTerminationDate, 1, 4);
			this.tlpNewEstateAgent.Location = new System.Drawing.Point(0, 10);
			this.tlpNewEstateAgent.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.tlpNewEstateAgent.Name = "tlpNewEstateAgent";
			this.tlpNewEstateAgent.RowCount = 7;
			this.tlpNewEstateAgent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewEstateAgent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewEstateAgent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewEstateAgent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewEstateAgent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewEstateAgent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewEstateAgent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewEstateAgent.Size = new System.Drawing.Size(480, 280);
			this.tlpNewEstateAgent.TabIndex = 5;
			// 
			// stbEmail
			// 
			this.stbEmail.AllowComma = false;
			this.stbEmail.AllowDrop = true;
			this.stbEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbEmail.AutomaticValidation = true;
			this.stbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbEmail.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbEmail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbEmail.Location = new System.Drawing.Point(120, 80);
			this.stbEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbEmail.MaxLength = 50;
			this.stbEmail.MinLength = -1;
			this.stbEmail.Name = "stbEmail";
			this.stbEmail.NumericOnly = false;
			this.stbEmail.Placeholder = null;
			this.stbEmail.RegularExpression = null;
			this.stbEmail.Required = true;
			this.stbEmail.Size = new System.Drawing.Size(360, 30);
			this.stbEmail.Suffix = null;
			this.stbEmail.TabIndex = 2;
			this.stbEmail.TabStop = false;
			this.stbEmail.UseSystemPasswordChar = false;
			// 
			// stbPhone
			// 
			this.stbPhone.AllowComma = false;
			this.stbPhone.AllowDrop = true;
			this.stbPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbPhone.AutomaticValidation = true;
			this.stbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbPhone.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbPhone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbPhone.Location = new System.Drawing.Point(120, 40);
			this.stbPhone.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbPhone.MaxLength = 50;
			this.stbPhone.MinLength = 8;
			this.stbPhone.Name = "stbPhone";
			this.stbPhone.NumericOnly = true;
			this.stbPhone.Placeholder = null;
			this.stbPhone.RegularExpression = null;
			this.stbPhone.Required = true;
			this.stbPhone.Size = new System.Drawing.Size(360, 30);
			this.stbPhone.Suffix = null;
			this.stbPhone.TabIndex = 1;
			this.stbPhone.TabStop = false;
			this.stbPhone.UseSystemPasswordChar = false;
			// 
			// lblEstateAgentTerminationDate
			// 
			this.lblEstateAgentTerminationDate.AutoSize = true;
			this.lblEstateAgentTerminationDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblEstateAgentTerminationDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEstateAgentTerminationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblEstateAgentTerminationDate.Location = new System.Drawing.Point(0, 160);
			this.lblEstateAgentTerminationDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblEstateAgentTerminationDate.Name = "lblEstateAgentTerminationDate";
			this.lblEstateAgentTerminationDate.Size = new System.Drawing.Size(120, 30);
			this.lblEstateAgentTerminationDate.TabIndex = 9;
			this.lblEstateAgentTerminationDate.Text = "Afskedsdato";
			this.lblEstateAgentTerminationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEstateAgentName
			// 
			this.lblEstateAgentName.AutoSize = true;
			this.lblEstateAgentName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblEstateAgentName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEstateAgentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblEstateAgentName.Location = new System.Drawing.Point(0, 0);
			this.lblEstateAgentName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblEstateAgentName.Name = "lblEstateAgentName";
			this.lblEstateAgentName.Size = new System.Drawing.Size(120, 30);
			this.lblEstateAgentName.TabIndex = 5;
			this.lblEstateAgentName.Text = "Navn";
			this.lblEstateAgentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEstateAgentPhone
			// 
			this.lblEstateAgentPhone.AutoSize = true;
			this.lblEstateAgentPhone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblEstateAgentPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEstateAgentPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblEstateAgentPhone.Location = new System.Drawing.Point(0, 40);
			this.lblEstateAgentPhone.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblEstateAgentPhone.Name = "lblEstateAgentPhone";
			this.lblEstateAgentPhone.Size = new System.Drawing.Size(120, 30);
			this.lblEstateAgentPhone.TabIndex = 6;
			this.lblEstateAgentPhone.Text = "Telefon";
			this.lblEstateAgentPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEstateAgentEmail
			// 
			this.lblEstateAgentEmail.AutoSize = true;
			this.lblEstateAgentEmail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblEstateAgentEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEstateAgentEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblEstateAgentEmail.Location = new System.Drawing.Point(0, 80);
			this.lblEstateAgentEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblEstateAgentEmail.Name = "lblEstateAgentEmail";
			this.lblEstateAgentEmail.Size = new System.Drawing.Size(120, 30);
			this.lblEstateAgentEmail.TabIndex = 7;
			this.lblEstateAgentEmail.Text = "Email";
			this.lblEstateAgentEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEstateAgentStartDate
			// 
			this.lblEstateAgentStartDate.AutoSize = true;
			this.lblEstateAgentStartDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblEstateAgentStartDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEstateAgentStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblEstateAgentStartDate.Location = new System.Drawing.Point(0, 120);
			this.lblEstateAgentStartDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblEstateAgentStartDate.Name = "lblEstateAgentStartDate";
			this.lblEstateAgentStartDate.Size = new System.Drawing.Size(120, 30);
			this.lblEstateAgentStartDate.TabIndex = 8;
			this.lblEstateAgentStartDate.Text = "Startdato";
			this.lblEstateAgentStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// stbName
			// 
			this.stbName.AllowComma = false;
			this.stbName.AllowDrop = true;
			this.stbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbName.AutomaticValidation = true;
			this.stbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbName.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbName.Location = new System.Drawing.Point(120, 0);
			this.stbName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbName.MaxLength = 50;
			this.stbName.MinLength = -1;
			this.stbName.Name = "stbName";
			this.stbName.NumericOnly = false;
			this.stbName.Placeholder = null;
			this.stbName.RegularExpression = null;
			this.stbName.Required = true;
			this.stbName.Size = new System.Drawing.Size(360, 30);
			this.stbName.Suffix = null;
			this.stbName.TabIndex = 0;
			this.stbName.TabStop = false;
			this.stbName.UseSystemPasswordChar = false;
			// 
			// dafStartDate
			// 
			this.dafStartDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dafStartDate.Location = new System.Drawing.Point(120, 120);
			this.dafStartDate.Margin = new System.Windows.Forms.Padding(0);
			this.dafStartDate.Name = "dafStartDate";
			this.dafStartDate.Size = new System.Drawing.Size(360, 40);
			this.dafStartDate.TabIndex = 3;
			// 
			// dafTerminationDate
			// 
			this.dafTerminationDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dafTerminationDate.Location = new System.Drawing.Point(120, 160);
			this.dafTerminationDate.Margin = new System.Windows.Forms.Padding(0);
			this.dafTerminationDate.Name = "dafTerminationDate";
			this.dafTerminationDate.Size = new System.Drawing.Size(360, 40);
			this.dafTerminationDate.TabIndex = 4;
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblUsername.Location = new System.Drawing.Point(0, 200);
			this.lblUsername.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(120, 30);
			this.lblUsername.TabIndex = 10;
			this.lblUsername.Text = "Brugernavn";
			this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblPassword.Location = new System.Drawing.Point(0, 240);
			this.lblPassword.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(120, 30);
			this.lblPassword.TabIndex = 11;
			this.lblPassword.Text = "Adgangskode";
			this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// stbUsername
			// 
			this.stbUsername.AllowComma = false;
			this.stbUsername.AllowDrop = true;
			this.stbUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbUsername.AutomaticValidation = true;
			this.stbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbUsername.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbUsername.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbUsername.Location = new System.Drawing.Point(120, 200);
			this.stbUsername.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbUsername.MaxLength = 50;
			this.stbUsername.MinLength = -1;
			this.stbUsername.Name = "stbUsername";
			this.stbUsername.NumericOnly = false;
			this.stbUsername.Placeholder = null;
			this.stbUsername.RegularExpression = null;
			this.stbUsername.Required = true;
			this.stbUsername.Size = new System.Drawing.Size(360, 30);
			this.stbUsername.Suffix = null;
			this.stbUsername.TabIndex = 12;
			this.stbUsername.TabStop = false;
			this.stbUsername.UseSystemPasswordChar = false;
			// 
			// stbPassword
			// 
			this.stbPassword.AllowComma = false;
			this.stbPassword.AllowDrop = true;
			this.stbPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbPassword.AutomaticValidation = true;
			this.stbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbPassword.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbPassword.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbPassword.Location = new System.Drawing.Point(120, 240);
			this.stbPassword.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbPassword.MaxLength = 50;
			this.stbPassword.MinLength = -1;
			this.stbPassword.Name = "stbPassword";
			this.stbPassword.NumericOnly = false;
			this.stbPassword.Placeholder = null;
			this.stbPassword.RegularExpression = null;
			this.stbPassword.Required = true;
			this.stbPassword.Size = new System.Drawing.Size(360, 30);
			this.stbPassword.Suffix = null;
			this.stbPassword.TabIndex = 13;
			this.stbPassword.TabStop = false;
			this.stbPassword.UseSystemPasswordChar = false;
			// 
			// NewEstateAgent
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.tlpNewEstateAgent);
			this.Name = "NewEstateAgent";
			this.Size = new System.Drawing.Size(480, 290);
			this.tlpNewEstateAgent.ResumeLayout(false);
			this.tlpNewEstateAgent.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.TableLayoutPanel tlpNewEstateAgent;
        private System.Windows.Forms.Label lblEstateAgentTerminationDate;
        private System.Windows.Forms.Label lblEstateAgentName;
        private System.Windows.Forms.Label lblEstateAgentPhone;
        private System.Windows.Forms.Label lblEstateAgentEmail;
        private System.Windows.Forms.Label lblEstateAgentStartDate;
        private SmartControls.SmartTextBox stbEmail;
        private SmartControls.SmartTextBox stbPhone;
        private SmartControls.SmartTextBox stbName;
        private UserControls.DateField dafStartDate;
        private UserControls.DateField dafTerminationDate;
		private SmartTextBox stbPassword;
		private SmartTextBox stbUsername;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblUsername;
    }
}
