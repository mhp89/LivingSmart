using SmartControls;

namespace LivingSmartForms.Views
{
    partial class NewPartner
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
			this.tlpNewPartner = new System.Windows.Forms.TableLayoutPanel();
			this.stbRegion = new SmartControls.SmartTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblPartnerTimeZone = new System.Windows.Forms.Label();
			this.lblPartnerName = new System.Windows.Forms.Label();
			this.lblPartnerCity = new System.Windows.Forms.Label();
			this.lblPartnerRegionShort = new System.Windows.Forms.Label();
			this.lblPartnerCountry = new System.Windows.Forms.Label();
			this.lblPartnerPhone = new System.Windows.Forms.Label();
			this.lblPartnerEmail = new System.Windows.Forms.Label();
			this.stbName = new SmartControls.SmartTextBox();
			this.stbCity = new SmartControls.SmartTextBox();
			this.stbCountry = new SmartControls.SmartTextBox();
			this.stbPhone = new SmartControls.SmartTextBox();
			this.stbEmail = new SmartControls.SmartTextBox();
			this.stbTimeZone = new SmartControls.SmartTextBox();
			this.pnlPartnerRegionShort = new System.Windows.Forms.Panel();
			this.lblPartnerRegionFormat = new System.Windows.Forms.Label();
			this.stbRegionShort = new SmartControls.SmartTextBox();
			this.tlpNewPartner.SuspendLayout();
			this.pnlPartnerRegionShort.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpNewPartner
			// 
			this.tlpNewPartner.ColumnCount = 2;
			this.tlpNewPartner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpNewPartner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.tlpNewPartner.Controls.Add(this.stbRegion, 1, 2);
			this.tlpNewPartner.Controls.Add(this.label1, 0, 2);
			this.tlpNewPartner.Controls.Add(this.lblPartnerTimeZone, 0, 7);
			this.tlpNewPartner.Controls.Add(this.lblPartnerName, 0, 0);
			this.tlpNewPartner.Controls.Add(this.lblPartnerCity, 0, 1);
			this.tlpNewPartner.Controls.Add(this.lblPartnerRegionShort, 0, 3);
			this.tlpNewPartner.Controls.Add(this.lblPartnerCountry, 0, 4);
			this.tlpNewPartner.Controls.Add(this.lblPartnerPhone, 0, 5);
			this.tlpNewPartner.Controls.Add(this.lblPartnerEmail, 0, 6);
			this.tlpNewPartner.Controls.Add(this.stbName, 1, 0);
			this.tlpNewPartner.Controls.Add(this.stbCity, 1, 1);
			this.tlpNewPartner.Controls.Add(this.stbCountry, 1, 4);
			this.tlpNewPartner.Controls.Add(this.stbPhone, 1, 5);
			this.tlpNewPartner.Controls.Add(this.stbEmail, 1, 6);
			this.tlpNewPartner.Controls.Add(this.stbTimeZone, 1, 7);
			this.tlpNewPartner.Controls.Add(this.pnlPartnerRegionShort, 1, 3);
			this.tlpNewPartner.Location = new System.Drawing.Point(0, 10);
			this.tlpNewPartner.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.tlpNewPartner.Name = "tlpNewPartner";
			this.tlpNewPartner.RowCount = 8;
			this.tlpNewPartner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewPartner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewPartner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewPartner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewPartner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewPartner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewPartner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewPartner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpNewPartner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpNewPartner.Size = new System.Drawing.Size(480, 320);
			this.tlpNewPartner.TabIndex = 5;
			// 
			// stbRegion
			// 
			this.stbRegion.AllowComma = false;
			this.stbRegion.AllowDrop = true;
			this.stbRegion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbRegion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbRegion.AutomaticValidation = true;
			this.stbRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbRegion.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbRegion.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbRegion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbRegion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbRegion.Location = new System.Drawing.Point(120, 80);
			this.stbRegion.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbRegion.MaxLength = 50;
			this.stbRegion.MinLength = -1;
			this.stbRegion.Name = "stbRegion";
			this.stbRegion.NumericOnly = false;
			this.stbRegion.Placeholder = null;
			this.stbRegion.RegularExpression = null;
			this.stbRegion.Required = true;
			this.stbRegion.Size = new System.Drawing.Size(360, 30);
			this.stbRegion.Suffix = null;
			this.stbRegion.TabIndex = 2;
			this.stbRegion.TabStop = false;
			this.stbRegion.UseSystemPasswordChar = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.label1.Location = new System.Drawing.Point(0, 80);
			this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 30);
			this.label1.TabIndex = 20;
			this.label1.Text = "Region";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPartnerTimeZone
			// 
			this.lblPartnerTimeZone.AutoSize = true;
			this.lblPartnerTimeZone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblPartnerTimeZone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPartnerTimeZone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblPartnerTimeZone.Location = new System.Drawing.Point(0, 280);
			this.lblPartnerTimeZone.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblPartnerTimeZone.Name = "lblPartnerTimeZone";
			this.lblPartnerTimeZone.Size = new System.Drawing.Size(120, 30);
			this.lblPartnerTimeZone.TabIndex = 11;
			this.lblPartnerTimeZone.Text = "Tidszone";
			this.lblPartnerTimeZone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPartnerName
			// 
			this.lblPartnerName.AutoSize = true;
			this.lblPartnerName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblPartnerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPartnerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblPartnerName.Location = new System.Drawing.Point(0, 0);
			this.lblPartnerName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblPartnerName.Name = "lblPartnerName";
			this.lblPartnerName.Size = new System.Drawing.Size(120, 30);
			this.lblPartnerName.TabIndex = 1;
			this.lblPartnerName.Text = "Navn";
			this.lblPartnerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPartnerCity
			// 
			this.lblPartnerCity.AutoSize = true;
			this.lblPartnerCity.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblPartnerCity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPartnerCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblPartnerCity.Location = new System.Drawing.Point(0, 40);
			this.lblPartnerCity.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblPartnerCity.Name = "lblPartnerCity";
			this.lblPartnerCity.Size = new System.Drawing.Size(120, 30);
			this.lblPartnerCity.TabIndex = 2;
			this.lblPartnerCity.Text = "By";
			this.lblPartnerCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPartnerRegionShort
			// 
			this.lblPartnerRegionShort.AutoSize = true;
			this.lblPartnerRegionShort.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblPartnerRegionShort.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPartnerRegionShort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblPartnerRegionShort.Location = new System.Drawing.Point(0, 120);
			this.lblPartnerRegionShort.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblPartnerRegionShort.Name = "lblPartnerRegionShort";
			this.lblPartnerRegionShort.Size = new System.Drawing.Size(120, 30);
			this.lblPartnerRegionShort.TabIndex = 20;
			this.lblPartnerRegionShort.Text = "Region kort";
			this.lblPartnerRegionShort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPartnerCountry
			// 
			this.lblPartnerCountry.AutoSize = true;
			this.lblPartnerCountry.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblPartnerCountry.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPartnerCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblPartnerCountry.Location = new System.Drawing.Point(0, 160);
			this.lblPartnerCountry.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblPartnerCountry.Name = "lblPartnerCountry";
			this.lblPartnerCountry.Size = new System.Drawing.Size(120, 30);
			this.lblPartnerCountry.TabIndex = 8;
			this.lblPartnerCountry.Text = "Land";
			this.lblPartnerCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPartnerPhone
			// 
			this.lblPartnerPhone.AutoSize = true;
			this.lblPartnerPhone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblPartnerPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPartnerPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblPartnerPhone.Location = new System.Drawing.Point(0, 200);
			this.lblPartnerPhone.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblPartnerPhone.Name = "lblPartnerPhone";
			this.lblPartnerPhone.Size = new System.Drawing.Size(120, 30);
			this.lblPartnerPhone.TabIndex = 9;
			this.lblPartnerPhone.Text = "Telefon";
			this.lblPartnerPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPartnerEmail
			// 
			this.lblPartnerEmail.AutoSize = true;
			this.lblPartnerEmail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblPartnerEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPartnerEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblPartnerEmail.Location = new System.Drawing.Point(0, 240);
			this.lblPartnerEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblPartnerEmail.Name = "lblPartnerEmail";
			this.lblPartnerEmail.Size = new System.Drawing.Size(120, 30);
			this.lblPartnerEmail.TabIndex = 10;
			this.lblPartnerEmail.Text = "Email";
			this.lblPartnerEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// stbName
			// 
			this.stbName.AllowComma = false;
			this.stbName.AllowDrop = true;
			this.stbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbName.AutomaticValidation = true;
			this.stbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbName.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbName.Location = new System.Drawing.Point(120, 0);
			this.stbName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbName.MaxLength = 50;
			this.stbName.MinLength = -1;
			this.stbName.Name = "stbName";
			this.stbName.NumericOnly = false;
			this.stbName.Placeholder = null;
			this.stbName.RegularExpression = null;
			this.stbName.Required = true;
			this.stbName.Size = new System.Drawing.Size(360, 30);
			this.stbName.Suffix = null;
			this.stbName.TabIndex = 0;
			this.stbName.TabStop = false;
			this.stbName.UseSystemPasswordChar = false;
			// 
			// stbCity
			// 
			this.stbCity.AllowComma = false;
			this.stbCity.AllowDrop = true;
			this.stbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbCity.AutomaticValidation = true;
			this.stbCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbCity.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbCity.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbCity.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbCity.Location = new System.Drawing.Point(120, 40);
			this.stbCity.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbCity.MaxLength = 50;
			this.stbCity.MinLength = -1;
			this.stbCity.Name = "stbCity";
			this.stbCity.NumericOnly = false;
			this.stbCity.Placeholder = null;
			this.stbCity.RegularExpression = null;
			this.stbCity.Required = true;
			this.stbCity.Size = new System.Drawing.Size(360, 30);
			this.stbCity.Suffix = null;
			this.stbCity.TabIndex = 1;
			this.stbCity.TabStop = false;
			this.stbCity.UseSystemPasswordChar = false;
			// 
			// stbCountry
			// 
			this.stbCountry.AllowComma = false;
			this.stbCountry.AllowDrop = true;
			this.stbCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbCountry.AutomaticValidation = true;
			this.stbCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbCountry.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbCountry.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbCountry.Location = new System.Drawing.Point(120, 160);
			this.stbCountry.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbCountry.MaxLength = 50;
			this.stbCountry.MinLength = -1;
			this.stbCountry.Name = "stbCountry";
			this.stbCountry.NumericOnly = false;
			this.stbCountry.Placeholder = "";
			this.stbCountry.RegularExpression = null;
			this.stbCountry.Required = true;
			this.stbCountry.Size = new System.Drawing.Size(360, 30);
			this.stbCountry.Suffix = null;
			this.stbCountry.TabIndex = 4;
			this.stbCountry.TabStop = false;
			this.stbCountry.UseSystemPasswordChar = false;
			// 
			// stbPhone
			// 
			this.stbPhone.AllowComma = false;
			this.stbPhone.AllowDrop = true;
			this.stbPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbPhone.AutomaticValidation = true;
			this.stbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbPhone.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbPhone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbPhone.Location = new System.Drawing.Point(120, 200);
			this.stbPhone.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbPhone.MaxLength = 50;
			this.stbPhone.MinLength = 8;
			this.stbPhone.Name = "stbPhone";
			this.stbPhone.NumericOnly = true;
			this.stbPhone.Placeholder = "";
			this.stbPhone.RegularExpression = null;
			this.stbPhone.Required = true;
			this.stbPhone.Size = new System.Drawing.Size(360, 30);
			this.stbPhone.Suffix = null;
			this.stbPhone.TabIndex = 5;
			this.stbPhone.TabStop = false;
			this.stbPhone.UseSystemPasswordChar = false;
			// 
			// stbEmail
			// 
			this.stbEmail.AllowComma = false;
			this.stbEmail.AllowDrop = true;
			this.stbEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbEmail.AutomaticValidation = true;
			this.stbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbEmail.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbEmail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbEmail.Location = new System.Drawing.Point(120, 240);
			this.stbEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbEmail.MaxLength = 50;
			this.stbEmail.MinLength = -1;
			this.stbEmail.Name = "stbEmail";
			this.stbEmail.NumericOnly = false;
			this.stbEmail.Placeholder = null;
			this.stbEmail.RegularExpression = null;
			this.stbEmail.Required = true;
			this.stbEmail.Size = new System.Drawing.Size(360, 30);
			this.stbEmail.Suffix = null;
			this.stbEmail.TabIndex = 6;
			this.stbEmail.TabStop = false;
			this.stbEmail.UseSystemPasswordChar = false;
			// 
			// stbTimeZone
			// 
			this.stbTimeZone.AllowComma = false;
			this.stbTimeZone.AllowDrop = true;
			this.stbTimeZone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbTimeZone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbTimeZone.AutomaticValidation = true;
			this.stbTimeZone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbTimeZone.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbTimeZone.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbTimeZone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbTimeZone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbTimeZone.Location = new System.Drawing.Point(120, 280);
			this.stbTimeZone.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbTimeZone.MaxLength = 50;
			this.stbTimeZone.MinLength = -1;
			this.stbTimeZone.Name = "stbTimeZone";
			this.stbTimeZone.NumericOnly = false;
			this.stbTimeZone.Placeholder = null;
			this.stbTimeZone.RegularExpression = null;
			this.stbTimeZone.Required = true;
			this.stbTimeZone.Size = new System.Drawing.Size(360, 30);
			this.stbTimeZone.Suffix = null;
			this.stbTimeZone.TabIndex = 7;
			this.stbTimeZone.TabStop = false;
			this.stbTimeZone.UseSystemPasswordChar = false;
			// 
			// pnlPartnerRegionShort
			// 
			this.pnlPartnerRegionShort.Controls.Add(this.lblPartnerRegionFormat);
			this.pnlPartnerRegionShort.Controls.Add(this.stbRegionShort);
			this.pnlPartnerRegionShort.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlPartnerRegionShort.Location = new System.Drawing.Point(120, 120);
			this.pnlPartnerRegionShort.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.pnlPartnerRegionShort.Name = "pnlPartnerRegionShort";
			this.pnlPartnerRegionShort.Size = new System.Drawing.Size(360, 30);
			this.pnlPartnerRegionShort.TabIndex = 3;
			// 
			// lblPartnerRegionFormat
			// 
			this.lblPartnerRegionFormat.Location = new System.Drawing.Point(89, 0);
			this.lblPartnerRegionFormat.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblPartnerRegionFormat.Name = "lblPartnerRegionFormat";
			this.lblPartnerRegionFormat.Size = new System.Drawing.Size(267, 30);
			this.lblPartnerRegionFormat.TabIndex = 21;
			this.lblPartnerRegionFormat.Text = "Brug forkortet regionsbetegnelse";
			this.lblPartnerRegionFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// stbRegionShort
			// 
			this.stbRegionShort.AllowComma = false;
			this.stbRegionShort.AllowDrop = true;
			this.stbRegionShort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbRegionShort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbRegionShort.AutomaticValidation = true;
			this.stbRegionShort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbRegionShort.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbRegionShort.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbRegionShort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbRegionShort.Location = new System.Drawing.Point(0, 0);
			this.stbRegionShort.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbRegionShort.MaxLength = 10;
			this.stbRegionShort.MinLength = -1;
			this.stbRegionShort.Name = "stbRegionShort";
			this.stbRegionShort.NumericOnly = false;
			this.stbRegionShort.Placeholder = "Fx. NY";
			this.stbRegionShort.RegularExpression = null;
			this.stbRegionShort.Required = true;
			this.stbRegionShort.Size = new System.Drawing.Size(68, 30);
			this.stbRegionShort.Suffix = null;
			this.stbRegionShort.TabIndex = 0;
			this.stbRegionShort.TabStop = false;
			this.stbRegionShort.UseSystemPasswordChar = false;
			// 
			// NewPartner
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.tlpNewPartner);
			this.Name = "NewPartner";
			this.Size = new System.Drawing.Size(480, 330);
			this.tlpNewPartner.ResumeLayout(false);
			this.tlpNewPartner.PerformLayout();
			this.pnlPartnerRegionShort.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.TableLayoutPanel tlpNewPartner;
        private System.Windows.Forms.Label lblPartnerTimeZone;
        private System.Windows.Forms.Label lblPartnerName;
        private System.Windows.Forms.Label lblPartnerCity;
        private System.Windows.Forms.Label lblPartnerRegionShort;
        private System.Windows.Forms.Label lblPartnerCountry;
        private System.Windows.Forms.Label lblPartnerPhone;
        private System.Windows.Forms.Label lblPartnerEmail;
        private SmartControls.SmartTextBox stbName;
        private SmartControls.SmartTextBox stbCity;
        private SmartControls.SmartTextBox stbCountry;
        private SmartControls.SmartTextBox stbPhone;
        private SmartControls.SmartTextBox stbEmail;
        private SmartControls.SmartTextBox stbTimeZone;
        private System.Windows.Forms.Panel pnlPartnerRegionShort;
        private System.Windows.Forms.Label lblPartnerRegionFormat;
        private SmartControls.SmartTextBox stbRegionShort;
		private SmartTextBox stbRegion;
		private System.Windows.Forms.Label label1;
    }
}
