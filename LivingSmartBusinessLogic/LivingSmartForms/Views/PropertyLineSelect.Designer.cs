namespace LivingSmartForms.Views
{
    partial class PropertyLineSelect
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
            this.tlpProperty = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.slbPropertyAddress = new SmartControls.SmartLabel();
            this.tlpProperty.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpProperty
            // 
            this.tlpProperty.ColumnCount = 1;
            this.tlpProperty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProperty.Controls.Add(this.slbPropertyAddress, 0, 0);
            this.tlpProperty.Controls.Add(this.pnlLine, 0, 1);
            this.tlpProperty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProperty.Location = new System.Drawing.Point(0, 0);
            this.tlpProperty.Margin = new System.Windows.Forms.Padding(2);
            this.tlpProperty.Name = "tlpProperty";
            this.tlpProperty.RowCount = 2;
            this.tlpProperty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProperty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tlpProperty.Size = new System.Drawing.Size(450, 30);
            this.tlpProperty.TabIndex = 1;
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.tlpProperty.SetColumnSpan(this.pnlLine, 2);
            this.pnlLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLine.Location = new System.Drawing.Point(0, 29);
            this.pnlLine.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(450, 1);
            this.pnlLine.TabIndex = 8;
            // 
            // slbPropertyAddress
            // 
            this.slbPropertyAddress.AutoSize = true;
            this.slbPropertyAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slbPropertyAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.slbPropertyAddress.Location = new System.Drawing.Point(0, 0);
            this.slbPropertyAddress.Name = "slbPropertyAddress";
            this.slbPropertyAddress.Size = new System.Drawing.Size(450, 24);
            this.slbPropertyAddress.TabIndex = 2;
            this.slbPropertyAddress.Text = "Kronprinsessegade 78, 1100 København";
            this.slbPropertyAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slbPropertyAddress.Title = "Adresse:";
            this.slbPropertyAddress.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            // 
            // PropertyLineSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpProperty);
            this.Name = "PropertyLineSearch";
            this.Size = new System.Drawing.Size(450, 30);
            this.tlpProperty.ResumeLayout(false);
            this.tlpProperty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpProperty;
        private System.Windows.Forms.Panel pnlLine;
        private SmartControls.SmartLabel slbPropertyAddress;

    }
}
