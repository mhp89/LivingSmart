namespace LivingSmartForms.Pages
{
	partial class Partners
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
			this.btnNewPartner = new SmartControls.SmartButton();
			this.sblActiveCases = new SmartControls.SmartLabel();
			this.clsPartners = new SmartControls.ControlList();
			this.hdrPartners = new SmartControls.Header();
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
			this.pnlSubmenuBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.pnlSubmenuBorder.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubmenuBorder.Location = new System.Drawing.Point(0, 40);
			this.pnlSubmenuBorder.Name = "pnlSubmenuBorder";
			this.pnlSubmenuBorder.Size = new System.Drawing.Size(1135, 2);
			this.pnlSubmenuBorder.TabIndex = 1;
			// 
			// pnlSubmenu
			// 
			this.pnlSubmenu.Controls.Add(this.btnNewPartner);
			this.pnlSubmenu.Controls.Add(this.sblActiveCases);
			this.pnlSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubmenu.Location = new System.Drawing.Point(0, 0);
			this.pnlSubmenu.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSubmenu.Name = "pnlSubmenu";
			this.pnlSubmenu.Size = new System.Drawing.Size(1135, 40);
			this.pnlSubmenu.TabIndex = 0;
			// 
			// btnNewPartner
			// 
			this.btnNewPartner.AutoSize = true;
			this.btnNewPartner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnNewPartner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnNewPartner.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.btnNewPartner.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNewPartner.FlatAppearance.BorderSize = 0;
			this.btnNewPartner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnNewPartner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnNewPartner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewPartner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnNewPartner.Location = new System.Drawing.Point(0, 0);
			this.btnNewPartner.Name = "btnNewPartner";
			this.btnNewPartner.Size = new System.Drawing.Size(111, 30);
			this.btnNewPartner.TabIndex = 2;
			this.btnNewPartner.Text = "Ny partner";
			this.btnNewPartner.UseVisualStyleBackColor = false;
			this.btnNewPartner.Click += new System.EventHandler(this.btnNewEstateAgents_Click);
			// 
			// sblActiveCases
			// 
			this.sblActiveCases.AutoSize = true;
			this.sblActiveCases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.sblActiveCases.Location = new System.Drawing.Point(121, 7);
			this.sblActiveCases.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.sblActiveCases.Name = "sblActiveCases";
			this.sblActiveCases.Size = new System.Drawing.Size(80, 17);
			this.sblActiveCases.TabIndex = 1;
			this.sblActiveCases.Text = "20";
			this.sblActiveCases.Title = "Partner:";
			this.sblActiveCases.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// clsPartners
			// 
			this.clsPartners.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.clsPartners.AutoScroll = true;
			this.clsPartners.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.clsPartners.Location = new System.Drawing.Point(20, 90);
			this.clsPartners.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
			this.clsPartners.Name = "clsPartners";
			this.clsPartners.Size = new System.Drawing.Size(1095, 450);
			this.clsPartners.TabIndex = 6;
			this.clsPartners.WrapContents = false;
			// 
			// hdrPartners
			// 
			this.hdrPartners.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hdrPartners.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.hdrPartners.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.hdrPartners.Location = new System.Drawing.Point(10, 55);
			this.hdrPartners.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
			this.hdrPartners.Name = "hdrPartners";
			this.hdrPartners.Size = new System.Drawing.Size(1115, 25);
			this.hdrPartners.TabIndex = 5;
			this.hdrPartners.Text = "Partner";
			// 
			// Partners
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.pnlSubmenuHolder);
			this.Controls.Add(this.clsPartners);
			this.Controls.Add(this.hdrPartners);
			this.Name = "Partners";
			this.Size = new System.Drawing.Size(1135, 560);
			this.pnlSubmenuHolder.ResumeLayout(false);
			this.pnlSubmenu.ResumeLayout(false);
			this.pnlSubmenu.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private SmartControls.Header hdrPartners;
		private SmartControls.ControlList clsPartners;
		private System.Windows.Forms.Panel pnlSubmenuHolder;
		private System.Windows.Forms.Panel pnlSubmenuBorder;
		private System.Windows.Forms.Panel pnlSubmenu;
		private SmartControls.SmartButton btnNewPartner;
		private SmartControls.SmartLabel sblActiveCases;
	}
}
