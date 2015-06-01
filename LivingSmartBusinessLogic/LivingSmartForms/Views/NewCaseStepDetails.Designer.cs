using LivingSmartForms.Classes;
using SmartControls;

namespace LivingSmartForms.Views
{
    partial class NewCaseStepDetails
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
			this.tlpPropertyDetails = new System.Windows.Forms.TableLayoutPanel();
			this.lblDetailsPictures = new System.Windows.Forms.Label();
			this.stbDetailsDescription = new SmartControls.SmartTextBox();
			this.stbDetailsPrice = new SmartControls.SmartTextBox();
			this.lblDetailsDescription = new System.Windows.Forms.Label();
			this.lblDetailsPublicEvaluation = new System.Windows.Forms.Label();
			this.lblDetailsEvaluation = new System.Windows.Forms.Label();
			this.lblDetailsPrice = new System.Windows.Forms.Label();
			this.stbDetailsPublicEvaluation = new SmartControls.SmartTextBox();
			this.stbDetailsRating = new SmartControls.SmartTextBox();
			this.pnlDetailsPictures = new System.Windows.Forms.Panel();
			this.clsImages = new SmartControls.ControlList();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnAddImage = new SmartControls.SmartButton();
			this.hdrPropertyDetails = new SmartControls.Header();
			this.lblSystemRating = new System.Windows.Forms.Label();
			this.pnlSystemRating = new System.Windows.Forms.Panel();
			this.stbSystemRating = new SmartControls.SmartTextBox();
			this.btnGetNewRating = new SmartControls.SmartButton();
			this.tlpPropertyDetails.SuspendLayout();
			this.pnlDetailsPictures.SuspendLayout();
			this.panel1.SuspendLayout();
			this.pnlSystemRating.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpPropertyDetails
			// 
			this.tlpPropertyDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tlpPropertyDetails.ColumnCount = 2;
			this.tlpPropertyDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.08333F));
			this.tlpPropertyDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.91666F));
			this.tlpPropertyDetails.Controls.Add(this.lblSystemRating, 0, 1);
			this.tlpPropertyDetails.Controls.Add(this.lblDetailsPictures, 0, 5);
			this.tlpPropertyDetails.Controls.Add(this.stbDetailsDescription, 1, 4);
			this.tlpPropertyDetails.Controls.Add(this.stbDetailsPrice, 1, 3);
			this.tlpPropertyDetails.Controls.Add(this.lblDetailsDescription, 0, 4);
			this.tlpPropertyDetails.Controls.Add(this.lblDetailsPublicEvaluation, 0, 0);
			this.tlpPropertyDetails.Controls.Add(this.lblDetailsEvaluation, 0, 2);
			this.tlpPropertyDetails.Controls.Add(this.lblDetailsPrice, 0, 3);
			this.tlpPropertyDetails.Controls.Add(this.stbDetailsPublicEvaluation, 1, 0);
			this.tlpPropertyDetails.Controls.Add(this.stbDetailsRating, 1, 2);
			this.tlpPropertyDetails.Controls.Add(this.pnlDetailsPictures, 1, 5);
			this.tlpPropertyDetails.Controls.Add(this.pnlSystemRating, 1, 1);
			this.tlpPropertyDetails.Location = new System.Drawing.Point(0, 45);
			this.tlpPropertyDetails.Margin = new System.Windows.Forms.Padding(0);
			this.tlpPropertyDetails.Name = "tlpPropertyDetails";
			this.tlpPropertyDetails.RowCount = 6;
			this.tlpPropertyDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpPropertyDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpPropertyDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpPropertyDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tlpPropertyDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
			this.tlpPropertyDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
			this.tlpPropertyDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpPropertyDetails.Size = new System.Drawing.Size(480, 480);
			this.tlpPropertyDetails.TabIndex = 5;
			// 
			// lblDetailsPictures
			// 
			this.lblDetailsPictures.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDetailsPictures.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDetailsPictures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblDetailsPictures.Location = new System.Drawing.Point(0, 430);
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
			this.stbDetailsDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbDetailsDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbDetailsDescription.AutomaticValidation = true;
			this.stbDetailsDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbDetailsDescription.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbDetailsDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbDetailsDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbDetailsDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbDetailsDescription.Location = new System.Drawing.Point(130, 220);
			this.stbDetailsDescription.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbDetailsDescription.MaxLength = 500;
			this.stbDetailsDescription.MinLength = -1;
			this.stbDetailsDescription.Name = "stbDetailsDescription";
			this.stbDetailsDescription.NumericOnly = false;
			this.stbDetailsDescription.Placeholder = null;
			this.stbDetailsDescription.RegularExpression = null;
			this.stbDetailsDescription.Required = true;
			this.stbDetailsDescription.Size = new System.Drawing.Size(350, 200);
			this.stbDetailsDescription.Suffix = null;
			this.stbDetailsDescription.TabIndex = 3;
			this.stbDetailsDescription.TabStop = false;
			this.stbDetailsDescription.UseSystemPasswordChar = false;
			// 
			// stbDetailsPrice
			// 
			this.stbDetailsPrice.AllowComma = false;
			this.stbDetailsPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbDetailsPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbDetailsPrice.AutomaticValidation = true;
			this.stbDetailsPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbDetailsPrice.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbDetailsPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbDetailsPrice.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbDetailsPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbDetailsPrice.Location = new System.Drawing.Point(130, 120);
			this.stbDetailsPrice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbDetailsPrice.MaxLength = 50;
			this.stbDetailsPrice.MinLength = -1;
			this.stbDetailsPrice.Name = "stbDetailsPrice";
			this.stbDetailsPrice.NumericOnly = true;
			this.stbDetailsPrice.Placeholder = null;
			this.stbDetailsPrice.RegularExpression = null;
			this.stbDetailsPrice.Required = true;
			this.stbDetailsPrice.Size = new System.Drawing.Size(350, 90);
			this.stbDetailsPrice.Suffix = null;
			this.stbDetailsPrice.TabIndex = 2;
			this.stbDetailsPrice.TabStop = false;
			this.stbDetailsPrice.UseSystemPasswordChar = false;
			// 
			// lblDetailsDescription
			// 
			this.lblDetailsDescription.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDetailsDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDetailsDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblDetailsDescription.Location = new System.Drawing.Point(0, 220);
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
			this.lblDetailsEvaluation.Location = new System.Drawing.Point(0, 80);
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
			this.lblDetailsPrice.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblDetailsPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDetailsPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblDetailsPrice.Location = new System.Drawing.Point(0, 120);
			this.lblDetailsPrice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblDetailsPrice.Name = "lblDetailsPrice";
			this.lblDetailsPrice.Size = new System.Drawing.Size(130, 90);
			this.lblDetailsPrice.TabIndex = 7;
			this.lblDetailsPrice.Text = "Udbudspris";
			this.lblDetailsPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// stbDetailsPublicEvaluation
			// 
			this.stbDetailsPublicEvaluation.AllowComma = false;
			this.stbDetailsPublicEvaluation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbDetailsPublicEvaluation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbDetailsPublicEvaluation.AutomaticValidation = true;
			this.stbDetailsPublicEvaluation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbDetailsPublicEvaluation.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbDetailsPublicEvaluation.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbDetailsPublicEvaluation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbDetailsPublicEvaluation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbDetailsPublicEvaluation.Location = new System.Drawing.Point(130, 0);
			this.stbDetailsPublicEvaluation.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbDetailsPublicEvaluation.MaxLength = 50;
			this.stbDetailsPublicEvaluation.MinLength = -1;
			this.stbDetailsPublicEvaluation.Name = "stbDetailsPublicEvaluation";
			this.stbDetailsPublicEvaluation.NumericOnly = true;
			this.stbDetailsPublicEvaluation.Placeholder = null;
			this.stbDetailsPublicEvaluation.RegularExpression = null;
			this.stbDetailsPublicEvaluation.Required = true;
			this.stbDetailsPublicEvaluation.Size = new System.Drawing.Size(350, 30);
			this.stbDetailsPublicEvaluation.Suffix = null;
			this.stbDetailsPublicEvaluation.TabIndex = 0;
			this.stbDetailsPublicEvaluation.TabStop = false;
			this.stbDetailsPublicEvaluation.UseSystemPasswordChar = false;
			// 
			// stbDetailsRating
			// 
			this.stbDetailsRating.AllowComma = false;
			this.stbDetailsRating.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbDetailsRating.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbDetailsRating.AutomaticValidation = true;
			this.stbDetailsRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbDetailsRating.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbDetailsRating.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbDetailsRating.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbDetailsRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbDetailsRating.Location = new System.Drawing.Point(130, 80);
			this.stbDetailsRating.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbDetailsRating.MaxLength = 50;
			this.stbDetailsRating.MinLength = -1;
			this.stbDetailsRating.Name = "stbDetailsRating";
			this.stbDetailsRating.NumericOnly = true;
			this.stbDetailsRating.Placeholder = null;
			this.stbDetailsRating.RegularExpression = null;
			this.stbDetailsRating.Required = true;
			this.stbDetailsRating.Size = new System.Drawing.Size(350, 30);
			this.stbDetailsRating.Suffix = null;
			this.stbDetailsRating.TabIndex = 1;
			this.stbDetailsRating.TabStop = false;
			this.stbDetailsRating.UseSystemPasswordChar = false;
			// 
			// pnlDetailsPictures
			// 
			this.pnlDetailsPictures.Controls.Add(this.clsImages);
			this.pnlDetailsPictures.Controls.Add(this.panel1);
			this.pnlDetailsPictures.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlDetailsPictures.Location = new System.Drawing.Point(130, 430);
			this.pnlDetailsPictures.Margin = new System.Windows.Forms.Padding(0);
			this.pnlDetailsPictures.Name = "pnlDetailsPictures";
			this.pnlDetailsPictures.Size = new System.Drawing.Size(350, 50);
			this.pnlDetailsPictures.TabIndex = 17;
			// 
			// clsImages
			// 
			this.clsImages.AutoScroll = true;
			this.clsImages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.clsImages.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.clsImages.Location = new System.Drawing.Point(0, 40);
			this.clsImages.Margin = new System.Windows.Forms.Padding(0);
			this.clsImages.Name = "clsImages";
			this.clsImages.Size = new System.Drawing.Size(350, 10);
			this.clsImages.Spacing = 5;
			this.clsImages.TabIndex = 0;
			this.clsImages.WrapContents = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnAddImage);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(350, 40);
			this.panel1.TabIndex = 1;
			// 
			// btnAddImage
			// 
			this.btnAddImage.AutoSize = true;
			this.btnAddImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnAddImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnAddImage.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.btnAddImage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddImage.FlatAppearance.BorderSize = 0;
			this.btnAddImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnAddImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnAddImage.Location = new System.Drawing.Point(0, 0);
			this.btnAddImage.Name = "btnAddImage";
			this.btnAddImage.Size = new System.Drawing.Size(140, 30);
			this.btnAddImage.TabIndex = 1;
			this.btnAddImage.Text = "Tilføj nyt billede";
			this.btnAddImage.UseVisualStyleBackColor = false;
			this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
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
			// lblSystemRating
			// 
			this.lblSystemRating.AutoSize = true;
			this.lblSystemRating.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblSystemRating.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSystemRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblSystemRating.Location = new System.Drawing.Point(0, 40);
			this.lblSystemRating.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblSystemRating.Name = "lblSystemRating";
			this.lblSystemRating.Size = new System.Drawing.Size(130, 30);
			this.lblSystemRating.TabIndex = 18;
			this.lblSystemRating.Text = "Systemvurdering";
			this.lblSystemRating.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlSystemRating
			// 
			this.pnlSystemRating.Controls.Add(this.btnGetNewRating);
			this.pnlSystemRating.Controls.Add(this.stbSystemRating);
			this.pnlSystemRating.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlSystemRating.Location = new System.Drawing.Point(130, 40);
			this.pnlSystemRating.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.pnlSystemRating.Name = "pnlSystemRating";
			this.pnlSystemRating.Size = new System.Drawing.Size(350, 30);
			this.pnlSystemRating.TabIndex = 19;
			// 
			// stbSystemRating
			// 
			this.stbSystemRating.AllowComma = false;
			this.stbSystemRating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.stbSystemRating.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbSystemRating.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbSystemRating.AutomaticValidation = true;
			this.stbSystemRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbSystemRating.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbSystemRating.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbSystemRating.Enabled = false;
			this.stbSystemRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbSystemRating.Location = new System.Drawing.Point(0, 0);
			this.stbSystemRating.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.stbSystemRating.MaxLength = 50;
			this.stbSystemRating.MinLength = -1;
			this.stbSystemRating.Name = "stbSystemRating";
			this.stbSystemRating.NumericOnly = true;
			this.stbSystemRating.Placeholder = null;
			this.stbSystemRating.RegularExpression = null;
			this.stbSystemRating.Required = true;
			this.stbSystemRating.Size = new System.Drawing.Size(197, 30);
			this.stbSystemRating.Suffix = null;
			this.stbSystemRating.TabIndex = 2;
			this.stbSystemRating.TabStop = false;
			this.stbSystemRating.UseSystemPasswordChar = false;
			// 
			// btnGetNewRating
			// 
			this.btnGetNewRating.AutoSize = true;
			this.btnGetNewRating.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnGetNewRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnGetNewRating.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.btnGetNewRating.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGetNewRating.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnGetNewRating.FlatAppearance.BorderSize = 0;
			this.btnGetNewRating.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnGetNewRating.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnGetNewRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGetNewRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnGetNewRating.Location = new System.Drawing.Point(207, 0);
			this.btnGetNewRating.Name = "btnGetNewRating";
			this.btnGetNewRating.Size = new System.Drawing.Size(143, 30);
			this.btnGetNewRating.TabIndex = 3;
			this.btnGetNewRating.Text = "Vurdér ejendom";
			this.btnGetNewRating.UseVisualStyleBackColor = false;
			this.btnGetNewRating.Click += new System.EventHandler(this.btnGetNewRating_Click);
			// 
			// NewCaseStepDetails
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.tlpPropertyDetails);
			this.Controls.Add(this.hdrPropertyDetails);
			this.Name = "NewCaseStepDetails";
			this.Size = new System.Drawing.Size(480, 525);
			this.tlpPropertyDetails.ResumeLayout(false);
			this.tlpPropertyDetails.PerformLayout();
			this.pnlDetailsPictures.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.pnlSystemRating.ResumeLayout(false);
			this.pnlSystemRating.PerformLayout();
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
        private SmartControls.SmartTextBox stbDetailsRating;
		private System.Windows.Forms.Panel pnlDetailsPictures;
		private ControlList clsImages;
		private SmartButton btnAddImage;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblSystemRating;
		private System.Windows.Forms.Panel pnlSystemRating;
		private SmartButton btnGetNewRating;
		private SmartTextBox stbSystemRating;

    }
}
