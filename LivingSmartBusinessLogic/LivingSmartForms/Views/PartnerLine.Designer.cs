namespace LivingSmartForms.Views
{
    partial class PartnerLine
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
            this.DeleteThisButton = new System.Windows.Forms.Button();
            this.tlpPartner = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEditPartner = new System.Windows.Forms.Panel();
            this.btnEditPartner = new System.Windows.Forms.Button();
            this.slbParterName = new SmartControls.SmartLabel();
            this.slbPartnerAddress = new SmartControls.SmartLabel();
            this.slbPartnerPhone = new SmartControls.SmartLabel();
            this.slbPartnerEmail = new SmartControls.SmartLabel();
            this.tlpPartner.SuspendLayout();
            this.pnlEditPartner.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteThisButton
            // 
            this.DeleteThisButton.Location = new System.Drawing.Point(278, 1);
            this.DeleteThisButton.Name = "DeleteThisButton";
            this.DeleteThisButton.Size = new System.Drawing.Size(75, 39);
            this.DeleteThisButton.TabIndex = 0;
            this.DeleteThisButton.Text = "Rediger";
            this.DeleteThisButton.UseVisualStyleBackColor = true;
            // 
            // tlpPartner
            // 
            this.tlpPartner.ColumnCount = 3;
            this.tlpPartner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.5F));
            this.tlpPartner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.375F));
            this.tlpPartner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tlpPartner.Controls.Add(this.pnlEditPartner, 2, 0);
            this.tlpPartner.Controls.Add(this.slbParterName, 0, 0);
            this.tlpPartner.Controls.Add(this.slbPartnerAddress, 0, 1);
            this.tlpPartner.Controls.Add(this.slbPartnerPhone, 1, 0);
            this.tlpPartner.Controls.Add(this.slbPartnerEmail, 1, 1);
            this.tlpPartner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPartner.Location = new System.Drawing.Point(0, 0);
            this.tlpPartner.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPartner.Name = "tlpPartner";
            this.tlpPartner.RowCount = 2;
            this.tlpPartner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPartner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPartner.Size = new System.Drawing.Size(600, 49);
            this.tlpPartner.TabIndex = 0;
            // 
            // pnlEditPartner
            // 
            this.pnlEditPartner.Controls.Add(this.btnEditPartner);
            this.pnlEditPartner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditPartner.Location = new System.Drawing.Point(533, 0);
            this.pnlEditPartner.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEditPartner.Name = "pnlEditPartner";
            this.tlpPartner.SetRowSpan(this.pnlEditPartner, 2);
            this.pnlEditPartner.Size = new System.Drawing.Size(67, 49);
            this.pnlEditPartner.TabIndex = 0;
            // 
            // btnEditPartner
            // 
            this.btnEditPartner.Location = new System.Drawing.Point(6, 8);
            this.btnEditPartner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditPartner.Name = "btnEditPartner";
            this.btnEditPartner.Size = new System.Drawing.Size(56, 32);
            this.btnEditPartner.TabIndex = 0;
            this.btnEditPartner.Text = "Rediger";
            this.btnEditPartner.UseVisualStyleBackColor = true;
            // 
            // slbParterName
            // 
            this.slbParterName.AutoSize = true;
            this.slbParterName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slbParterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.slbParterName.Location = new System.Drawing.Point(0, 0);
            this.slbParterName.Name = "slbParterName";
            this.slbParterName.Size = new System.Drawing.Size(267, 24);
            this.slbParterName.TabIndex = 1;
            this.slbParterName.Text = "Partner company name";
            this.slbParterName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slbParterName.Title = "Company:";
            this.slbParterName.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            // 
            // slbPartnerAddress
            // 
            this.slbPartnerAddress.AutoSize = true;
            this.slbPartnerAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slbPartnerAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.slbPartnerAddress.Location = new System.Drawing.Point(0, 24);
            this.slbPartnerAddress.Name = "slbPartnerAddress";
            this.slbPartnerAddress.Size = new System.Drawing.Size(267, 25);
            this.slbPartnerAddress.TabIndex = 2;
            this.slbPartnerAddress.Text = "Partner company address";
            this.slbPartnerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slbPartnerAddress.Title = "Address:";
            this.slbPartnerAddress.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            // 
            // slbPartnerPhone
            // 
            this.slbPartnerPhone.AutoSize = true;
            this.slbPartnerPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slbPartnerPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.slbPartnerPhone.Location = new System.Drawing.Point(267, 0);
            this.slbPartnerPhone.Name = "slbPartnerPhone";
            this.slbPartnerPhone.Size = new System.Drawing.Size(266, 24);
            this.slbPartnerPhone.TabIndex = 3;
            this.slbPartnerPhone.Text = "+1 xxx-xxx-xxx";
            this.slbPartnerPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slbPartnerPhone.Title = "Phone number:";
            this.slbPartnerPhone.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            // 
            // slbPartnerEmail
            // 
            this.slbPartnerEmail.AutoSize = true;
            this.slbPartnerEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slbPartnerEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.slbPartnerEmail.Location = new System.Drawing.Point(267, 24);
            this.slbPartnerEmail.Name = "slbPartnerEmail";
            this.slbPartnerEmail.Size = new System.Drawing.Size(266, 25);
            this.slbPartnerEmail.TabIndex = 4;
            this.slbPartnerEmail.Text = "contact@xxxxxxx.com";
            this.slbPartnerEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slbPartnerEmail.Title = "Email:";
            this.slbPartnerEmail.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            // 
            // PartnerLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tlpPartner);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PartnerLine";
            this.Size = new System.Drawing.Size(600, 49);
            this.tlpPartner.ResumeLayout(false);
            this.tlpPartner.PerformLayout();
            this.pnlEditPartner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteThisButton;
        private System.Windows.Forms.TableLayoutPanel tlpPartner;
        private System.Windows.Forms.Panel pnlEditPartner;
        private System.Windows.Forms.Button btnEditPartner;
        private SmartControls.SmartLabel slbParterName;
        private SmartControls.SmartLabel slbPartnerAddress;
        private SmartControls.SmartLabel slbPartnerPhone;
        private SmartControls.SmartLabel slbPartnerEmail;
    }
}
