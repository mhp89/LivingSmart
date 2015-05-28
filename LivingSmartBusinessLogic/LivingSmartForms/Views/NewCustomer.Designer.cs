namespace LivingSmartForms.Views
{
    partial class NewCustomer
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
			this.tlpNewCustomer = new System.Windows.Forms.TableLayoutPanel();
			this.stbCustomerPhone = new SmartControls.SmartTextBox();
			this.stbCustomerEmail = new SmartControls.SmartTextBox();
			this.stbCustomerAddress = new SmartControls.SmartTextBox();
			this.stbCustomerName = new SmartControls.SmartTextBox();
			this.lblCustomerName = new System.Windows.Forms.Label();
			this.lblCustomerAddress = new System.Windows.Forms.Label();
			this.lblCustomerCity = new System.Windows.Forms.Label();
			this.pnlCustomerCity = new System.Windows.Forms.Panel();
			this.lblCustomerCityCountry = new System.Windows.Forms.Label();
			this.stbCustomerZipCode = new SmartControls.SmartTextBox();
			this.lblCustomerEmail = new System.Windows.Forms.Label();
			this.lblCustomerPhone = new System.Windows.Forms.Label();
			this.lblCustomerDateOfBirth = new System.Windows.Forms.Label();
			this.dafCustomerBirthday = new LivingSmartForms.UserControls.DateField();
			this.tlpNewCustomer.SuspendLayout();
			this.pnlCustomerCity.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpNewCustomer
			// 
			this.tlpNewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tlpNewCustomer.ColumnCount = 2;
			this.tlpNewCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpNewCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.tlpNewCustomer.Controls.Add(this.stbCustomerPhone, 1, 3);
			this.tlpNewCustomer.Controls.Add(this.stbCustomerEmail, 1, 4);
			this.tlpNewCustomer.Controls.Add(this.stbCustomerAddress, 1, 1);
			this.tlpNewCustomer.Controls.Add(this.stbCustomerName, 1, 0);
			this.tlpNewCustomer.Controls.Add(this.lblCustomerName, 0, 0);
			this.tlpNewCustomer.Controls.Add(this.lblCustomerAddress, 0, 1);
			this.tlpNewCustomer.Controls.Add(this.lblCustomerCity, 0, 2);
			this.tlpNewCustomer.Controls.Add(this.pnlCustomerCity, 1, 2);
			this.tlpNewCustomer.Controls.Add(this.lblCustomerEmail, 0, 4);
			this.tlpNewCustomer.Controls.Add(this.lblCustomerPhone, 0, 3);
			this.tlpNewCustomer.Controls.Add(this.lblCustomerDateOfBirth, 0, 5);
			this.tlpNewCustomer.Controls.Add(this.dafCustomerBirthday, 1, 5);
			this.tlpNewCustomer.Location = new System.Drawing.Point(0, 10);
			this.tlpNewCustomer.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.tlpNewCustomer.Name = "tlpNewCustomer";
			this.tlpNewCustomer.RowCount = 6;
			this.tlpNewCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpNewCustomer.Size = new System.Drawing.Size(480, 240);
			this.tlpNewCustomer.TabIndex = 0;
			// 
			// stbCustomerPhone
			// 
			this.stbCustomerPhone.AllowComma = false;
			this.stbCustomerPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbCustomerPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbCustomerPhone.AutomaticValidation = true;
			this.stbCustomerPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbCustomerPhone.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbCustomerPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbCustomerPhone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbCustomerPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbCustomerPhone.Location = new System.Drawing.Point(120, 120);
			this.stbCustomerPhone.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbCustomerPhone.MaxLength = 8;
			this.stbCustomerPhone.MinLength = 8;
			this.stbCustomerPhone.Name = "stbCustomerPhone";
			this.stbCustomerPhone.NumericOnly = true;
			this.stbCustomerPhone.Placeholder = null;
			this.stbCustomerPhone.RegularExpression = null;
			this.stbCustomerPhone.Required = true;
			this.stbCustomerPhone.Size = new System.Drawing.Size(360, 30);
			this.stbCustomerPhone.Suffix = null;
			this.stbCustomerPhone.TabIndex = 16;
			this.stbCustomerPhone.UseSystemPasswordChar = false;
			// 
			// stbCustomerEmail
			// 
			this.stbCustomerEmail.AllowComma = false;
			this.stbCustomerEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbCustomerEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbCustomerEmail.AutomaticValidation = true;
			this.stbCustomerEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbCustomerEmail.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbCustomerEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbCustomerEmail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbCustomerEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbCustomerEmail.Location = new System.Drawing.Point(120, 160);
			this.stbCustomerEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbCustomerEmail.MaxLength = 50;
			this.stbCustomerEmail.MinLength = -1;
			this.stbCustomerEmail.Name = "stbCustomerEmail";
			this.stbCustomerEmail.NumericOnly = false;
			this.stbCustomerEmail.Placeholder = null;
			this.stbCustomerEmail.RegularExpression = null;
			this.stbCustomerEmail.Required = true;
			this.stbCustomerEmail.Size = new System.Drawing.Size(360, 30);
			this.stbCustomerEmail.Suffix = null;
			this.stbCustomerEmail.TabIndex = 14;
			this.stbCustomerEmail.UseSystemPasswordChar = false;
			// 
			// stbCustomerAddress
			// 
			this.stbCustomerAddress.AllowComma = false;
			this.stbCustomerAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbCustomerAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbCustomerAddress.AutomaticValidation = true;
			this.stbCustomerAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbCustomerAddress.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbCustomerAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbCustomerAddress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbCustomerAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbCustomerAddress.Location = new System.Drawing.Point(120, 40);
			this.stbCustomerAddress.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbCustomerAddress.MaxLength = 50;
			this.stbCustomerAddress.MinLength = -1;
			this.stbCustomerAddress.Name = "stbCustomerAddress";
			this.stbCustomerAddress.NumericOnly = false;
			this.stbCustomerAddress.Placeholder = null;
			this.stbCustomerAddress.RegularExpression = null;
			this.stbCustomerAddress.Required = true;
			this.stbCustomerAddress.Size = new System.Drawing.Size(360, 30);
			this.stbCustomerAddress.Suffix = null;
			this.stbCustomerAddress.TabIndex = 12;
			this.stbCustomerAddress.UseSystemPasswordChar = false;
			// 
			// stbCustomerName
			// 
			this.stbCustomerName.AllowComma = false;
			this.stbCustomerName.AllowDrop = true;
			this.stbCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbCustomerName.AutomaticValidation = true;
			this.stbCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbCustomerName.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbCustomerName.Location = new System.Drawing.Point(120, 0);
			this.stbCustomerName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbCustomerName.MaxLength = 50;
			this.stbCustomerName.MinLength = -1;
			this.stbCustomerName.Name = "stbCustomerName";
			this.stbCustomerName.NumericOnly = false;
			this.stbCustomerName.Placeholder = null;
			this.stbCustomerName.RegularExpression = null;
			this.stbCustomerName.Required = true;
			this.stbCustomerName.Size = new System.Drawing.Size(360, 30);
			this.stbCustomerName.Suffix = null;
			this.stbCustomerName.TabIndex = 11;
			this.stbCustomerName.UseSystemPasswordChar = false;
			// 
			// lblCustomerName
			// 
			this.lblCustomerName.AutoSize = true;
			this.lblCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblCustomerName.Location = new System.Drawing.Point(0, 0);
			this.lblCustomerName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblCustomerName.Name = "lblCustomerName";
			this.lblCustomerName.Size = new System.Drawing.Size(120, 30);
			this.lblCustomerName.TabIndex = 4;
			this.lblCustomerName.Text = "Navn";
			this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblCustomerAddress
			// 
			this.lblCustomerAddress.AutoSize = true;
			this.lblCustomerAddress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblCustomerAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomerAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblCustomerAddress.Location = new System.Drawing.Point(0, 40);
			this.lblCustomerAddress.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblCustomerAddress.Name = "lblCustomerAddress";
			this.lblCustomerAddress.Size = new System.Drawing.Size(120, 30);
			this.lblCustomerAddress.TabIndex = 5;
			this.lblCustomerAddress.Text = "Adresse";
			this.lblCustomerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblCustomerCity
			// 
			this.lblCustomerCity.AutoSize = true;
			this.lblCustomerCity.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblCustomerCity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomerCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblCustomerCity.Location = new System.Drawing.Point(0, 80);
			this.lblCustomerCity.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblCustomerCity.Name = "lblCustomerCity";
			this.lblCustomerCity.Size = new System.Drawing.Size(120, 30);
			this.lblCustomerCity.TabIndex = 6;
			this.lblCustomerCity.Text = "By";
			this.lblCustomerCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlCustomerCity
			// 
			this.pnlCustomerCity.Controls.Add(this.lblCustomerCityCountry);
			this.pnlCustomerCity.Controls.Add(this.stbCustomerZipCode);
			this.pnlCustomerCity.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlCustomerCity.Location = new System.Drawing.Point(120, 80);
			this.pnlCustomerCity.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.pnlCustomerCity.Name = "pnlCustomerCity";
			this.pnlCustomerCity.Size = new System.Drawing.Size(360, 30);
			this.pnlCustomerCity.TabIndex = 7;
			// 
			// lblCustomerCityCountry
			// 
			this.lblCustomerCityCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCustomerCityCountry.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.lblCustomerCityCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblCustomerCityCountry.Location = new System.Drawing.Point(78, 0);
			this.lblCustomerCityCountry.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.lblCustomerCityCountry.Name = "lblCustomerCityCountry";
			this.lblCustomerCityCountry.Size = new System.Drawing.Size(282, 30);
			this.lblCustomerCityCountry.TabIndex = 5;
			this.lblCustomerCityCountry.Text = "By";
			this.lblCustomerCityCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// stbCustomerZipCode
			// 
			this.stbCustomerZipCode.AllowComma = false;
			this.stbCustomerZipCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbCustomerZipCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbCustomerZipCode.AutomaticValidation = true;
			this.stbCustomerZipCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbCustomerZipCode.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbCustomerZipCode.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbCustomerZipCode.Dock = System.Windows.Forms.DockStyle.Left;
			this.stbCustomerZipCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbCustomerZipCode.Location = new System.Drawing.Point(0, 0);
			this.stbCustomerZipCode.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbCustomerZipCode.MaxLength = 4;
			this.stbCustomerZipCode.MinLength = 4;
			this.stbCustomerZipCode.Name = "stbCustomerZipCode";
			this.stbCustomerZipCode.NumericOnly = true;
			this.stbCustomerZipCode.Placeholder = null;
			this.stbCustomerZipCode.RegularExpression = null;
			this.stbCustomerZipCode.Required = true;
			this.stbCustomerZipCode.Size = new System.Drawing.Size(68, 30);
			this.stbCustomerZipCode.Suffix = null;
			this.stbCustomerZipCode.TabIndex = 4;
			this.stbCustomerZipCode.UseSystemPasswordChar = false;
			this.stbCustomerZipCode.TextChanged += new System.EventHandler(this.stbCustomerZipCode_TextChanged);
			// 
			// lblCustomerEmail
			// 
			this.lblCustomerEmail.AutoSize = true;
			this.lblCustomerEmail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblCustomerEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomerEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblCustomerEmail.Location = new System.Drawing.Point(0, 160);
			this.lblCustomerEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblCustomerEmail.Name = "lblCustomerEmail";
			this.lblCustomerEmail.Size = new System.Drawing.Size(120, 30);
			this.lblCustomerEmail.TabIndex = 9;
			this.lblCustomerEmail.Text = "Email";
			this.lblCustomerEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblCustomerPhone
			// 
			this.lblCustomerPhone.AutoSize = true;
			this.lblCustomerPhone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblCustomerPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomerPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblCustomerPhone.Location = new System.Drawing.Point(0, 120);
			this.lblCustomerPhone.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblCustomerPhone.Name = "lblCustomerPhone";
			this.lblCustomerPhone.Size = new System.Drawing.Size(120, 30);
			this.lblCustomerPhone.TabIndex = 8;
			this.lblCustomerPhone.Text = "Telefon";
			this.lblCustomerPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblCustomerDateOfBirth
			// 
			this.lblCustomerDateOfBirth.AutoSize = true;
			this.lblCustomerDateOfBirth.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblCustomerDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomerDateOfBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblCustomerDateOfBirth.Location = new System.Drawing.Point(0, 200);
			this.lblCustomerDateOfBirth.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblCustomerDateOfBirth.Name = "lblCustomerDateOfBirth";
			this.lblCustomerDateOfBirth.Size = new System.Drawing.Size(120, 30);
			this.lblCustomerDateOfBirth.TabIndex = 10;
			this.lblCustomerDateOfBirth.Text = "Fødselsdato";
			this.lblCustomerDateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dafCustomerBirthday
			// 
			this.dafCustomerBirthday.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dafCustomerBirthday.Location = new System.Drawing.Point(120, 200);
			this.dafCustomerBirthday.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.dafCustomerBirthday.Name = "dafCustomerBirthday";
			this.dafCustomerBirthday.Size = new System.Drawing.Size(360, 30);
			this.dafCustomerBirthday.TabIndex = 17;
			// 
			// NewCustomer
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.tlpNewCustomer);
			this.Name = "NewCustomer";
			this.Size = new System.Drawing.Size(480, 250);
			this.tlpNewCustomer.ResumeLayout(false);
			this.tlpNewCustomer.PerformLayout();
			this.pnlCustomerCity.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpNewCustomer;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerCity;
        private System.Windows.Forms.Panel pnlCustomerCity;
        private SmartControls.SmartTextBox stbCustomerZipCode;
        private System.Windows.Forms.Label lblCustomerCityCountry;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerDateOfBirth;
        private SmartControls.SmartTextBox stbCustomerName;
        private SmartControls.SmartTextBox stbCustomerAddress;
        private SmartControls.SmartTextBox stbCustomerEmail;
		private SmartControls.SmartTextBox stbCustomerPhone;
        private UserControls.DateField dafCustomerBirthday;
    }
}
