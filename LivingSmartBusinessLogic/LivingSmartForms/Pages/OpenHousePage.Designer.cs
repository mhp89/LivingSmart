namespace LivingSmartForms.Pages
{
	partial class OpenHousePage
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
            this.btnMakeSelection = new SmartControls.SmartButton();
            this.btnSelectProperties = new SmartControls.SmartButton();
            this.btnSelectEstateAgents = new SmartControls.SmartButton();
            this.hdrOpenHouse = new SmartControls.Header();
            this.ctcOpenHouse = new SmartControls.ControlCurtain();
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
            this.pnlSubmenu.Controls.Add(this.btnMakeSelection);
            this.pnlSubmenu.Controls.Add(this.btnSelectProperties);
            this.pnlSubmenu.Controls.Add(this.btnSelectEstateAgents);
            this.pnlSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSubmenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSubmenu.Name = "pnlSubmenu";
            this.pnlSubmenu.Size = new System.Drawing.Size(1135, 40);
            this.pnlSubmenu.TabIndex = 0;
            // 
            // btnMakeSelection
            // 
            this.btnMakeSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMakeSelection.AutoSize = true;
            this.btnMakeSelection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMakeSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnMakeSelection.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.btnMakeSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakeSelection.FlatAppearance.BorderSize = 0;
            this.btnMakeSelection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnMakeSelection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnMakeSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnMakeSelection.Location = new System.Drawing.Point(994, 0);
            this.btnMakeSelection.Name = "btnMakeSelection";
            this.btnMakeSelection.Size = new System.Drawing.Size(141, 30);
            this.btnMakeSelection.TabIndex = 4;
            this.btnMakeSelection.Text = "Lav tildeling";
            this.btnMakeSelection.UseVisualStyleBackColor = false;
            this.btnMakeSelection.Click += new System.EventHandler(this.btnMakeSelection_Click);
            // 
            // btnSelectProperties
            // 
            this.btnSelectProperties.AutoSize = true;
            this.btnSelectProperties.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnSelectProperties.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.btnSelectProperties.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectProperties.FlatAppearance.BorderSize = 0;
            this.btnSelectProperties.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnSelectProperties.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnSelectProperties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectProperties.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnSelectProperties.Location = new System.Drawing.Point(171, 0);
            this.btnSelectProperties.Name = "btnSelectProperties";
            this.btnSelectProperties.Size = new System.Drawing.Size(185, 30);
            this.btnSelectProperties.TabIndex = 3;
            this.btnSelectProperties.Text = "Vælg ejendomme";
            this.btnSelectProperties.UseVisualStyleBackColor = false;
            this.btnSelectProperties.Click += new System.EventHandler(this.btnSelectProperties_Click);
            // 
            // btnSelectEstateAgents
            // 
            this.btnSelectEstateAgents.AutoSize = true;
            this.btnSelectEstateAgents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectEstateAgents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnSelectEstateAgents.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.btnSelectEstateAgents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectEstateAgents.FlatAppearance.BorderSize = 0;
            this.btnSelectEstateAgents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnSelectEstateAgents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnSelectEstateAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectEstateAgents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnSelectEstateAgents.Location = new System.Drawing.Point(0, 0);
            this.btnSelectEstateAgents.Name = "btnSelectEstateAgents";
            this.btnSelectEstateAgents.Size = new System.Drawing.Size(161, 30);
            this.btnSelectEstateAgents.TabIndex = 2;
            this.btnSelectEstateAgents.Text = "Vælg mæglere";
            this.btnSelectEstateAgents.UseVisualStyleBackColor = false;
            this.btnSelectEstateAgents.Click += new System.EventHandler(this.btnSelectEstateAgents_Click);
            // 
            // hdrOpenHouse
            // 
            this.hdrOpenHouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hdrOpenHouse.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.hdrOpenHouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hdrOpenHouse.Location = new System.Drawing.Point(10, 55);
            this.hdrOpenHouse.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.hdrOpenHouse.Name = "hdrOpenHouse";
            this.hdrOpenHouse.Size = new System.Drawing.Size(1115, 25);
            this.hdrOpenHouse.TabIndex = 5;
            this.hdrOpenHouse.Text = "Åbent hus";
            // 
            // ctcOpenHouse
            // 
            this.ctcOpenHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctcOpenHouse.AutoScroll = true;
            this.ctcOpenHouse.Location = new System.Drawing.Point(20, 90);
            this.ctcOpenHouse.Name = "ctcOpenHouse";
            this.ctcOpenHouse.Size = new System.Drawing.Size(1095, 450);
            this.ctcOpenHouse.Spacing = 30;
            this.ctcOpenHouse.TabIndex = 8;
            this.ctcOpenHouse.WrapContents = false;
            // 
            // OpenHousePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.ctcOpenHouse);
            this.Controls.Add(this.pnlSubmenuHolder);
            this.Controls.Add(this.hdrOpenHouse);
            this.Name = "OpenHousePage";
            this.Size = new System.Drawing.Size(1135, 560);
            this.pnlSubmenuHolder.ResumeLayout(false);
            this.pnlSubmenu.ResumeLayout(false);
            this.pnlSubmenu.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

        private SmartControls.Header hdrOpenHouse;
		private System.Windows.Forms.Panel pnlSubmenuHolder;
		private System.Windows.Forms.Panel pnlSubmenuBorder;
		private System.Windows.Forms.Panel pnlSubmenu;
        private SmartControls.SmartButton btnSelectEstateAgents;
        private SmartControls.SmartButton btnMakeSelection;
        private SmartControls.SmartButton btnSelectProperties;
        private SmartControls.ControlCurtain ctcOpenHouse;
	}
}
