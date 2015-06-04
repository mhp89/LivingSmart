namespace LivingSmartForms.Views
{
	partial class DetailDocument
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
			this.stbType = new SmartControls.SmartTextBox();
			this.btnRemove = new SmartControls.SmartButton();
			this.stbPrice = new SmartControls.SmartTextBox();
			this.lblFile = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// stbType
			// 
			this.stbType.AllowComma = false;
			this.stbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.stbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbType.AutomaticValidation = false;
			this.stbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbType.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbType.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbType.Location = new System.Drawing.Point(0, 40);
			this.stbType.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
			this.stbType.MaxLength = 32767;
			this.stbType.MinLength = -1;
			this.stbType.Multiline = false;
			this.stbType.Name = "stbType";
			this.stbType.NumericOnly = false;
			this.stbType.Placeholder = "Type";
			this.stbType.RegularExpression = null;
			this.stbType.Required = true;
			this.stbType.Size = new System.Drawing.Size(260, 30);
			this.stbType.Suffix = null;
			this.stbType.TabIndex = 1;
			this.stbType.TabStop = false;
			this.stbType.UseSystemPasswordChar = false;
			this.stbType.TextChanged += new System.EventHandler(this.stbType_TextChanged);
			// 
			// btnRemove
			// 
			this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
			this.btnRemove.Size = new System.Drawing.Size(30, 70);
			this.btnRemove.TabIndex = 1;
			this.btnRemove.Text = "X";
			this.btnRemove.UseVisualStyleBackColor = false;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// stbPrice
			// 
			this.stbPrice.AllowComma = true;
			this.stbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.stbPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbPrice.AutomaticValidation = false;
			this.stbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbPrice.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbPrice.Location = new System.Drawing.Point(150, 0);
			this.stbPrice.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.stbPrice.MaxLength = 32767;
			this.stbPrice.MinLength = -1;
			this.stbPrice.Multiline = false;
			this.stbPrice.Name = "stbPrice";
			this.stbPrice.NumericOnly = true;
			this.stbPrice.Placeholder = "Pris";
			this.stbPrice.RegularExpression = null;
			this.stbPrice.Required = true;
			this.stbPrice.Size = new System.Drawing.Size(110, 30);
			this.stbPrice.Suffix = "kr.";
			this.stbPrice.TabIndex = 3;
			this.stbPrice.TabStop = false;
			this.stbPrice.UseSystemPasswordChar = false;
			this.stbPrice.TextChanged += new System.EventHandler(this.stbPrice_TextChanged);
			// 
			// lblFile
			// 
			this.lblFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblFile.Location = new System.Drawing.Point(0, 0);
			this.lblFile.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblFile.Name = "lblFile";
			this.lblFile.Size = new System.Drawing.Size(140, 30);
			this.lblFile.TabIndex = 17;
			this.lblFile.Text = "Fil";
			this.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// DetailDocument
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.lblFile);
			this.Controls.Add(this.stbPrice);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.stbType);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "DetailDocument";
			this.Size = new System.Drawing.Size(300, 70);
			this.ResumeLayout(false);

		}

		#endregion

		private SmartControls.SmartTextBox stbType;
		private SmartControls.SmartButton btnRemove;
		private SmartControls.SmartTextBox stbPrice;
		private System.Windows.Forms.Label lblFile;
	}
}
