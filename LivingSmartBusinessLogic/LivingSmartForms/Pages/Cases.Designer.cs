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
			this.smartButton1 = new SmartControls.SmartButton();
			this.sblActiveCases = new SmartControls.SmartLabel();
			this.smartTextBox2 = new SmartControls.SmartTextBox();
			this.smartTextBox1 = new SmartControls.SmartTextBox();
			this.smartTextBox3 = new SmartControls.SmartTextBox();
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
			this.smartButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
			this.smartButton1.Size = new System.Drawing.Size(89, 30);
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
			// smartTextBox2
			// 
			this.smartTextBox2.AllowComma = false;
			this.smartTextBox2.AutomaticValidation = true;
			this.smartTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.smartTextBox2.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.smartTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.smartTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.smartTextBox2.Location = new System.Drawing.Point(247, 257);
			this.smartTextBox2.MaxLength = 32767;
			this.smartTextBox2.MinLength = 2;
			this.smartTextBox2.Name = "smartTextBox2";
			this.smartTextBox2.NumericOnly = false;
			this.smartTextBox2.RegularExpression = "";
			this.smartTextBox2.Size = new System.Drawing.Size(107, 30);
			this.smartTextBox2.Suffix = "m²";
			this.smartTextBox2.TabIndex = 4;
			this.smartTextBox2.Text = "test4";
			this.smartTextBox2.UseSystemPasswordChar = false;
			// 
			// smartTextBox1
			// 
			this.smartTextBox1.AllowComma = false;
			this.smartTextBox1.AutomaticValidation = true;
			this.smartTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.smartTextBox1.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.smartTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.smartTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.smartTextBox1.Location = new System.Drawing.Point(247, 198);
			this.smartTextBox1.MaxLength = 32767;
			this.smartTextBox1.MinLength = -1;
			this.smartTextBox1.Name = "smartTextBox1";
			this.smartTextBox1.NumericOnly = false;
			this.smartTextBox1.RegularExpression = "^[\\S]+@[\\S]+\\.[\\S]+$";
			this.smartTextBox1.Size = new System.Drawing.Size(329, 30);
			this.smartTextBox1.Suffix = null;
			this.smartTextBox1.TabIndex = 3;
			this.smartTextBox1.Text = "smartTextBox1";
			this.smartTextBox1.UseSystemPasswordChar = false;
			// 
			// smartTextBox3
			// 
			this.smartTextBox3.AllowComma = false;
			this.smartTextBox3.AutomaticValidation = true;
			this.smartTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.smartTextBox3.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.smartTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.smartTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.smartTextBox3.Location = new System.Drawing.Point(247, 307);
			this.smartTextBox3.MaxLength = 32767;
			this.smartTextBox3.MinLength = 2;
			this.smartTextBox3.Name = "smartTextBox3";
			this.smartTextBox3.NumericOnly = false;
			this.smartTextBox3.RegularExpression = "";
			this.smartTextBox3.Size = new System.Drawing.Size(107, 30);
			this.smartTextBox3.Suffix = "m�";
			this.smartTextBox3.TabIndex = 5;
			this.smartTextBox3.Text = "test4";
			this.smartTextBox3.UseSystemPasswordChar = true;
			// 
			// Cases
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.smartTextBox3);
			this.Controls.Add(this.smartTextBox2);
			this.Controls.Add(this.smartTextBox1);
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
		private SmartControls.SmartButton smartButton1;
		private System.Windows.Forms.Panel pnlSubmenuHolder;
		private SmartControls.SmartTextBox smartTextBox1;
		private SmartControls.SmartTextBox smartTextBox2;
		private SmartControls.SmartTextBox smartTextBox3;


	}
}
