using SmartControls;

namespace LivingSmartForms.DropIns
{
	partial class EstateAgentSearchDropIn
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
			this.pnlBottomControlsHolder = new System.Windows.Forms.Panel();
			this.pnlBottomControlsBorder = new System.Windows.Forms.Panel();
			this.pnlBottomControls = new System.Windows.Forms.Panel();
			this.btnCancel = new SmartControls.SmartButton();
			this.btnSelect = new SmartControls.SmartButton();
			this.clsResult = new SmartControls.ControlList();
			this.pnlSubmenuHolder = new System.Windows.Forms.Panel();
			this.pnlSubmenuBorder = new System.Windows.Forms.Panel();
			this.pnlSubmenu = new System.Windows.Forms.Panel();
			this.header1 = new SmartControls.Header();
			this.tlpSeller = new System.Windows.Forms.TableLayoutPanel();
			this.lblId = new System.Windows.Forms.Label();
			this.stbId = new SmartControls.SmartTextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.stbName = new SmartControls.SmartTextBox();
			this.stbPhone = new SmartControls.SmartTextBox();
			this.stbEmail = new SmartControls.SmartTextBox();
			this.lblPhone = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.header = new SmartControls.Header();
			this.pnlBottomControlsHolder.SuspendLayout();
			this.pnlBottomControls.SuspendLayout();
			this.pnlSubmenuHolder.SuspendLayout();
			this.tlpSeller.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlBottomControlsHolder
			// 
			this.pnlBottomControlsHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlBottomControlsHolder.Controls.Add(this.pnlBottomControlsBorder);
			this.pnlBottomControlsHolder.Controls.Add(this.pnlBottomControls);
			this.pnlBottomControlsHolder.Location = new System.Drawing.Point(0, 600);
			this.pnlBottomControlsHolder.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBottomControlsHolder.Name = "pnlBottomControlsHolder";
			this.pnlBottomControlsHolder.Size = new System.Drawing.Size(400, 50);
			this.pnlBottomControlsHolder.TabIndex = 13;
			// 
			// pnlBottomControlsBorder
			// 
			this.pnlBottomControlsBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.pnlBottomControlsBorder.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlBottomControlsBorder.Location = new System.Drawing.Point(0, 0);
			this.pnlBottomControlsBorder.Name = "pnlBottomControlsBorder";
			this.pnlBottomControlsBorder.Size = new System.Drawing.Size(400, 2);
			this.pnlBottomControlsBorder.TabIndex = 1;
			// 
			// pnlBottomControls
			// 
			this.pnlBottomControls.Controls.Add(this.btnCancel);
			this.pnlBottomControls.Controls.Add(this.btnSelect);
			this.pnlBottomControls.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottomControls.Location = new System.Drawing.Point(0, 0);
			this.pnlBottomControls.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBottomControls.Name = "pnlBottomControls";
			this.pnlBottomControls.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.pnlBottomControls.Size = new System.Drawing.Size(400, 50);
			this.pnlBottomControls.TabIndex = 0;
			// 
			// btnCancel
			// 
			this.btnCancel.AutoSize = true;
			this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnCancel.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnCancel.Location = new System.Drawing.Point(17, 10);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(20, 10, 0, 10);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(95, 30);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Annullér";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSelect
			// 
			this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelect.AutoSize = true;
			this.btnSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnSelect.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSelect.FlatAppearance.BorderSize = 0;
			this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnSelect.Location = new System.Drawing.Point(302, 10);
			this.btnSelect.Margin = new System.Windows.Forms.Padding(0, 10, 20, 10);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(78, 30);
			this.btnSelect.TabIndex = 0;
			this.btnSelect.Text = "Vælg";
			this.btnSelect.UseVisualStyleBackColor = false;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// clsResult
			// 
			this.clsResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.clsResult.AutoScroll = true;
			this.clsResult.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.clsResult.Location = new System.Drawing.Point(10, 302);
			this.clsResult.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.clsResult.Name = "clsResult";
			this.clsResult.Size = new System.Drawing.Size(380, 284);
			this.clsResult.Spacing = 5;
			this.clsResult.TabIndex = 15;
			this.clsResult.WrapContents = false;
			// 
			// pnlSubmenuHolder
			// 
			this.pnlSubmenuHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSubmenuHolder.Controls.Add(this.pnlSubmenuBorder);
			this.pnlSubmenuHolder.Controls.Add(this.pnlSubmenu);
			this.pnlSubmenuHolder.Location = new System.Drawing.Point(0, 2);
			this.pnlSubmenuHolder.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSubmenuHolder.Name = "pnlSubmenuHolder";
			this.pnlSubmenuHolder.Size = new System.Drawing.Size(400, 50);
			this.pnlSubmenuHolder.TabIndex = 12;
			// 
			// pnlSubmenuBorder
			// 
			this.pnlSubmenuBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.pnlSubmenuBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlSubmenuBorder.Location = new System.Drawing.Point(0, 48);
			this.pnlSubmenuBorder.Name = "pnlSubmenuBorder";
			this.pnlSubmenuBorder.Size = new System.Drawing.Size(400, 2);
			this.pnlSubmenuBorder.TabIndex = 1;
			// 
			// pnlSubmenu
			// 
			this.pnlSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubmenu.Location = new System.Drawing.Point(0, 0);
			this.pnlSubmenu.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSubmenu.Name = "pnlSubmenu";
			this.pnlSubmenu.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.pnlSubmenu.Size = new System.Drawing.Size(400, 50);
			this.pnlSubmenu.TabIndex = 0;
			// 
			// header1
			// 
			this.header1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.header1.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.header1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.header1.Location = new System.Drawing.Point(10, 267);
			this.header1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.header1.Name = "header1";
			this.header1.Size = new System.Drawing.Size(380, 25);
			this.header1.TabIndex = 14;
			this.header1.Text = "Resultat";
			// 
			// tlpSeller
			// 
			this.tlpSeller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tlpSeller.ColumnCount = 2;
			this.tlpSeller.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpSeller.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.tlpSeller.Controls.Add(this.lblId, 0, 0);
			this.tlpSeller.Controls.Add(this.stbId, 1, 0);
			this.tlpSeller.Controls.Add(this.lblName, 0, 1);
			this.tlpSeller.Controls.Add(this.stbName, 1, 1);
			this.tlpSeller.Controls.Add(this.stbPhone, 1, 2);
			this.tlpSeller.Controls.Add(this.stbEmail, 1, 3);
			this.tlpSeller.Controls.Add(this.lblPhone, 0, 2);
			this.tlpSeller.Controls.Add(this.lblEmail, 0, 3);
			this.tlpSeller.Location = new System.Drawing.Point(10, 97);
			this.tlpSeller.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
			this.tlpSeller.Name = "tlpSeller";
			this.tlpSeller.RowCount = 4;
			this.tlpSeller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpSeller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpSeller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpSeller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpSeller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpSeller.Size = new System.Drawing.Size(380, 160);
			this.tlpSeller.TabIndex = 10;
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblId.Location = new System.Drawing.Point(0, 0);
			this.lblId.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(95, 30);
			this.lblId.TabIndex = 8;
			this.lblId.Text = "Id";
			this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// stbId
			// 
			this.stbId.AllowComma = false;
			this.stbId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbId.AutomaticValidation = false;
			this.stbId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbId.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbId.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbId.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbId.Location = new System.Drawing.Point(95, 0);
			this.stbId.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbId.MaxLength = 32767;
			this.stbId.MinLength = -1;
			this.stbId.Multiline = false;
			this.stbId.Name = "stbId";
			this.stbId.NumericOnly = true;
			this.stbId.Placeholder = null;
			this.stbId.RegularExpression = null;
			this.stbId.Required = false;
			this.stbId.Size = new System.Drawing.Size(285, 30);
			this.stbId.Suffix = null;
			this.stbId.TabIndex = 0;
			this.stbId.TabStop = false;
			this.stbId.UseSystemPasswordChar = false;
			this.stbId.TextChanged += new System.EventHandler(this.Search);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblName.Location = new System.Drawing.Point(0, 40);
			this.lblName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(95, 30);
			this.lblName.TabIndex = 3;
			this.lblName.Text = "Navn";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// stbName
			// 
			this.stbName.AllowComma = false;
			this.stbName.AllowDrop = true;
			this.stbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbName.AutomaticValidation = false;
			this.stbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbName.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbName.Location = new System.Drawing.Point(95, 40);
			this.stbName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbName.MaxLength = 32767;
			this.stbName.MinLength = -1;
			this.stbName.Multiline = false;
			this.stbName.Name = "stbName";
			this.stbName.NumericOnly = false;
			this.stbName.Placeholder = null;
			this.stbName.RegularExpression = null;
			this.stbName.Required = false;
			this.stbName.Size = new System.Drawing.Size(285, 30);
			this.stbName.Suffix = null;
			this.stbName.TabIndex = 1;
			this.stbName.TabStop = false;
			this.stbName.UseSystemPasswordChar = false;
			this.stbName.TextChanged += new System.EventHandler(this.Search);
			// 
			// stbPhone
			// 
			this.stbPhone.AllowComma = false;
			this.stbPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbPhone.AutomaticValidation = false;
			this.stbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbPhone.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbPhone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbPhone.Location = new System.Drawing.Point(95, 80);
			this.stbPhone.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbPhone.MaxLength = 8;
			this.stbPhone.MinLength = -1;
			this.stbPhone.Multiline = false;
			this.stbPhone.Name = "stbPhone";
			this.stbPhone.NumericOnly = true;
			this.stbPhone.Placeholder = null;
			this.stbPhone.RegularExpression = null;
			this.stbPhone.Required = false;
			this.stbPhone.Size = new System.Drawing.Size(285, 30);
			this.stbPhone.Suffix = null;
			this.stbPhone.TabIndex = 2;
			this.stbPhone.TabStop = false;
			this.stbPhone.UseSystemPasswordChar = false;
			this.stbPhone.TextChanged += new System.EventHandler(this.Search);
			// 
			// stbEmail
			// 
			this.stbEmail.AllowComma = false;
			this.stbEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbEmail.AutomaticValidation = false;
			this.stbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbEmail.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbEmail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbEmail.Location = new System.Drawing.Point(95, 120);
			this.stbEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbEmail.MaxLength = 32767;
			this.stbEmail.MinLength = -1;
			this.stbEmail.Multiline = false;
			this.stbEmail.Name = "stbEmail";
			this.stbEmail.NumericOnly = false;
			this.stbEmail.Placeholder = null;
			this.stbEmail.RegularExpression = null;
			this.stbEmail.Required = false;
			this.stbEmail.Size = new System.Drawing.Size(285, 30);
			this.stbEmail.Suffix = null;
			this.stbEmail.TabIndex = 3;
			this.stbEmail.TabStop = false;
			this.stbEmail.UseSystemPasswordChar = false;
			this.stbEmail.TextChanged += new System.EventHandler(this.Search);
			// 
			// lblPhone
			// 
			this.lblPhone.AutoSize = true;
			this.lblPhone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblPhone.Location = new System.Drawing.Point(0, 80);
			this.lblPhone.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(85, 40);
			this.lblPhone.TabIndex = 3;
			this.lblPhone.Text = "Tlf.";
			this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblEmail.Location = new System.Drawing.Point(0, 120);
			this.lblEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(95, 30);
			this.lblEmail.TabIndex = 2;
			this.lblEmail.Text = "Email";
			this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// header
			// 
			this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.header.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.header.Location = new System.Drawing.Point(10, 62);
			this.header.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.header.Name = "header";
			this.header.Size = new System.Drawing.Size(380, 25);
			this.header.TabIndex = 11;
			this.header.Text = "Find mægler";
			// 
			// EstateAgentSearchDropIn
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.pnlBottomControlsHolder);
			this.Controls.Add(this.clsResult);
			this.Controls.Add(this.pnlSubmenuHolder);
			this.Controls.Add(this.header1);
			this.Controls.Add(this.tlpSeller);
			this.Controls.Add(this.header);
			this.Name = "EstateAgentSearchDropIn";
			this.Size = new System.Drawing.Size(400, 650);
			this.pnlBottomControlsHolder.ResumeLayout(false);
			this.pnlBottomControls.ResumeLayout(false);
			this.pnlBottomControls.PerformLayout();
			this.pnlSubmenuHolder.ResumeLayout(false);
			this.tlpSeller.ResumeLayout(false);
			this.tlpSeller.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlSubmenu;
		private System.Windows.Forms.Panel pnlBottomControlsBorder;
		private System.Windows.Forms.Label lblId;
		private SmartControls.SmartTextBox stbId;
		private SmartControls.SmartTextBox stbEmail;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblPhone;
		private System.Windows.Forms.Panel pnlBottomControls;
		private SmartControls.SmartButton btnCancel;
		private SmartControls.SmartButton btnSelect;
		private System.Windows.Forms.Label lblName;
		private SmartControls.SmartTextBox stbName;
		private System.Windows.Forms.Panel pnlBottomControlsHolder;
		private SmartControls.ControlList clsResult;
		private SmartControls.SmartTextBox stbPhone;
		private System.Windows.Forms.Panel pnlSubmenuHolder;
		private System.Windows.Forms.Panel pnlSubmenuBorder;
		private SmartControls.Header header1;
		private System.Windows.Forms.TableLayoutPanel tlpSeller;
		private SmartControls.Header header;
	}
}
