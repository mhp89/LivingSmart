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
			this.slbEstateAgentId = new SmartControls.SmartLabel();
			this.slbEstateAgentName = new SmartControls.SmartLabel();
			this.pnlLine = new System.Windows.Forms.Panel();
			this.tlpEstateAgentId.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpEstateAgentId
			// 
			this.tlpEstateAgentId.ColumnCount = 2;
			this.tlpEstateAgentId.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.15789F));
			this.tlpEstateAgentId.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.8421F));
			this.tlpEstateAgentId.Controls.Add(this.slbEstateAgentId, 0, 0);
			this.tlpEstateAgentId.Controls.Add(this.slbEstateAgentName, 1, 0);
			this.tlpEstateAgentId.Controls.Add(this.pnlLine, 0, 1);
			this.tlpEstateAgentId.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpEstateAgentId.Location = new System.Drawing.Point(0, 0);
			this.tlpEstateAgentId.Margin = new System.Windows.Forms.Padding(2);
			this.tlpEstateAgentId.Name = "tlpEstateAgentId";
			this.tlpEstateAgentId.RowCount = 2;
			this.tlpEstateAgentId.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpEstateAgentId.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
			this.tlpEstateAgentId.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
			this.tlpEstateAgentId.Size = new System.Drawing.Size(270, 24);
			this.tlpEstateAgentId.TabIndex = 1;
			// 
			// slbEstateAgentId
			// 
			this.slbEstateAgentId.AutoSize = true;
			this.slbEstateAgentId.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbEstateAgentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.slbEstateAgentId.Location = new System.Drawing.Point(0, 0);
			this.slbEstateAgentId.Name = "slbEstateAgentId";
			this.slbEstateAgentId.Size = new System.Drawing.Size(62, 19);
			this.slbEstateAgentId.TabIndex = 3;
			this.slbEstateAgentId.Text = "xxx";
			this.slbEstateAgentId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbEstateAgentId.Title = "Id:";
			this.slbEstateAgentId.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// slbEstateAgentName
			// 
			this.slbEstateAgentName.AutoSize = true;
			this.slbEstateAgentName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbEstateAgentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.slbEstateAgentName.Location = new System.Drawing.Point(62, 0);
			this.slbEstateAgentName.Name = "slbEstateAgentName";
			this.slbEstateAgentName.Size = new System.Drawing.Size(208, 19);
			this.slbEstateAgentName.TabIndex = 2;
			this.slbEstateAgentName.Text = "Mæglers navn";
			this.slbEstateAgentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbEstateAgentName.Title = "Navn:";
			this.slbEstateAgentName.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// pnlLine
			// 
			this.pnlLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.tlpEstateAgentId.SetColumnSpan(this.pnlLine, 2);
			this.pnlLine.Location = new System.Drawing.Point(0, 23);
			this.pnlLine.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
			this.pnlLine.Name = "pnlLine";
			this.pnlLine.Size = new System.Drawing.Size(270, 1);
			this.pnlLine.TabIndex = 8;
			// 
			// EstateAgentLineSelect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tlpEstateAgentId);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "EstateAgentLineSelect";
			this.Size = new System.Drawing.Size(270, 24);
			this.tlpEstateAgentId.ResumeLayout(false);
			this.tlpEstateAgentId.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEstateAgentId;
        private SmartControls.SmartLabel slbEstateAgentName;
        private SmartControls.SmartLabel slbEstateAgentId;
        private System.Windows.Forms.Panel pnlLine;

    }
}
