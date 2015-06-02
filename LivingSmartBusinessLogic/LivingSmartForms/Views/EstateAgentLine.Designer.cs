using SmartControls;

namespace LivingSmartForms
{
    partial class EstateAgentLine
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
			this.tlpEmployee = new System.Windows.Forms.TableLayoutPanel();
			this.slbName = new SmartControls.SmartLabel();
			this.slbHireDate = new SmartControls.SmartLabel();
			this.slbPhone = new SmartControls.SmartLabel();
			this.slbEmail = new SmartControls.SmartLabel();
			this.slbEmployeeNo = new SmartControls.SmartLabel();
			this.btnSeeEstateAgent = new SmartControls.SmartButton();
			this.tlpEmployee.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpEmployee
			// 
			this.tlpEmployee.ColumnCount = 4;
			this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpEmployee.Controls.Add(this.btnSeeEstateAgent, 3, 0);
			this.tlpEmployee.Controls.Add(this.slbName, 1, 0);
			this.tlpEmployee.Controls.Add(this.slbHireDate, 1, 1);
			this.tlpEmployee.Controls.Add(this.slbPhone, 2, 0);
			this.tlpEmployee.Controls.Add(this.slbEmail, 2, 1);
			this.tlpEmployee.Controls.Add(this.slbEmployeeNo, 0, 0);
			this.tlpEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpEmployee.Location = new System.Drawing.Point(0, 0);
			this.tlpEmployee.Margin = new System.Windows.Forms.Padding(2);
			this.tlpEmployee.Name = "tlpEmployee";
			this.tlpEmployee.RowCount = 2;
			this.tlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpEmployee.Size = new System.Drawing.Size(1064, 49);
			this.tlpEmployee.TabIndex = 0;
			// 
			// slbName
			// 
			this.slbName.AutoSize = true;
			this.slbName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.slbName.Location = new System.Drawing.Point(310, 0);
			this.slbName.Name = "slbName";
			this.slbName.Size = new System.Drawing.Size(310, 24);
			this.slbName.TabIndex = 2;
			this.slbName.Text = "Medarbejders navn";
			this.slbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbName.Title = "Navn:";
			this.slbName.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// slbHireDate
			// 
			this.slbHireDate.AutoSize = true;
			this.slbHireDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbHireDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.slbHireDate.Location = new System.Drawing.Point(310, 24);
			this.slbHireDate.Name = "slbHireDate";
			this.slbHireDate.Size = new System.Drawing.Size(310, 25);
			this.slbHireDate.TabIndex = 5;
			this.slbHireDate.Text = "xx yyy zzzz";
			this.slbHireDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbHireDate.Title = "Ansættelsesdato:";
			this.slbHireDate.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// slbPhone
			// 
			this.slbPhone.AutoSize = true;
			this.slbPhone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.slbPhone.Location = new System.Drawing.Point(620, 0);
			this.slbPhone.Name = "slbPhone";
			this.slbPhone.Size = new System.Drawing.Size(310, 24);
			this.slbPhone.TabIndex = 6;
			this.slbPhone.Text = "xxxx xxxx";
			this.slbPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbPhone.Title = "Telefonnummer:";
			this.slbPhone.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// slbEmail
			// 
			this.slbEmail.AutoSize = true;
			this.slbEmail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.slbEmail.Location = new System.Drawing.Point(620, 24);
			this.slbEmail.Name = "slbEmail";
			this.slbEmail.Size = new System.Drawing.Size(310, 25);
			this.slbEmail.TabIndex = 7;
			this.slbEmail.Text = "employee@smartliving.dk";
			this.slbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbEmail.Title = "Email:";
			this.slbEmail.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// slbEmployeeNo
			// 
			this.slbEmployeeNo.AutoSize = true;
			this.slbEmployeeNo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbEmployeeNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.slbEmployeeNo.Location = new System.Drawing.Point(0, 0);
			this.slbEmployeeNo.Name = "slbEmployeeNo";
			this.tlpEmployee.SetRowSpan(this.slbEmployeeNo, 2);
			this.slbEmployeeNo.Size = new System.Drawing.Size(310, 49);
			this.slbEmployeeNo.TabIndex = 8;
			this.slbEmployeeNo.Text = "xxx";
			this.slbEmployeeNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbEmployeeNo.Title = "Medarbejdernr:";
			this.slbEmployeeNo.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// btnSeeEstateAgent
			// 
			this.btnSeeEstateAgent.AutoSize = true;
			this.btnSeeEstateAgent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnSeeEstateAgent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnSeeEstateAgent.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.btnSeeEstateAgent.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSeeEstateAgent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSeeEstateAgent.FlatAppearance.BorderSize = 0;
			this.btnSeeEstateAgent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnSeeEstateAgent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnSeeEstateAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSeeEstateAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnSeeEstateAgent.Location = new System.Drawing.Point(940, 10);
			this.btnSeeEstateAgent.Margin = new System.Windows.Forms.Padding(10);
			this.btnSeeEstateAgent.Name = "btnSeeEstateAgent";
			this.tlpEmployee.SetRowSpan(this.btnSeeEstateAgent, 2);
			this.btnSeeEstateAgent.Size = new System.Drawing.Size(114, 29);
			this.btnSeeEstateAgent.TabIndex = 10;
			this.btnSeeEstateAgent.Text = "Se mægler";
			this.btnSeeEstateAgent.UseVisualStyleBackColor = false;
			// 
			// EstateAgentLine
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.tlpEmployee);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "EstateAgentLine";
			this.Size = new System.Drawing.Size(1064, 49);
			this.tlpEmployee.ResumeLayout(false);
			this.tlpEmployee.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.TableLayoutPanel tlpEmployee;
		private SmartControls.SmartLabel slbName;
        private SmartControls.SmartLabel slbHireDate;
        private SmartControls.SmartLabel slbPhone;
        private SmartControls.SmartLabel slbEmail;
		private SmartControls.SmartLabel slbEmployeeNo;
		private SmartButton btnSeeEstateAgent;
    }
}
