namespace LivingSmartForms
{
    partial class BaseWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.pnlMenuHolder = new System.Windows.Forms.Panel();
			this.flpMenuRight = new System.Windows.Forms.FlowLayoutPanel();
			this.flpMenuLeft = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuButton3 = new SmartControls.MenuButton();
			this.menuButton4 = new SmartControls.MenuButton();
			this.menuButton5 = new SmartControls.MenuButton();
			this.menuButton1 = new SmartControls.MenuButton();
			this.menuButton2 = new SmartControls.MenuButton();
			this.cases1 = new LivingSmartForms.Pages.Cases();
			this.overview1 = new LivingSmartForms.Pages.Overview();
			this.pnlMenuHolder.SuspendLayout();
			this.flpMenuRight.SuspendLayout();
			this.flpMenuLeft.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlMenuHolder
			// 
			this.pnlMenuHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.pnlMenuHolder.Controls.Add(this.flpMenuRight);
			this.pnlMenuHolder.Controls.Add(this.flpMenuLeft);
			this.pnlMenuHolder.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlMenuHolder.Location = new System.Drawing.Point(0, 0);
			this.pnlMenuHolder.Name = "pnlMenuHolder";
			this.pnlMenuHolder.Size = new System.Drawing.Size(1135, 30);
			this.pnlMenuHolder.TabIndex = 0;
			// 
			// flpMenuRight
			// 
			this.flpMenuRight.AutoSize = true;
			this.flpMenuRight.Controls.Add(this.menuButton3);
			this.flpMenuRight.Controls.Add(this.menuButton4);
			this.flpMenuRight.Controls.Add(this.menuButton5);
			this.flpMenuRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.flpMenuRight.Location = new System.Drawing.Point(914, 0);
			this.flpMenuRight.Margin = new System.Windows.Forms.Padding(0);
			this.flpMenuRight.Name = "flpMenuRight";
			this.flpMenuRight.Size = new System.Drawing.Size(221, 30);
			this.flpMenuRight.TabIndex = 3;
			this.flpMenuRight.WrapContents = false;
			// 
			// flpMenuLeft
			// 
			this.flpMenuLeft.AutoSize = true;
			this.flpMenuLeft.Controls.Add(this.menuButton1);
			this.flpMenuLeft.Controls.Add(this.menuButton2);
			this.flpMenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.flpMenuLeft.Location = new System.Drawing.Point(0, 0);
			this.flpMenuLeft.Margin = new System.Windows.Forms.Padding(0);
			this.flpMenuLeft.Name = "flpMenuLeft";
			this.flpMenuLeft.Size = new System.Drawing.Size(155, 30);
			this.flpMenuLeft.TabIndex = 2;
			this.flpMenuLeft.WrapContents = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cases1);
			this.panel1.Controls.Add(this.overview1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 30);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1135, 560);
			this.panel1.TabIndex = 1;
			// 
			// menuButton3
			// 
			this.menuButton3.AutoSize = true;
			this.menuButton3.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.menuButton3.Location = new System.Drawing.Point(0, 0);
			this.menuButton3.Name = "menuButton3";
			this.menuButton3.Selected = false;
			this.menuButton3.Size = new System.Drawing.Size(106, 30);
			this.menuButton3.TabIndex = 0;
			this.menuButton3.Text = "Indstillinger";
			this.menuButton3.UseVisualStyleBackColor = true;
			this.menuButton3.Click += new System.EventHandler(this.MenuButtonClick);
			// 
			// menuButton4
			// 
			this.menuButton4.AutoSize = true;
			this.menuButton4.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.menuButton4.Location = new System.Drawing.Point(106, 0);
			this.menuButton4.Name = "menuButton4";
			this.menuButton4.Selected = false;
			this.menuButton4.Size = new System.Drawing.Size(73, 30);
			this.menuButton4.TabIndex = 1;
			this.menuButton4.Text = "Log af";
			this.menuButton4.UseVisualStyleBackColor = true;
			this.menuButton4.Click += new System.EventHandler(this.MenuButtonClick);
			// 
			// menuButton5
			// 
			this.menuButton5.AutoSize = true;
			this.menuButton5.Font = new System.Drawing.Font("Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.menuButton5.Location = new System.Drawing.Point(179, 0);
			this.menuButton5.Name = "menuButton5";
			this.menuButton5.Selected = false;
			this.menuButton5.Size = new System.Drawing.Size(42, 30);
			this.menuButton5.TabIndex = 2;
			this.menuButton5.Text = "<";
			this.menuButton5.UseVisualStyleBackColor = true;
			this.menuButton5.Click += new System.EventHandler(this.MenuButtonClick);
			// 
			// menuButton1
			// 
			this.menuButton1.AutoSize = true;
			this.menuButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.menuButton1.Location = new System.Drawing.Point(0, 0);
			this.menuButton1.Name = "menuButton1";
			this.menuButton1.Selected = false;
			this.menuButton1.Size = new System.Drawing.Size(86, 30);
			this.menuButton1.TabIndex = 0;
			this.menuButton1.Text = "Oversigt";
			this.menuButton1.UseVisualStyleBackColor = true;
			this.menuButton1.Click += new System.EventHandler(this.MenuButtonClick);
			// 
			// menuButton2
			// 
			this.menuButton2.AutoSize = true;
			this.menuButton2.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.menuButton2.Location = new System.Drawing.Point(86, 0);
			this.menuButton2.Name = "menuButton2";
			this.menuButton2.Selected = false;
			this.menuButton2.Size = new System.Drawing.Size(69, 30);
			this.menuButton2.TabIndex = 1;
			this.menuButton2.Text = "Sager";
			this.menuButton2.UseVisualStyleBackColor = true;
			this.menuButton2.Click += new System.EventHandler(this.MenuButtonClick);
			// 
			// cases1
			// 
			this.cases1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cases1.Location = new System.Drawing.Point(0, 0);
			this.cases1.Name = "cases1";
			this.cases1.Size = new System.Drawing.Size(1135, 560);
			this.cases1.TabIndex = 1;
			// 
			// overview1
			// 
			this.overview1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.overview1.Location = new System.Drawing.Point(0, 0);
			this.overview1.Name = "overview1";
			this.overview1.Size = new System.Drawing.Size(1135, 560);
			this.overview1.TabIndex = 0;
			// 
			// BaseWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.ClientSize = new System.Drawing.Size(1135, 590);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnlMenuHolder);
			this.Name = "BaseWindow";
			this.Text = "LivingSmart";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseWindow_FormClosing);
			this.pnlMenuHolder.ResumeLayout(false);
			this.pnlMenuHolder.PerformLayout();
			this.flpMenuRight.ResumeLayout(false);
			this.flpMenuRight.PerformLayout();
			this.flpMenuLeft.ResumeLayout(false);
			this.flpMenuLeft.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Panel pnlMenuHolder;
		private SmartControls.MenuButton menuButton1;
		private SmartControls.MenuButton menuButton2;
		private System.Windows.Forms.FlowLayoutPanel flpMenuRight;
		private SmartControls.MenuButton menuButton3;
		private SmartControls.MenuButton menuButton4;
		private System.Windows.Forms.FlowLayoutPanel flpMenuLeft;
		private SmartControls.MenuButton menuButton5;
		private System.Windows.Forms.Panel panel1;
		private Pages.Overview overview1;
		private Pages.Cases cases1;



	}
}

