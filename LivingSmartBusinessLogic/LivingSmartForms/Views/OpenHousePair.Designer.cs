namespace LivingSmartForms.Views
{
    partial class OpenHousePair
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
            this.lblEstateAgentTitle = new System.Windows.Forms.Label();
            this.clsProperties = new SmartControls.ControlList();
            this.hdrProperties = new SmartControls.Header();
            this.hdrEstateAgent = new SmartControls.Header();
            this.SuspendLayout();
            // 
            // lblEstateAgentTitle
            // 
            this.lblEstateAgentTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstateAgentTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstateAgentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lblEstateAgentTitle.Location = new System.Drawing.Point(3, 34);
            this.lblEstateAgentTitle.Name = "lblEstateAgentTitle";
            this.lblEstateAgentTitle.Size = new System.Drawing.Size(207, 30);
            this.lblEstateAgentTitle.TabIndex = 0;
            this.lblEstateAgentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clsProperties
            // 
            this.clsProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clsProperties.AutoScroll = true;
            this.clsProperties.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.clsProperties.Location = new System.Drawing.Point(0, 115);
            this.clsProperties.Name = "clsProperties";
            this.clsProperties.Size = new System.Drawing.Size(210, 332);
            this.clsProperties.Spacing = 10;
            this.clsProperties.TabIndex = 3;
            this.clsProperties.WrapContents = false;
            // 
            // hdrProperties
            // 
            this.hdrProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hdrProperties.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.hdrProperties.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hdrProperties.Location = new System.Drawing.Point(0, 80);
            this.hdrProperties.Name = "hdrProperties";
            this.hdrProperties.Size = new System.Drawing.Size(210, 25);
            this.hdrProperties.TabIndex = 2;
            this.hdrProperties.Text = "Ejendomme";
            // 
            // hdrEstateAgent
            // 
            this.hdrEstateAgent.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.hdrEstateAgent.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdrEstateAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hdrEstateAgent.Location = new System.Drawing.Point(0, 0);
            this.hdrEstateAgent.Name = "hdrEstateAgent";
            this.hdrEstateAgent.Size = new System.Drawing.Size(210, 25);
            this.hdrEstateAgent.TabIndex = 1;
            this.hdrEstateAgent.Text = "Mægler";
            // 
            // OpenHousePair
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.clsProperties);
            this.Controls.Add(this.hdrProperties);
            this.Controls.Add(this.hdrEstateAgent);
            this.Controls.Add(this.lblEstateAgentTitle);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "OpenHousePair";
            this.Size = new System.Drawing.Size(210, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEstateAgentTitle;
        private SmartControls.Header hdrEstateAgent;
        private SmartControls.Header hdrProperties;
        private SmartControls.ControlList clsProperties;
    }
}
