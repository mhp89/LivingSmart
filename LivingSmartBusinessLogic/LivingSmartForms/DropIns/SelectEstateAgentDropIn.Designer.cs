namespace LivingSmartForms.DropIns
{
    partial class SelectEstateAgentDropIn
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
            this.hdrEstateAgentSelect = new SmartControls.Header();
            this.clsAllEstateAgents = new SmartControls.ControlList();
            this.pnlBottomControls = new System.Windows.Forms.Panel();
            this.btnCancel = new SmartControls.SmartButton();
            this.btnSelect = new SmartControls.SmartButton();
            this.pnlSubmenuBorder = new System.Windows.Forms.Panel();
            this.pnlSubmenuHolder = new System.Windows.Forms.Panel();
            this.pnlMenuLine = new System.Windows.Forms.Panel();
            this.pnlSubmenu = new System.Windows.Forms.Panel();
            this.pnlBottomControls.SuspendLayout();
            this.pnlSubmenuHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // hdrEstateAgentSelect
            // 
            this.hdrEstateAgentSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hdrEstateAgentSelect.Color = SmartControls.SmartColor.ColorStyle.Dark;
            this.hdrEstateAgentSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.hdrEstateAgentSelect.Location = new System.Drawing.Point(10, 60);
            this.hdrEstateAgentSelect.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.hdrEstateAgentSelect.Name = "hdrEstateAgentSelect";
            this.hdrEstateAgentSelect.Size = new System.Drawing.Size(430, 25);
            this.hdrEstateAgentSelect.TabIndex = 5;
            this.hdrEstateAgentSelect.Text = "Vælg mæglere";
            // 
            // clsAllEstateAgents
            // 
            this.clsAllEstateAgents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clsAllEstateAgents.AutoScroll = true;
            this.clsAllEstateAgents.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.clsAllEstateAgents.Location = new System.Drawing.Point(10, 95);
            this.clsAllEstateAgents.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.clsAllEstateAgents.Name = "clsAllEstateAgents";
            this.clsAllEstateAgents.Size = new System.Drawing.Size(430, 495);
            this.clsAllEstateAgents.Spacing = 5;
            this.clsAllEstateAgents.TabIndex = 10;
            this.clsAllEstateAgents.WrapContents = false;
            // 
            // pnlBottomControls
            // 
            this.pnlBottomControls.Controls.Add(this.btnCancel);
            this.pnlBottomControls.Controls.Add(this.btnSelect);
            this.pnlBottomControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomControls.Location = new System.Drawing.Point(0, 600);
            this.pnlBottomControls.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottomControls.Name = "pnlBottomControls";
            this.pnlBottomControls.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.pnlBottomControls.Size = new System.Drawing.Size(450, 50);
            this.pnlBottomControls.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnCancel.Color = SmartControls.SmartColor.ColorStyle.Dark;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnCancel.Location = new System.Drawing.Point(17, 10);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(20, 10, 0, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Annullér";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.AutoSize = true;
            this.btnSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnSelect.Color = SmartControls.SmartColor.ColorStyle.Dark;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnSelect.Location = new System.Drawing.Point(341, 10);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(0, 10, 20, 10);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(89, 30);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Vælg";
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // pnlSubmenuBorder
            // 
            this.pnlSubmenuBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.pnlSubmenuBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSubmenuBorder.Location = new System.Drawing.Point(0, 598);
            this.pnlSubmenuBorder.Name = "pnlSubmenuBorder";
            this.pnlSubmenuBorder.Size = new System.Drawing.Size(450, 2);
            this.pnlSubmenuBorder.TabIndex = 12;
            // 
            // pnlSubmenuHolder
            // 
            this.pnlSubmenuHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSubmenuHolder.Controls.Add(this.pnlMenuLine);
            this.pnlSubmenuHolder.Controls.Add(this.pnlSubmenu);
            this.pnlSubmenuHolder.Location = new System.Drawing.Point(0, 2);
            this.pnlSubmenuHolder.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSubmenuHolder.Name = "pnlSubmenuHolder";
            this.pnlSubmenuHolder.Size = new System.Drawing.Size(450, 50);
            this.pnlSubmenuHolder.TabIndex = 13;
            // 
            // pnlMenuLine
            // 
            this.pnlMenuLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.pnlMenuLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMenuLine.Location = new System.Drawing.Point(0, 48);
            this.pnlMenuLine.Name = "pnlMenuLine";
            this.pnlMenuLine.Size = new System.Drawing.Size(450, 2);
            this.pnlMenuLine.TabIndex = 1;
            // 
            // pnlSubmenu
            // 
            this.pnlSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSubmenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSubmenu.Name = "pnlSubmenu";
            this.pnlSubmenu.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.pnlSubmenu.Size = new System.Drawing.Size(450, 50);
            this.pnlSubmenu.TabIndex = 0;
            // 
            // SelectEstateAgentDropIn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnlSubmenuHolder);
            this.Controls.Add(this.pnlSubmenuBorder);
            this.Controls.Add(this.pnlBottomControls);
            this.Controls.Add(this.clsAllEstateAgents);
            this.Controls.Add(this.hdrEstateAgentSelect);
            this.Name = "SelectEstateAgentDropIn";
            this.Size = new System.Drawing.Size(450, 650);
            this.pnlBottomControls.ResumeLayout(false);
            this.pnlBottomControls.PerformLayout();
            this.pnlSubmenuHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SmartControls.Header hdrEstateAgentSelect;
        private SmartControls.ControlList clsAllEstateAgents;
        private System.Windows.Forms.Panel pnlBottomControls;
        private SmartControls.SmartButton btnCancel;
        private SmartControls.SmartButton btnSelect;
        private System.Windows.Forms.Panel pnlSubmenuBorder;
        private System.Windows.Forms.Panel pnlSubmenuHolder;
        private System.Windows.Forms.Panel pnlMenuLine;
        private System.Windows.Forms.Panel pnlSubmenu;
    }
}
