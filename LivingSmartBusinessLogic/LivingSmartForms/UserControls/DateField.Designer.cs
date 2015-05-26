namespace LivingSmartForms.UserControls
{
    partial class DateField
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
            this.pnlDate = new System.Windows.Forms.Panel();
            this.lblDateFormat = new System.Windows.Forms.Label();
            this.lblHyphenDateMonthYear = new System.Windows.Forms.Label();
            this.lblHyphenDateDayMonth = new System.Windows.Forms.Label();
            this.stbDateYear = new SmartControls.SmartTextBox();
            this.stbDateDay = new SmartControls.SmartTextBox();
            this.stbDateMonth = new SmartControls.SmartTextBox();
            this.pnlDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDate
            // 
            this.pnlDate.Controls.Add(this.lblDateFormat);
            this.pnlDate.Controls.Add(this.lblHyphenDateMonthYear);
            this.pnlDate.Controls.Add(this.lblHyphenDateDayMonth);
            this.pnlDate.Controls.Add(this.stbDateYear);
            this.pnlDate.Controls.Add(this.stbDateDay);
            this.pnlDate.Controls.Add(this.stbDateMonth);
            this.pnlDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDate.Location = new System.Drawing.Point(0, 0);
            this.pnlDate.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(364, 30);
            this.pnlDate.TabIndex = 18;
            // 
            // lblDateFormat
            // 
            this.lblDateFormat.AutoSize = true;
            this.lblDateFormat.Location = new System.Drawing.Point(198, 7);
            this.lblDateFormat.Margin = new System.Windows.Forms.Padding(0);
            this.lblDateFormat.Name = "lblDateFormat";
            this.lblDateFormat.Size = new System.Drawing.Size(162, 17);
            this.lblDateFormat.TabIndex = 20;
            this.lblDateFormat.Text = "Datoformat: dd-mm-yyyy";
            // 
            // lblHyphenDateMonthYear
            // 
            this.lblHyphenDateMonthYear.AutoSize = true;
            this.lblHyphenDateMonthYear.Location = new System.Drawing.Point(111, 7);
            this.lblHyphenDateMonthYear.Name = "lblHyphenDateMonthYear";
            this.lblHyphenDateMonthYear.Size = new System.Drawing.Size(13, 17);
            this.lblHyphenDateMonthYear.TabIndex = 19;
            this.lblHyphenDateMonthYear.Text = "-";
            // 
            // lblHyphenDateDayMonth
            // 
            this.lblHyphenDateDayMonth.AutoSize = true;
            this.lblHyphenDateDayMonth.Location = new System.Drawing.Point(48, 7);
            this.lblHyphenDateDayMonth.Name = "lblHyphenDateDayMonth";
            this.lblHyphenDateDayMonth.Size = new System.Drawing.Size(13, 17);
            this.lblHyphenDateDayMonth.TabIndex = 18;
            this.lblHyphenDateDayMonth.Text = "-";
            // 
            // stbDateYear
            // 
            this.stbDateYear.AllowComma = false;
            this.stbDateYear.AutomaticValidation = true;
            this.stbDateYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stbDateYear.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.stbDateYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stbDateYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.stbDateYear.Location = new System.Drawing.Point(126, 0);
            this.stbDateYear.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.stbDateYear.MaxLength = 4;
            this.stbDateYear.MinLength = 4;
            this.stbDateYear.Name = "stbDateYear";
            this.stbDateYear.NumericOnly = true;
            this.stbDateYear.Placeholder = "yyyy";
            this.stbDateYear.RegularExpression = null;
            this.stbDateYear.Size = new System.Drawing.Size(62, 30);
            this.stbDateYear.Suffix = null;
            this.stbDateYear.TabIndex = 17;
            this.stbDateYear.UseSystemPasswordChar = false;
            // 
            // stbDateDay
            // 
            this.stbDateDay.AllowComma = false;
            this.stbDateDay.AutomaticValidation = true;
            this.stbDateDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stbDateDay.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.stbDateDay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stbDateDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.stbDateDay.Location = new System.Drawing.Point(0, 0);
            this.stbDateDay.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.stbDateDay.MaxLength = 2;
            this.stbDateDay.MinLength = 1;
            this.stbDateDay.Name = "stbDateDay";
            this.stbDateDay.NumericOnly = true;
            this.stbDateDay.Placeholder = "dd";
            this.stbDateDay.RegularExpression = null;
            this.stbDateDay.Size = new System.Drawing.Size(45, 30);
            this.stbDateDay.Suffix = null;
            this.stbDateDay.TabIndex = 15;
            this.stbDateDay.UseSystemPasswordChar = false;
            // 
            // stbDateMonth
            // 
            this.stbDateMonth.AllowComma = false;
            this.stbDateMonth.AutomaticValidation = true;
            this.stbDateMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stbDateMonth.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.stbDateMonth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stbDateMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.stbDateMonth.Location = new System.Drawing.Point(63, 0);
            this.stbDateMonth.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.stbDateMonth.MaxLength = 2;
            this.stbDateMonth.MinLength = 1;
            this.stbDateMonth.Name = "stbDateMonth";
            this.stbDateMonth.NumericOnly = true;
            this.stbDateMonth.Placeholder = "mm";
            this.stbDateMonth.RegularExpression = null;
            this.stbDateMonth.Size = new System.Drawing.Size(45, 30);
            this.stbDateMonth.Suffix = null;
            this.stbDateMonth.TabIndex = 16;
            this.stbDateMonth.UseSystemPasswordChar = false;
            // 
            // DateField
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnlDate);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DateField";
            this.Size = new System.Drawing.Size(364, 30);
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.Label lblDateFormat;
        private System.Windows.Forms.Label lblHyphenDateMonthYear;
        private System.Windows.Forms.Label lblHyphenDateDayMonth;
        private SmartControls.SmartTextBox stbDateYear;
        private SmartControls.SmartTextBox stbDateDay;
        private SmartControls.SmartTextBox stbDateMonth;
    }
}
