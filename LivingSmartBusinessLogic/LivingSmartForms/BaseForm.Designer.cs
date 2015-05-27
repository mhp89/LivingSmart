using System.Windows.Forms;
using SmartControls;

namespace LivingSmartForms
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.pnlMenuHolder = new System.Windows.Forms.Panel();
            this.flpMenuRight = new System.Windows.Forms.FlowLayoutPanel();
            this.flpMenuLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlInnerContent = new System.Windows.Forms.Panel();
            this.pnlDropInHolder = new System.Windows.Forms.Panel();
            this.pnlPartnersHolder = new System.Windows.Forms.Panel();
            this.pnlMasterContent = new System.Windows.Forms.Panel();
            this.pnlMenuHolder.SuspendLayout();
            this.pnlMasterContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuHolder
            // 
            this.pnlMenuHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pnlMenuHolder.Controls.Add(this.flpMenuRight);
            this.pnlMenuHolder.Controls.Add(this.flpMenuLeft);
            this.pnlMenuHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuHolder.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuHolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMenuHolder.Name = "pnlMenuHolder";
            this.pnlMenuHolder.Size = new System.Drawing.Size(1324, 30);
            this.pnlMenuHolder.TabIndex = 0;
            // 
            // flpMenuRight
            // 
            this.flpMenuRight.AutoSize = true;
            this.flpMenuRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpMenuRight.Location = new System.Drawing.Point(1324, 0);
            this.flpMenuRight.Margin = new System.Windows.Forms.Padding(0);
            this.flpMenuRight.Name = "flpMenuRight";
            this.flpMenuRight.Size = new System.Drawing.Size(0, 30);
            this.flpMenuRight.TabIndex = 3;
            this.flpMenuRight.WrapContents = false;
            // 
            // flpMenuLeft
            // 
            this.flpMenuLeft.AutoSize = true;
            this.flpMenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpMenuLeft.Location = new System.Drawing.Point(0, 0);
            this.flpMenuLeft.Margin = new System.Windows.Forms.Padding(0);
            this.flpMenuLeft.Name = "flpMenuLeft";
            this.flpMenuLeft.Size = new System.Drawing.Size(0, 30);
            this.flpMenuLeft.TabIndex = 2;
            this.flpMenuLeft.WrapContents = false;
            // 
            // pnlInnerContent
            // 
            this.pnlInnerContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInnerContent.Location = new System.Drawing.Point(0, 0);
            this.pnlInnerContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlInnerContent.Name = "pnlInnerContent";
            this.pnlInnerContent.Padding = new System.Windows.Forms.Padding(10);
            this.pnlInnerContent.Size = new System.Drawing.Size(1324, 711);
            this.pnlInnerContent.TabIndex = 1;
            // 
            // pnlDropInHolder
            // 
            this.pnlDropInHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDropInHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pnlDropInHolder.Location = new System.Drawing.Point(0, 0);
            this.pnlDropInHolder.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDropInHolder.Name = "pnlDropInHolder";
            this.pnlDropInHolder.Size = new System.Drawing.Size(0, 711);
            this.pnlDropInHolder.TabIndex = 3;
            // 
            // pnlPartnersHolder
            // 
            this.pnlPartnersHolder.AutoSize = true;
            this.pnlPartnersHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pnlPartnersHolder.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPartnersHolder.Location = new System.Drawing.Point(1324, 30);
            this.pnlPartnersHolder.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPartnersHolder.Name = "pnlPartnersHolder";
            this.pnlPartnersHolder.Size = new System.Drawing.Size(0, 711);
            this.pnlPartnersHolder.TabIndex = 4;
            // 
            // pnlMasterContent
            // 
            this.pnlMasterContent.Controls.Add(this.pnlInnerContent);
            this.pnlMasterContent.Controls.Add(this.pnlDropInHolder);
            this.pnlMasterContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMasterContent.Location = new System.Drawing.Point(0, 30);
            this.pnlMasterContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMasterContent.Name = "pnlMasterContent";
            this.pnlMasterContent.Size = new System.Drawing.Size(1324, 711);
            this.pnlMasterContent.TabIndex = 2;
            // 
            // BaseForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1324, 741);
            this.Controls.Add(this.pnlMasterContent);
            this.Controls.Add(this.pnlPartnersHolder);
            this.Controls.Add(this.pnlMenuHolder);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BaseForm";
            this.Text = "LivingSmart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseForm_FormClosing);
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.SizeChanged += new System.EventHandler(this.BaseForm_SizeChanged);
            this.pnlMenuHolder.ResumeLayout(false);
            this.pnlMenuHolder.PerformLayout();
            this.pnlMasterContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Panel pnlMenuHolder;
		private System.Windows.Forms.FlowLayoutPanel flpMenuRight;
		private System.Windows.Forms.FlowLayoutPanel flpMenuLeft;
		private System.Windows.Forms.Panel pnlInnerContent;
		private System.Windows.Forms.Panel pnlPartnersHolder;
		private Panel pnlMasterContent;
		public Panel pnlDropInHolder;



	}
}

