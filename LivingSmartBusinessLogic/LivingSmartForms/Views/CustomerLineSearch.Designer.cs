using SmartControls;

namespace LivingSmartForms.Views
{
    partial class CustomerLineSearch
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
			this.slbCustomerNo = new SmartControls.SmartLabel();
			this.slbCustomer = new SmartControls.SmartLabel();
			this.tlpCustomer = new System.Windows.Forms.TableLayoutPanel();
			this.slbCustomerPhone = new SmartControls.SmartLabel();
			this.pnlLine = new System.Windows.Forms.Panel();
			this.tlpCustomer.SuspendLayout();
			this.SuspendLayout();
			// 
			// slbCustomerNo
			// 
			this.slbCustomerNo.AutoSize = true;
			this.slbCustomerNo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbCustomerNo.ForeColor = SmartColor.Dark;
			this.slbCustomerNo.Location = new System.Drawing.Point(0, 0);
			this.slbCustomerNo.Name = "slbCustomerNo";
			this.tlpCustomer.SetRowSpan(this.slbCustomerNo, 2);
			this.slbCustomerNo.Size = new System.Drawing.Size(141, 44);
			this.slbCustomerNo.TabIndex = 3;
			this.slbCustomerNo.Text = "xxx";
			this.slbCustomerNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbCustomerNo.Title = "Kundenr:";
			this.slbCustomerNo.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// slbCustomer
			// 
			this.slbCustomer.AutoSize = true;
			this.slbCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbCustomer.ForeColor = SmartColor.Dark;
			this.slbCustomer.Location = new System.Drawing.Point(141, 0);
			this.slbCustomer.Name = "slbCustomer";
			this.slbCustomer.Size = new System.Drawing.Size(239, 22);
			this.slbCustomer.TabIndex = 2;
			this.slbCustomer.Text = "Kundens navn";
			this.slbCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbCustomer.Title = "Navn:";
			this.slbCustomer.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// tlpCustomer
			// 
			this.tlpCustomer.ColumnCount = 2;
			this.tlpCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.10543F));
			this.tlpCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.89457F));
			this.tlpCustomer.Controls.Add(this.slbCustomer, 1, 0);
			this.tlpCustomer.Controls.Add(this.slbCustomerNo, 0, 0);
			this.tlpCustomer.Controls.Add(this.slbCustomerPhone, 1, 1);
			this.tlpCustomer.Controls.Add(this.pnlLine, 0, 2);
			this.tlpCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpCustomer.Location = new System.Drawing.Point(0, 0);
			this.tlpCustomer.Margin = new System.Windows.Forms.Padding(2);
			this.tlpCustomer.Name = "tlpCustomer";
			this.tlpCustomer.RowCount = 3;
			this.tlpCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
			this.tlpCustomer.Size = new System.Drawing.Size(380, 50);
			this.tlpCustomer.TabIndex = 0;
			// 
			// slbCustomerPhone
			// 
			this.slbCustomerPhone.AutoSize = true;
			this.slbCustomerPhone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbCustomerPhone.ForeColor = SmartColor.Dark;
			this.slbCustomerPhone.Location = new System.Drawing.Point(141, 22);
			this.slbCustomerPhone.Name = "slbCustomerPhone";
			this.slbCustomerPhone.Size = new System.Drawing.Size(239, 22);
			this.slbCustomerPhone.TabIndex = 7;
			this.slbCustomerPhone.Text = "xxxx xxxx";
			this.slbCustomerPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbCustomerPhone.Title = "Telefon:";
			this.slbCustomerPhone.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// pnlLine
			// 
			this.pnlLine.BackColor = SmartColor.Dark;
			this.tlpCustomer.SetColumnSpan(this.pnlLine, 2);
			this.pnlLine.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlLine.Location = new System.Drawing.Point(0, 49);
			this.pnlLine.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.pnlLine.Name = "pnlLine";
			this.pnlLine.Size = new System.Drawing.Size(380, 1);
			this.pnlLine.TabIndex = 8;
			// 
			// CustomerLineSearch
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.tlpCustomer);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "CustomerLineSearch";
			this.Size = new System.Drawing.Size(380, 50);
			this.tlpCustomer.ResumeLayout(false);
			this.tlpCustomer.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

		private SmartControls.SmartLabel slbCustomerNo;
		private System.Windows.Forms.TableLayoutPanel tlpCustomer;
		private SmartControls.SmartLabel slbCustomer;
		private SmartControls.SmartLabel slbCustomerPhone;
		private System.Windows.Forms.Panel pnlLine;

	}
}
