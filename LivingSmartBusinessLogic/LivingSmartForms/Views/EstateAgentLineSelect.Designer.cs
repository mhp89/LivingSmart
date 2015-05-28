namespace LivingSmartForms.Views
{
    partial class EstateAgentLineSelect
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
            this.tlpEstateAgentId = new System.Windows.Forms.TableLayoutPanel();
            this.slbEstateAgentName = new SmartControls.SmartLabel();
            this.slbCustomerNo = new SmartControls.SmartLabel();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.tlpEstateAgentId.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpEstateAgentId
            // 
            this.tlpEstateAgentId.ColumnCount = 2;
            this.tlpEstateAgentId.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.05263F));
            this.tlpEstateAgentId.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.94736F));
            this.tlpEstateAgentId.Controls.Add(this.slbCustomerNo, 0, 0);
            this.tlpEstateAgentId.Controls.Add(this.slbEstateAgentName, 1, 0);
            this.tlpEstateAgentId.Controls.Add(this.pnlLine, 0, 1);
            this.tlpEstateAgentId.Location = new System.Drawing.Point(0, 0);
            this.tlpEstateAgentId.Margin = new System.Windows.Forms.Padding(2);
            this.tlpEstateAgentId.Name = "tlpEstateAgentId";
            this.tlpEstateAgentId.RowCount = 2;
            this.tlpEstateAgentId.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEstateAgentId.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tlpEstateAgentId.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tlpEstateAgentId.Size = new System.Drawing.Size(380, 30);
            this.tlpEstateAgentId.TabIndex = 1;
            // 
            // slbEstateAgentName
            // 
            this.slbEstateAgentName.AutoSize = true;
            this.slbEstateAgentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slbEstateAgentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.slbEstateAgentName.Location = new System.Drawing.Point(98, 0);
            this.slbEstateAgentName.Name = "slbEstateAgentName";
            this.slbEstateAgentName.Size = new System.Drawing.Size(282, 24);
            this.slbEstateAgentName.TabIndex = 2;
            this.slbEstateAgentName.Text = "Mæglers navn";
            this.slbEstateAgentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slbEstateAgentName.Title = "Navn:";
            this.slbEstateAgentName.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            // 
            // slbCustomerNo
            // 
            this.slbCustomerNo.AutoSize = true;
            this.slbCustomerNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slbCustomerNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.slbCustomerNo.Location = new System.Drawing.Point(0, 0);
            this.slbCustomerNo.Name = "slbCustomerNo";
            this.slbCustomerNo.Size = new System.Drawing.Size(98, 24);
            this.slbCustomerNo.TabIndex = 3;
            this.slbCustomerNo.Text = "xxx";
            this.slbCustomerNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slbCustomerNo.Title = "Id:";
            this.slbCustomerNo.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.tlpEstateAgentId.SetColumnSpan(this.pnlLine, 2);
            this.pnlLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLine.Location = new System.Drawing.Point(0, 29);
            this.pnlLine.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(380, 1);
            this.pnlLine.TabIndex = 8;
            // 
            // EstateAgentSearchLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpEstateAgentId);
            this.Name = "EstateAgentSearchLine";
            this.Size = new System.Drawing.Size(380, 30);
            this.tlpEstateAgentId.ResumeLayout(false);
            this.tlpEstateAgentId.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEstateAgentId;
        private SmartControls.SmartLabel slbEstateAgentName;
        private SmartControls.SmartLabel slbCustomerNo;
        private System.Windows.Forms.Panel pnlLine;

    }
}
