using SmartControls;

namespace LivingSmartForms.Pages
{
	partial class EstateAgents
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
			this.btnNewEstateAgents = new SmartControls.SmartButton();
			this.sblActiveCases = new SmartControls.SmartLabel();
			this.clsEstateAgents = new SmartControls.ControlList();
			this.hdrEstateAgents = new SmartControls.Header();
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
			this.pnlSubmenuHolder.TabIndex = 7;
			// 
			// pnlSubmenuBorder
			// 
			this.pnlSubmenuBorder.BackColor = SmartColor.Light;
			this.pnlSubmenuBorder.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubmenuBorder.Location = new System.Drawing.Point(0, 40);
			this.pnlSubmenuBorder.Name = "pnlSubmenuBorder";
			this.pnlSubmenuBorder.Size = new System.Drawing.Size(1135, 2);
			this.pnlSubmenuBorder.TabIndex = 1;
			// 
			// pnlSubmenu
			// 
			this.pnlSubmenu.Controls.Add(this.btnNewEstateAgents);
			this.pnlSubmenu.Controls.Add(this.sblActiveCases);
			this.pnlSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubmenu.Location = new System.Drawing.Point(0, 0);
			this.pnlSubmenu.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSubmenu.Name = "pnlSubmenu";
			this.pnlSubmenu.Size = new System.Drawing.Size(1135, 40);
			this.pnlSubmenu.TabIndex = 0;
			// 
			// btnNewEstateAgents
			// 
			this.btnNewEstateAgents.AutoSize = true;
			this.btnNewEstateAgents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnNewEstateAgents.BackColor = SmartColor.Light;
			this.btnNewEstateAgents.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.btnNewEstateAgents.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNewEstateAgents.FlatAppearance.BorderSize = 0;
			this.btnNewEstateAgents.FlatAppearance.MouseDownBackColor = SmartColor.Dark;
			this.btnNewEstateAgents.FlatAppearance.MouseOverBackColor = SmartColor.Dark;
			this.btnNewEstateAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewEstateAgents.ForeColor = SmartColor.Dark;
			this.btnNewEstateAgents.Location = new System.Drawing.Point(0, 0);
			this.btnNewEstateAgents.Name = "btnNewEstateAgents";
			this.btnNewEstateAgents.Size = new System.Drawing.Size(113, 30);
			this.btnNewEstateAgents.TabIndex = 2;
			this.btnNewEstateAgents.Text = "Ny mægler";
			this.btnNewEstateAgents.UseVisualStyleBackColor = false;
			this.btnNewEstateAgents.Click += new System.EventHandler(this.btnNewEstateAgents_Click);
			// 
			// sblActiveCases
			// 
			this.sblActiveCases.AutoSize = true;
			this.sblActiveCases.ForeColor = SmartColor.Light;
			this.sblActiveCases.Location = new System.Drawing.Point(123, 7);
			this.sblActiveCases.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.sblActiveCases.Name = "sblActiveCases";
			this.sblActiveCases.Size = new System.Drawing.Size(82, 17);
			this.sblActiveCases.TabIndex = 1;
			this.sblActiveCases.Text = "20";
			this.sblActiveCases.Title = "Mægler:";
			this.sblActiveCases.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// clsEstateAgents
			// 
			this.clsEstateAgents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.clsEstateAgents.AutoScroll = true;
			this.clsEstateAgents.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.clsEstateAgents.Location = new System.Drawing.Point(20, 90);
			this.clsEstateAgents.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
			this.clsEstateAgents.Name = "clsEstateAgents";
			this.clsEstateAgents.Size = new System.Drawing.Size(1095, 450);
			this.clsEstateAgents.TabIndex = 6;
			this.clsEstateAgents.WrapContents = false;
			// 
			// hdrEstateAgents
			// 
			this.hdrEstateAgents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hdrEstateAgents.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.hdrEstateAgents.ForeColor = SmartColor.Light;
			this.hdrEstateAgents.Location = new System.Drawing.Point(10, 55);
			this.hdrEstateAgents.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
			this.hdrEstateAgents.Name = "hdrEstateAgents";
			this.hdrEstateAgents.Size = new System.Drawing.Size(1115, 25);
			this.hdrEstateAgents.TabIndex = 5;
			this.hdrEstateAgents.Text = "Mægler";
			// 
			// EstateAgents
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.pnlSubmenuHolder);
			this.Controls.Add(this.clsEstateAgents);
			this.Controls.Add(this.hdrEstateAgents);
			this.Name = "EstateAgents";
			this.Size = new System.Drawing.Size(1135, 560);
			this.pnlSubmenuHolder.ResumeLayout(false);
			this.pnlSubmenu.ResumeLayout(false);
			this.pnlSubmenu.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private SmartControls.Header hdrEstateAgents;
		private SmartControls.ControlList clsEstateAgents;
		private System.Windows.Forms.Panel pnlSubmenuHolder;
		private System.Windows.Forms.Panel pnlSubmenuBorder;
		private System.Windows.Forms.Panel pnlSubmenu;
		private SmartControls.SmartButton btnNewEstateAgents;
		private SmartControls.SmartLabel sblActiveCases;
	}
}
