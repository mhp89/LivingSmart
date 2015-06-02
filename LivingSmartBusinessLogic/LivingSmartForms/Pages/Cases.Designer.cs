using SmartControls;

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
			this.pnlSubmenuHolder = new System.Windows.Forms.Panel();
			this.pnlSubmenuBorder = new System.Windows.Forms.Panel();
			this.pnlSubmenu = new System.Windows.Forms.Panel();
			this.btnNewCase = new SmartControls.SmartButton();
			this.sblActiveCases = new SmartControls.SmartLabel();
			this.clsCases = new SmartControls.ControlList();
			this.hdrCases = new SmartControls.Header();
			this.pnlSubmenuHolder.SuspendLayout();
			this.pnlSubmenu.SuspendLayout();
			this.SuspendLayout();
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
			// pnlSubmenuBorder
			// 
			this.pnlSubmenuBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.pnlSubmenuBorder.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubmenuBorder.Location = new System.Drawing.Point(0, 40);
			this.pnlSubmenuBorder.Name = "pnlSubmenuBorder";
			this.pnlSubmenuBorder.Size = new System.Drawing.Size(1135, 2);
			this.pnlSubmenuBorder.TabIndex = 1;
			// 
			// pnlSubmenu
			// 
			this.pnlSubmenu.Controls.Add(this.btnNewCase);
			this.pnlSubmenu.Controls.Add(this.sblActiveCases);
			this.pnlSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubmenu.Location = new System.Drawing.Point(0, 0);
			this.pnlSubmenu.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSubmenu.Name = "pnlSubmenu";
			this.pnlSubmenu.Size = new System.Drawing.Size(1135, 40);
			this.pnlSubmenu.TabIndex = 0;
			// 
			// btnNewCase
			// 
			this.btnNewCase.AutoSize = true;
			this.btnNewCase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnNewCase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnNewCase.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.btnNewCase.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNewCase.FlatAppearance.BorderSize = 0;
			this.btnNewCase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnNewCase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnNewCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewCase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnNewCase.Location = new System.Drawing.Point(0, 0);
			this.btnNewCase.Name = "btnNewCase";
			this.btnNewCase.Size = new System.Drawing.Size(89, 30);
			this.btnNewCase.TabIndex = 2;
			this.btnNewCase.Text = "Ny sag";
			this.btnNewCase.UseVisualStyleBackColor = false;
			this.btnNewCase.Click += new System.EventHandler(this.btnNewCase_Click);
			// 
			// sblActiveCases
			// 
			this.sblActiveCases.AutoSize = true;
			this.sblActiveCases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.sblActiveCases.Location = new System.Drawing.Point(99, 7);
			this.sblActiveCases.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.sblActiveCases.Name = "sblActiveCases";
			this.sblActiveCases.Size = new System.Drawing.Size(111, 17);
			this.sblActiveCases.TabIndex = 1;
			this.sblActiveCases.Text = "35";
			this.sblActiveCases.Title = "Aktive sager:";
			this.sblActiveCases.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// clsCases
			// 
			this.clsCases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.clsCases.AutoScroll = true;
			this.clsCases.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.clsCases.Location = new System.Drawing.Point(20, 90);
			this.clsCases.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
			this.clsCases.Name = "clsCases";
			this.clsCases.Size = new System.Drawing.Size(1095, 450);
			this.clsCases.Spacing = 5;
			this.clsCases.TabIndex = 8;
			this.clsCases.WrapContents = false;
			// 
			// hdrCases
			// 
			this.hdrCases.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hdrCases.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.hdrCases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.hdrCases.Location = new System.Drawing.Point(10, 55);
			this.hdrCases.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
			this.hdrCases.Name = "hdrCases";
			this.hdrCases.Size = new System.Drawing.Size(1115, 25);
			this.hdrCases.TabIndex = 7;
			this.hdrCases.Text = "Sager";
			// 
			// Cases
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.clsCases);
			this.Controls.Add(this.hdrCases);
			this.Controls.Add(this.pnlSubmenuHolder);
			this.Name = "Cases";
			this.Size = new System.Drawing.Size(1135, 560);
			this.pnlSubmenuHolder.ResumeLayout(false);
			this.pnlSubmenu.ResumeLayout(false);
			this.pnlSubmenu.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlSubmenu;
		private System.Windows.Forms.Panel pnlSubmenuBorder;
		private SmartControls.SmartLabel sblActiveCases;
		private SmartControls.SmartButton btnNewCase;
		private System.Windows.Forms.Panel pnlSubmenuHolder;
		private SmartControls.ControlList clsCases;
		private SmartControls.Header hdrCases;


	}
}
