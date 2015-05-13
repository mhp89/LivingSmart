namespace LivingSmartForms.DropIns
{
	partial class NewCaseDropIn
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
			this.pnlSubmenuHolder = new System.Windows.Forms.Panel();
			this.pnlSubmenuBorder = new System.Windows.Forms.Panel();
			this.pnlSubmenu = new System.Windows.Forms.Panel();
			this.smartButton1 = new SmartControls.SmartButton();
			this.sblActiveCases = new SmartControls.SmartLabel();
			this.smartLabel2 = new SmartControls.SmartLabel();
			this.pnlSubmenuHolder.SuspendLayout();
			this.pnlSubmenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlSubmenuHolder
			// 
			this.pnlSubmenuHolder.Controls.Add(this.pnlSubmenuBorder);
			this.pnlSubmenuHolder.Controls.Add(this.pnlSubmenu);
			this.pnlSubmenuHolder.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubmenuHolder.Location = new System.Drawing.Point(2, 2);
			this.pnlSubmenuHolder.Name = "pnlSubmenuHolder";
			this.pnlSubmenuHolder.Size = new System.Drawing.Size(498, 50);
			this.pnlSubmenuHolder.TabIndex = 5;
			// 
			// pnlSubmenuBorder
			// 
			this.pnlSubmenuBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.pnlSubmenuBorder.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubmenuBorder.Location = new System.Drawing.Point(0, 48);
			this.pnlSubmenuBorder.Name = "pnlSubmenuBorder";
			this.pnlSubmenuBorder.Size = new System.Drawing.Size(498, 2);
			this.pnlSubmenuBorder.TabIndex = 1;
			// 
			// pnlSubmenu
			// 
			this.pnlSubmenu.Controls.Add(this.smartButton1);
			this.pnlSubmenu.Controls.Add(this.sblActiveCases);
			this.pnlSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubmenu.Location = new System.Drawing.Point(0, 0);
			this.pnlSubmenu.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSubmenu.Name = "pnlSubmenu";
			this.pnlSubmenu.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.pnlSubmenu.Size = new System.Drawing.Size(498, 48);
			this.pnlSubmenu.TabIndex = 0;
			// 
			// smartButton1
			// 
			this.smartButton1.AutoSize = true;
			this.smartButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.smartButton1.Color = SmartControls.MenuButton.ColorStyle.Dark;
			this.smartButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.smartButton1.FlatAppearance.BorderSize = 0;
			this.smartButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.smartButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.smartButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.smartButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.smartButton1.Location = new System.Drawing.Point(10, 8);
			this.smartButton1.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
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
			this.sblActiveCases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.sblActiveCases.Location = new System.Drawing.Point(111, 15);
			this.sblActiveCases.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.sblActiveCases.Name = "sblActiveCases";
			this.sblActiveCases.Size = new System.Drawing.Size(106, 17);
			this.sblActiveCases.TabIndex = 1;
			this.sblActiveCases.Text = "35";
			this.sblActiveCases.Title = "Aktive sager";
			this.sblActiveCases.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// smartLabel2
			// 
			this.smartLabel2.AutoSize = true;
			this.smartLabel2.Location = new System.Drawing.Point(10, 64);
			this.smartLabel2.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.smartLabel2.Name = "smartLabel2";
			this.smartLabel2.Size = new System.Drawing.Size(115, 17);
			this.smartLabel2.TabIndex = 4;
			this.smartLabel2.Text = "smartLabel2";
			this.smartLabel2.Title = "Title";
			this.smartLabel2.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// NewCaseDropIn
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.pnlSubmenuHolder);
			this.Controls.Add(this.smartLabel2);
			this.Name = "NewCaseDropIn";
			this.Size = new System.Drawing.Size(500, 600);
			this.Controls.SetChildIndex(this.smartLabel2, 0);
			this.Controls.SetChildIndex(this.pnlSubmenuHolder, 0);
			this.pnlSubmenuHolder.ResumeLayout(false);
			this.pnlSubmenu.ResumeLayout(false);
			this.pnlSubmenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private SmartControls.SmartLabel smartLabel2;
		private System.Windows.Forms.Panel pnlSubmenuHolder;
		private System.Windows.Forms.Panel pnlSubmenuBorder;
		private System.Windows.Forms.Panel pnlSubmenu;
		private SmartControls.SmartButton smartButton1;
		private SmartControls.SmartLabel sblActiveCases;


	}
}
