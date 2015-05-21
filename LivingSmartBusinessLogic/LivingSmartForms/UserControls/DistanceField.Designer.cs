namespace LivingSmartForms.UserControls
{
	partial class DistanceField
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
            this.stpDistance = new SmartControls.SmartTextBox();
            this.btnRemove = new SmartControls.SmartButton();
            this.tlpHolder = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // stbType
            // 
            this.stbType.AllowComma = false;
            this.stbType.AutomaticValidation = false;
            this.stbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stbType.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.stbType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stbType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.stbType.Location = new System.Drawing.Point(0, 0);
            this.stbType.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.stbType.MaxLength = 50;
            this.stbType.MinLength = -1;
            this.stbType.Name = "stbType";
            this.stbType.NumericOnly = false;
            this.stbType.RegularExpression = null;
            this.stbType.Size = new System.Drawing.Size(180, 30);
            this.stbType.Suffix = null;
            this.stbType.TabIndex = 0;
            this.stbType.UseSystemPasswordChar = false;
            // 
            // stpDistance
            // 
            this.stpDistance.AllowComma = false;
            this.stpDistance.AutomaticValidation = true;
            this.stpDistance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stpDistance.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.stpDistance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stpDistance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stpDistance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.stpDistance.Location = new System.Drawing.Point(190, 0);
            this.stpDistance.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.stpDistance.MaxLength = 50;
            this.stpDistance.MinLength = 1;
            this.stpDistance.Name = "stpDistance";
            this.stpDistance.NumericOnly = true;
            this.stpDistance.RegularExpression = null;
            this.stpDistance.Size = new System.Drawing.Size(92, 30);
            this.stpDistance.Suffix = null;
            this.stpDistance.TabIndex = 1;
            this.stpDistance.UseSystemPasswordChar = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.AutoSize = true;
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnRemove.Color = SmartControls.SmartColor.ColorStyle.Dark;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnRemove.Location = new System.Drawing.Point(293, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(57, 30);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // tlpHolder
            // 
            this.tlpHolder.ColumnCount = 3;
            this.tlpHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHolder.Controls.Add(this.btnRemove, 2, 0);
            this.tlpHolder.Controls.Add(this.stbType, 0, 0);
            this.tlpHolder.Controls.Add(this.stpDistance, 1, 0);
            this.tlpHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHolder.Location = new System.Drawing.Point(0, 0);
            this.tlpHolder.Margin = new System.Windows.Forms.Padding(0);
            this.tlpHolder.Name = "tlpHolder";
            this.tlpHolder.RowCount = 1;
            this.tlpHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHolder.Size = new System.Drawing.Size(350, 30);
            this.tlpHolder.TabIndex = 3;
            // 
            // DistanceField
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tlpHolder);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DistanceField";
            this.Size = new System.Drawing.Size(350, 30);
            this.tlpHolder.ResumeLayout(false);
            this.tlpHolder.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private SmartControls.SmartTextBox stbType;
		private SmartControls.SmartTextBox stpDistance;
		private System.Windows.Forms.TableLayoutPanel tlpHolder;
		private SmartControls.SmartButton btnRemove;
	}
}
