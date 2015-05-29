using System.Windows.Forms;
using SmartControls;

namespace LivingSmartForms.Classes
{
	partial class BaseDropIn
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
			this.pnlTopBorder = new System.Windows.Forms.Panel();
			this.pnlLeftBorder = new System.Windows.Forms.Panel();
			this.btnClose = new SmartControls.SmartButton();
			this.SuspendLayout();
			// 
			// pnlTopBorder
			// 
			this.pnlTopBorder.BackColor = SmartColor.Dark;
			this.pnlTopBorder.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTopBorder.Location = new System.Drawing.Point(0, 0);
			this.pnlTopBorder.Margin = new System.Windows.Forms.Padding(0);
			this.pnlTopBorder.Name = "pnlTopBorder";
			this.pnlTopBorder.Size = new System.Drawing.Size(400, 2);
			this.pnlTopBorder.TabIndex = 0;
			// 
			// pnlLeftBorder
			// 
			this.pnlLeftBorder.BackColor = SmartColor.Dark;
			this.pnlLeftBorder.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlLeftBorder.Location = new System.Drawing.Point(0, 2);
			this.pnlLeftBorder.Margin = new System.Windows.Forms.Padding(0);
			this.pnlLeftBorder.Name = "pnlLeftBorder";
			this.pnlLeftBorder.Size = new System.Drawing.Size(2, 498);
			this.pnlLeftBorder.TabIndex = 1;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnClose.BackColor = SmartColor.Light;
			this.btnClose.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = SmartColor.Dark;
			this.btnClose.FlatAppearance.MouseOverBackColor = SmartColor.Dark;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.ForeColor = SmartColor.Dark;
			this.btnClose.Location = new System.Drawing.Point(360, 10);
			this.btnClose.Name = "btnClose";
			this.btnClose.Padding = new System.Windows.Forms.Padding(0);
			this.btnClose.Size = new System.Drawing.Size(30, 30);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// BaseDropIn
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pnlLeftBorder);
			this.Controls.Add(this.pnlTopBorder);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "BaseDropIn";
			this.Size = new System.Drawing.Size(400, 500);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlTopBorder;
		private Panel pnlLeftBorder;
		private SmartControls.SmartButton btnClose;
	}
}
