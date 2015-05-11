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
			this.meter2 = new GraphicalMeterLibrary.Meter();
			this.meter1 = new GraphicalMeterLibrary.Meter();
			this.SuspendLayout();
			// 
			// meter2
			// 
			this.meter2.CircleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.meter2.CirclePoints = 3;
			this.meter2.CircleSize = 175;
			this.meter2.Location = new System.Drawing.Point(260, 20);
			this.meter2.Margin = new System.Windows.Forms.Padding(20);
			this.meter2.MaxValue = 60;
			this.meter2.MinValue = 0;
			this.meter2.Name = "meter2";
			this.meter2.PointerColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.meter2.Size = new System.Drawing.Size(200, 100);
			this.meter2.TabIndex = 1;
			this.meter2.Text = "meter2";
			this.meter2.Value = 33;
			// 
			// meter1
			// 
			this.meter1.CircleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.meter1.CirclePoints = 3;
			this.meter1.CircleSize = 175;
			this.meter1.Location = new System.Drawing.Point(20, 20);
			this.meter1.Margin = new System.Windows.Forms.Padding(20);
			this.meter1.MaxValue = 60;
			this.meter1.MinValue = 0;
			this.meter1.Name = "meter1";
			this.meter1.PointerColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.meter1.Size = new System.Drawing.Size(200, 100);
			this.meter1.TabIndex = 0;
			this.meter1.Text = "meter1";
			this.meter1.Value = 33;
			// 
			// Overview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.meter2);
			this.Controls.Add(this.meter1);
			this.Name = "Overview";
			this.Size = new System.Drawing.Size(1135, 560);
			this.ResumeLayout(false);

		}

		#endregion

		private GraphicalMeterLibrary.Meter meter1;
		private GraphicalMeterLibrary.Meter meter2;
	}
}
