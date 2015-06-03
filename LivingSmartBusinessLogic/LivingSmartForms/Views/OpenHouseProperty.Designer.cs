namespace LivingSmartForms.Views
{
    partial class OpenHouseProperty
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
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblAddress
            // 
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lblAddress.Location = new System.Drawing.Point(0, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(150, 25);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblZipCode
            // 
            this.lblZipCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblZipCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lblZipCode.Location = new System.Drawing.Point(0, 25);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(150, 25);
            this.lblZipCode.TabIndex = 1;
            this.lblZipCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pnlLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLine.Location = new System.Drawing.Point(0, 55);
            this.pnlLine.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(150, 1);
            this.pnlLine.TabIndex = 9;
            // 
            // OpenHouseProperty
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnlLine);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.lblAddress);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OpenHouseProperty";
            this.Size = new System.Drawing.Size(150, 56);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Panel pnlLine;
    }
}
