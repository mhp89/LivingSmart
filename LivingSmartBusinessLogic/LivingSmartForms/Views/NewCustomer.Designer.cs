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
			this.smartTextBox1 = new SmartControls.SmartTextBox();
			this.stbCustomerAdress = new SmartControls.SmartTextBox();
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
			this.hdrNewCustomer = new SmartControls.Header();
			this.tlpNewCustomer.SuspendLayout();
			this.pnlCustomerCity.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpNewCustomer
			// 
			this.tlpNewCustomer.ColumnCount = 2;
			this.tlpNewCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpNewCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.tlpNewCustomer.Controls.Add(this.stbCustomerPhone, 1, 3);
			this.tlpNewCustomer.Controls.Add(this.smartTextBox1, 1, 4);
			this.tlpNewCustomer.Controls.Add(this.stbCustomerAdress, 1, 1);
			this.tlpNewCustomer.Controls.Add(this.stbCustomerName, 1, 0);
			this.tlpNewCustomer.Controls.Add(this.lblCustomerName, 0, 0);
			this.tlpNewCustomer.Controls.Add(this.lblCustomerAddress, 0, 1);
			this.tlpNewCustomer.Controls.Add(this.lblCustomerCity, 0, 2);
			this.tlpNewCustomer.Controls.Add(this.pnlCustomerCity, 1, 2);
			this.tlpNewCustomer.Controls.Add(this.lblCustomerEmail, 0, 4);
			this.tlpNewCustomer.Controls.Add(this.lblCustomerPhone, 0, 3);
			this.tlpNewCustomer.Controls.Add(this.lblCustomerDateOfBirth, 0, 5);
			this.tlpNewCustomer.Controls.Add(this.dafCustomerBirthday, 1, 5);
			this.tlpNewCustomer.Location = new System.Drawing.Point(0, 45);
			this.tlpNewCustomer.Margin = new System.Windows.Forms.Padding(0);
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
			this.stbCustomerPhone.Size = new System.Drawing.Size(360, 30);
			this.stbCustomerPhone.Suffix = null;
			this.stbCustomerPhone.TabIndex = 16;
			this.stbCustomerPhone.UseSystemPasswordChar = false;
			// 
			// smartTextBox1
			// 
			this.smartTextBox1.AllowComma = false;
			this.smartTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.smartTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.smartTextBox1.AutomaticValidation = true;
			this.smartTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.smartTextBox1.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.smartTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.smartTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.smartTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.smartTextBox1.Location = new System.Drawing.Point(120, 160);
			this.smartTextBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.smartTextBox1.MaxLength = 50;
			this.smartTextBox1.MinLength = 10;
			this.smartTextBox1.Name = "smartTextBox1";
			this.smartTextBox1.NumericOnly = false;
			this.smartTextBox1.Placeholder = null;
			this.smartTextBox1.RegularExpression = null;
			this.smartTextBox1.Size = new System.Drawing.Size(360, 30);
			this.smartTextBox1.Suffix = null;
			this.smartTextBox1.TabIndex = 14;
			this.smartTextBox1.UseSystemPasswordChar = false;
			// 
			// stbCustomerAdress
			// 
			this.stbCustomerAdress.AllowComma = false;
			this.stbCustomerAdress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbCustomerAdress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbCustomerAdress.AutomaticValidation = true;
			this.stbCustomerAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbCustomerAdress.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbCustomerAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbCustomerAdress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbCustomerAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbCustomerAdress.Location = new System.Drawing.Point(120, 40);
			this.stbCustomerAdress.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbCustomerAdress.MaxLength = 50;
			this.stbCustomerAdress.MinLength = 5;
			this.stbCustomerAdress.Name = "stbCustomerAdress";
			this.stbCustomerAdress.NumericOnly = false;
			this.stbCustomerAdress.Placeholder = null;
			this.stbCustomerAdress.RegularExpression = null;
			this.stbCustomerAdress.Size = new System.Drawing.Size(360, 30);
			this.stbCustomerAdress.Suffix = null;
			this.stbCustomerAdress.TabIndex = 12;
			this.stbCustomerAdress.UseSystemPasswordChar = false;
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
			this.stbCustomerZipCode.Size = new System.Drawing.Size(68, 30);
			this.stbCustomerZipCode.Suffix = null;
			this.stbCustomerZipCode.TabIndex = 4;
			this.stbCustomerZipCode.UseSystemPasswordChar = false;
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
			this.dafCustomerBirthday.Location = new System.Drawing.Point(120, 200);
			this.dafCustomerBirthday.Margin = new System.Windows.Forms.Padding(0);
			this.dafCustomerBirthday.Name = "dafCustomerBirthday";
			this.dafCustomerBirthday.Size = new System.Drawing.Size(360, 30);
			this.dafCustomerBirthday.TabIndex = 17;
			// 
			// hdrNewCustomer
			// 
			this.hdrNewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hdrNewCustomer.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.hdrNewCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.hdrNewCustomer.Location = new System.Drawing.Point(0, 10);
			this.hdrNewCustomer.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.hdrNewCustomer.Name = "hdrNewCustomer";
			this.hdrNewCustomer.Size = new System.Drawing.Size(480, 25);
			this.hdrNewCustomer.TabIndex = 3;
			this.hdrNewCustomer.Text = "Kunde";
			// 
			// NewCustomer
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.hdrNewCustomer);
			this.Controls.Add(this.tlpNewCustomer);
			this.Name = "NewCustomer";
			this.Size = new System.Drawing.Size(480, 287);
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
        private SmartControls.SmartTextBox stbCustomerAdress;
        private SmartControls.SmartTextBox smartTextBox1;
        private SmartControls.SmartTextBox stbCustomerPhone;
        private SmartControls.Header hdrNewCustomer;
        private UserControls.DateField dafCustomerBirthday;
    }
}
