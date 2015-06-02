namespace LivingSmartForms.DropIns
{
    partial class SelectPropertyDropIn
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
            this.pnlMenuLine = new System.Windows.Forms.Panel();
            this.pnlSubmenu = new System.Windows.Forms.Panel();
            this.hdrPropertySelect = new SmartControls.Header();
            this.clsAllProperties = new SmartControls.ControlList();
            this.pnlBottomControls = new System.Windows.Forms.Panel();
            this.btnCancel = new SmartControls.SmartButton();
            this.btnSelect = new SmartControls.SmartButton();
            this.pnlSubmenuHolder.SuspendLayout();
            this.pnlBottomControls.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlSubmenuHolder.TabIndex = 14;
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
            // hdrPropertySelect
            // 
            this.hdrPropertySelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hdrPropertySelect.Color = SmartControls.SmartColor.ColorStyle.Dark;
            this.hdrPropertySelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.hdrPropertySelect.Location = new System.Drawing.Point(10, 60);
            this.hdrPropertySelect.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.hdrPropertySelect.Name = "hdrPropertySelect";
            this.hdrPropertySelect.Size = new System.Drawing.Size(430, 25);
            this.hdrPropertySelect.TabIndex = 15;
            this.hdrPropertySelect.Text = "Vælg ejendomme";
            // 
            // clsAllProperties
            // 
            this.clsAllProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clsAllProperties.AutoScroll = true;
            this.clsAllProperties.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.clsAllProperties.Location = new System.Drawing.Point(10, 95);
            this.clsAllProperties.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.clsAllProperties.Name = "clsAllProperties";
            this.clsAllProperties.Size = new System.Drawing.Size(430, 495);
            this.clsAllProperties.TabIndex = 16;
            this.clsAllProperties.WrapContents = false;
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
            this.pnlBottomControls.TabIndex = 17;
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
            // SelectPropertyDropIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBottomControls);
            this.Controls.Add(this.clsAllProperties);
            this.Controls.Add(this.hdrPropertySelect);
            this.Controls.Add(this.pnlSubmenuHolder);
            this.Name = "SelectPropertyDropIn";
            this.Size = new System.Drawing.Size(450, 650);
            this.pnlSubmenuHolder.ResumeLayout(false);
            this.pnlBottomControls.ResumeLayout(false);
            this.pnlBottomControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSubmenuHolder;
        private System.Windows.Forms.Panel pnlMenuLine;
        private System.Windows.Forms.Panel pnlSubmenu;
        private SmartControls.Header hdrPropertySelect;
        private SmartControls.ControlList clsAllProperties;
        private System.Windows.Forms.Panel pnlBottomControls;
        private SmartControls.SmartButton btnCancel;
        private SmartControls.SmartButton btnSelect;
    }
}
