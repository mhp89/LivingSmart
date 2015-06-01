namespace LivingSmartForms.UserControls
{
	partial class DetailImage
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
			this.stbDescription = new SmartControls.SmartTextBox();
			this.pcbImage = new System.Windows.Forms.PictureBox();
			this.pnlImage = new System.Windows.Forms.Panel();
			this.btnRemove = new SmartControls.SmartButton();
			((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
			this.pnlImage.SuspendLayout();
			this.SuspendLayout();
			// 
			// stbDescription
			// 
			this.stbDescription.AllowComma = false;
			this.stbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.stbDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbDescription.AutomaticValidation = false;
			this.stbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbDescription.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbDescription.Location = new System.Drawing.Point(60, 0);
			this.stbDescription.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.stbDescription.MaxLength = 32767;
			this.stbDescription.MinLength = -1;
			this.stbDescription.Name = "stbDescription";
			this.stbDescription.NumericOnly = false;
			this.stbDescription.Placeholder = null;
			this.stbDescription.RegularExpression = null;
			this.stbDescription.Required = false;
			this.stbDescription.Size = new System.Drawing.Size(200, 50);
			this.stbDescription.Suffix = null;
			this.stbDescription.TabIndex = 1;
			this.stbDescription.TabStop = false;
			this.stbDescription.UseSystemPasswordChar = false;
			// 
			// pcbImage
			// 
			this.pcbImage.BackColor = System.Drawing.SystemColors.Control;
			this.pcbImage.Location = new System.Drawing.Point(1, 1);
			this.pcbImage.Margin = new System.Windows.Forms.Padding(1);
			this.pcbImage.Name = "pcbImage";
			this.pcbImage.Size = new System.Drawing.Size(48, 48);
			this.pcbImage.TabIndex = 0;
			this.pcbImage.TabStop = false;
			// 
			// pnlImage
			// 
			this.pnlImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.pnlImage.Controls.Add(this.pcbImage);
			this.pnlImage.Location = new System.Drawing.Point(0, 0);
			this.pnlImage.Margin = new System.Windows.Forms.Padding(0);
			this.pnlImage.Name = "pnlImage";
			this.pnlImage.Size = new System.Drawing.Size(50, 50);
			this.pnlImage.TabIndex = 2;
			// 
			// btnRemove
			// 
			this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnRemove.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRemove.FlatAppearance.BorderSize = 0;
			this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnRemove.Location = new System.Drawing.Point(270, 0);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Padding = new System.Windows.Forms.Padding(0);
			this.btnRemove.Size = new System.Drawing.Size(30, 50);
			this.btnRemove.TabIndex = 1;
			this.btnRemove.Text = "X";
			this.btnRemove.UseVisualStyleBackColor = false;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// DetailImage
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.pnlImage);
			this.Controls.Add(this.stbDescription);
			this.Name = "DetailImage";
			this.Size = new System.Drawing.Size(300, 50);
			((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
			this.pnlImage.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pcbImage;
		private SmartControls.SmartTextBox stbDescription;
		private System.Windows.Forms.Panel pnlImage;
		private SmartControls.SmartButton btnRemove;
	}
}
