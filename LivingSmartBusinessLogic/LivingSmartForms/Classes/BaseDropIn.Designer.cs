using System.Windows.Forms;

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
			this.SuspendLayout();
			// 
			// pnlTopBorder
			// 
			this.pnlTopBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.pnlTopBorder.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTopBorder.Location = new System.Drawing.Point(0, 0);
			this.pnlTopBorder.Margin = new System.Windows.Forms.Padding(0);
			this.pnlTopBorder.Name = "pnlTopBorder";
			this.pnlTopBorder.Size = new System.Drawing.Size(400, 2);
			this.pnlTopBorder.TabIndex = 0;
			// 
			// pnlLeftBorder
			// 
			this.pnlLeftBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.pnlLeftBorder.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlLeftBorder.Location = new System.Drawing.Point(0, 2);
			this.pnlLeftBorder.Margin = new System.Windows.Forms.Padding(0);
			this.pnlLeftBorder.Name = "pnlLeftBorder";
			this.pnlLeftBorder.Size = new System.Drawing.Size(2, 498);
			this.pnlLeftBorder.TabIndex = 1;
			// 
			// BaseDropIn
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
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
	}
}
