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
			this.caseLineSimple1 = new LivingSmartForms.Views.CaseLineSimple();
			this.caseLineSimple2 = new LivingSmartForms.Views.CaseLineSimple();
			this.caseLineSimple3 = new LivingSmartForms.Views.CaseLineSimple();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
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
			this.meter2.Value = 54;
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
			this.meter1.Value = 54;
			// 
			// caseLineSimple1
			// 
			this.caseLineSimple1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.caseLineSimple1.Location = new System.Drawing.Point(20, 366);
			this.caseLineSimple1.Margin = new System.Windows.Forms.Padding(2);
			this.caseLineSimple1.Name = "caseLineSimple1";
			this.caseLineSimple1.Size = new System.Drawing.Size(1095, 49);
			this.caseLineSimple1.TabIndex = 2;
			// 
			// caseLineSimple2
			// 
			this.caseLineSimple2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.caseLineSimple2.Location = new System.Drawing.Point(20, 419);
			this.caseLineSimple2.Margin = new System.Windows.Forms.Padding(2);
			this.caseLineSimple2.Name = "caseLineSimple2";
			this.caseLineSimple2.Size = new System.Drawing.Size(1095, 49);
			this.caseLineSimple2.TabIndex = 3;
			// 
			// caseLineSimple3
			// 
			this.caseLineSimple3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.caseLineSimple3.Location = new System.Drawing.Point(20, 472);
			this.caseLineSimple3.Margin = new System.Windows.Forms.Padding(2);
			this.caseLineSimple3.Name = "caseLineSimple3";
			this.caseLineSimple3.Size = new System.Drawing.Size(1095, 49);
			this.caseLineSimple3.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.label1.Location = new System.Drawing.Point(15, 321);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(202, 30);
			this.label1.TabIndex = 5;
			this.label1.Text = "Igangv�rende sager";
			// 
			// Overview
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.caseLineSimple3);
			this.Controls.Add(this.caseLineSimple2);
			this.Controls.Add(this.caseLineSimple1);
			this.Controls.Add(this.meter2);
			this.Controls.Add(this.meter1);
			this.Name = "Overview";
			this.Size = new System.Drawing.Size(1135, 560);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private GraphicalMeterLibrary.Meter meter1;
		private GraphicalMeterLibrary.Meter meter2;
		private Views.CaseLineSimple caseLineSimple1;
		private Views.CaseLineSimple caseLineSimple2;
		private Views.CaseLineSimple caseLineSimple3;
		private System.Windows.Forms.Label label1;
	}
}
