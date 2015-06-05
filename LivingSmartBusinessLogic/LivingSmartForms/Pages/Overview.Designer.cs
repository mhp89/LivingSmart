using SmartControls;

namespace LivingSmartForms.Pages
{
	partial class Overview
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
            this.lblCountTitle = new System.Windows.Forms.Label();
            this.pnlNoOfProperties = new System.Windows.Forms.Panel();
            this.lblCountValue = new System.Windows.Forms.Label();
            this.mtrCount = new GraphicalMeterLibrary.Meter();
            this.pnlPrice = new System.Windows.Forms.Panel();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.mtrPrice = new GraphicalMeterLibrary.Meter();
            this.lblPriceTitle = new System.Windows.Forms.Label();
            this.lblAgentName = new System.Windows.Forms.Label();
            this.hdrDials = new SmartControls.Header();
            this.hdrOngoingCases = new SmartControls.Header();
            this.clsActiveCases = new SmartControls.ControlList();
            this.pnlNoOfProperties.SuspendLayout();
            this.pnlPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCountTitle
            // 
            this.lblCountTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCountTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lblCountTitle.Location = new System.Drawing.Point(0, 0);
            this.lblCountTitle.Name = "lblCountTitle";
            this.lblCountTitle.Size = new System.Drawing.Size(200, 20);
            this.lblCountTitle.TabIndex = 7;
            this.lblCountTitle.Text = "Antal ejendomme";
            this.lblCountTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlNoOfProperties
            // 
            this.pnlNoOfProperties.Controls.Add(this.lblCountValue);
            this.pnlNoOfProperties.Controls.Add(this.mtrCount);
            this.pnlNoOfProperties.Controls.Add(this.lblCountTitle);
            this.pnlNoOfProperties.Location = new System.Drawing.Point(20, 45);
            this.pnlNoOfProperties.Name = "pnlNoOfProperties";
            this.pnlNoOfProperties.Size = new System.Drawing.Size(200, 150);
            this.pnlNoOfProperties.TabIndex = 11;
            // 
            // lblCountValue
            // 
            this.lblCountValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCountValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lblCountValue.Location = new System.Drawing.Point(0, 130);
            this.lblCountValue.Name = "lblCountValue";
            this.lblCountValue.Size = new System.Drawing.Size(200, 20);
            this.lblCountValue.TabIndex = 8;
            this.lblCountValue.Text = "Antal";
            this.lblCountValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mtrCount
            // 
            this.mtrCount.CircleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mtrCount.CirclePoints = 3;
            this.mtrCount.CircleSize = 175;
            this.mtrCount.Location = new System.Drawing.Point(0, 30);
            this.mtrCount.Margin = new System.Windows.Forms.Padding(20);
            this.mtrCount.MaxValue = 10;
            this.mtrCount.MinValue = 0;
            this.mtrCount.Name = "mtrCount";
            this.mtrCount.PointerColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.mtrCount.Size = new System.Drawing.Size(200, 90);
            this.mtrCount.TabIndex = 0;
            this.mtrCount.TabStop = false;
            this.mtrCount.Text = "meter1";
            this.mtrCount.Value = 0;
            // 
            // pnlPrice
            // 
            this.pnlPrice.Controls.Add(this.lblPriceValue);
            this.pnlPrice.Controls.Add(this.mtrPrice);
            this.pnlPrice.Controls.Add(this.lblPriceTitle);
            this.pnlPrice.Location = new System.Drawing.Point(270, 45);
            this.pnlPrice.Name = "pnlPrice";
            this.pnlPrice.Size = new System.Drawing.Size(200, 150);
            this.pnlPrice.TabIndex = 12;
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPriceValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lblPriceValue.Location = new System.Drawing.Point(0, 130);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(200, 20);
            this.lblPriceValue.TabIndex = 8;
            this.lblPriceValue.Text = "Pris";
            this.lblPriceValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mtrPrice
            // 
            this.mtrPrice.CircleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mtrPrice.CirclePoints = 3;
            this.mtrPrice.CircleSize = 175;
            this.mtrPrice.Location = new System.Drawing.Point(0, 30);
            this.mtrPrice.Margin = new System.Windows.Forms.Padding(20);
            this.mtrPrice.MaxValue = 10;
            this.mtrPrice.MinValue = 0;
            this.mtrPrice.Name = "mtrPrice";
            this.mtrPrice.PointerColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.mtrPrice.Size = new System.Drawing.Size(200, 90);
            this.mtrPrice.TabIndex = 0;
            this.mtrPrice.TabStop = false;
            this.mtrPrice.Text = "meter1";
            this.mtrPrice.Value = 0;
            // 
            // lblPriceTitle
            // 
            this.lblPriceTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPriceTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lblPriceTitle.Location = new System.Drawing.Point(0, 0);
            this.lblPriceTitle.Name = "lblPriceTitle";
            this.lblPriceTitle.Size = new System.Drawing.Size(200, 20);
            this.lblPriceTitle.TabIndex = 7;
            this.lblPriceTitle.Text = "Samlet salgspris";
            this.lblPriceTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAgentName
            // 
            this.lblAgentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAgentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lblAgentName.Location = new System.Drawing.Point(970, 10);
            this.lblAgentName.Margin = new System.Windows.Forms.Padding(0, 10, 15, 0);
            this.lblAgentName.Name = "lblAgentName";
            this.lblAgentName.Size = new System.Drawing.Size(150, 18);
            this.lblAgentName.TabIndex = 13;
            this.lblAgentName.Text = "Navn";
            this.lblAgentName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // hdrDials
            // 
            this.hdrDials.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hdrDials.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.hdrDials.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hdrDials.Location = new System.Drawing.Point(10, 10);
            this.hdrDials.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.hdrDials.Name = "hdrDials";
            this.hdrDials.Size = new System.Drawing.Size(1115, 25);
            this.hdrDials.TabIndex = 10;
            this.hdrDials.Text = "Ejendomme solgt i indeværende år sammenlignet med sidste år";
            // 
            // hdrOngoingCases
            // 
            this.hdrOngoingCases.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hdrOngoingCases.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.hdrOngoingCases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hdrOngoingCases.Location = new System.Drawing.Point(10, 218);
            this.hdrOngoingCases.Margin = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.hdrOngoingCases.Name = "hdrOngoingCases";
            this.hdrOngoingCases.Size = new System.Drawing.Size(1115, 25);
            this.hdrOngoingCases.TabIndex = 9;
            this.hdrOngoingCases.Text = "Igangværende sager";
            // 
            // clsActiveCases
            // 
            this.clsActiveCases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clsActiveCases.AutoScroll = true;
            this.clsActiveCases.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.clsActiveCases.Location = new System.Drawing.Point(20, 253);
            this.clsActiveCases.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.clsActiveCases.Name = "clsActiveCases";
            this.clsActiveCases.Size = new System.Drawing.Size(1095, 287);
            this.clsActiveCases.Spacing = 5;
            this.clsActiveCases.TabIndex = 6;
            this.clsActiveCases.WrapContents = false;
            // 
            // Overview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblAgentName);
            this.Controls.Add(this.pnlPrice);
            this.Controls.Add(this.pnlNoOfProperties);
            this.Controls.Add(this.hdrDials);
            this.Controls.Add(this.hdrOngoingCases);
            this.Controls.Add(this.clsActiveCases);
            this.Name = "Overview";
            this.Size = new System.Drawing.Size(1135, 560);
            this.pnlNoOfProperties.ResumeLayout(false);
            this.pnlPrice.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private GraphicalMeterLibrary.Meter mtrCount;
		private SmartControls.ControlList clsActiveCases;
        private System.Windows.Forms.Label lblCountTitle;
        private Header hdrOngoingCases;
        private Header hdrDials;
        private System.Windows.Forms.Panel pnlNoOfProperties;
        private System.Windows.Forms.Label lblCountValue;
        private System.Windows.Forms.Panel pnlPrice;
        private System.Windows.Forms.Label lblPriceValue;
        private GraphicalMeterLibrary.Meter mtrPrice;
        private System.Windows.Forms.Label lblPriceTitle;
        private System.Windows.Forms.Label lblAgentName;
	}
}
