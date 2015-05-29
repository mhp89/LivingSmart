using SmartControls;

namespace LivingSmartForms.Pages
{
    partial class Customers
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
			this.btnNewCustomer = new SmartControls.SmartButton();
			this.sblCustomers = new SmartControls.SmartLabel();
			this.clsCustomers = new SmartControls.ControlList();
			this.hdrCustomers = new SmartControls.Header();
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
			this.pnlSubmenu.Controls.Add(this.btnNewCustomer);
			this.pnlSubmenu.Controls.Add(this.sblCustomers);
			this.pnlSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubmenu.Location = new System.Drawing.Point(0, 0);
			this.pnlSubmenu.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSubmenu.Name = "pnlSubmenu";
			this.pnlSubmenu.Size = new System.Drawing.Size(1135, 40);
			this.pnlSubmenu.TabIndex = 0;
			// 
			// btnNewCustomer
			// 
			this.btnNewCustomer.AutoSize = true;
			this.btnNewCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnNewCustomer.BackColor = SmartColor.Light;
			this.btnNewCustomer.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.btnNewCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNewCustomer.FlatAppearance.BorderSize = 0;
			this.btnNewCustomer.FlatAppearance.MouseDownBackColor = SmartColor.Dark;
			this.btnNewCustomer.FlatAppearance.MouseOverBackColor = SmartColor.Dark;
			this.btnNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewCustomer.ForeColor = SmartColor.Dark;
			this.btnNewCustomer.Location = new System.Drawing.Point(0, 0);
			this.btnNewCustomer.Name = "btnNewCustomer";
			this.btnNewCustomer.Size = new System.Drawing.Size(103, 30);
			this.btnNewCustomer.TabIndex = 2;
			this.btnNewCustomer.Text = "Ny kunde";
			this.btnNewCustomer.UseVisualStyleBackColor = false;
			this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
			// 
			// sblCustomers
			// 
			this.sblCustomers.AutoSize = true;
			this.sblCustomers.ForeColor = SmartColor.Light;
			this.sblCustomers.Location = new System.Drawing.Point(113, 7);
			this.sblCustomers.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.sblCustomers.Name = "sblCustomers";
			this.sblCustomers.Size = new System.Drawing.Size(79, 17);
			this.sblCustomers.TabIndex = 1;
			this.sblCustomers.Text = "20";
			this.sblCustomers.Title = "Kunder:";
			this.sblCustomers.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// clsCustomers
			// 
			this.clsCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.clsCustomers.AutoScroll = true;
			this.clsCustomers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.clsCustomers.Location = new System.Drawing.Point(20, 90);
			this.clsCustomers.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
			this.clsCustomers.Name = "clsCustomers";
			this.clsCustomers.Size = new System.Drawing.Size(1095, 450);
			this.clsCustomers.TabIndex = 6;
			this.clsCustomers.WrapContents = false;
			// 
			// hdrCustomers
			// 
			this.hdrCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hdrCustomers.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.hdrCustomers.ForeColor = SmartColor.Light;
			this.hdrCustomers.Location = new System.Drawing.Point(10, 55);
			this.hdrCustomers.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
			this.hdrCustomers.Name = "hdrCustomers";
			this.hdrCustomers.Size = new System.Drawing.Size(1115, 25);
			this.hdrCustomers.TabIndex = 5;
			this.hdrCustomers.Text = "Kunder";
			// 
			// Customers
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.pnlSubmenuHolder);
			this.Controls.Add(this.clsCustomers);
			this.Controls.Add(this.hdrCustomers);
			this.Name = "Customers";
			this.Size = new System.Drawing.Size(1135, 560);
			this.pnlSubmenuHolder.ResumeLayout(false);
			this.pnlSubmenu.ResumeLayout(false);
			this.pnlSubmenu.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private SmartControls.Header hdrCustomers;
		private SmartControls.ControlList clsCustomers;
		private System.Windows.Forms.Panel pnlSubmenuHolder;
		private System.Windows.Forms.Panel pnlSubmenuBorder;
		private System.Windows.Forms.Panel pnlSubmenu;
		private SmartControls.SmartButton btnNewCustomer;
		private SmartControls.SmartLabel sblCustomers;
	}
}
