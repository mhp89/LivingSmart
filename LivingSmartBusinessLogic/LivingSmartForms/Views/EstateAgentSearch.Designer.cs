namespace LivingSmartForms.Views
{
	partial class EstateAgentSearch
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
			this.slbName = new SmartControls.SmartLabel();
			this.slbEstateAgentNo = new SmartControls.SmartLabel();
			this.slbPhone = new SmartControls.SmartLabel();
			this.tlpCustomer = new System.Windows.Forms.TableLayoutPanel();
			this.pnlLine = new System.Windows.Forms.Panel();
			this.tlpCustomer.SuspendLayout();
			this.SuspendLayout();
			// 
			// slbName
			// 
			this.slbName.AutoSize = true;
			this.slbName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.slbName.Location = new System.Drawing.Point(141, 0);
			this.slbName.Name = "slbName";
			this.slbName.Size = new System.Drawing.Size(239, 22);
			this.slbName.TabIndex = 2;
			this.slbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbName.Title = "Navn:";
			this.slbName.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// slbEstateAgentNo
			// 
			this.slbEstateAgentNo.AutoSize = true;
			this.slbEstateAgentNo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbEstateAgentNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.slbEstateAgentNo.Location = new System.Drawing.Point(0, 0);
			this.slbEstateAgentNo.Name = "slbEstateAgentNo";
			this.tlpCustomer.SetRowSpan(this.slbEstateAgentNo, 2);
			this.slbEstateAgentNo.Size = new System.Drawing.Size(141, 44);
			this.slbEstateAgentNo.TabIndex = 3;
			this.slbEstateAgentNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbEstateAgentNo.Title = "Id:";
			this.slbEstateAgentNo.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// slbPhone
			// 
			this.slbPhone.AutoSize = true;
			this.slbPhone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.slbPhone.Location = new System.Drawing.Point(141, 22);
			this.slbPhone.Name = "slbPhone";
			this.slbPhone.Size = new System.Drawing.Size(239, 22);
			this.slbPhone.TabIndex = 7;
			this.slbPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbPhone.Title = "Telefon:";
			this.slbPhone.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// tlpCustomer
			// 
			this.tlpCustomer.ColumnCount = 2;
			this.tlpCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.10543F));
			this.tlpCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.89457F));
			this.tlpCustomer.Controls.Add(this.slbName, 1, 0);
			this.tlpCustomer.Controls.Add(this.slbEstateAgentNo, 0, 0);
			this.tlpCustomer.Controls.Add(this.slbPhone, 1, 1);
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
			this.tlpCustomer.TabIndex = 1;
			// 
			// pnlLine
			// 
			this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.tlpCustomer.SetColumnSpan(this.pnlLine, 2);
			this.pnlLine.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlLine.Location = new System.Drawing.Point(0, 49);
			this.pnlLine.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.pnlLine.Name = "pnlLine";
			this.pnlLine.Size = new System.Drawing.Size(380, 1);
			this.pnlLine.TabIndex = 8;
			// 
			// EstateAgentSimple
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tlpCustomer);
			this.Name = "EstateAgentSimple";
			this.Size = new System.Drawing.Size(380, 50);
			this.tlpCustomer.ResumeLayout(false);
			this.tlpCustomer.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private SmartControls.SmartLabel slbName;
		private SmartControls.SmartLabel slbEstateAgentNo;
		private System.Windows.Forms.TableLayoutPanel tlpCustomer;
		private SmartControls.SmartLabel slbPhone;
		private System.Windows.Forms.Panel pnlLine;
	}
}
