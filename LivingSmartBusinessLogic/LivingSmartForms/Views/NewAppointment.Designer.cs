namespace LivingSmartForms.Views
{
    partial class NewAppointment
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
			this.hdrNewAppointment = new SmartControls.Header();
			this.tlpNewAppointment = new System.Windows.Forms.TableLayoutPanel();
			this.stbAppointmentDescription = new SmartControls.SmartTextBox();
			this.lblAppointmentDescription = new System.Windows.Forms.Label();
			this.stbAppointmentPlace = new SmartControls.SmartTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dafAppointmentEnd = new LivingSmartForms.UserControls.DateField();
			this.lblAppointmentEnd = new System.Windows.Forms.Label();
			this.lblAppointmentStart = new System.Windows.Forms.Label();
			this.lblAppointmentCase = new System.Windows.Forms.Label();
			this.lblAppointmentCustomer = new System.Windows.Forms.Label();
			this.lblAppointmentEstateAgent = new System.Windows.Forms.Label();
			this.pnlAppointmentEstateAgent = new System.Windows.Forms.Panel();
			this.lblAppointmentEstateAgentName = new System.Windows.Forms.Label();
			this.btnAppointmentFindEstateAgent = new SmartControls.SmartButton();
			this.pnlAppointmentCustomer = new System.Windows.Forms.Panel();
			this.btnAppointmentFindCustomer = new SmartControls.SmartButton();
			this.lblAppointmentCustomerName = new System.Windows.Forms.Label();
			this.pnlAppointmentCase = new System.Windows.Forms.Panel();
			this.lblAppointmentCaseNumber = new System.Windows.Forms.Label();
			this.btnAppointmentFindCase = new SmartControls.SmartButton();
			this.dafAppointmentStart = new LivingSmartForms.UserControls.DateField();
			this.tlpNewAppointment.SuspendLayout();
			this.pnlAppointmentEstateAgent.SuspendLayout();
			this.pnlAppointmentCustomer.SuspendLayout();
			this.pnlAppointmentCase.SuspendLayout();
			this.SuspendLayout();
			// 
			// hdrNewAppointment
			// 
			this.hdrNewAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hdrNewAppointment.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.hdrNewAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.hdrNewAppointment.Location = new System.Drawing.Point(0, 10);
			this.hdrNewAppointment.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.hdrNewAppointment.Name = "hdrNewAppointment";
			this.hdrNewAppointment.Size = new System.Drawing.Size(480, 25);
			this.hdrNewAppointment.TabIndex = 4;
			this.hdrNewAppointment.Text = "Aftale";
			// 
			// tlpNewAppointment
			// 
			this.tlpNewAppointment.ColumnCount = 2;
			this.tlpNewAppointment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.625F));
			this.tlpNewAppointment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.375F));
			this.tlpNewAppointment.Controls.Add(this.stbAppointmentDescription, 1, 6);
			this.tlpNewAppointment.Controls.Add(this.lblAppointmentDescription, 0, 6);
			this.tlpNewAppointment.Controls.Add(this.stbAppointmentPlace, 1, 5);
			this.tlpNewAppointment.Controls.Add(this.label1, 0, 5);
			this.tlpNewAppointment.Controls.Add(this.dafAppointmentEnd, 1, 4);
			this.tlpNewAppointment.Controls.Add(this.lblAppointmentEnd, 0, 4);
			this.tlpNewAppointment.Controls.Add(this.lblAppointmentStart, 0, 3);
			this.tlpNewAppointment.Controls.Add(this.lblAppointmentCase, 0, 2);
			this.tlpNewAppointment.Controls.Add(this.lblAppointmentCustomer, 0, 1);
			this.tlpNewAppointment.Controls.Add(this.lblAppointmentEstateAgent, 0, 0);
			this.tlpNewAppointment.Controls.Add(this.pnlAppointmentEstateAgent, 1, 0);
			this.tlpNewAppointment.Controls.Add(this.pnlAppointmentCustomer, 1, 1);
			this.tlpNewAppointment.Controls.Add(this.pnlAppointmentCase, 1, 2);
			this.tlpNewAppointment.Controls.Add(this.dafAppointmentStart, 1, 3);
			this.tlpNewAppointment.Location = new System.Drawing.Point(0, 45);
			this.tlpNewAppointment.Name = "tlpNewAppointment";
			this.tlpNewAppointment.RowCount = 7;
			this.tlpNewAppointment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewAppointment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewAppointment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewAppointment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewAppointment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewAppointment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewAppointment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpNewAppointment.Size = new System.Drawing.Size(480, 334);
			this.tlpNewAppointment.TabIndex = 5;
			// 
			// stbAppointmentDescription
			// 
			this.stbAppointmentDescription.AllowComma = false;
			this.stbAppointmentDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbAppointmentDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbAppointmentDescription.AutomaticValidation = true;
			this.stbAppointmentDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbAppointmentDescription.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbAppointmentDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbAppointmentDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbAppointmentDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbAppointmentDescription.Location = new System.Drawing.Point(123, 240);
			this.stbAppointmentDescription.Margin = new System.Windows.Forms.Padding(0);
			this.stbAppointmentDescription.MaxLength = 500;
			this.stbAppointmentDescription.MinLength = -1;
			this.stbAppointmentDescription.Name = "stbAppointmentDescription";
			this.stbAppointmentDescription.NumericOnly = false;
			this.stbAppointmentDescription.Placeholder = null;
			this.stbAppointmentDescription.RegularExpression = null;
			this.stbAppointmentDescription.Required = true;
			this.stbAppointmentDescription.Size = new System.Drawing.Size(357, 94);
			this.stbAppointmentDescription.Suffix = null;
			this.stbAppointmentDescription.TabIndex = 18;
			this.stbAppointmentDescription.UseSystemPasswordChar = false;
			// 
			// lblAppointmentDescription
			// 
			this.lblAppointmentDescription.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblAppointmentDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAppointmentDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblAppointmentDescription.Location = new System.Drawing.Point(0, 240);
			this.lblAppointmentDescription.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblAppointmentDescription.Name = "lblAppointmentDescription";
			this.lblAppointmentDescription.Size = new System.Drawing.Size(123, 30);
			this.lblAppointmentDescription.TabIndex = 17;
			this.lblAppointmentDescription.Text = "Beskrivelse";
			this.lblAppointmentDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// stbAppointmentPlace
			// 
			this.stbAppointmentPlace.AllowComma = false;
			this.stbAppointmentPlace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbAppointmentPlace.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbAppointmentPlace.AutomaticValidation = true;
			this.stbAppointmentPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.stbAppointmentPlace.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbAppointmentPlace.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbAppointmentPlace.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbAppointmentPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stbAppointmentPlace.Location = new System.Drawing.Point(123, 200);
			this.stbAppointmentPlace.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbAppointmentPlace.MaxLength = 50;
			this.stbAppointmentPlace.MinLength = -1;
			this.stbAppointmentPlace.Name = "stbAppointmentPlace";
			this.stbAppointmentPlace.NumericOnly = false;
			this.stbAppointmentPlace.Placeholder = null;
			this.stbAppointmentPlace.RegularExpression = null;
			this.stbAppointmentPlace.Required = false;
			this.stbAppointmentPlace.Size = new System.Drawing.Size(357, 30);
			this.stbAppointmentPlace.Suffix = null;
			this.stbAppointmentPlace.TabIndex = 16;
			this.stbAppointmentPlace.UseSystemPasswordChar = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.label1.Location = new System.Drawing.Point(0, 200);
			this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 30);
			this.label1.TabIndex = 15;
			this.label1.Text = "Sted";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dafAppointmentEnd
			// 
			this.dafAppointmentEnd.Location = new System.Drawing.Point(123, 160);
			this.dafAppointmentEnd.Margin = new System.Windows.Forms.Padding(0);
			this.dafAppointmentEnd.Name = "dafAppointmentEnd";
			this.dafAppointmentEnd.Size = new System.Drawing.Size(357, 30);
			this.dafAppointmentEnd.TabIndex = 14;
			// 
			// lblAppointmentEnd
			// 
			this.lblAppointmentEnd.AutoSize = true;
			this.lblAppointmentEnd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblAppointmentEnd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAppointmentEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblAppointmentEnd.Location = new System.Drawing.Point(0, 160);
			this.lblAppointmentEnd.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblAppointmentEnd.Name = "lblAppointmentEnd";
			this.lblAppointmentEnd.Size = new System.Drawing.Size(123, 30);
			this.lblAppointmentEnd.TabIndex = 13;
			this.lblAppointmentEnd.Text = "Slut";
			this.lblAppointmentEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblAppointmentStart
			// 
			this.lblAppointmentStart.AutoSize = true;
			this.lblAppointmentStart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblAppointmentStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAppointmentStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblAppointmentStart.Location = new System.Drawing.Point(0, 120);
			this.lblAppointmentStart.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblAppointmentStart.Name = "lblAppointmentStart";
			this.lblAppointmentStart.Size = new System.Drawing.Size(123, 30);
			this.lblAppointmentStart.TabIndex = 11;
			this.lblAppointmentStart.Text = "Start";
			this.lblAppointmentStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblAppointmentCase
			// 
			this.lblAppointmentCase.AutoSize = true;
			this.lblAppointmentCase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblAppointmentCase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAppointmentCase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblAppointmentCase.Location = new System.Drawing.Point(0, 80);
			this.lblAppointmentCase.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblAppointmentCase.Name = "lblAppointmentCase";
			this.lblAppointmentCase.Size = new System.Drawing.Size(123, 30);
			this.lblAppointmentCase.TabIndex = 9;
			this.lblAppointmentCase.Text = "Sag";
			this.lblAppointmentCase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblAppointmentCustomer
			// 
			this.lblAppointmentCustomer.AutoSize = true;
			this.lblAppointmentCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblAppointmentCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAppointmentCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblAppointmentCustomer.Location = new System.Drawing.Point(0, 40);
			this.lblAppointmentCustomer.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblAppointmentCustomer.Name = "lblAppointmentCustomer";
			this.lblAppointmentCustomer.Size = new System.Drawing.Size(123, 30);
			this.lblAppointmentCustomer.TabIndex = 7;
			this.lblAppointmentCustomer.Text = "Kunde";
			this.lblAppointmentCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblAppointmentEstateAgent
			// 
			this.lblAppointmentEstateAgent.AutoSize = true;
			this.lblAppointmentEstateAgent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblAppointmentEstateAgent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAppointmentEstateAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.lblAppointmentEstateAgent.Location = new System.Drawing.Point(0, 0);
			this.lblAppointmentEstateAgent.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lblAppointmentEstateAgent.Name = "lblAppointmentEstateAgent";
			this.lblAppointmentEstateAgent.Size = new System.Drawing.Size(123, 30);
			this.lblAppointmentEstateAgent.TabIndex = 5;
			this.lblAppointmentEstateAgent.Text = "Mægler";
			this.lblAppointmentEstateAgent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlAppointmentEstateAgent
			// 
			this.pnlAppointmentEstateAgent.Controls.Add(this.lblAppointmentEstateAgentName);
			this.pnlAppointmentEstateAgent.Controls.Add(this.btnAppointmentFindEstateAgent);
			this.pnlAppointmentEstateAgent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlAppointmentEstateAgent.Location = new System.Drawing.Point(123, 0);
			this.pnlAppointmentEstateAgent.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.pnlAppointmentEstateAgent.Name = "pnlAppointmentEstateAgent";
			this.pnlAppointmentEstateAgent.Size = new System.Drawing.Size(357, 30);
			this.pnlAppointmentEstateAgent.TabIndex = 6;
			// 
			// lblAppointmentEstateAgentName
			// 
			this.lblAppointmentEstateAgentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblAppointmentEstateAgentName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.lblAppointmentEstateAgentName.Location = new System.Drawing.Point(0, 0);
			this.lblAppointmentEstateAgentName.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.lblAppointmentEstateAgentName.Name = "lblAppointmentEstateAgentName";
			this.lblAppointmentEstateAgentName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.lblAppointmentEstateAgentName.Size = new System.Drawing.Size(202, 30);
			this.lblAppointmentEstateAgentName.TabIndex = 3;
			this.lblAppointmentEstateAgentName.Text = "Navn";
			this.lblAppointmentEstateAgentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnAppointmentFindEstateAgent
			// 
			this.btnAppointmentFindEstateAgent.AutoSize = true;
			this.btnAppointmentFindEstateAgent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnAppointmentFindEstateAgent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnAppointmentFindEstateAgent.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.btnAppointmentFindEstateAgent.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAppointmentFindEstateAgent.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnAppointmentFindEstateAgent.FlatAppearance.BorderSize = 0;
			this.btnAppointmentFindEstateAgent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnAppointmentFindEstateAgent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnAppointmentFindEstateAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAppointmentFindEstateAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnAppointmentFindEstateAgent.Location = new System.Drawing.Point(236, 0);
			this.btnAppointmentFindEstateAgent.Name = "btnAppointmentFindEstateAgent";
			this.btnAppointmentFindEstateAgent.Size = new System.Drawing.Size(121, 30);
			this.btnAppointmentFindEstateAgent.TabIndex = 2;
			this.btnAppointmentFindEstateAgent.Text = "Find mægler";
			this.btnAppointmentFindEstateAgent.UseVisualStyleBackColor = false;
			// 
			// pnlAppointmentCustomer
			// 
			this.pnlAppointmentCustomer.Controls.Add(this.btnAppointmentFindCustomer);
			this.pnlAppointmentCustomer.Controls.Add(this.lblAppointmentCustomerName);
			this.pnlAppointmentCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlAppointmentCustomer.Location = new System.Drawing.Point(123, 40);
			this.pnlAppointmentCustomer.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.pnlAppointmentCustomer.Name = "pnlAppointmentCustomer";
			this.pnlAppointmentCustomer.Size = new System.Drawing.Size(357, 30);
			this.pnlAppointmentCustomer.TabIndex = 8;
			// 
			// btnAppointmentFindCustomer
			// 
			this.btnAppointmentFindCustomer.AutoSize = true;
			this.btnAppointmentFindCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnAppointmentFindCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnAppointmentFindCustomer.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.btnAppointmentFindCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAppointmentFindCustomer.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnAppointmentFindCustomer.FlatAppearance.BorderSize = 0;
			this.btnAppointmentFindCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnAppointmentFindCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnAppointmentFindCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAppointmentFindCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnAppointmentFindCustomer.Location = new System.Drawing.Point(246, 0);
			this.btnAppointmentFindCustomer.Name = "btnAppointmentFindCustomer";
			this.btnAppointmentFindCustomer.Size = new System.Drawing.Size(111, 30);
			this.btnAppointmentFindCustomer.TabIndex = 4;
			this.btnAppointmentFindCustomer.Text = "Find kunde";
			this.btnAppointmentFindCustomer.UseVisualStyleBackColor = false;
			// 
			// lblAppointmentCustomerName
			// 
			this.lblAppointmentCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblAppointmentCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.lblAppointmentCustomerName.Location = new System.Drawing.Point(0, 2);
			this.lblAppointmentCustomerName.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.lblAppointmentCustomerName.Name = "lblAppointmentCustomerName";
			this.lblAppointmentCustomerName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.lblAppointmentCustomerName.Size = new System.Drawing.Size(202, 30);
			this.lblAppointmentCustomerName.TabIndex = 4;
			this.lblAppointmentCustomerName.Text = "Navn";
			this.lblAppointmentCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlAppointmentCase
			// 
			this.pnlAppointmentCase.Controls.Add(this.lblAppointmentCaseNumber);
			this.pnlAppointmentCase.Controls.Add(this.btnAppointmentFindCase);
			this.pnlAppointmentCase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlAppointmentCase.Location = new System.Drawing.Point(123, 80);
			this.pnlAppointmentCase.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.pnlAppointmentCase.Name = "pnlAppointmentCase";
			this.pnlAppointmentCase.Size = new System.Drawing.Size(357, 30);
			this.pnlAppointmentCase.TabIndex = 10;
			// 
			// lblAppointmentCaseNumber
			// 
			this.lblAppointmentCaseNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblAppointmentCaseNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.lblAppointmentCaseNumber.Location = new System.Drawing.Point(0, 0);
			this.lblAppointmentCaseNumber.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.lblAppointmentCaseNumber.Name = "lblAppointmentCaseNumber";
			this.lblAppointmentCaseNumber.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.lblAppointmentCaseNumber.Size = new System.Drawing.Size(202, 30);
			this.lblAppointmentCaseNumber.TabIndex = 6;
			this.lblAppointmentCaseNumber.Text = "Nummer";
			this.lblAppointmentCaseNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnAppointmentFindCase
			// 
			this.btnAppointmentFindCase.AutoSize = true;
			this.btnAppointmentFindCase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnAppointmentFindCase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnAppointmentFindCase.Color = SmartControls.SmartColor.ColorStyle.Dark;
			this.btnAppointmentFindCase.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAppointmentFindCase.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnAppointmentFindCase.FlatAppearance.BorderSize = 0;
			this.btnAppointmentFindCase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnAppointmentFindCase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnAppointmentFindCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAppointmentFindCase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnAppointmentFindCase.Location = new System.Drawing.Point(260, 0);
			this.btnAppointmentFindCase.Name = "btnAppointmentFindCase";
			this.btnAppointmentFindCase.Size = new System.Drawing.Size(97, 30);
			this.btnAppointmentFindCase.TabIndex = 5;
			this.btnAppointmentFindCase.Text = "Find sag";
			this.btnAppointmentFindCase.UseVisualStyleBackColor = false;
			// 
			// dafAppointmentStart
			// 
			this.dafAppointmentStart.Location = new System.Drawing.Point(123, 120);
			this.dafAppointmentStart.Margin = new System.Windows.Forms.Padding(0);
			this.dafAppointmentStart.Name = "dafAppointmentStart";
			this.dafAppointmentStart.Size = new System.Drawing.Size(357, 30);
			this.dafAppointmentStart.TabIndex = 12;
			// 
			// NewAppointment
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.tlpNewAppointment);
			this.Controls.Add(this.hdrNewAppointment);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "NewAppointment";
			this.Size = new System.Drawing.Size(480, 380);
			this.tlpNewAppointment.ResumeLayout(false);
			this.tlpNewAppointment.PerformLayout();
			this.pnlAppointmentEstateAgent.ResumeLayout(false);
			this.pnlAppointmentEstateAgent.PerformLayout();
			this.pnlAppointmentCustomer.ResumeLayout(false);
			this.pnlAppointmentCustomer.PerformLayout();
			this.pnlAppointmentCase.ResumeLayout(false);
			this.pnlAppointmentCase.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private SmartControls.Header hdrNewAppointment;
        private System.Windows.Forms.TableLayoutPanel tlpNewAppointment;
        private System.Windows.Forms.Label lblAppointmentEstateAgent;
        private System.Windows.Forms.Panel pnlAppointmentEstateAgent;
        private SmartControls.SmartButton btnAppointmentFindEstateAgent;
        private System.Windows.Forms.Label lblAppointmentEstateAgentName;
        private System.Windows.Forms.Label lblAppointmentCustomer;
        private System.Windows.Forms.Panel pnlAppointmentCustomer;
        private SmartControls.SmartButton btnAppointmentFindCustomer;
        private System.Windows.Forms.Label lblAppointmentCustomerName;
        private System.Windows.Forms.Label lblAppointmentStart;
        private System.Windows.Forms.Label lblAppointmentCase;
        private System.Windows.Forms.Panel pnlAppointmentCase;
        private System.Windows.Forms.Label lblAppointmentCaseNumber;
        private SmartControls.SmartButton btnAppointmentFindCase;
        private UserControls.DateField dafAppointmentStart;
        private System.Windows.Forms.Label lblAppointmentEnd;
        private UserControls.DateField dafAppointmentEnd;
        private System.Windows.Forms.Label label1;
        private SmartControls.SmartTextBox stbAppointmentDescription;
        private System.Windows.Forms.Label lblAppointmentDescription;
        private SmartControls.SmartTextBox stbAppointmentPlace;
    }
}
