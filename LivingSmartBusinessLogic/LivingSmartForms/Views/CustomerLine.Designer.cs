using SmartControls;

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
			this.slbCustomer = new SmartControls.SmartLabel();
			this.slbCustomerNo = new SmartControls.SmartLabel();
			this.slbCustomerBirthday = new SmartControls.SmartLabel();
			this.slbCustomerAddress = new SmartControls.SmartLabel();
			this.slbCustomerZipcode = new SmartControls.SmartLabel();
			this.slbCustomerPhone = new SmartControls.SmartLabel();
			this.slbCustomerEmail = new SmartControls.SmartLabel();
			this.btnEditCustomer = new SmartControls.SmartButton();
			this.tlpCustomer.SuspendLayout();
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
			this.tlpCustomer.Controls.Add(this.slbCustomer, 1, 0);
			this.tlpCustomer.Controls.Add(this.slbCustomerNo, 0, 0);
			this.tlpCustomer.Controls.Add(this.slbCustomerBirthday, 1, 1);
			this.tlpCustomer.Controls.Add(this.slbCustomerAddress, 2, 0);
			this.tlpCustomer.Controls.Add(this.slbCustomerZipcode, 2, 1);
			this.tlpCustomer.Controls.Add(this.slbCustomerPhone, 3, 0);
			this.tlpCustomer.Controls.Add(this.slbCustomerEmail, 3, 1);
			this.tlpCustomer.Controls.Add(this.btnEditCustomer, 4, 0);
			this.tlpCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpCustomer.Location = new System.Drawing.Point(0, 0);
			this.tlpCustomer.Margin = new System.Windows.Forms.Padding(2);
			this.tlpCustomer.Name = "tlpCustomer";
			this.tlpCustomer.RowCount = 2;
			this.tlpCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpCustomer.Size = new System.Drawing.Size(600, 49);
			this.tlpCustomer.TabIndex = 0;
			// 
			// slbCustomer
			// 
			this.slbCustomer.AutoSize = true;
			this.slbCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbCustomer.ForeColor = SmartColor.Light;
			this.slbCustomer.Location = new System.Drawing.Point(81, 0);
			this.slbCustomer.Name = "slbCustomer";
			this.slbCustomer.Size = new System.Drawing.Size(138, 24);
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
			this.slbCustomerNo.ForeColor = SmartColor.Light;
			this.slbCustomerNo.Location = new System.Drawing.Point(0, 0);
			this.slbCustomerNo.Name = "slbCustomerNo";
			this.tlpCustomer.SetRowSpan(this.slbCustomerNo, 2);
			this.slbCustomerNo.Size = new System.Drawing.Size(81, 49);
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
			this.slbCustomerBirthday.ForeColor = SmartColor.Light;
			this.slbCustomerBirthday.Location = new System.Drawing.Point(81, 24);
			this.slbCustomerBirthday.Name = "slbCustomerBirthday";
			this.slbCustomerBirthday.Size = new System.Drawing.Size(138, 25);
			this.slbCustomerBirthday.TabIndex = 4;
			this.slbCustomerBirthday.Text = "xx-xxx-xxxx";
			this.slbCustomerBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbCustomerBirthday.Title = "Fødselsdato:";
			this.slbCustomerBirthday.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// slbCustomerAddress
			// 
			this.slbCustomerAddress.AutoSize = true;
			this.slbCustomerAddress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbCustomerAddress.ForeColor = SmartColor.Light;
			this.slbCustomerAddress.Location = new System.Drawing.Point(219, 0);
			this.slbCustomerAddress.Name = "slbCustomerAddress";
			this.slbCustomerAddress.Size = new System.Drawing.Size(152, 24);
			this.slbCustomerAddress.TabIndex = 5;
			this.slbCustomerAddress.Text = "Gadenavn og nummer";
			this.slbCustomerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbCustomerAddress.Title = "Adresse:";
			this.slbCustomerAddress.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// slbCustomerZipcode
			// 
			this.slbCustomerZipcode.AutoSize = true;
			this.slbCustomerZipcode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbCustomerZipcode.ForeColor = SmartColor.Light;
			this.slbCustomerZipcode.Location = new System.Drawing.Point(219, 24);
			this.slbCustomerZipcode.Name = "slbCustomerZipcode";
			this.slbCustomerZipcode.Size = new System.Drawing.Size(152, 25);
			this.slbCustomerZipcode.TabIndex = 6;
			this.slbCustomerZipcode.Text = "xxxx by";
			this.slbCustomerZipcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbCustomerZipcode.Title = "Postnr og by:";
			this.slbCustomerZipcode.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// slbCustomerPhone
			// 
			this.slbCustomerPhone.AutoSize = true;
			this.slbCustomerPhone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbCustomerPhone.ForeColor = SmartColor.Light;
			this.slbCustomerPhone.Location = new System.Drawing.Point(371, 0);
			this.slbCustomerPhone.Name = "slbCustomerPhone";
			this.slbCustomerPhone.Size = new System.Drawing.Size(114, 24);
			this.slbCustomerPhone.TabIndex = 7;
			this.slbCustomerPhone.Text = "xxxx xxxx";
			this.slbCustomerPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbCustomerPhone.Title = "Telefon:";
			this.slbCustomerPhone.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// slbCustomerEmail
			// 
			this.slbCustomerEmail.AutoSize = true;
			this.slbCustomerEmail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbCustomerEmail.ForeColor = SmartColor.Light;
			this.slbCustomerEmail.Location = new System.Drawing.Point(371, 24);
			this.slbCustomerEmail.Name = "slbCustomerEmail";
			this.slbCustomerEmail.Size = new System.Drawing.Size(114, 25);
			this.slbCustomerEmail.TabIndex = 8;
			this.slbCustomerEmail.Text = "xx@xxx.xx";
			this.slbCustomerEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbCustomerEmail.Title = "Email:";
			this.slbCustomerEmail.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// btnEditCustomer
			// 
			this.btnEditCustomer.AutoSize = true;
			this.btnEditCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnEditCustomer.BackColor = SmartColor.Light;
			this.btnEditCustomer.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.btnEditCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnEditCustomer.FlatAppearance.BorderSize = 0;
			this.btnEditCustomer.FlatAppearance.MouseDownBackColor = SmartColor.Dark;
			this.btnEditCustomer.FlatAppearance.MouseOverBackColor = SmartColor.Dark;
			this.btnEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditCustomer.ForeColor = SmartColor.Dark;
			this.btnEditCustomer.Location = new System.Drawing.Point(495, 10);
			this.btnEditCustomer.Margin = new System.Windows.Forms.Padding(10);
			this.btnEditCustomer.Name = "btnEditCustomer";
			this.tlpCustomer.SetRowSpan(this.btnEditCustomer, 2);
			this.btnEditCustomer.Size = new System.Drawing.Size(95, 29);
			this.btnEditCustomer.TabIndex = 9;
			this.btnEditCustomer.Text = "Redigér";
			this.btnEditCustomer.UseVisualStyleBackColor = false;
			// 
			// CustomerLine
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.tlpCustomer);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "CustomerLine";
			this.Size = new System.Drawing.Size(600, 49);
			this.tlpCustomer.ResumeLayout(false);
			this.tlpCustomer.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.TableLayoutPanel tlpCustomer;
        private SmartControls.SmartLabel slbCustomer;
        private SmartControls.SmartLabel slbCustomerNo;
        private SmartControls.SmartLabel slbCustomerBirthday;
        private SmartControls.SmartLabel slbCustomerAddress;
        private SmartControls.SmartLabel slbCustomerZipcode;
        private SmartControls.SmartLabel slbCustomerPhone;
		private SmartControls.SmartLabel slbCustomerEmail;
		private SmartControls.SmartButton btnEditCustomer;
    }
}
