using SmartControls;

namespace LivingSmartForms.Views
{
	partial class NewCaseStepEndCase
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
			this.tlpSeller = new System.Windows.Forms.TableLayoutPanel();
			this.dafTransferDate = new LivingSmartForms.UserControls.DateField();
			this.pnlSellerId = new System.Windows.Forms.Panel();
			this.btnFindBuyer = new SmartControls.SmartButton();
			this.lblBuyerName = new System.Windows.Forms.Label();
			this.lblBuyerTitle = new System.Windows.Forms.Label();
			this.lblDateOfSale = new System.Windows.Forms.Label();
			this.lblTransferDate = new System.Windows.Forms.Label();
			this.lblSellingPrice = new System.Windows.Forms.Label();
			this.stbSellingPrice = new SmartControls.SmartTextBox();
			this.dafDateOfSale = new LivingSmartForms.UserControls.DateField();
			this.hdrBuyer = new SmartControls.Header();
			this.hdrCase = new SmartControls.Header();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnCreateInvoice = new SmartControls.SmartButton();
			this.stbFeePercent = new SmartControls.SmartTextBox();
			this.lblFeePercent = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCloseCase = new SmartControls.SmartButton();
			this.lblCreateInvoice = new System.Windows.Forms.Label();
			this.lblStatusTitle = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.tlpSeller.SuspendLayout();
			this.pnlSellerId.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpSeller
			// 
			this.tlpSeller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tlpSeller.ColumnCount = 2;
			this.tlpSeller.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.125F));
			this.tlpSeller.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.875F));
			this.tlpSeller.Controls.Add(this.dafTransferDate, 1, 2);
			this.tlpSeller.Controls.Add(this.pnlSellerId, 1, 0);
			this.tlpSeller.Controls.Add(this.lblBuyerTitle, 0, 0);
			this.tlpSeller.Controls.Add(this.lblDateOfSale, 0, 1);
			this.tlpSeller.Controls.Add(this.lblTransferDate, 0, 2);
			this.tlpSeller.Controls.Add(this.lblSellingPrice, 0, 3);
			this.tlpSeller.Controls.Add(this.stbSellingPrice, 1, 3);
			this.tlpSeller.Controls.Add(this.dafDateOfSale, 1, 1);
			this.tlpSeller.Location = new System.Drawing.Point(0, 43);
			this.tlpSeller.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.tlpSeller.Name = "tlpSeller";
			this.tlpSeller.RowCount = 5;
			this.tlpSeller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpSeller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpSeller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpSeller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpSeller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpSeller.Size = new System.Drawing.Size(480, 160);
			this.tlpSeller.TabIndex = 1;
			// 
			// dafTransferDate
			// 
			this.dafTransferDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dafTransferDate.Location = new System.Drawing.Point(135, 80);
			this.dafTransferDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.dafTransferDate.Name = "dafTransferDate";
			this.dafTransferDate.Size = new System.Drawing.Size(345, 30);
			this.dafTransferDate.TabIndex = 10;
			// 
			// pnlSellerId
			// 
			this.pnlSellerId.Controls.Add(this.btnFindBuyer);
			this.pnlSellerId.Controls.Add(this.lblBuyerName);
			this.pnlSellerId.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlSellerId.Location = new System.Drawing.Point(135, 0);
			this.pnlSellerId.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.pnlSellerId.Name = "pnlSellerId";
			this.pnlSellerId.Size = new System.Drawing.Size(345, 30);
			this.pnlSellerId.TabIndex = 9;
			// 
			// btnFindBuyer
			// 
			this.btnFindBuyer.AutoSize = true;
			this.btnFindBuyer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnFindBuyer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnFindBuyer.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.btnFindBuyer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFindBuyer.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnFindBuyer.FlatAppearance.BorderSize = 0;
			this.btnFindBuyer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnFindBuyer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnFindBuyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFindBuyer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnFindBuyer.Location = new System.Drawing.Point(234, 0);
			this.btnFindBuyer.Name = "btnFindBuyer";
			this.btnFindBuyer.Size = new System.Drawing.Size(111, 30);
			this.btnFindBuyer.TabIndex = 0;
			this.btnFindBuyer.Text = "Find kunde";
			this.btnFindBuyer.UseVisualStyleBackColor = false;
			this.btnFindBuyer.Click += new System.EventHandler(this.btnFindBuyer_Click);
			// 
			// lblBuyerName
			// 
			this.lblBuyerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblBuyerName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.lblBuyerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblBuyerName.Location = new System.Drawing.Point(0, 0);
			this.lblBuyerName.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.lblBuyerName.Name = "lblBuyerName";
			this.lblBuyerName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.lblBuyerName.Size = new System.Drawing.Size(201, 30);
			this.lblBuyerName.TabIndex = 0;
			this.lblBuyerName.Text = "Navn";
			this.lblBuyerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblBuyerTitle
			// 
			this.lblBuyerTitle.AutoSize = true;
			this.lblBuyerTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblBuyerTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBuyerTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblBuyerTitle.Location = new System.Drawing.Point(0, 0);
			this.lblBuyerTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblBuyerTitle.Name = "lblBuyerTitle";
			this.lblBuyerTitle.Size = new System.Drawing.Size(135, 30);
			this.lblBuyerTitle.TabIndex = 3;
			this.lblBuyerTitle.Text = "Køber";
			this.lblBuyerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblDateOfSale
			// 
			this.lblDateOfSale.AutoSize = true;
			this.lblDateOfSale.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblDateOfSale.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDateOfSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblDateOfSale.Location = new System.Drawing.Point(0, 40);
			this.lblDateOfSale.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblDateOfSale.Name = "lblDateOfSale";
			this.lblDateOfSale.Size = new System.Drawing.Size(135, 30);
			this.lblDateOfSale.TabIndex = 3;
			this.lblDateOfSale.Text = "Salgsdato";
			this.lblDateOfSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTransferDate
			// 
			this.lblTransferDate.AutoEllipsis = true;
			this.lblTransferDate.AutoSize = true;
			this.lblTransferDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTransferDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTransferDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblTransferDate.Location = new System.Drawing.Point(0, 80);
			this.lblTransferDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblTransferDate.Name = "lblTransferDate";
			this.lblTransferDate.Size = new System.Drawing.Size(135, 30);
			this.lblTransferDate.TabIndex = 3;
			this.lblTransferDate.Text = "Overdragelsesdato";
			this.lblTransferDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblSellingPrice
			// 
			this.lblSellingPrice.AutoSize = true;
			this.lblSellingPrice.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblSellingPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSellingPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblSellingPrice.Location = new System.Drawing.Point(0, 120);
			this.lblSellingPrice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblSellingPrice.Name = "lblSellingPrice";
			this.lblSellingPrice.Size = new System.Drawing.Size(135, 30);
			this.lblSellingPrice.TabIndex = 3;
			this.lblSellingPrice.Text = "Salgspris";
			this.lblSellingPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// stbSellingPrice
			// 
			this.stbSellingPrice.AllowComma = false;
			this.stbSellingPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbSellingPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbSellingPrice.AutomaticValidation = true;
			this.stbSellingPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbSellingPrice.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbSellingPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbSellingPrice.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbSellingPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbSellingPrice.Location = new System.Drawing.Point(135, 120);
			this.stbSellingPrice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbSellingPrice.MaxLength = 8;
			this.stbSellingPrice.MinLength = -1;
			this.stbSellingPrice.Multiline = false;
			this.stbSellingPrice.Name = "stbSellingPrice";
			this.stbSellingPrice.NumericOnly = true;
			this.stbSellingPrice.Placeholder = null;
			this.stbSellingPrice.RegularExpression = null;
			this.stbSellingPrice.Required = true;
			this.stbSellingPrice.Size = new System.Drawing.Size(345, 30);
			this.stbSellingPrice.Suffix = "kr.";
			this.stbSellingPrice.TabIndex = 4;
			this.stbSellingPrice.TabStop = false;
			this.stbSellingPrice.UseSystemPasswordChar = false;
			// 
			// dafDateOfSale
			// 
			this.dafDateOfSale.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dafDateOfSale.Location = new System.Drawing.Point(135, 40);
			this.dafDateOfSale.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.dafDateOfSale.Name = "dafDateOfSale";
			this.dafDateOfSale.Size = new System.Drawing.Size(345, 30);
			this.dafDateOfSale.TabIndex = 6;
			// 
			// hdrBuyer
			// 
			this.hdrBuyer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hdrBuyer.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.hdrBuyer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.hdrBuyer.Location = new System.Drawing.Point(0, 8);
			this.hdrBuyer.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.hdrBuyer.Name = "hdrBuyer";
			this.hdrBuyer.Size = new System.Drawing.Size(480, 25);
			this.hdrBuyer.TabIndex = 2;
			this.hdrBuyer.Text = "Køber";
			// 
			// hdrCase
			// 
			this.hdrCase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hdrCase.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.hdrCase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.hdrCase.Location = new System.Drawing.Point(0, 223);
			this.hdrCase.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
			this.hdrCase.Name = "hdrCase";
			this.hdrCase.Size = new System.Drawing.Size(480, 25);
			this.hdrCase.TabIndex = 3;
			this.hdrCase.Text = "Sag";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.125F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.875F));
			this.tableLayoutPanel1.Controls.Add(this.btnCreateInvoice, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.stbFeePercent, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblFeePercent, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.btnCloseCase, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.lblCreateInvoice, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblStatusTitle, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblStatus, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 258);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 160);
			this.tableLayoutPanel1.TabIndex = 11;
			// 
			// btnCreateInvoice
			// 
			this.btnCreateInvoice.AutoSize = true;
			this.btnCreateInvoice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnCreateInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnCreateInvoice.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.btnCreateInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCreateInvoice.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnCreateInvoice.FlatAppearance.BorderSize = 0;
			this.btnCreateInvoice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnCreateInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnCreateInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreateInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnCreateInvoice.Location = new System.Drawing.Point(135, 80);
			this.btnCreateInvoice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.btnCreateInvoice.Name = "btnCreateInvoice";
			this.btnCreateInvoice.Size = new System.Drawing.Size(111, 30);
			this.btnCreateInvoice.TabIndex = 9;
			this.btnCreateInvoice.Text = "Lav faktura";
			this.btnCreateInvoice.UseVisualStyleBackColor = false;
			this.btnCreateInvoice.Click += new System.EventHandler(this.btnCreateInvoice_Click);
			// 
			// stbFeePercent
			// 
			this.stbFeePercent.AllowComma = true;
			this.stbFeePercent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbFeePercent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbFeePercent.AutomaticValidation = true;
			this.stbFeePercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbFeePercent.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbFeePercent.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbFeePercent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbFeePercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbFeePercent.Location = new System.Drawing.Point(135, 40);
			this.stbFeePercent.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbFeePercent.MaxLength = 8;
			this.stbFeePercent.MinLength = -1;
			this.stbFeePercent.Multiline = false;
			this.stbFeePercent.Name = "stbFeePercent";
			this.stbFeePercent.NumericOnly = true;
			this.stbFeePercent.Placeholder = null;
			this.stbFeePercent.RegularExpression = null;
			this.stbFeePercent.Required = true;
			this.stbFeePercent.Size = new System.Drawing.Size(345, 30);
			this.stbFeePercent.Suffix = "%";
			this.stbFeePercent.TabIndex = 8;
			this.stbFeePercent.TabStop = false;
			this.stbFeePercent.UseSystemPasswordChar = false;
			// 
			// lblFeePercent
			// 
			this.lblFeePercent.AutoSize = true;
			this.lblFeePercent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblFeePercent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFeePercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblFeePercent.Location = new System.Drawing.Point(0, 40);
			this.lblFeePercent.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblFeePercent.Name = "lblFeePercent";
			this.lblFeePercent.Size = new System.Drawing.Size(135, 30);
			this.lblFeePercent.TabIndex = 7;
			this.lblFeePercent.Text = "Salær procentsats";
			this.lblFeePercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.label1.Location = new System.Drawing.Point(0, 120);
			this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 30);
			this.label1.TabIndex = 6;
			this.label1.Text = "Afslut";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnCloseCase
			// 
			this.btnCloseCase.AutoSize = true;
			this.btnCloseCase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnCloseCase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnCloseCase.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.btnCloseCase.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCloseCase.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnCloseCase.FlatAppearance.BorderSize = 0;
			this.btnCloseCase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnCloseCase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnCloseCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCloseCase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnCloseCase.Location = new System.Drawing.Point(135, 120);
			this.btnCloseCase.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.btnCloseCase.Name = "btnCloseCase";
			this.btnCloseCase.Size = new System.Drawing.Size(92, 30);
			this.btnCloseCase.TabIndex = 5;
			this.btnCloseCase.Text = "Luk sag";
			this.btnCloseCase.UseVisualStyleBackColor = false;
			this.btnCloseCase.Click += new System.EventHandler(this.btnCloseCase_Click);
			// 
			// lblCreateInvoice
			// 
			this.lblCreateInvoice.AutoSize = true;
			this.lblCreateInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblCreateInvoice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCreateInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblCreateInvoice.Location = new System.Drawing.Point(0, 80);
			this.lblCreateInvoice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblCreateInvoice.Name = "lblCreateInvoice";
			this.lblCreateInvoice.Size = new System.Drawing.Size(135, 30);
			this.lblCreateInvoice.TabIndex = 4;
			this.lblCreateInvoice.Text = "Faktura";
			this.lblCreateInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblStatusTitle
			// 
			this.lblStatusTitle.AutoSize = true;
			this.lblStatusTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblStatusTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatusTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblStatusTitle.Location = new System.Drawing.Point(0, 0);
			this.lblStatusTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblStatusTitle.Name = "lblStatusTitle";
			this.lblStatusTitle.Size = new System.Drawing.Size(135, 30);
			this.lblStatusTitle.TabIndex = 3;
			this.lblStatusTitle.Text = "Status";
			this.lblStatusTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblStatus
			// 
			this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblStatus.Location = new System.Drawing.Point(135, 0);
			this.lblStatus.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.lblStatus.Size = new System.Drawing.Size(345, 30);
			this.lblStatus.TabIndex = 0;
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// NewCaseStepEndCase
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.hdrCase);
			this.Controls.Add(this.hdrBuyer);
			this.Controls.Add(this.tlpSeller);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "NewCaseStepEndCase";
			this.Size = new System.Drawing.Size(480, 513);
			this.tlpSeller.ResumeLayout(false);
			this.tlpSeller.PerformLayout();
			this.pnlSellerId.ResumeLayout(false);
			this.pnlSellerId.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.TableLayoutPanel tlpSeller;
		private System.Windows.Forms.Label lblBuyerTitle;
        private System.Windows.Forms.Label lblDateOfSale;
        private System.Windows.Forms.Label lblTransferDate;
		private System.Windows.Forms.Label lblSellingPrice;
		private SmartControls.SmartTextBox stbSellingPrice;
		private SmartControls.Header hdrBuyer;
		private UserControls.DateField dafTransferDate;
		private System.Windows.Forms.Panel pnlSellerId;
		private SmartButton btnFindBuyer;
		private System.Windows.Forms.Label lblBuyerName;
		private UserControls.DateField dafDateOfSale;
		private Header hdrCase;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private SmartButton btnCloseCase;
		private System.Windows.Forms.Label lblCreateInvoice;
		private System.Windows.Forms.Label lblStatusTitle;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Label lblFeePercent;
		private System.Windows.Forms.Label label1;
		private SmartButton btnCreateInvoice;
		private SmartTextBox stbFeePercent;
    }
}
