using SmartControls;

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
			System.Windows.Forms.Label lblEstateAgentNameTitle;
			this.tlpEstateAgent = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblEstateAgentName = new System.Windows.Forms.Label();
			this.stbFindEstateAgent = new SmartControls.SmartButton();
			this.tlpSeller = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.stbSellerEmail = new SmartControls.SmartTextBox();
			this.stbSellerAdress = new SmartControls.SmartTextBox();
			this.lblSellerEmail = new System.Windows.Forms.Label();
			this.lblSellerId = new System.Windows.Forms.Label();
			this.lblSellerPhone = new System.Windows.Forms.Label();
			this.lblSellerName = new System.Windows.Forms.Label();
			this.lblSellerAddress = new System.Windows.Forms.Label();
			this.lblSellerCity = new System.Windows.Forms.Label();
			this.stbSellerName = new SmartControls.SmartTextBox();
			this.pnlSellerId = new System.Windows.Forms.Panel();
			this.btnFindCustomer = new SmartControls.SmartButton();
			this.lblSellerIdNo = new System.Windows.Forms.Label();
			this.stbSellerPhone = new SmartControls.SmartTextBox();
			this.pnlSellerCity = new System.Windows.Forms.Panel();
			this.lblSellerCityCountry = new System.Windows.Forms.Label();
			this.stbSellerZipCode = new SmartControls.SmartTextBox();
			this.dafBirthday = new LivingSmartForms.UserControls.DateField();
			this.hdrEstateAgent = new SmartControls.Header();
			this.hdrSeller = new SmartControls.Header();
			lblEstateAgentNameTitle = new System.Windows.Forms.Label();
			this.tlpEstateAgent.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tlpSeller.SuspendLayout();
			this.pnlSellerId.SuspendLayout();
			this.pnlSellerCity.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblEstateAgentNameTitle
			// 
			lblEstateAgentNameTitle.AutoSize = true;
			lblEstateAgentNameTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			lblEstateAgentNameTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			lblEstateAgentNameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			lblEstateAgentNameTitle.Location = new System.Drawing.Point(0, 0);
			lblEstateAgentNameTitle.Margin = new System.Windows.Forms.Padding(0);
			lblEstateAgentNameTitle.Name = "lblEstateAgentNameTitle";
			lblEstateAgentNameTitle.Size = new System.Drawing.Size(120, 30);
			lblEstateAgentNameTitle.TabIndex = 0;
			lblEstateAgentNameTitle.Text = "Navn";
			lblEstateAgentNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tlpEstateAgent
			// 
			this.tlpEstateAgent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tlpEstateAgent.ColumnCount = 2;
			this.tlpEstateAgent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpEstateAgent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.tlpEstateAgent.Controls.Add(lblEstateAgentNameTitle, 0, 0);
			this.tlpEstateAgent.Controls.Add(this.panel1, 1, 0);
			this.tlpEstateAgent.Location = new System.Drawing.Point(0, 45);
			this.tlpEstateAgent.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.tlpEstateAgent.Name = "tlpEstateAgent";
			this.tlpEstateAgent.RowCount = 1;
			this.tlpEstateAgent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpEstateAgent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpEstateAgent.Size = new System.Drawing.Size(480, 30);
			this.tlpEstateAgent.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblEstateAgentName);
			this.panel1.Controls.Add(this.stbFindEstateAgent);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(120, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(360, 30);
			this.panel1.TabIndex = 0;
			// 
			// lblEstateAgentName
			// 
			this.lblEstateAgentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblEstateAgentName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.lblEstateAgentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblEstateAgentName.Location = new System.Drawing.Point(0, 0);
			this.lblEstateAgentName.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.lblEstateAgentName.Name = "lblEstateAgentName";
			this.lblEstateAgentName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.lblEstateAgentName.Size = new System.Drawing.Size(229, 30);
			this.lblEstateAgentName.TabIndex = 3;
			this.lblEstateAgentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// stbFindEstateAgent
			// 
			this.stbFindEstateAgent.AutoSize = true;
			this.stbFindEstateAgent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.stbFindEstateAgent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbFindEstateAgent.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.stbFindEstateAgent.Cursor = System.Windows.Forms.Cursors.Hand;
			this.stbFindEstateAgent.Dock = System.Windows.Forms.DockStyle.Right;
			this.stbFindEstateAgent.FlatAppearance.BorderSize = 0;
			this.stbFindEstateAgent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbFindEstateAgent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbFindEstateAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.stbFindEstateAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbFindEstateAgent.Location = new System.Drawing.Point(239, 0);
			this.stbFindEstateAgent.Name = "stbFindEstateAgent";
			this.stbFindEstateAgent.Size = new System.Drawing.Size(121, 30);
			this.stbFindEstateAgent.TabIndex = 0;
			this.stbFindEstateAgent.Text = "Find mægler";
			this.stbFindEstateAgent.UseVisualStyleBackColor = false;
			this.stbFindEstateAgent.Click += new System.EventHandler(this.stbFindEstateAgent_Click);
			// 
			// tlpSeller
			// 
			this.tlpSeller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tlpSeller.ColumnCount = 2;
			this.tlpSeller.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpSeller.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.tlpSeller.Controls.Add(this.label1, 0, 6);
			this.tlpSeller.Controls.Add(this.stbSellerEmail, 1, 5);
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
			this.tlpSeller.Controls.Add(this.dafBirthday, 1, 6);
			this.tlpSeller.Location = new System.Drawing.Point(0, 130);
			this.tlpSeller.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.tlpSeller.Name = "tlpSeller";
			this.tlpSeller.RowCount = 7;
			this.tlpSeller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpSeller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpSeller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpSeller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpSeller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpSeller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpSeller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpSeller.Size = new System.Drawing.Size(480, 280);
			this.tlpSeller.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.label1.Location = new System.Drawing.Point(0, 240);
			this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 30);
			this.label1.TabIndex = 7;
			this.label1.Text = "Fødselsdag";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// stbSellerEmail
			// 
			this.stbSellerEmail.AllowComma = false;
			this.stbSellerEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbSellerEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbSellerEmail.AutomaticValidation = true;
			this.stbSellerEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbSellerEmail.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbSellerEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbSellerEmail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbSellerEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbSellerEmail.Location = new System.Drawing.Point(120, 200);
			this.stbSellerEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbSellerEmail.MaxLength = 32767;
			this.stbSellerEmail.MinLength = -1;
			this.stbSellerEmail.Name = "stbSellerEmail";
			this.stbSellerEmail.NumericOnly = false;
			this.stbSellerEmail.Placeholder = null;
			this.stbSellerEmail.RegularExpression = null;
			this.stbSellerEmail.Required = true;
			this.stbSellerEmail.Size = new System.Drawing.Size(360, 30);
			this.stbSellerEmail.Suffix = null;
			this.stbSellerEmail.TabIndex = 5;
			this.stbSellerEmail.TabStop = false;
			this.stbSellerEmail.UseSystemPasswordChar = false;
			// 
			// stbSellerAdress
			// 
			this.stbSellerAdress.AllowComma = false;
			this.stbSellerAdress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbSellerAdress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbSellerAdress.AutomaticValidation = true;
			this.stbSellerAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbSellerAdress.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbSellerAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbSellerAdress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbSellerAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbSellerAdress.Location = new System.Drawing.Point(120, 80);
			this.stbSellerAdress.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbSellerAdress.MaxLength = 50;
			this.stbSellerAdress.MinLength = -1;
			this.stbSellerAdress.Name = "stbSellerAdress";
			this.stbSellerAdress.NumericOnly = false;
			this.stbSellerAdress.Placeholder = null;
			this.stbSellerAdress.RegularExpression = null;
			this.stbSellerAdress.Required = true;
			this.stbSellerAdress.Size = new System.Drawing.Size(360, 30);
			this.stbSellerAdress.Suffix = null;
			this.stbSellerAdress.TabIndex = 2;
			this.stbSellerAdress.TabStop = false;
			this.stbSellerAdress.UseSystemPasswordChar = false;
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
			this.stbSellerName.AllowComma = false;
			this.stbSellerName.AllowDrop = true;
			this.stbSellerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbSellerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbSellerName.AutomaticValidation = true;
			this.stbSellerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbSellerName.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbSellerName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbSellerName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbSellerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbSellerName.Location = new System.Drawing.Point(120, 40);
			this.stbSellerName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbSellerName.MaxLength = 50;
			this.stbSellerName.MinLength = -1;
			this.stbSellerName.Name = "stbSellerName";
			this.stbSellerName.NumericOnly = false;
			this.stbSellerName.Placeholder = null;
			this.stbSellerName.RegularExpression = null;
			this.stbSellerName.Required = true;
			this.stbSellerName.Size = new System.Drawing.Size(360, 30);
			this.stbSellerName.Suffix = null;
			this.stbSellerName.TabIndex = 1;
			this.stbSellerName.TabStop = false;
			this.stbSellerName.UseSystemPasswordChar = false;
			// 
			// pnlSellerId
			// 
			this.pnlSellerId.Controls.Add(this.btnFindCustomer);
			this.pnlSellerId.Controls.Add(this.lblSellerIdNo);
			this.pnlSellerId.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlSellerId.Location = new System.Drawing.Point(120, 0);
			this.pnlSellerId.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.pnlSellerId.Name = "pnlSellerId";
			this.pnlSellerId.Size = new System.Drawing.Size(360, 30);
			this.pnlSellerId.TabIndex = 0;
			// 
			// btnFindCustomer
			// 
			this.btnFindCustomer.AutoSize = true;
			this.btnFindCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnFindCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnFindCustomer.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.btnFindCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFindCustomer.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnFindCustomer.FlatAppearance.BorderSize = 0;
			this.btnFindCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnFindCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnFindCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFindCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnFindCustomer.Location = new System.Drawing.Point(249, 0);
			this.btnFindCustomer.Name = "btnFindCustomer";
			this.btnFindCustomer.Size = new System.Drawing.Size(111, 30);
			this.btnFindCustomer.TabIndex = 0;
			this.btnFindCustomer.Text = "Find kunde";
			this.btnFindCustomer.UseVisualStyleBackColor = false;
			this.btnFindCustomer.Click += new System.EventHandler(this.btnExistingCustomer_Click);
			// 
			// lblSellerIdNo
			// 
			this.lblSellerIdNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSellerIdNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.lblSellerIdNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblSellerIdNo.Location = new System.Drawing.Point(0, 0);
			this.lblSellerIdNo.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.lblSellerIdNo.Name = "lblSellerIdNo";
			this.lblSellerIdNo.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.lblSellerIdNo.Size = new System.Drawing.Size(216, 30);
			this.lblSellerIdNo.TabIndex = 0;
			this.lblSellerIdNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// stbSellerPhone
			// 
			this.stbSellerPhone.AllowComma = false;
			this.stbSellerPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbSellerPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbSellerPhone.AutomaticValidation = true;
			this.stbSellerPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbSellerPhone.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbSellerPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbSellerPhone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbSellerPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbSellerPhone.Location = new System.Drawing.Point(120, 160);
			this.stbSellerPhone.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbSellerPhone.MaxLength = 8;
			this.stbSellerPhone.MinLength = 8;
			this.stbSellerPhone.Name = "stbSellerPhone";
			this.stbSellerPhone.NumericOnly = true;
			this.stbSellerPhone.Placeholder = null;
			this.stbSellerPhone.RegularExpression = null;
			this.stbSellerPhone.Required = true;
			this.stbSellerPhone.Size = new System.Drawing.Size(360, 30);
			this.stbSellerPhone.Suffix = null;
			this.stbSellerPhone.TabIndex = 4;
			this.stbSellerPhone.TabStop = false;
			this.stbSellerPhone.UseSystemPasswordChar = false;
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
			this.pnlSellerCity.TabIndex = 3;
			// 
			// lblSellerCityCountry
			// 
			this.lblSellerCityCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSellerCityCountry.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.lblSellerCityCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblSellerCityCountry.Location = new System.Drawing.Point(79, 0);
			this.lblSellerCityCountry.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.lblSellerCityCountry.Name = "lblSellerCityCountry";
			this.lblSellerCityCountry.Size = new System.Drawing.Size(282, 30);
			this.lblSellerCityCountry.TabIndex = 4;
			this.lblSellerCityCountry.Text = "By";
			this.lblSellerCityCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// stbSellerZipCode
			// 
			this.stbSellerZipCode.AllowComma = false;
			this.stbSellerZipCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbSellerZipCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbSellerZipCode.AutomaticValidation = true;
			this.stbSellerZipCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbSellerZipCode.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbSellerZipCode.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbSellerZipCode.Dock = System.Windows.Forms.DockStyle.Left;
			this.stbSellerZipCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbSellerZipCode.Location = new System.Drawing.Point(0, 0);
			this.stbSellerZipCode.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbSellerZipCode.MaxLength = 4;
			this.stbSellerZipCode.MinLength = 4;
			this.stbSellerZipCode.Name = "stbSellerZipCode";
			this.stbSellerZipCode.NumericOnly = true;
			this.stbSellerZipCode.Placeholder = null;
			this.stbSellerZipCode.RegularExpression = null;
			this.stbSellerZipCode.Required = true;
			this.stbSellerZipCode.Size = new System.Drawing.Size(68, 30);
			this.stbSellerZipCode.Suffix = null;
			this.stbSellerZipCode.TabIndex = 0;
			this.stbSellerZipCode.TabStop = false;
			this.stbSellerZipCode.UseSystemPasswordChar = false;
			this.stbSellerZipCode.TextChanged += new System.EventHandler(this.stbSellerZipCode_TextChanged);
			// 
			// dafBirthday
			// 
			this.dafBirthday.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dafBirthday.Location = new System.Drawing.Point(120, 240);
			this.dafBirthday.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.dafBirthday.Name = "dafBirthday";
			this.dafBirthday.Size = new System.Drawing.Size(360, 30);
			this.dafBirthday.TabIndex = 6;
			// 
			// hdrEstateAgent
			// 
			this.hdrEstateAgent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hdrEstateAgent.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.hdrEstateAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.hdrEstateAgent.Location = new System.Drawing.Point(0, 10);
			this.hdrEstateAgent.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.hdrEstateAgent.Name = "hdrEstateAgent";
			this.hdrEstateAgent.Size = new System.Drawing.Size(480, 25);
			this.hdrEstateAgent.TabIndex = 2;
			this.hdrEstateAgent.Text = "Mægler";
			// 
			// hdrSeller
			// 
			this.hdrSeller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hdrSeller.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.hdrSeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.hdrSeller.Location = new System.Drawing.Point(0, 95);
			this.hdrSeller.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
			this.hdrSeller.Name = "hdrSeller";
			this.hdrSeller.Size = new System.Drawing.Size(480, 25);
			this.hdrSeller.TabIndex = 3;
			this.hdrSeller.Text = "Sælger";
			// 
			// NewCaseStepSeller
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.hdrSeller);
			this.Controls.Add(this.hdrEstateAgent);
			this.Controls.Add(this.tlpSeller);
			this.Controls.Add(this.tlpEstateAgent);
			this.Name = "NewCaseStepSeller";
			this.Size = new System.Drawing.Size(480, 410);
			this.tlpEstateAgent.ResumeLayout(false);
			this.tlpEstateAgent.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tlpSeller.ResumeLayout(false);
			this.tlpSeller.PerformLayout();
			this.pnlSellerId.ResumeLayout(false);
			this.pnlSellerId.PerformLayout();
			this.pnlSellerCity.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.TableLayoutPanel tlpEstateAgent;
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
        private SmartControls.SmartTextBox stbSellerEmail;
        private SmartControls.SmartTextBox stbSellerAdress;
        private SmartControls.SmartButton btnFindCustomer;
        private SmartControls.SmartTextBox stbSellerPhone;
        private System.Windows.Forms.Panel pnlSellerCity;
        private System.Windows.Forms.Label lblSellerCityCountry;
        private SmartControls.SmartTextBox stbSellerZipCode;
		private SmartControls.Header hdrEstateAgent;
		private SmartControls.Header hdrSeller;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblEstateAgentName;
		private SmartControls.SmartButton stbFindEstateAgent;
		private UserControls.DateField dafBirthday;
    }
}
