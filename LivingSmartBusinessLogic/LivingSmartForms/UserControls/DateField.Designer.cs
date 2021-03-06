using SmartControls;

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
			this.stbDateYear = new SmartControls.SmartTextBox();
			this.lblHyphenDateMonthYear = new System.Windows.Forms.Label();
			this.stbDateDay = new SmartControls.SmartTextBox();
			this.lblHyphenDateDayMonth = new System.Windows.Forms.Label();
			this.stbDateMonth = new SmartControls.SmartTextBox();
			this.SuspendLayout();
			// 
			// stbDateYear
			// 
			this.stbDateYear.AllowComma = false;
			this.stbDateYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbDateYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbDateYear.AutomaticValidation = true;
			this.stbDateYear.BackColor = SmartColor.Light;
			this.stbDateYear.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbDateYear.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbDateYear.ForeColor = SmartColor.Dark;
			this.stbDateYear.Location = new System.Drawing.Point(145, 0);
			this.stbDateYear.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbDateYear.MaxLength = 4;
			this.stbDateYear.MinLength = 4;
			this.stbDateYear.Name = "stbDateYear";
			this.stbDateYear.NumericOnly = true;
			this.stbDateYear.Placeholder = "YYYY";
			this.stbDateYear.RegularExpression = null;
			this.stbDateYear.Required = true;
			this.stbDateYear.Size = new System.Drawing.Size(65, 30);
			this.stbDateYear.Suffix = null;
			this.stbDateYear.TabIndex = 2;
			this.stbDateYear.UseSystemPasswordChar = false;
			// 
			// lblHyphenDateMonthYear
			// 
			this.lblHyphenDateMonthYear.AutoSize = true;
			this.lblHyphenDateMonthYear.Location = new System.Drawing.Point(130, 7);
			this.lblHyphenDateMonthYear.Margin = new System.Windows.Forms.Padding(5);
			this.lblHyphenDateMonthYear.Name = "lblHyphenDateMonthYear";
			this.lblHyphenDateMonthYear.Size = new System.Drawing.Size(10, 13);
			this.lblHyphenDateMonthYear.TabIndex = 24;
			this.lblHyphenDateMonthYear.Text = "-";
			// 
			// stbDateDay
			// 
			this.stbDateDay.AllowComma = false;
			this.stbDateDay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbDateDay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbDateDay.AutomaticValidation = true;
			this.stbDateDay.BackColor = SmartColor.Light;
			this.stbDateDay.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbDateDay.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbDateDay.ForeColor = SmartColor.Dark;
			this.stbDateDay.Location = new System.Drawing.Point(0, 0);
			this.stbDateDay.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbDateDay.MaxLength = 2;
			this.stbDateDay.MinLength = -1;
			this.stbDateDay.Name = "stbDateDay";
			this.stbDateDay.NumericOnly = true;
			this.stbDateDay.Placeholder = "DD";
			this.stbDateDay.RegularExpression = null;
			this.stbDateDay.Required = true;
			this.stbDateDay.Size = new System.Drawing.Size(50, 30);
			this.stbDateDay.Suffix = null;
			this.stbDateDay.TabIndex = 0;
			this.stbDateDay.UseSystemPasswordChar = false;
			// 
			// lblHyphenDateDayMonth
			// 
			this.lblHyphenDateDayMonth.AutoSize = true;
			this.lblHyphenDateDayMonth.Location = new System.Drawing.Point(55, 7);
			this.lblHyphenDateDayMonth.Margin = new System.Windows.Forms.Padding(5);
			this.lblHyphenDateDayMonth.Name = "lblHyphenDateDayMonth";
			this.lblHyphenDateDayMonth.Size = new System.Drawing.Size(10, 13);
			this.lblHyphenDateDayMonth.TabIndex = 23;
			this.lblHyphenDateDayMonth.Text = "-";
			// 
			// stbDateMonth
			// 
			this.stbDateMonth.AllowComma = false;
			this.stbDateMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.stbDateMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.stbDateMonth.AutomaticValidation = true;
			this.stbDateMonth.BackColor = SmartColor.Light;
			this.stbDateMonth.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.stbDateMonth.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.stbDateMonth.ForeColor = SmartColor.Dark;
			this.stbDateMonth.Location = new System.Drawing.Point(70, 0);
			this.stbDateMonth.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.stbDateMonth.MaxLength = 2;
			this.stbDateMonth.MinLength = -1;
			this.stbDateMonth.Name = "stbDateMonth";
			this.stbDateMonth.NumericOnly = true;
			this.stbDateMonth.Placeholder = "MM";
			this.stbDateMonth.RegularExpression = null;
			this.stbDateMonth.Required = true;
			this.stbDateMonth.Size = new System.Drawing.Size(55, 30);
			this.stbDateMonth.Suffix = null;
			this.stbDateMonth.TabIndex = 1;
			this.stbDateMonth.UseSystemPasswordChar = false;
			// 
			// DateField
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.stbDateYear);
			this.Controls.Add(this.lblHyphenDateMonthYear);
			this.Controls.Add(this.stbDateDay);
			this.Controls.Add(this.lblHyphenDateDayMonth);
			this.Controls.Add(this.stbDateMonth);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "DateField";
			this.Size = new System.Drawing.Size(210, 30);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private SmartControls.SmartTextBox stbDateYear;
		private System.Windows.Forms.Label lblHyphenDateMonthYear;
		private SmartControls.SmartTextBox stbDateDay;
		private System.Windows.Forms.Label lblHyphenDateDayMonth;
		private SmartControls.SmartTextBox stbDateMonth;


	}
}
