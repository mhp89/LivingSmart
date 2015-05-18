namespace LivingSmartForms.Views
{
    partial class NewCaseStepSeller
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
            this.tlpEstateAgent = new System.Windows.Forms.TableLayoutPanel();
            this.lblEstateAgentName = new System.Windows.Forms.Label();
            this.stbEstateAgentName = new SmartControls.SmartTextBox();
            this.tlpSeller = new System.Windows.Forms.TableLayoutPanel();
            this.smartTextBox2 = new SmartControls.SmartTextBox();
            this.stbSellerAdress = new SmartControls.SmartTextBox();
            this.lblSellerEmail = new System.Windows.Forms.Label();
            this.lblSellerId = new System.Windows.Forms.Label();
            this.lblSellerPhone = new System.Windows.Forms.Label();
            this.lblSellerName = new System.Windows.Forms.Label();
            this.lblSellerAddress = new System.Windows.Forms.Label();
            this.lblSellerCity = new System.Windows.Forms.Label();
            this.stbSellerName = new SmartControls.SmartTextBox();
            this.pnlSellerId = new System.Windows.Forms.Panel();
            this.btnExistingCustomer = new SmartControls.SmartButton();
            this.lblSellerIdNo = new System.Windows.Forms.Label();
            this.stbSellerPhone = new SmartControls.SmartTextBox();
            this.pnlSellerCity = new System.Windows.Forms.Panel();
            this.lblSellerCityCountry = new System.Windows.Forms.Label();
            this.stbSellerZipCode = new SmartControls.SmartTextBox();
            this.tlpEstateAgent.SuspendLayout();
            this.tlpSeller.SuspendLayout();
            this.pnlSellerId.SuspendLayout();
            this.pnlSellerCity.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpEstateAgent
            // 
            this.tlpEstateAgent.ColumnCount = 2;
            this.tlpEstateAgent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpEstateAgent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpEstateAgent.Controls.Add(this.lblEstateAgentName, 0, 0);
            this.tlpEstateAgent.Controls.Add(this.stbEstateAgentName, 1, 0);
            this.tlpEstateAgent.Location = new System.Drawing.Point(0, 60);
            this.tlpEstateAgent.Margin = new System.Windows.Forms.Padding(0);
            this.tlpEstateAgent.Name = "tlpEstateAgent";
            this.tlpEstateAgent.RowCount = 1;
            this.tlpEstateAgent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEstateAgent.Size = new System.Drawing.Size(480, 30);
            this.tlpEstateAgent.TabIndex = 0;
            // 
            // lblEstateAgentName
            // 
            this.lblEstateAgentName.AutoSize = true;
            this.lblEstateAgentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstateAgentName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstateAgentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblEstateAgentName.Location = new System.Drawing.Point(0, 0);
            this.lblEstateAgentName.Margin = new System.Windows.Forms.Padding(0);
            this.lblEstateAgentName.Name = "lblEstateAgentName";
            this.lblEstateAgentName.Size = new System.Drawing.Size(120, 30);
            this.lblEstateAgentName.TabIndex = 0;
            this.lblEstateAgentName.Text = "Navn";
            this.lblEstateAgentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stbEstateAgentName
            // 
            this.stbEstateAgentName.AutomaticValidation = true;
            this.stbEstateAgentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stbEstateAgentName.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.stbEstateAgentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stbEstateAgentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stbEstateAgentName.ErrorMsg = SmartControls.SmartTextBox.ErrorType.ToShort;
            this.stbEstateAgentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.stbEstateAgentName.Location = new System.Drawing.Point(120, 0);
            this.stbEstateAgentName.Margin = new System.Windows.Forms.Padding(0);
            this.stbEstateAgentName.MinLength = 5;
            this.stbEstateAgentName.Name = "stbEstateAgentName";
            this.stbEstateAgentName.RegularExpression = null;
            this.stbEstateAgentName.Size = new System.Drawing.Size(360, 30);
            this.stbEstateAgentName.TabIndex = 1;
            this.stbEstateAgentName.Text = null;
            // 
            // tlpSeller
            // 
            this.tlpSeller.ColumnCount = 2;
            this.tlpSeller.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSeller.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpSeller.Controls.Add(this.smartTextBox2, 1, 5);
            this.tlpSeller.Controls.Add(this.stbSellerAdress, 1, 2);
            this.tlpSeller.Controls.Add(this.lblSellerEmail, 0, 5);
            this.tlpSeller.Controls.Add(this.lblSellerId, 0, 0);
            this.tlpSeller.Controls.Add(this.lblSellerPhone, 0, 4);
            this.tlpSeller.Controls.Add(this.lblSellerName, 0, 1);
            this.tlpSeller.Controls.Add(this.lblSellerAddress, 0, 2);
            this.tlpSeller.Controls.Add(this.lblSellerCity, 0, 3);
            this.tlpSeller.Controls.Add(this.stbSellerName, 1, 1);
            this.tlpSeller.Controls.Add(this.pnlSellerId, 1, 0);
            this.tlpSeller.Controls.Add(this.stbSellerPhone, 1, 4);
            this.tlpSeller.Controls.Add(this.pnlSellerCity, 1, 3);
            this.tlpSeller.Location = new System.Drawing.Point(0, 178);
            this.tlpSeller.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSeller.Name = "tlpSeller";
            this.tlpSeller.RowCount = 6;
            this.tlpSeller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSeller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSeller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSeller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSeller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSeller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSeller.Size = new System.Drawing.Size(480, 240);
            this.tlpSeller.TabIndex = 1;
            // 
            // smartTextBox2
            // 
            this.smartTextBox2.AutomaticValidation = true;
            this.smartTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.smartTextBox2.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.smartTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.smartTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.smartTextBox2.ErrorMsg = SmartControls.SmartTextBox.ErrorType.None;
            this.smartTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.smartTextBox2.Location = new System.Drawing.Point(120, 200);
            this.smartTextBox2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.smartTextBox2.MinLength = 10;
            this.smartTextBox2.Name = "smartTextBox2";
            this.smartTextBox2.RegularExpression = null;
            this.smartTextBox2.Size = new System.Drawing.Size(360, 30);
            this.smartTextBox2.TabIndex = 2;
            this.smartTextBox2.Text = "jens-hansen@bondegaard.dk";
            // 
            // stbSellerAdress
            // 
            this.stbSellerAdress.AutomaticValidation = true;
            this.stbSellerAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stbSellerAdress.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.stbSellerAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stbSellerAdress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stbSellerAdress.ErrorMsg = SmartControls.SmartTextBox.ErrorType.None;
            this.stbSellerAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.stbSellerAdress.Location = new System.Drawing.Point(120, 80);
            this.stbSellerAdress.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.stbSellerAdress.MinLength = 5;
            this.stbSellerAdress.Name = "stbSellerAdress";
            this.stbSellerAdress.RegularExpression = null;
            this.stbSellerAdress.Size = new System.Drawing.Size(360, 30);
            this.stbSellerAdress.TabIndex = 3;
            this.stbSellerAdress.Text = "Bondegård 1";
            // 
            // lblSellerEmail
            // 
            this.lblSellerEmail.AutoSize = true;
            this.lblSellerEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSellerEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblSellerEmail.Location = new System.Drawing.Point(0, 200);
            this.lblSellerEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblSellerEmail.Name = "lblSellerEmail";
            this.lblSellerEmail.Size = new System.Drawing.Size(120, 30);
            this.lblSellerEmail.TabIndex = 2;
            this.lblSellerEmail.Text = "Email";
            this.lblSellerEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSellerId
            // 
            this.lblSellerId.AutoSize = true;
            this.lblSellerId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSellerId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblSellerId.Location = new System.Drawing.Point(0, 0);
            this.lblSellerId.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblSellerId.Name = "lblSellerId";
            this.lblSellerId.Size = new System.Drawing.Size(120, 30);
            this.lblSellerId.TabIndex = 3;
            this.lblSellerId.Text = "Id";
            this.lblSellerId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSellerPhone
            // 
            this.lblSellerPhone.AutoSize = true;
            this.lblSellerPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSellerPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblSellerPhone.Location = new System.Drawing.Point(0, 160);
            this.lblSellerPhone.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblSellerPhone.Name = "lblSellerPhone";
            this.lblSellerPhone.Size = new System.Drawing.Size(110, 40);
            this.lblSellerPhone.TabIndex = 3;
            this.lblSellerPhone.Text = "Tlf.";
            this.lblSellerPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSellerName
            // 
            this.lblSellerName.AutoSize = true;
            this.lblSellerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSellerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblSellerName.Location = new System.Drawing.Point(0, 40);
            this.lblSellerName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.Size = new System.Drawing.Size(120, 30);
            this.lblSellerName.TabIndex = 3;
            this.lblSellerName.Text = "Navn";
            this.lblSellerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSellerAddress
            // 
            this.lblSellerAddress.AutoSize = true;
            this.lblSellerAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSellerAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblSellerAddress.Location = new System.Drawing.Point(0, 80);
            this.lblSellerAddress.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblSellerAddress.Name = "lblSellerAddress";
            this.lblSellerAddress.Size = new System.Drawing.Size(120, 30);
            this.lblSellerAddress.TabIndex = 3;
            this.lblSellerAddress.Text = "Adresse";
            this.lblSellerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSellerCity
            // 
            this.lblSellerCity.AutoSize = true;
            this.lblSellerCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSellerCity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblSellerCity.Location = new System.Drawing.Point(0, 120);
            this.lblSellerCity.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblSellerCity.Name = "lblSellerCity";
            this.lblSellerCity.Size = new System.Drawing.Size(120, 30);
            this.lblSellerCity.TabIndex = 3;
            this.lblSellerCity.Text = "By";
            this.lblSellerCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stbSellerName
            // 
            this.stbSellerName.AllowDrop = true;
            this.stbSellerName.AutomaticValidation = true;
            this.stbSellerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stbSellerName.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.stbSellerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stbSellerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stbSellerName.ErrorMsg = SmartControls.SmartTextBox.ErrorType.None;
            this.stbSellerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.stbSellerName.Location = new System.Drawing.Point(120, 40);
            this.stbSellerName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.stbSellerName.MinLength = -1;
            this.stbSellerName.Name = "stbSellerName";
            this.stbSellerName.RegularExpression = null;
            this.stbSellerName.Size = new System.Drawing.Size(360, 30);
            this.stbSellerName.TabIndex = 4;
            this.stbSellerName.Text = "Jens Hansen";
            // 
            // pnlSellerId
            // 
            this.pnlSellerId.Controls.Add(this.btnExistingCustomer);
            this.pnlSellerId.Controls.Add(this.lblSellerIdNo);
            this.pnlSellerId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSellerId.Location = new System.Drawing.Point(120, 0);
            this.pnlSellerId.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlSellerId.Name = "pnlSellerId";
            this.pnlSellerId.Size = new System.Drawing.Size(360, 30);
            this.pnlSellerId.TabIndex = 5;
            // 
            // btnExistingCustomer
            // 
            this.btnExistingCustomer.AutoSize = true;
            this.btnExistingCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExistingCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnExistingCustomer.Color = SmartControls.SmartColor.ColorStyle.Dark;
            this.btnExistingCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExistingCustomer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExistingCustomer.FlatAppearance.BorderSize = 0;
            this.btnExistingCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnExistingCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnExistingCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExistingCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnExistingCustomer.Location = new System.Drawing.Point(127, 0);
            this.btnExistingCustomer.Name = "btnExistingCustomer";
            this.btnExistingCustomer.Size = new System.Drawing.Size(233, 30);
            this.btnExistingCustomer.TabIndex = 1;
            this.btnExistingCustomer.Text = "Find eksisterende kunde";
            this.btnExistingCustomer.UseVisualStyleBackColor = false;
            // 
            // lblSellerIdNo
            // 
            this.lblSellerIdNo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSellerIdNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerIdNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblSellerIdNo.Location = new System.Drawing.Point(0, 0);
            this.lblSellerIdNo.Margin = new System.Windows.Forms.Padding(0);
            this.lblSellerIdNo.Name = "lblSellerIdNo";
            this.lblSellerIdNo.Size = new System.Drawing.Size(68, 30);
            this.lblSellerIdNo.TabIndex = 0;
            this.lblSellerIdNo.Text = "1";
            this.lblSellerIdNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stbSellerPhone
            // 
            this.stbSellerPhone.AutomaticValidation = true;
            this.stbSellerPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stbSellerPhone.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.stbSellerPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stbSellerPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stbSellerPhone.ErrorMsg = SmartControls.SmartTextBox.ErrorType.None;
            this.stbSellerPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.stbSellerPhone.Location = new System.Drawing.Point(120, 160);
            this.stbSellerPhone.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.stbSellerPhone.MinLength = 8;
            this.stbSellerPhone.Name = "stbSellerPhone";
            this.stbSellerPhone.RegularExpression = null;
            this.stbSellerPhone.Size = new System.Drawing.Size(360, 30);
            this.stbSellerPhone.TabIndex = 3;
            this.stbSellerPhone.Text = "987654321";
            // 
            // pnlSellerCity
            // 
            this.pnlSellerCity.Controls.Add(this.lblSellerCityCountry);
            this.pnlSellerCity.Controls.Add(this.stbSellerZipCode);
            this.pnlSellerCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSellerCity.Location = new System.Drawing.Point(120, 120);
            this.pnlSellerCity.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlSellerCity.Name = "pnlSellerCity";
            this.pnlSellerCity.Size = new System.Drawing.Size(360, 30);
            this.pnlSellerCity.TabIndex = 6;
            // 
            // lblSellerCityCountry
            // 
            this.lblSellerCityCountry.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSellerCityCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblSellerCityCountry.Location = new System.Drawing.Point(79, 0);
            this.lblSellerCityCountry.Name = "lblSellerCityCountry";
            this.lblSellerCityCountry.Size = new System.Drawing.Size(281, 30);
            this.lblSellerCityCountry.TabIndex = 4;
            this.lblSellerCityCountry.Text = "Vejle, Danmark";
            this.lblSellerCityCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stbSellerZipCode
            // 
            this.stbSellerZipCode.AutomaticValidation = true;
            this.stbSellerZipCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stbSellerZipCode.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.stbSellerZipCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stbSellerZipCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.stbSellerZipCode.ErrorMsg = SmartControls.SmartTextBox.ErrorType.None;
            this.stbSellerZipCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.stbSellerZipCode.Location = new System.Drawing.Point(0, 0);
            this.stbSellerZipCode.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.stbSellerZipCode.MinLength = 4;
            this.stbSellerZipCode.Name = "stbSellerZipCode";
            this.stbSellerZipCode.RegularExpression = null;
            this.stbSellerZipCode.Size = new System.Drawing.Size(68, 30);
            this.stbSellerZipCode.TabIndex = 3;
            this.stbSellerZipCode.Text = "7100";
            // 
            // NewCaseStepSeller
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tlpSeller);
            this.Controls.Add(this.tlpEstateAgent);
            this.Name = "NewCaseStepSeller";
            this.Size = new System.Drawing.Size(480, 500);
            this.tlpEstateAgent.ResumeLayout(false);
            this.tlpEstateAgent.PerformLayout();
            this.tlpSeller.ResumeLayout(false);
            this.tlpSeller.PerformLayout();
            this.pnlSellerId.ResumeLayout(false);
            this.pnlSellerId.PerformLayout();
            this.pnlSellerCity.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEstateAgent;
        private System.Windows.Forms.Label lblEstateAgentName;
        private SmartControls.SmartTextBox stbEstateAgentName;
        private System.Windows.Forms.TableLayoutPanel tlpSeller;
        private System.Windows.Forms.Label lblSellerEmail;
        private System.Windows.Forms.Label lblSellerId;
        private System.Windows.Forms.Label lblSellerPhone;
        private System.Windows.Forms.Label lblSellerName;
        private System.Windows.Forms.Label lblSellerAddress;
        private System.Windows.Forms.Label lblSellerCity;
        private SmartControls.SmartTextBox stbSellerName;
        private System.Windows.Forms.Panel pnlSellerId;
        private System.Windows.Forms.Label lblSellerIdNo;
        private SmartControls.SmartTextBox smartTextBox2;
        private SmartControls.SmartTextBox stbSellerAdress;
        private SmartControls.SmartButton btnExistingCustomer;
        private SmartControls.SmartTextBox stbSellerPhone;
        private System.Windows.Forms.Panel pnlSellerCity;
        private System.Windows.Forms.Label lblSellerCityCountry;
        private SmartControls.SmartTextBox stbSellerZipCode;
    }
}
