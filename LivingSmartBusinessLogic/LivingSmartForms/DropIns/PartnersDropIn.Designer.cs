using SmartControls;

namespace LivingSmartForms.DropIns
{
	partial class PartnersDropIn
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
			this.clsPartners = new SmartControls.ControlList();
			this.analogClock1 = new SmartControls.AnalogClock();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblCity = new System.Windows.Forms.Label();
			this.lnlPartner = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// clsPartners
			// 
			this.clsPartners.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.clsPartners.AutoScroll = true;
			this.clsPartners.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.clsPartners.Location = new System.Drawing.Point(0, 115);
			this.clsPartners.Margin = new System.Windows.Forms.Padding(0);
			this.clsPartners.Name = "clsPartners";
			this.clsPartners.Size = new System.Drawing.Size(300, 385);
			this.clsPartners.TabIndex = 0;
			this.clsPartners.WrapContents = false;
			// 
			// analogClock1
			// 
			this.analogClock1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.analogClock1.Location = new System.Drawing.Point(0, 0);
			this.analogClock1.Margin = new System.Windows.Forms.Padding(0);
			this.analogClock1.Name = "analogClock1";
			this.analogClock1.Points = 12;
			this.analogClock1.Size = new System.Drawing.Size(83, 83);
			this.analogClock1.TabIndex = 1;
			this.analogClock1.Text = "analogClock1";
			this.analogClock1.Timezone = "Romance Standard Time";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.lblCity);
			this.panel1.Controls.Add(this.lnlPartner);
			this.panel1.Controls.Add(this.analogClock1);
			this.panel1.Location = new System.Drawing.Point(10, 10);
			this.panel1.Margin = new System.Windows.Forms.Padding(10);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(280, 95);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 93);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(280, 2);
			this.panel2.TabIndex = 12;
			// 
			// lblCity
			// 
			this.lblCity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCity.Location = new System.Drawing.Point(96, 32);
			this.lblCity.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
			this.lblCity.Name = "lblCity";
			this.lblCity.Size = new System.Drawing.Size(184, 17);
			this.lblCity.TabIndex = 11;
			this.lblCity.Text = "Vejle, Danmark";
			// 
			// lnlPartner
			// 
			this.lnlPartner.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnlPartner.Location = new System.Drawing.Point(96, 10);
			this.lnlPartner.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
			this.lnlPartner.Name = "lnlPartner";
			this.lnlPartner.Size = new System.Drawing.Size(184, 17);
			this.lnlPartner.TabIndex = 10;
			this.lnlPartner.Text = "Living Smart";
			// 
			// PartnersDropIn
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.clsPartners);
			this.Name = "PartnersDropIn";
			this.Size = new System.Drawing.Size(300, 500);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private ControlList clsPartners;
		private AnalogClock analogClock1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.Label lnlPartner;
		private System.Windows.Forms.Panel panel2;

	}
}
