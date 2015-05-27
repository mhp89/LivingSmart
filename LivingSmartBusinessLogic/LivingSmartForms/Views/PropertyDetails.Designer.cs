namespace LivingSmartForms.Views
{
    partial class PropertyDetails
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
            this.hdrPropertyDetails = new SmartControls.Header();
            this.tlpPropertyDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblDetailsPictures = new System.Windows.Forms.Label();
            this.stbDetailsDescription = new SmartControls.SmartTextBox();
            this.stbDetailsPrice = new SmartControls.SmartTextBox();
            this.lblDetailsDescription = new System.Windows.Forms.Label();
            this.lblDetailsPublicEvaluation = new System.Windows.Forms.Label();
            this.lblDetailsEvaluation = new System.Windows.Forms.Label();
            this.lblDetailsPrice = new System.Windows.Forms.Label();
            this.stbDetailsPublicEvaluation = new SmartControls.SmartTextBox();
            this.stbDetailsEvaluation = new SmartControls.SmartTextBox();
            this.pnlDetailsPictures = new System.Windows.Forms.Panel();
            this.tlpPropertyDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // hdrPropertyDetails
            // 
            this.hdrPropertyDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hdrPropertyDetails.Color = SmartControls.SmartColor.ColorStyle.Dark;
            this.hdrPropertyDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.hdrPropertyDetails.Location = new System.Drawing.Point(0, 10);
            this.hdrPropertyDetails.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.hdrPropertyDetails.Name = "hdrPropertyDetails";
            this.hdrPropertyDetails.Size = new System.Drawing.Size(480, 25);
            this.hdrPropertyDetails.TabIndex = 4;
            this.hdrPropertyDetails.Text = "Detaljer";
            // 
            // tlpPropertyDetails
            // 
            this.tlpPropertyDetails.ColumnCount = 2;
            this.tlpPropertyDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.08333F));
            this.tlpPropertyDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.91666F));
            this.tlpPropertyDetails.Controls.Add(this.lblDetailsPictures, 0, 4);
            this.tlpPropertyDetails.Controls.Add(this.stbDetailsDescription, 1, 3);
            this.tlpPropertyDetails.Controls.Add(this.stbDetailsPrice, 1, 2);
            this.tlpPropertyDetails.Controls.Add(this.lblDetailsDescription, 0, 3);
            this.tlpPropertyDetails.Controls.Add(this.lblDetailsPublicEvaluation, 0, 0);
            this.tlpPropertyDetails.Controls.Add(this.lblDetailsEvaluation, 0, 1);
            this.tlpPropertyDetails.Controls.Add(this.lblDetailsPrice, 0, 2);
            this.tlpPropertyDetails.Controls.Add(this.stbDetailsPublicEvaluation, 1, 0);
            this.tlpPropertyDetails.Controls.Add(this.stbDetailsEvaluation, 1, 1);
            this.tlpPropertyDetails.Controls.Add(this.pnlDetailsPictures, 1, 4);
            this.tlpPropertyDetails.Location = new System.Drawing.Point(0, 45);
            this.tlpPropertyDetails.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPropertyDetails.Name = "tlpPropertyDetails";
            this.tlpPropertyDetails.RowCount = 5;
            this.tlpPropertyDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPropertyDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPropertyDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPropertyDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpPropertyDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpPropertyDetails.Size = new System.Drawing.Size(480, 405);
            this.tlpPropertyDetails.TabIndex = 5;
            // 
            // lblDetailsPictures
            // 
            this.lblDetailsPictures.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetailsPictures.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsPictures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblDetailsPictures.Location = new System.Drawing.Point(0, 220);
            this.lblDetailsPictures.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblDetailsPictures.Name = "lblDetailsPictures";
            this.lblDetailsPictures.Size = new System.Drawing.Size(130, 30);
            this.lblDetailsPictures.TabIndex = 16;
            this.lblDetailsPictures.Text = "Billeder";
            this.lblDetailsPictures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stbDetailsDescription
            // 
            this.stbDetailsDescription.AllowComma = false;
            this.stbDetailsDescription.AutomaticValidation = true;
            this.stbDetailsDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stbDetailsDescription.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.stbDetailsDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stbDetailsDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stbDetailsDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.stbDetailsDescription.Location = new System.Drawing.Point(130, 120);
            this.stbDetailsDescription.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.stbDetailsDescription.MaxLength = 500;
            this.stbDetailsDescription.MinLength = 1;
            this.stbDetailsDescription.Name = "stbDetailsDescription";
            this.stbDetailsDescription.NumericOnly = false;
            this.stbDetailsDescription.Placeholder = null;
            this.stbDetailsDescription.RegularExpression = null;
            this.stbDetailsDescription.Size = new System.Drawing.Size(350, 90);
            this.stbDetailsDescription.Suffix = null;
            this.stbDetailsDescription.TabIndex = 15;
            this.stbDetailsDescription.UseSystemPasswordChar = false;
            // 
            // stbDetailsPrice
            // 
            this.stbDetailsPrice.AllowComma = false;
            this.stbDetailsPrice.AutomaticValidation = true;
            this.stbDetailsPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stbDetailsPrice.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.stbDetailsPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stbDetailsPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stbDetailsPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.stbDetailsPrice.Location = new System.Drawing.Point(130, 80);
            this.stbDetailsPrice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.stbDetailsPrice.MaxLength = 50;
            this.stbDetailsPrice.MinLength = 1;
            this.stbDetailsPrice.Name = "stbDetailsPrice";
            this.stbDetailsPrice.NumericOnly = true;
            this.stbDetailsPrice.Placeholder = null;
            this.stbDetailsPrice.RegularExpression = null;
            this.stbDetailsPrice.Size = new System.Drawing.Size(350, 30);
            this.stbDetailsPrice.Suffix = null;
            this.stbDetailsPrice.TabIndex = 15;
            this.stbDetailsPrice.UseSystemPasswordChar = false;
            // 
            // lblDetailsDescription
            // 
            this.lblDetailsDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetailsDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblDetailsDescription.Location = new System.Drawing.Point(0, 120);
            this.lblDetailsDescription.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblDetailsDescription.Name = "lblDetailsDescription";
            this.lblDetailsDescription.Size = new System.Drawing.Size(130, 30);
            this.lblDetailsDescription.TabIndex = 8;
            this.lblDetailsDescription.Text = "Beskrivelse";
            this.lblDetailsDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDetailsPublicEvaluation
            // 
            this.lblDetailsPublicEvaluation.AutoSize = true;
            this.lblDetailsPublicEvaluation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetailsPublicEvaluation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsPublicEvaluation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblDetailsPublicEvaluation.Location = new System.Drawing.Point(0, 0);
            this.lblDetailsPublicEvaluation.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblDetailsPublicEvaluation.Name = "lblDetailsPublicEvaluation";
            this.lblDetailsPublicEvaluation.Size = new System.Drawing.Size(130, 30);
            this.lblDetailsPublicEvaluation.TabIndex = 5;
            this.lblDetailsPublicEvaluation.Text = "Off. vurdering";
            this.lblDetailsPublicEvaluation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDetailsEvaluation
            // 
            this.lblDetailsEvaluation.AutoSize = true;
            this.lblDetailsEvaluation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetailsEvaluation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsEvaluation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblDetailsEvaluation.Location = new System.Drawing.Point(0, 40);
            this.lblDetailsEvaluation.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblDetailsEvaluation.Name = "lblDetailsEvaluation";
            this.lblDetailsEvaluation.Size = new System.Drawing.Size(130, 30);
            this.lblDetailsEvaluation.TabIndex = 6;
            this.lblDetailsEvaluation.Text = "Vurdering";
            this.lblDetailsEvaluation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDetailsPrice
            // 
            this.lblDetailsPrice.AutoSize = true;
            this.lblDetailsPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblDetailsPrice.Location = new System.Drawing.Point(0, 80);
            this.lblDetailsPrice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblDetailsPrice.Name = "lblDetailsPrice";
            this.lblDetailsPrice.Size = new System.Drawing.Size(102, 23);
            this.lblDetailsPrice.TabIndex = 7;
            this.lblDetailsPrice.Text = "Udbudspris";
            this.lblDetailsPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stbDetailsPublicEvaluation
            // 
            this.stbDetailsPublicEvaluation.AllowComma = false;
            this.stbDetailsPublicEvaluation.AutomaticValidation = true;
            this.stbDetailsPublicEvaluation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stbDetailsPublicEvaluation.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.stbDetailsPublicEvaluation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stbDetailsPublicEvaluation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stbDetailsPublicEvaluation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.stbDetailsPublicEvaluation.Location = new System.Drawing.Point(130, 0);
            this.stbDetailsPublicEvaluation.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.stbDetailsPublicEvaluation.MaxLength = 50;
            this.stbDetailsPublicEvaluation.MinLength = 1;
            this.stbDetailsPublicEvaluation.Name = "stbDetailsPublicEvaluation";
            this.stbDetailsPublicEvaluation.NumericOnly = true;
            this.stbDetailsPublicEvaluation.Placeholder = null;
            this.stbDetailsPublicEvaluation.RegularExpression = null;
            this.stbDetailsPublicEvaluation.Size = new System.Drawing.Size(350, 30);
            this.stbDetailsPublicEvaluation.Suffix = null;
            this.stbDetailsPublicEvaluation.TabIndex = 13;
            this.stbDetailsPublicEvaluation.UseSystemPasswordChar = false;
            // 
            // stbDetailsEvaluation
            // 
            this.stbDetailsEvaluation.AllowComma = false;
            this.stbDetailsEvaluation.AutomaticValidation = true;
            this.stbDetailsEvaluation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stbDetailsEvaluation.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.stbDetailsEvaluation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stbDetailsEvaluation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stbDetailsEvaluation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.stbDetailsEvaluation.Location = new System.Drawing.Point(130, 40);
            this.stbDetailsEvaluation.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.stbDetailsEvaluation.MaxLength = 50;
            this.stbDetailsEvaluation.MinLength = 1;
            this.stbDetailsEvaluation.Name = "stbDetailsEvaluation";
            this.stbDetailsEvaluation.NumericOnly = true;
            this.stbDetailsEvaluation.Placeholder = null;
            this.stbDetailsEvaluation.RegularExpression = null;
            this.stbDetailsEvaluation.Size = new System.Drawing.Size(350, 30);
            this.stbDetailsEvaluation.Suffix = null;
            this.stbDetailsEvaluation.TabIndex = 14;
            this.stbDetailsEvaluation.UseSystemPasswordChar = false;
            // 
            // pnlDetailsPictures
            // 
            this.pnlDetailsPictures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailsPictures.Location = new System.Drawing.Point(130, 220);
            this.pnlDetailsPictures.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDetailsPictures.Name = "pnlDetailsPictures";
            this.pnlDetailsPictures.Size = new System.Drawing.Size(350, 185);
            this.pnlDetailsPictures.TabIndex = 17;
            // 
            // PropertyDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tlpPropertyDetails);
            this.Controls.Add(this.hdrPropertyDetails);
            this.Name = "PropertyDetails";
            this.Size = new System.Drawing.Size(480, 450);
            this.tlpPropertyDetails.ResumeLayout(false);
            this.tlpPropertyDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SmartControls.Header hdrPropertyDetails;
        private System.Windows.Forms.TableLayoutPanel tlpPropertyDetails;
        private System.Windows.Forms.Label lblDetailsPublicEvaluation;
        private System.Windows.Forms.Label lblDetailsDescription;
        private System.Windows.Forms.Label lblDetailsEvaluation;
        private System.Windows.Forms.Label lblDetailsPrice;
        private SmartControls.SmartTextBox stbDetailsPublicEvaluation;
        private System.Windows.Forms.Label lblDetailsPictures;
        private SmartControls.SmartTextBox stbDetailsDescription;
        private SmartControls.SmartTextBox stbDetailsPrice;
        private SmartControls.SmartTextBox stbDetailsEvaluation;
        private System.Windows.Forms.Panel pnlDetailsPictures;

    }
}
