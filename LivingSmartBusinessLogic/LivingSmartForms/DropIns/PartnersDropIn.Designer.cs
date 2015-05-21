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
			this.SuspendLayout();
			// 
			// clsPartners
			// 
			this.clsPartners.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.clsPartners.AutoScroll = true;
			this.clsPartners.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.clsPartners.Location = new System.Drawing.Point(0, 0);
			this.clsPartners.Margin = new System.Windows.Forms.Padding(0);
			this.clsPartners.Name = "clsPartners";
			this.clsPartners.Size = new System.Drawing.Size(300, 500);
			this.clsPartners.TabIndex = 0;
			// 
			// PartnersDropIn
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.clsPartners);
			this.Name = "PartnersDropIn";
			this.Size = new System.Drawing.Size(300, 500);
			this.ResumeLayout(false);

		}

		#endregion

		private ControlList clsPartners;

	}
}
