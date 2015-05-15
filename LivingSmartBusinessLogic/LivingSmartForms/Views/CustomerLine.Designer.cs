namespace LivingSmartForms.Views
{
    partial class CustomerLine
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
			this.tlpCustomer = new System.Windows.Forms.TableLayoutPanel();
			this.pnlEditCustomer = new System.Windows.Forms.Panel();
			this.btnEditCustomer = new System.Windows.Forms.Button();
			this.slbCustomer = new SmartControls.SmartLabel();
			this.slbCustomerNo = new SmartControls.SmartLabel();
			this.slbCustomerBirthday = new SmartControls.SmartLabel();
			this.slbCustomerAddress = new SmartControls.SmartLabel();
			this.slbZipcode = new SmartControls.SmartLabel();
			this.slbPhone = new SmartControls.SmartLabel();
			this.slbEmail = new SmartControls.SmartLabel();
			this.tlpCustomer.SuspendLayout();
			this.pnlEditCustomer.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpCustomer
			// 
			this.tlpCustomer.ColumnCount = 5;
			this.tlpCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.75718F));
			this.tlpCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.4038F));
			this.tlpCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.35667F));
			this.tlpCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.48235F));
			this.tlpCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpCustomer.Controls.Add(this.pnlEditCustomer, 4, 0);
			this.tlpCustomer.Controls.Add(this.slbCustomer, 1, 0);
			this.tlpCustomer.Controls.Add(this.slbCustomerNo, 0, 0);
			this.tlpCustomer.Controls.Add(this.slbCustomerBirthday, 1, 1);
			this.tlpCustomer.Controls.Add(this.slbCustomerAddress, 2, 0);
			this.tlpCustomer.Controls.Add(this.slbZipcode, 2, 1);
			this.tlpCustomer.Controls.Add(this.slbPhone, 3, 0);
			this.tlpCustomer.Controls.Add(this.slbEmail, 3, 1);
			this.tlpCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpCustomer.Location = new System.Drawing.Point(0, 0);
			this.tlpCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tlpCustomer.Name = "tlpCustomer";
			this.tlpCustomer.RowCount = 2;
			this.tlpCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpCustomer.Size = new System.Drawing.Size(600, 49);
			this.tlpCustomer.TabIndex = 0;
			// 
			// pnlEditCustomer
			// 
			this.pnlEditCustomer.Controls.Add(this.btnEditCustomer);
			this.pnlEditCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlEditCustomer.Location = new System.Drawing.Point(532, 0);
			this.pnlEditCustomer.Margin = new System.Windows.Forms.Padding(0);
			this.pnlEditCustomer.Name = "pnlEditCustomer";
			this.tlpCustomer.SetRowSpan(this.pnlEditCustomer, 2);
			this.pnlEditCustomer.Size = new System.Drawing.Size(68, 49);
			this.pnlEditCustomer.TabIndex = 0;
			// 
			// btnEditCustomer
			// 
			this.btnEditCustomer.Location = new System.Drawing.Point(6, 8);
			this.btnEditCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnEditCustomer.Name = "btnEditCustomer";
			this.btnEditCustomer.Size = new System.Drawing.Size(56, 32);
			this.btnEditCustomer.TabIndex = 0;
			this.btnEditCustomer.Text = "Rediger";
			this.btnEditCustomer.UseVisualStyleBackColor = true;
			// 
			// slbCustomer
			// 
			this.slbCustomer.AutoSize = true;
			this.slbCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbCustomer.Location = new System.Drawing.Point(89, 0);
			this.slbCustomer.Name = "slbCustomer";
			this.slbCustomer.Size = new System.Drawing.Size(151, 24);
			this.slbCustomer.TabIndex = 2;
			this.slbCustomer.Text = "Kundens navn";
			this.slbCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbCustomer.Title = "Navn:";
			this.slbCustomer.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// slbCustomerNo
			// 
			this.slbCustomerNo.AutoSize = true;
			this.slbCustomerNo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbCustomerNo.Location = new System.Drawing.Point(0, 0);
			this.slbCustomerNo.Name = "slbCustomerNo";
			this.tlpCustomer.SetRowSpan(this.slbCustomerNo, 2);
			this.slbCustomerNo.Size = new System.Drawing.Size(89, 49);
			this.slbCustomerNo.TabIndex = 3;
			this.slbCustomerNo.Text = "xxx";
			this.slbCustomerNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbCustomerNo.Title = "Kundenr:";
			this.slbCustomerNo.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// slbCustomerBirthday
			// 
			this.slbCustomerBirthday.AutoSize = true;
			this.slbCustomerBirthday.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbCustomerBirthday.Location = new System.Drawing.Point(89, 24);
			this.slbCustomerBirthday.Name = "slbCustomerBirthday";
			this.slbCustomerBirthday.Size = new System.Drawing.Size(151, 25);
			this.slbCustomerBirthday.TabIndex = 4;
			this.slbCustomerBirthday.Text = "xx-xxx-xxxx";
			this.slbCustomerBirthday.Title = "Fødselsdato:";
			this.slbCustomerBirthday.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// slbCustomerAddress
			// 
			this.slbCustomerAddress.AutoSize = true;
			this.slbCustomerAddress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbCustomerAddress.Location = new System.Drawing.Point(240, 0);
			this.slbCustomerAddress.Name = "slbCustomerAddress";
			this.slbCustomerAddress.Size = new System.Drawing.Size(167, 24);
			this.slbCustomerAddress.TabIndex = 5;
			this.slbCustomerAddress.Text = "Gadenavn og nummer";
			this.slbCustomerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbCustomerAddress.Title = "Adresse:";
			this.slbCustomerAddress.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// slbZipcode
			// 
			this.slbZipcode.AutoSize = true;
			this.slbZipcode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbZipcode.Location = new System.Drawing.Point(240, 24);
			this.slbZipcode.Name = "slbZipcode";
			this.slbZipcode.Size = new System.Drawing.Size(167, 25);
			this.slbZipcode.TabIndex = 6;
			this.slbZipcode.Text = "xxxx by";
			this.slbZipcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbZipcode.Title = "Postnr og by:";
			this.slbZipcode.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// slbPhone
			// 
			this.slbPhone.AutoSize = true;
			this.slbPhone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbPhone.Location = new System.Drawing.Point(407, 0);
			this.slbPhone.Name = "slbPhone";
			this.slbPhone.Size = new System.Drawing.Size(125, 24);
			this.slbPhone.TabIndex = 7;
			this.slbPhone.Text = "xxxx xxxx";
			this.slbPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbPhone.Title = "Telefon:";
			this.slbPhone.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// slbEmail
			// 
			this.slbEmail.AutoSize = true;
			this.slbEmail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbEmail.Location = new System.Drawing.Point(407, 24);
			this.slbEmail.Name = "slbEmail";
			this.slbEmail.Size = new System.Drawing.Size(125, 25);
			this.slbEmail.TabIndex = 8;
			this.slbEmail.Text = "xx@xxx.xx";
			this.slbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbEmail.Title = "Email:";
			this.slbEmail.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// CustomerLine
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.tlpCustomer);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "CustomerLine";
			this.Size = new System.Drawing.Size(600, 49);
			this.tlpCustomer.ResumeLayout(false);
			this.tlpCustomer.PerformLayout();
			this.pnlEditCustomer.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCustomer;
        private System.Windows.Forms.Panel pnlEditCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private SmartControls.SmartLabel slbCustomer;
        private SmartControls.SmartLabel slbCustomerNo;
        private SmartControls.SmartLabel slbCustomerBirthday;
        private SmartControls.SmartLabel slbCustomerAddress;
        private SmartControls.SmartLabel slbZipcode;
        private SmartControls.SmartLabel slbPhone;
        private SmartControls.SmartLabel slbEmail;
    }
}
