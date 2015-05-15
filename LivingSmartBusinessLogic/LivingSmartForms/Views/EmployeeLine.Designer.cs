namespace LivingSmartForms
{
    partial class EmployeeLine
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
            this.pnlEditEmployee = new System.Windows.Forms.Panel();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.slbEmployeeName = new SmartControls.SmartLabel();
            this.slbEmployeeAddress = new SmartControls.SmartLabel();
            this.slbEmployeeZipcode = new SmartControls.SmartLabel();
            this.slbEmployeeHireDate = new SmartControls.SmartLabel();
            this.slbEmployeePhone = new SmartControls.SmartLabel();
            this.slbEmployeeEmail = new SmartControls.SmartLabel();
            this.slbEmployeeNo = new SmartControls.SmartLabel();
            this.tlpEmployee.SuspendLayout();
            this.pnlEditEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpEmployee
            // 
            this.tlpEmployee.ColumnCount = 5;
            this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.375F));
            this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.25F));
            this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.375F));
            this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.875F));
            this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.125F));
            this.tlpEmployee.Controls.Add(this.pnlEditEmployee, 4, 0);
            this.tlpEmployee.Controls.Add(this.slbEmployeeName, 1, 0);
            this.tlpEmployee.Controls.Add(this.slbEmployeeAddress, 2, 0);
            this.tlpEmployee.Controls.Add(this.slbEmployeeZipcode, 2, 1);
            this.tlpEmployee.Controls.Add(this.slbEmployeeHireDate, 1, 1);
            this.tlpEmployee.Controls.Add(this.slbEmployeePhone, 3, 0);
            this.tlpEmployee.Controls.Add(this.slbEmployeeEmail, 3, 1);
            this.tlpEmployee.Controls.Add(this.slbEmployeeNo, 0, 0);
            this.tlpEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEmployee.Location = new System.Drawing.Point(0, 0);
            this.tlpEmployee.Name = "tlpEmployee";
            this.tlpEmployee.RowCount = 2;
            this.tlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEmployee.Size = new System.Drawing.Size(800, 60);
            this.tlpEmployee.TabIndex = 0;
            // 
            // pnlEditEmployee
            // 
            this.pnlEditEmployee.Controls.Add(this.btnEditEmployee);
            this.pnlEditEmployee.Location = new System.Drawing.Point(711, 0);
            this.pnlEditEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEditEmployee.Name = "pnlEditEmployee";
            this.tlpEmployee.SetRowSpan(this.pnlEditEmployee, 2);
            this.pnlEditEmployee.Size = new System.Drawing.Size(89, 60);
            this.pnlEditEmployee.TabIndex = 0;
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(8, 10);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(75, 39);
            this.btnEditEmployee.TabIndex = 0;
            this.btnEditEmployee.Text = "Rediger";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            // 
            // slbEmployeeName
            // 
            this.slbEmployeeName.AutoSize = true;
            this.slbEmployeeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slbEmployeeName.Location = new System.Drawing.Point(155, 0);
            this.slbEmployeeName.Margin = new System.Windows.Forms.Padding(0);
            this.slbEmployeeName.Name = "slbEmployeeName";
            this.slbEmployeeName.Size = new System.Drawing.Size(186, 30);
            this.slbEmployeeName.TabIndex = 2;
            this.slbEmployeeName.Text = "Medarbejders navn";
            this.slbEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slbEmployeeName.Title = "Navn:";
            // 
            // slbEmployeeAddress
            // 
            this.slbEmployeeAddress.AutoSize = true;
            this.slbEmployeeAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slbEmployeeAddress.Location = new System.Drawing.Point(341, 0);
            this.slbEmployeeAddress.Margin = new System.Windows.Forms.Padding(0);
            this.slbEmployeeAddress.Name = "slbEmployeeAddress";
            this.slbEmployeeAddress.Size = new System.Drawing.Size(211, 30);
            this.slbEmployeeAddress.TabIndex = 3;
            this.slbEmployeeAddress.Text = "Gadenavn og nummer";
            this.slbEmployeeAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slbEmployeeAddress.Title = "Adresse:";
            // 
            // slbEmployeeZipcode
            // 
            this.slbEmployeeZipcode.AutoSize = true;
            this.slbEmployeeZipcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slbEmployeeZipcode.Location = new System.Drawing.Point(341, 30);
            this.slbEmployeeZipcode.Margin = new System.Windows.Forms.Padding(0);
            this.slbEmployeeZipcode.Name = "slbEmployeeZipcode";
            this.slbEmployeeZipcode.Size = new System.Drawing.Size(211, 30);
            this.slbEmployeeZipcode.TabIndex = 4;
            this.slbEmployeeZipcode.Text = "xxxx by";
            this.slbEmployeeZipcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slbEmployeeZipcode.Title = "Postnr og by:";
            // 
            // slbEmployeeHireDate
            // 
            this.slbEmployeeHireDate.AutoSize = true;
            this.slbEmployeeHireDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slbEmployeeHireDate.Location = new System.Drawing.Point(155, 30);
            this.slbEmployeeHireDate.Margin = new System.Windows.Forms.Padding(0);
            this.slbEmployeeHireDate.Name = "slbEmployeeHireDate";
            this.slbEmployeeHireDate.Size = new System.Drawing.Size(186, 30);
            this.slbEmployeeHireDate.TabIndex = 5;
            this.slbEmployeeHireDate.Text = "xx yyy zzzz";
            this.slbEmployeeHireDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slbEmployeeHireDate.Title = "Ansættelsesdato:";
            // 
            // slbEmployeePhone
            // 
            this.slbEmployeePhone.AutoSize = true;
            this.slbEmployeePhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slbEmployeePhone.Location = new System.Drawing.Point(552, 0);
            this.slbEmployeePhone.Margin = new System.Windows.Forms.Padding(0);
            this.slbEmployeePhone.Name = "slbEmployeePhone";
            this.slbEmployeePhone.Size = new System.Drawing.Size(159, 30);
            this.slbEmployeePhone.TabIndex = 6;
            this.slbEmployeePhone.Text = "xxxx xxxx";
            this.slbEmployeePhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slbEmployeePhone.Title = "Telefonnummer:";
            // 
            // slbEmployeeEmail
            // 
            this.slbEmployeeEmail.AutoSize = true;
            this.slbEmployeeEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slbEmployeeEmail.Location = new System.Drawing.Point(552, 30);
            this.slbEmployeeEmail.Margin = new System.Windows.Forms.Padding(0);
            this.slbEmployeeEmail.Name = "slbEmployeeEmail";
            this.slbEmployeeEmail.Size = new System.Drawing.Size(159, 30);
            this.slbEmployeeEmail.TabIndex = 7;
            this.slbEmployeeEmail.Text = "employee@smartliving.dk";
            this.slbEmployeeEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slbEmployeeEmail.Title = "Email:";
            // 
            // slbEmployeeNo
            // 
            this.slbEmployeeNo.AutoSize = true;
            this.slbEmployeeNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slbEmployeeNo.Location = new System.Drawing.Point(3, 0);
            this.slbEmployeeNo.Name = "slbEmployeeNo";
            this.tlpEmployee.SetRowSpan(this.slbEmployeeNo, 2);
            this.slbEmployeeNo.Size = new System.Drawing.Size(149, 60);
            this.slbEmployeeNo.TabIndex = 8;
            this.slbEmployeeNo.Text = "xxx";
            this.slbEmployeeNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slbEmployeeNo.Title = "Medarbejdernr:";
            // 
            // EmployeeLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpEmployee);
            this.Name = "EmployeeLine";
            this.Size = new System.Drawing.Size(800, 60);
            this.tlpEmployee.ResumeLayout(false);
            this.tlpEmployee.PerformLayout();
            this.pnlEditEmployee.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEmployee;
        private System.Windows.Forms.Panel pnlEditEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private SmartControls.SmartLabel slbEmployeeName;
        private SmartControls.SmartLabel slbEmployeeAddress;
        private SmartControls.SmartLabel slbEmployeeZipcode;
        private SmartControls.SmartLabel slbEmployeeHireDate;
        private SmartControls.SmartLabel slbEmployeePhone;
        private SmartControls.SmartLabel slbEmployeeEmail;
        private SmartControls.SmartLabel slbEmployeeNo;
    }
}
