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
			this.stbEstateAgentEmail = new SmartControls.SmartTextBox();
			this.stbEstateAgentPhone = new SmartControls.SmartTextBox();
			this.lblEstateAgentTerminationDate = new System.Windows.Forms.Label();
			this.lblEstateAgentName = new System.Windows.Forms.Label();
			this.lblEstateAgentPhone = new System.Windows.Forms.Label();
			this.lblEstateAgentEmail = new System.Windows.Forms.Label();
			this.lblEstateAgentStartDate = new System.Windows.Forms.Label();
			this.stbEstateAgentName = new SmartControls.SmartTextBox();
			this.dafEstateAgentStartDate = new LivingSmartForms.UserControls.DateField();
			this.dafEstateAgentTerminationDate = new LivingSmartForms.UserControls.DateField();
			this.tlpNewEstateAgent.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpNewEstateAgent
			// 
			this.tlpNewEstateAgent.ColumnCount = 2;
			this.tlpNewEstateAgent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpNewEstateAgent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.tlpNewEstateAgent.Controls.Add(this.stbEstateAgentEmail, 1, 2);
			this.tlpNewEstateAgent.Controls.Add(this.stbEstateAgentPhone, 1, 1);
			this.tlpNewEstateAgent.Controls.Add(this.lblEstateAgentTerminationDate, 0, 4);
			this.tlpNewEstateAgent.Controls.Add(this.lblEstateAgentName, 0, 0);
			this.tlpNewEstateAgent.Controls.Add(this.lblEstateAgentPhone, 0, 1);
			this.tlpNewEstateAgent.Controls.Add(this.lblEstateAgentEmail, 0, 2);
			this.tlpNewEstateAgent.Controls.Add(this.lblEstateAgentStartDate, 0, 3);
			this.tlpNewEstateAgent.Controls.Add(this.stbEstateAgentName, 1, 0);
			this.tlpNewEstateAgent.Controls.Add(this.dafEstateAgentStartDate, 1, 3);
			this.tlpNewEstateAgent.Controls.Add(this.dafEstateAgentTerminationDate, 1, 4);
			this.tlpNewEstateAgent.Location = new System.Drawing.Point(0, 10);
			this.tlpNewEstateAgent.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.tlpNewEstateAgent.Name = "tlpNewEstateAgent";
			this.tlpNewEstateAgent.RowCount = 5;
			this.tlpNewEstateAgent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewEstateAgent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewEstateAgent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewEstateAgent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewEstateAgent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewEstateAgent.Size = new System.Drawing.Size(480, 200);
			this.tlpNewEstateAgent.TabIndex = 5;
			// 
			// stbEstateAgentEmail
			// 
			this.stbEstateAgentEmail.AllowComma = false;
			this.stbEstateAgentEmail.AllowDrop = true;
			this.stbEstateAgentEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbEstateAgentEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbEstateAgentEmail.AutomaticValidation = true;
			this.stbEstateAgentEmail.BackColor = SmartColor.Light;
			this.stbEstateAgentEmail.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbEstateAgentEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbEstateAgentEmail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbEstateAgentEmail.ForeColor = SmartColor.Dark;
			this.stbEstateAgentEmail.Location = new System.Drawing.Point(120, 80);
			this.stbEstateAgentEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbEstateAgentEmail.MaxLength = 50;
			this.stbEstateAgentEmail.MinLength = -1;
			this.stbEstateAgentEmail.Name = "stbEstateAgentEmail";
			this.stbEstateAgentEmail.NumericOnly = false;
			this.stbEstateAgentEmail.Placeholder = null;
			this.stbEstateAgentEmail.RegularExpression = null;
			this.stbEstateAgentEmail.Required = true;
			this.stbEstateAgentEmail.Size = new System.Drawing.Size(360, 30);
			this.stbEstateAgentEmail.Suffix = null;
			this.stbEstateAgentEmail.TabIndex = 14;
			this.stbEstateAgentEmail.UseSystemPasswordChar = false;
			// 
			// stbEstateAgentPhone
			// 
			this.stbEstateAgentPhone.AllowComma = false;
			this.stbEstateAgentPhone.AllowDrop = true;
			this.stbEstateAgentPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbEstateAgentPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbEstateAgentPhone.AutomaticValidation = true;
			this.stbEstateAgentPhone.BackColor = SmartColor.Light;
			this.stbEstateAgentPhone.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbEstateAgentPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbEstateAgentPhone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbEstateAgentPhone.ForeColor = SmartColor.Dark;
			this.stbEstateAgentPhone.Location = new System.Drawing.Point(120, 40);
			this.stbEstateAgentPhone.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbEstateAgentPhone.MaxLength = 50;
			this.stbEstateAgentPhone.MinLength = 8;
			this.stbEstateAgentPhone.Name = "stbEstateAgentPhone";
			this.stbEstateAgentPhone.NumericOnly = true;
			this.stbEstateAgentPhone.Placeholder = null;
			this.stbEstateAgentPhone.RegularExpression = null;
			this.stbEstateAgentPhone.Required = true;
			this.stbEstateAgentPhone.Size = new System.Drawing.Size(360, 30);
			this.stbEstateAgentPhone.Suffix = null;
			this.stbEstateAgentPhone.TabIndex = 13;
			this.stbEstateAgentPhone.UseSystemPasswordChar = false;
			// 
			// lblEstateAgentTerminationDate
			// 
			this.lblEstateAgentTerminationDate.AutoSize = true;
			this.lblEstateAgentTerminationDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblEstateAgentTerminationDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEstateAgentTerminationDate.ForeColor = SmartColor.Dark;
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
			this.lblEstateAgentName.ForeColor = SmartColor.Dark;
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
			this.lblEstateAgentPhone.ForeColor = SmartColor.Dark;
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
			this.lblEstateAgentEmail.ForeColor = SmartColor.Dark;
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
			this.lblEstateAgentStartDate.ForeColor = SmartColor.Dark;
			this.lblEstateAgentStartDate.Location = new System.Drawing.Point(0, 120);
			this.lblEstateAgentStartDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblEstateAgentStartDate.Name = "lblEstateAgentStartDate";
			this.lblEstateAgentStartDate.Size = new System.Drawing.Size(120, 30);
			this.lblEstateAgentStartDate.TabIndex = 8;
			this.lblEstateAgentStartDate.Text = "Startdato";
			this.lblEstateAgentStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// stbEstateAgentName
			// 
			this.stbEstateAgentName.AllowComma = false;
			this.stbEstateAgentName.AllowDrop = true;
			this.stbEstateAgentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbEstateAgentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbEstateAgentName.AutomaticValidation = true;
			this.stbEstateAgentName.BackColor = SmartColor.Light;
			this.stbEstateAgentName.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbEstateAgentName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbEstateAgentName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbEstateAgentName.ForeColor = SmartColor.Dark;
			this.stbEstateAgentName.Location = new System.Drawing.Point(120, 0);
			this.stbEstateAgentName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbEstateAgentName.MaxLength = 50;
			this.stbEstateAgentName.MinLength = -1;
			this.stbEstateAgentName.Name = "stbEstateAgentName";
			this.stbEstateAgentName.NumericOnly = false;
			this.stbEstateAgentName.Placeholder = null;
			this.stbEstateAgentName.RegularExpression = null;
			this.stbEstateAgentName.Required = true;
			this.stbEstateAgentName.Size = new System.Drawing.Size(360, 30);
			this.stbEstateAgentName.Suffix = null;
			this.stbEstateAgentName.TabIndex = 12;
			this.stbEstateAgentName.UseSystemPasswordChar = false;
			// 
			// dafEstateAgentStartDate
			// 
			this.dafEstateAgentStartDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dafEstateAgentStartDate.Location = new System.Drawing.Point(120, 120);
			this.dafEstateAgentStartDate.Margin = new System.Windows.Forms.Padding(0);
			this.dafEstateAgentStartDate.Name = "dafEstateAgentStartDate";
			this.dafEstateAgentStartDate.Size = new System.Drawing.Size(360, 40);
			this.dafEstateAgentStartDate.TabIndex = 15;
			// 
			// dafEstateAgentTerminationDate
			// 
			this.dafEstateAgentTerminationDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dafEstateAgentTerminationDate.Location = new System.Drawing.Point(120, 160);
			this.dafEstateAgentTerminationDate.Margin = new System.Windows.Forms.Padding(0);
			this.dafEstateAgentTerminationDate.Name = "dafEstateAgentTerminationDate";
			this.dafEstateAgentTerminationDate.Size = new System.Drawing.Size(360, 40);
			this.dafEstateAgentTerminationDate.TabIndex = 16;
			// 
			// NewEstateAgent
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.tlpNewEstateAgent);
			this.Name = "NewEstateAgent";
			this.Size = new System.Drawing.Size(480, 210);
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
        private SmartControls.SmartTextBox stbEstateAgentEmail;
        private SmartControls.SmartTextBox stbEstateAgentPhone;
        private SmartControls.SmartTextBox stbEstateAgentName;
        private UserControls.DateField dafEstateAgentStartDate;
        private UserControls.DateField dafEstateAgentTerminationDate;
    }
}
