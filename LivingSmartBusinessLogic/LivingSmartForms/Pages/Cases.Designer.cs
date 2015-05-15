namespace LivingSmartForms.Pages
{
	partial class Cases
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
			this.pnlSubmenu = new System.Windows.Forms.Panel();
			this.smartButton1 = new SmartControls.SmartButton();
			this.sblActiveCases = new SmartControls.SmartLabel();
			this.pnlSubmenuBorder = new System.Windows.Forms.Panel();
			this.pnlSubmenuHolder = new System.Windows.Forms.Panel();
			this.pnlSubmenu.SuspendLayout();
			this.pnlSubmenuHolder.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlSubmenu
			// 
			this.pnlSubmenu.Controls.Add(this.smartButton1);
			this.pnlSubmenu.Controls.Add(this.sblActiveCases);
			this.pnlSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubmenu.Location = new System.Drawing.Point(0, 0);
			this.pnlSubmenu.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSubmenu.Name = "pnlSubmenu";
			this.pnlSubmenu.Size = new System.Drawing.Size(1135, 40);
			this.pnlSubmenu.TabIndex = 0;
			// 
			// smartButton1
			// 
			this.smartButton1.AutoSize = true;
			this.smartButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.smartButton1.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.smartButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.smartButton1.FlatAppearance.BorderSize = 0;
			this.smartButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.smartButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.smartButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.smartButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.smartButton1.Location = new System.Drawing.Point(0, 0);
			this.smartButton1.Name = "smartButton1";
			this.smartButton1.Size = new System.Drawing.Size(91, 30);
			this.smartButton1.TabIndex = 2;
			this.smartButton1.Text = "Ny sag";
			this.smartButton1.UseVisualStyleBackColor = false;
			this.smartButton1.Click += new System.EventHandler(this.smartButton1_Click);
			// 
			// sblActiveCases
			// 
			this.sblActiveCases.AutoSize = true;
			this.sblActiveCases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.sblActiveCases.Location = new System.Drawing.Point(101, 7);
			this.sblActiveCases.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.sblActiveCases.Name = "sblActiveCases";
			this.sblActiveCases.Size = new System.Drawing.Size(106, 17);
			this.sblActiveCases.TabIndex = 1;
			this.sblActiveCases.Text = "35";
			this.sblActiveCases.Title = "Aktive sager";
			this.sblActiveCases.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// pnlSubmenuBorder
			// 
			this.pnlSubmenuBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.pnlSubmenuBorder.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubmenuBorder.Location = new System.Drawing.Point(0, 40);
			this.pnlSubmenuBorder.Name = "pnlSubmenuBorder";
			this.pnlSubmenuBorder.Size = new System.Drawing.Size(1135, 2);
			this.pnlSubmenuBorder.TabIndex = 1;
			// 
			// pnlSubmenuHolder
			// 
			this.pnlSubmenuHolder.Controls.Add(this.pnlSubmenuBorder);
			this.pnlSubmenuHolder.Controls.Add(this.pnlSubmenu);
			this.pnlSubmenuHolder.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubmenuHolder.Location = new System.Drawing.Point(0, 0);
			this.pnlSubmenuHolder.Name = "pnlSubmenuHolder";
			this.pnlSubmenuHolder.Size = new System.Drawing.Size(1135, 42);
			this.pnlSubmenuHolder.TabIndex = 2;
			// 
			// Cases
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.pnlSubmenuHolder);
			this.Name = "Cases";
			this.Size = new System.Drawing.Size(1135, 560);
			this.pnlSubmenu.ResumeLayout(false);
			this.pnlSubmenu.PerformLayout();
			this.pnlSubmenuHolder.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlSubmenu;
		private System.Windows.Forms.Panel pnlSubmenuBorder;
		private SmartControls.SmartLabel sblActiveCases;
		private SmartControls.SmartButton smartButton1;
		private System.Windows.Forms.Panel pnlSubmenuHolder;


	}
}
