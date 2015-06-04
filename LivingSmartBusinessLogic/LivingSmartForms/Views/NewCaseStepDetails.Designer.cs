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
			this.pnlDocuments = new System.Windows.Forms.Panel();
			this.clsDocuments = new SmartControls.ControlList();
			this.pnlNewDocument = new System.Windows.Forms.Panel();
			this.btnNewDocument = new SmartControls.SmartButton();
			this.lblDocuments = new System.Windows.Forms.Label();
			this.lblSystemRating = new System.Windows.Forms.Label();
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
			this.clsPictures = new SmartControls.ControlList();
			this.pnlNewPicture = new System.Windows.Forms.Panel();
			this.btnAddImage = new SmartControls.SmartButton();
			this.pnlSystemRating = new System.Windows.Forms.Panel();
			this.btnGetNewRating = new SmartControls.SmartButton();
			this.stbSystemRating = new SmartControls.SmartTextBox();
			this.hdrPropertyDetails = new SmartControls.Header();
			this.tlpPropertyDetails.SuspendLayout();
			this.pnlDocuments.SuspendLayout();
			this.pnlNewDocument.SuspendLayout();
			this.pnlDetailsPictures.SuspendLayout();
			this.pnlNewPicture.SuspendLayout();
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
			this.tlpPropertyDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.91667F));
			this.tlpPropertyDetails.Controls.Add(this.pnlDocuments, 1, 6);
			this.tlpPropertyDetails.Controls.Add(this.lblDocuments, 0, 6);
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
			this.tlpPropertyDetails.RowCount = 7;
			this.tlpPropertyDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpPropertyDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpPropertyDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpPropertyDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpPropertyDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpPropertyDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpPropertyDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpPropertyDetails.Size = new System.Drawing.Size(480, 560);
			this.tlpPropertyDetails.TabIndex = 5;
			// 
			// pnlDocuments
			// 
			this.pnlDocuments.Controls.Add(this.clsDocuments);
			this.pnlDocuments.Controls.Add(this.pnlNewDocument);
			this.pnlDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlDocuments.Location = new System.Drawing.Point(129, 426);
			this.pnlDocuments.Margin = new System.Windows.Forms.Padding(0);
			this.pnlDocuments.Name = "pnlDocuments";
			this.pnlDocuments.Size = new System.Drawing.Size(351, 134);
			this.pnlDocuments.TabIndex = 21;
			// 
			// clsDocuments
			// 
			this.clsDocuments.AutoScroll = true;
			this.clsDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
			this.clsDocuments.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.clsDocuments.Location = new System.Drawing.Point(0, 40);
			this.clsDocuments.Margin = new System.Windows.Forms.Padding(0);
			this.clsDocuments.Name = "clsDocuments";
			this.clsDocuments.Size = new System.Drawing.Size(351, 94);
			this.clsDocuments.Spacing = 5;
			this.clsDocuments.TabIndex = 0;
			this.clsDocuments.WrapContents = false;
			// 
			// pnlNewDocument
			// 
			this.pnlNewDocument.Controls.Add(this.btnNewDocument);
			this.pnlNewDocument.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlNewDocument.Location = new System.Drawing.Point(0, 0);
			this.pnlNewDocument.Name = "pnlNewDocument";
			this.pnlNewDocument.Size = new System.Drawing.Size(351, 40);
			this.pnlNewDocument.TabIndex = 1;
			// 
			// btnNewDocument
			// 
			this.btnNewDocument.AutoSize = true;
			this.btnNewDocument.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnNewDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnNewDocument.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.btnNewDocument.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNewDocument.FlatAppearance.BorderSize = 0;
			this.btnNewDocument.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnNewDocument.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnNewDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewDocument.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnNewDocument.Location = new System.Drawing.Point(0, 0);
			this.btnNewDocument.Name = "btnNewDocument";
			this.btnNewDocument.Size = new System.Drawing.Size(159, 30);
			this.btnNewDocument.TabIndex = 1;
			this.btnNewDocument.Text = "Tilføj nyt dokument";
			this.btnNewDocument.UseVisualStyleBackColor = false;
			this.btnNewDocument.Click += new System.EventHandler(this.btnNewDocument_Click);
			// 
			// lblDocuments
			// 
			this.lblDocuments.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDocuments.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDocuments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblDocuments.Location = new System.Drawing.Point(0, 426);
			this.lblDocuments.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblDocuments.Name = "lblDocuments";
			this.lblDocuments.Size = new System.Drawing.Size(129, 30);
			this.lblDocuments.TabIndex = 20;
			this.lblDocuments.Text = "Dokumenter";
			this.lblDocuments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.lblSystemRating.Size = new System.Drawing.Size(129, 30);
			this.lblSystemRating.TabIndex = 18;
			this.lblSystemRating.Text = "Systemvurdering";
			this.lblSystemRating.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblDetailsPictures
			// 
			this.lblDetailsPictures.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDetailsPictures.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDetailsPictures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblDetailsPictures.Location = new System.Drawing.Point(0, 293);
			this.lblDetailsPictures.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblDetailsPictures.Name = "lblDetailsPictures";
			this.lblDetailsPictures.Size = new System.Drawing.Size(129, 30);
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
			this.stbDetailsDescription.Location = new System.Drawing.Point(129, 160);
			this.stbDetailsDescription.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbDetailsDescription.MaxLength = 500;
			this.stbDetailsDescription.MinLength = -1;
			this.stbDetailsDescription.Multiline = true;
			this.stbDetailsDescription.Name = "stbDetailsDescription";
			this.stbDetailsDescription.NumericOnly = false;
			this.stbDetailsDescription.Placeholder = null;
			this.stbDetailsDescription.RegularExpression = null;
			this.stbDetailsDescription.Required = true;
			this.stbDetailsDescription.Size = new System.Drawing.Size(351, 123);
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
			this.stbDetailsPrice.Location = new System.Drawing.Point(129, 120);
			this.stbDetailsPrice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbDetailsPrice.MaxLength = 50;
			this.stbDetailsPrice.MinLength = -1;
			this.stbDetailsPrice.Multiline = false;
			this.stbDetailsPrice.Name = "stbDetailsPrice";
			this.stbDetailsPrice.NumericOnly = true;
			this.stbDetailsPrice.Placeholder = null;
			this.stbDetailsPrice.RegularExpression = null;
			this.stbDetailsPrice.Required = true;
			this.stbDetailsPrice.Size = new System.Drawing.Size(351, 30);
			this.stbDetailsPrice.Suffix = "kr.";
			this.stbDetailsPrice.TabIndex = 2;
			this.stbDetailsPrice.TabStop = false;
			this.stbDetailsPrice.UseSystemPasswordChar = false;
			// 
			// lblDetailsDescription
			// 
			this.lblDetailsDescription.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDetailsDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDetailsDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblDetailsDescription.Location = new System.Drawing.Point(0, 160);
			this.lblDetailsDescription.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblDetailsDescription.Name = "lblDetailsDescription";
			this.lblDetailsDescription.Size = new System.Drawing.Size(129, 30);
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
			this.lblDetailsPublicEvaluation.Size = new System.Drawing.Size(129, 30);
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
			this.lblDetailsEvaluation.Size = new System.Drawing.Size(129, 30);
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
			this.lblDetailsPrice.Size = new System.Drawing.Size(129, 30);
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
			this.stbDetailsPublicEvaluation.Location = new System.Drawing.Point(129, 0);
			this.stbDetailsPublicEvaluation.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbDetailsPublicEvaluation.MaxLength = 50;
			this.stbDetailsPublicEvaluation.MinLength = -1;
			this.stbDetailsPublicEvaluation.Multiline = false;
			this.stbDetailsPublicEvaluation.Name = "stbDetailsPublicEvaluation";
			this.stbDetailsPublicEvaluation.NumericOnly = true;
			this.stbDetailsPublicEvaluation.Placeholder = null;
			this.stbDetailsPublicEvaluation.RegularExpression = null;
			this.stbDetailsPublicEvaluation.Required = true;
			this.stbDetailsPublicEvaluation.Size = new System.Drawing.Size(351, 30);
			this.stbDetailsPublicEvaluation.Suffix = "kr.";
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
			this.stbDetailsRating.Location = new System.Drawing.Point(129, 80);
			this.stbDetailsRating.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbDetailsRating.MaxLength = 50;
			this.stbDetailsRating.MinLength = -1;
			this.stbDetailsRating.Multiline = false;
			this.stbDetailsRating.Name = "stbDetailsRating";
			this.stbDetailsRating.NumericOnly = true;
			this.stbDetailsRating.Placeholder = null;
			this.stbDetailsRating.RegularExpression = null;
			this.stbDetailsRating.Required = false;
			this.stbDetailsRating.Size = new System.Drawing.Size(351, 30);
			this.stbDetailsRating.Suffix = "kr.";
			this.stbDetailsRating.TabIndex = 1;
			this.stbDetailsRating.TabStop = false;
			this.stbDetailsRating.UseSystemPasswordChar = false;
			// 
			// pnlDetailsPictures
			// 
			this.pnlDetailsPictures.Controls.Add(this.clsPictures);
			this.pnlDetailsPictures.Controls.Add(this.pnlNewPicture);
			this.pnlDetailsPictures.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlDetailsPictures.Location = new System.Drawing.Point(129, 293);
			this.pnlDetailsPictures.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.pnlDetailsPictures.Name = "pnlDetailsPictures";
			this.pnlDetailsPictures.Size = new System.Drawing.Size(351, 123);
			this.pnlDetailsPictures.TabIndex = 17;
			// 
			// clsPictures
			// 
			this.clsPictures.AutoScroll = true;
			this.clsPictures.Dock = System.Windows.Forms.DockStyle.Fill;
			this.clsPictures.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.clsPictures.Location = new System.Drawing.Point(0, 40);
			this.clsPictures.Margin = new System.Windows.Forms.Padding(0);
			this.clsPictures.Name = "clsPictures";
			this.clsPictures.Size = new System.Drawing.Size(351, 83);
			this.clsPictures.Spacing = 5;
			this.clsPictures.TabIndex = 0;
			this.clsPictures.WrapContents = false;
			// 
			// pnlNewPicture
			// 
			this.pnlNewPicture.Controls.Add(this.btnAddImage);
			this.pnlNewPicture.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlNewPicture.Location = new System.Drawing.Point(0, 0);
			this.pnlNewPicture.Name = "pnlNewPicture";
			this.pnlNewPicture.Size = new System.Drawing.Size(351, 40);
			this.pnlNewPicture.TabIndex = 1;
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
			// pnlSystemRating
			// 
			this.pnlSystemRating.Controls.Add(this.btnGetNewRating);
			this.pnlSystemRating.Controls.Add(this.stbSystemRating);
			this.pnlSystemRating.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlSystemRating.Location = new System.Drawing.Point(129, 40);
			this.pnlSystemRating.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.pnlSystemRating.Name = "pnlSystemRating";
			this.pnlSystemRating.Size = new System.Drawing.Size(351, 30);
			this.pnlSystemRating.TabIndex = 19;
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
			this.btnGetNewRating.Location = new System.Drawing.Point(208, 0);
			this.btnGetNewRating.Name = "btnGetNewRating";
			this.btnGetNewRating.Size = new System.Drawing.Size(143, 30);
			this.btnGetNewRating.TabIndex = 3;
			this.btnGetNewRating.Text = "Vurdér ejendom";
			this.btnGetNewRating.UseVisualStyleBackColor = false;
			this.btnGetNewRating.Click += new System.EventHandler(this.btnGetNewRating_Click);
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
			this.stbSystemRating.Multiline = false;
			this.stbSystemRating.Name = "stbSystemRating";
			this.stbSystemRating.NumericOnly = true;
			this.stbSystemRating.Placeholder = null;
			this.stbSystemRating.RegularExpression = null;
			this.stbSystemRating.Required = true;
			this.stbSystemRating.Size = new System.Drawing.Size(198, 30);
			this.stbSystemRating.Suffix = "kr.";
			this.stbSystemRating.TabIndex = 2;
			this.stbSystemRating.TabStop = false;
			this.stbSystemRating.UseSystemPasswordChar = false;
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
			// NewCaseStepDetails
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.tlpPropertyDetails);
			this.Controls.Add(this.hdrPropertyDetails);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.MinimumSize = new System.Drawing.Size(480, 525);
			this.Name = "NewCaseStepDetails";
			this.Size = new System.Drawing.Size(480, 605);
			this.tlpPropertyDetails.ResumeLayout(false);
			this.tlpPropertyDetails.PerformLayout();
			this.pnlDocuments.ResumeLayout(false);
			this.pnlNewDocument.ResumeLayout(false);
			this.pnlNewDocument.PerformLayout();
			this.pnlDetailsPictures.ResumeLayout(false);
			this.pnlNewPicture.ResumeLayout(false);
			this.pnlNewPicture.PerformLayout();
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
		private ControlList clsPictures;
		private SmartButton btnAddImage;
		private System.Windows.Forms.Panel pnlNewPicture;
		private System.Windows.Forms.Label lblSystemRating;
		private System.Windows.Forms.Panel pnlSystemRating;
		private SmartButton btnGetNewRating;
		private SmartTextBox stbSystemRating;
		private System.Windows.Forms.Label lblDocuments;
		private System.Windows.Forms.Panel pnlDocuments;
		private ControlList clsDocuments;
		private System.Windows.Forms.Panel pnlNewDocument;
		private SmartButton btnNewDocument;

    }
}
