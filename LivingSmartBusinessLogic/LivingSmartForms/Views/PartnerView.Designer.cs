using SmartControls;

namespace LivingSmartForms.Views
{
	partial class PartnerView
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
			this.analogClock = new SmartControls.AnalogClock();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblTelephone = new System.Windows.Forms.Label();
			this.lblCity = new System.Windows.Forms.Label();
			this.lnlPartner = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// analogClock
			// 
			this.analogClock.ForeColor = SmartColor.Dark;
			this.analogClock.Location = new System.Drawing.Point(10, 10);
			this.analogClock.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
			this.analogClock.Name = "analogClock";
			this.analogClock.Points = 12;
			this.analogClock.Size = new System.Drawing.Size(83, 83);
			this.analogClock.TabIndex = 10;
			this.analogClock.Text = "analogClock1";
			this.analogClock.Timezone = "Romance Standard Time";
			// 
			// lblEmail
			// 
			this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.Location = new System.Drawing.Point(103, 76);
			this.lblEmail.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(167, 17);
			this.lblEmail.TabIndex = 9;
			this.lblEmail.Text = "contact@NYHouses.com";
			// 
			// lblTelephone
			// 
			this.lblTelephone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelephone.Location = new System.Drawing.Point(103, 54);
			this.lblTelephone.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
			this.lblTelephone.Name = "lblTelephone";
			this.lblTelephone.Size = new System.Drawing.Size(167, 17);
			this.lblTelephone.TabIndex = 8;
			this.lblTelephone.Text = "+1 917-710-045";
			// 
			// lblCity
			// 
			this.lblCity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCity.Location = new System.Drawing.Point(103, 32);
			this.lblCity.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
			this.lblCity.Name = "lblCity";
			this.lblCity.Size = new System.Drawing.Size(167, 17);
			this.lblCity.TabIndex = 7;
			this.lblCity.Text = "New York City, NY, USA";
			// 
			// lnlPartner
			// 
			this.lnlPartner.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnlPartner.Location = new System.Drawing.Point(103, 10);
			this.lnlPartner.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
			this.lnlPartner.Name = "lnlPartner";
			this.lnlPartner.Size = new System.Drawing.Size(167, 17);
			this.lnlPartner.TabIndex = 6;
			this.lnlPartner.Text = "Newyorker Houses";
			// 
			// PartnerView
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.analogClock);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblTelephone);
			this.Controls.Add(this.lblCity);
			this.Controls.Add(this.lnlPartner);
			this.Name = "PartnerView";
			this.Size = new System.Drawing.Size(280, 103);
			this.ResumeLayout(false);

		}

		#endregion

		private SmartControls.AnalogClock analogClock;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.Label lnlPartner;
		private System.Windows.Forms.Label lblTelephone;
	}
}
