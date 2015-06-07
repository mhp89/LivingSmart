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
			this.stbYear = new SmartControls.SmartTextBox();
			this.btnStatisticsPrEstateAgent = new SmartControls.SmartButton();
			this.btnAllStatistics = new SmartControls.SmartButton();
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
			this.pnlSubmenuBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.pnlSubmenuBorder.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubmenuBorder.Location = new System.Drawing.Point(0, 40);
			this.pnlSubmenuBorder.Name = "pnlSubmenuBorder";
			this.pnlSubmenuBorder.Size = new System.Drawing.Size(1135, 2);
			this.pnlSubmenuBorder.TabIndex = 1;
			// 
			// pnlSubmenu
			// 
			this.pnlSubmenu.Controls.Add(this.stbYear);
			this.pnlSubmenu.Controls.Add(this.btnStatisticsPrEstateAgent);
			this.pnlSubmenu.Controls.Add(this.btnAllStatistics);
			this.pnlSubmenu.Controls.Add(this.btnNewEstateAgents);
			this.pnlSubmenu.Controls.Add(this.sblActiveCases);
			this.pnlSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubmenu.Location = new System.Drawing.Point(0, 0);
			this.pnlSubmenu.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSubmenu.Name = "pnlSubmenu";
			this.pnlSubmenu.Size = new System.Drawing.Size(1135, 40);
			this.pnlSubmenu.TabIndex = 0;
			// 
			// stbYear
			// 
			this.stbYear.AllowComma = false;
			this.stbYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.stbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbYear.AutomaticValidation = true;
			this.stbYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbYear.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbYear.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbYear.Location = new System.Drawing.Point(933, 0);
			this.stbYear.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
			this.stbYear.MaxLength = 4;
			this.stbYear.MinLength = 4;
			this.stbYear.Multiline = false;
			this.stbYear.Name = "stbYear";
			this.stbYear.NumericOnly = true;
			this.stbYear.Placeholder = "";
			this.stbYear.RegularExpression = null;
			this.stbYear.Required = false;
			this.stbYear.Size = new System.Drawing.Size(72, 30);
			this.stbYear.Suffix = null;
			this.stbYear.TabIndex = 5;
			this.stbYear.TabStop = false;
			this.stbYear.UseSystemPasswordChar = false;
			this.stbYear.TextChanged += new System.EventHandler(this.stbYear_TextChanged);
			// 
			// btnStatisticsPrEstateAgent
			// 
			this.btnStatisticsPrEstateAgent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStatisticsPrEstateAgent.AutoSize = true;
			this.btnStatisticsPrEstateAgent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnStatisticsPrEstateAgent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnStatisticsPrEstateAgent.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.btnStatisticsPrEstateAgent.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnStatisticsPrEstateAgent.Enabled = false;
			this.btnStatisticsPrEstateAgent.FlatAppearance.BorderSize = 0;
			this.btnStatisticsPrEstateAgent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnStatisticsPrEstateAgent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnStatisticsPrEstateAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStatisticsPrEstateAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnStatisticsPrEstateAgent.Location = new System.Drawing.Point(737, 0);
			this.btnStatisticsPrEstateAgent.Name = "btnStatisticsPrEstateAgent";
			this.btnStatisticsPrEstateAgent.Size = new System.Drawing.Size(186, 30);
			this.btnStatisticsPrEstateAgent.TabIndex = 4;
			this.btnStatisticsPrEstateAgent.Text = "Statistik for mægler for:";
			this.btnStatisticsPrEstateAgent.UseVisualStyleBackColor = false;
			this.btnStatisticsPrEstateAgent.Click += new System.EventHandler(this.btnStatisticsPrEstateAgent_Click);
			// 
			// btnAllStatistics
			// 
			this.btnAllStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAllStatistics.AutoSize = true;
			this.btnAllStatistics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnAllStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnAllStatistics.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.btnAllStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAllStatistics.FlatAppearance.BorderSize = 0;
			this.btnAllStatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnAllStatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnAllStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAllStatistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnAllStatistics.Location = new System.Drawing.Point(1025, 0);
			this.btnAllStatistics.Name = "btnAllStatistics";
			this.btnAllStatistics.Size = new System.Drawing.Size(110, 30);
			this.btnAllStatistics.TabIndex = 3;
			this.btnAllStatistics.Text = "Alt statistik";
			this.btnAllStatistics.UseVisualStyleBackColor = false;
			this.btnAllStatistics.Click += new System.EventHandler(this.btnAllStatistics_Click);
			// 
			// btnNewEstateAgents
			// 
			this.btnNewEstateAgents.AutoSize = true;
			this.btnNewEstateAgents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnNewEstateAgents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnNewEstateAgents.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.btnNewEstateAgents.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNewEstateAgents.FlatAppearance.BorderSize = 0;
			this.btnNewEstateAgents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnNewEstateAgents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnNewEstateAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewEstateAgents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
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
			this.sblActiveCases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
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
			this.clsEstateAgents.Spacing = 5;
			this.clsEstateAgents.TabIndex = 6;
			this.clsEstateAgents.WrapContents = false;
			// 
			// hdrEstateAgents
			// 
			this.hdrEstateAgents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hdrEstateAgents.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.hdrEstateAgents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
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
        private SmartButton btnStatisticsPrEstateAgent;
        private SmartButton btnAllStatistics;
        private SmartTextBox stbYear;
	}
}
