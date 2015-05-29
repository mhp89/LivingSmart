using SmartControls;

namespace LivingSmartForms.DropIns
{
	partial class NewEstateAgentDropIn
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
			this.lblNewEstateAgent = new System.Windows.Forms.Label();
			this.pnlBottomControlsHolder = new System.Windows.Forms.Panel();
			this.pnlBottomControlsBorder = new System.Windows.Forms.Panel();
			this.pnlBottomControls = new System.Windows.Forms.Panel();
			this.btnCancel = new SmartControls.SmartButton();
			this.btnSave = new SmartControls.SmartButton();
			this.pnlContentHolder = new System.Windows.Forms.Panel();
			this.pnlSubmenuHolder.SuspendLayout();
			this.pnlSubmenu.SuspendLayout();
			this.pnlBottomControlsHolder.SuspendLayout();
			this.pnlBottomControls.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlSubmenuHolder
			// 
			this.pnlSubmenuHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSubmenuHolder.Controls.Add(this.pnlSubmenuBorder);
			this.pnlSubmenuHolder.Controls.Add(this.pnlSubmenu);
			this.pnlSubmenuHolder.Location = new System.Drawing.Point(2, 2);
			this.pnlSubmenuHolder.Name = "pnlSubmenuHolder";
			this.pnlSubmenuHolder.Size = new System.Drawing.Size(498, 50);
			this.pnlSubmenuHolder.TabIndex = 5;
			// 
			// pnlSubmenuBorder
			// 
			this.pnlSubmenuBorder.BackColor = SmartColor.Dark;
			this.pnlSubmenuBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlSubmenuBorder.Location = new System.Drawing.Point(0, 48);
			this.pnlSubmenuBorder.Name = "pnlSubmenuBorder";
			this.pnlSubmenuBorder.Size = new System.Drawing.Size(498, 2);
			this.pnlSubmenuBorder.TabIndex = 1;
			// 
			// pnlSubmenu
			// 
			this.pnlSubmenu.Controls.Add(this.lblNewEstateAgent);
			this.pnlSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubmenu.Location = new System.Drawing.Point(0, 0);
			this.pnlSubmenu.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSubmenu.Name = "pnlSubmenu";
			this.pnlSubmenu.Padding = new System.Windows.Forms.Padding(10, 15, 0, 0);
			this.pnlSubmenu.Size = new System.Drawing.Size(498, 50);
			this.pnlSubmenu.TabIndex = 0;
			// 
			// lblNewEstateAgent
			// 
			this.lblNewEstateAgent.AutoSize = true;
			this.lblNewEstateAgent.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblNewEstateAgent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.lblNewEstateAgent.Location = new System.Drawing.Point(10, 15);
			this.lblNewEstateAgent.Margin = new System.Windows.Forms.Padding(0);
			this.lblNewEstateAgent.Name = "lblNewEstateAgent";
			this.lblNewEstateAgent.Size = new System.Drawing.Size(76, 20);
			this.lblNewEstateAgent.TabIndex = 1;
			this.lblNewEstateAgent.Text = "Ny kunde";
			this.lblNewEstateAgent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlBottomControlsHolder
			// 
			this.pnlBottomControlsHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlBottomControlsHolder.Controls.Add(this.pnlBottomControlsBorder);
			this.pnlBottomControlsHolder.Controls.Add(this.pnlBottomControls);
			this.pnlBottomControlsHolder.Location = new System.Drawing.Point(2, 550);
			this.pnlBottomControlsHolder.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBottomControlsHolder.Name = "pnlBottomControlsHolder";
			this.pnlBottomControlsHolder.Size = new System.Drawing.Size(498, 50);
			this.pnlBottomControlsHolder.TabIndex = 6;
			// 
			// pnlBottomControlsBorder
			// 
			this.pnlBottomControlsBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlBottomControlsBorder.BackColor = SmartColor.Dark;
			this.pnlBottomControlsBorder.Location = new System.Drawing.Point(0, 0);
			this.pnlBottomControlsBorder.Name = "pnlBottomControlsBorder";
			this.pnlBottomControlsBorder.Size = new System.Drawing.Size(498, 2);
			this.pnlBottomControlsBorder.TabIndex = 1;
			// 
			// pnlBottomControls
			// 
			this.pnlBottomControls.Controls.Add(this.btnCancel);
			this.pnlBottomControls.Controls.Add(this.btnSave);
			this.pnlBottomControls.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottomControls.Location = new System.Drawing.Point(0, 0);
			this.pnlBottomControls.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBottomControls.Name = "pnlBottomControls";
			this.pnlBottomControls.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.pnlBottomControls.Size = new System.Drawing.Size(498, 50);
			this.pnlBottomControls.TabIndex = 0;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCancel.AutoSize = true;
			this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnCancel.BackColor = SmartColor.Dark;
			this.btnCancel.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatAppearance.MouseDownBackColor = SmartColor.Light;
			this.btnCancel.FlatAppearance.MouseOverBackColor = SmartColor.Light;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.ForeColor = SmartColor.Light;
			this.btnCancel.Location = new System.Drawing.Point(17, 10);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(20, 10, 0, 10);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(95, 30);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Annullér";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.AutoSize = true;
			this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnSave.BackColor = SmartColor.Dark;
			this.btnSave.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatAppearance.MouseDownBackColor = SmartColor.Light;
			this.btnSave.FlatAppearance.MouseOverBackColor = SmartColor.Light;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.ForeColor = SmartColor.Light;
			this.btnSave.Location = new System.Drawing.Point(403, 10);
			this.btnSave.Margin = new System.Windows.Forms.Padding(0, 10, 20, 10);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 30);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Gem";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// pnlContentHolder
			// 
			this.pnlContentHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlContentHolder.AutoScroll = true;
			this.pnlContentHolder.ForeColor = SmartColor.Dark;
			this.pnlContentHolder.Location = new System.Drawing.Point(1, 50);
			this.pnlContentHolder.Margin = new System.Windows.Forms.Padding(0);
			this.pnlContentHolder.Name = "pnlContentHolder";
			this.pnlContentHolder.Size = new System.Drawing.Size(498, 500);
			this.pnlContentHolder.TabIndex = 7;
			// 
			// NewEstateAgentDropIn
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.pnlBottomControlsHolder);
			this.Controls.Add(this.pnlSubmenuHolder);
			this.Controls.Add(this.pnlContentHolder);
			this.Name = "NewEstateAgentDropIn";
			this.Size = new System.Drawing.Size(500, 600);
			this.pnlSubmenuHolder.ResumeLayout(false);
			this.pnlSubmenu.ResumeLayout(false);
			this.pnlSubmenu.PerformLayout();
			this.pnlBottomControlsHolder.ResumeLayout(false);
			this.pnlBottomControls.ResumeLayout(false);
			this.pnlBottomControls.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlSubmenuHolder;
		private System.Windows.Forms.Panel pnlSubmenuBorder;
		private System.Windows.Forms.Panel pnlSubmenu;
		private System.Windows.Forms.Panel pnlBottomControlsHolder;
		private System.Windows.Forms.Panel pnlBottomControlsBorder;
		private System.Windows.Forms.Panel pnlBottomControls;
		private SmartControls.SmartButton btnCancel;
		private SmartControls.SmartButton btnSave;
		private System.Windows.Forms.Panel pnlContentHolder;
		private System.Windows.Forms.Label lblNewEstateAgent;
	}
}
