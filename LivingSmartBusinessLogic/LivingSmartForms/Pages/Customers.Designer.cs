namespace LivingSmartForms.Pages
{
    partial class Customers
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
            this.controlList1 = new SmartControls.ControlList();
            this.header1 = new SmartControls.Header();
            this.meter2 = new GraphicalMeterLibrary.Meter();
            this.meter1 = new GraphicalMeterLibrary.Meter();
            this.SuspendLayout();
            // 
            // controlList1
            // 
            this.controlList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlList1.AutoScroll = true;
            this.controlList1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.controlList1.Location = new System.Drawing.Point(20, 301);
            this.controlList1.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.controlList1.Name = "controlList1";
            this.controlList1.Size = new System.Drawing.Size(1095, 239);
            this.controlList1.TabIndex = 6;
            this.controlList1.WrapContents = false;
            // 
            // header1
            // 
            this.header1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header1.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.header1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.header1.Location = new System.Drawing.Point(10, 266);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1115, 25);
            this.header1.TabIndex = 5;
            this.header1.Text = "Kunder";
            // 
            // meter2
            // 
            this.meter2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.meter2.CircleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.meter2.CirclePoints = 3;
            this.meter2.CircleSize = 175;
            this.meter2.Location = new System.Drawing.Point(915, 20);
            this.meter2.Margin = new System.Windows.Forms.Padding(20);
            this.meter2.MaxValue = 60;
            this.meter2.MinValue = 0;
            this.meter2.Name = "meter2";
            this.meter2.PointerColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.meter2.Size = new System.Drawing.Size(200, 100);
            this.meter2.TabIndex = 1;
            this.meter2.Text = "meter2";
            this.meter2.Value = 25;
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
            this.meter1.Value = 25;
            // 
            // Customers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.controlList1);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.meter2);
            this.Controls.Add(this.meter1);
            this.Name = "Customers";
            this.Size = new System.Drawing.Size(1135, 560);
            this.ResumeLayout(false);

		}

		#endregion

		private GraphicalMeterLibrary.Meter meter1;
		private GraphicalMeterLibrary.Meter meter2;
		private SmartControls.Header header1;
		private SmartControls.ControlList controlList1;
	}
}
