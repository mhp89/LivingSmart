using SmartControls;

namespace LivingSmartForms.Views
{
    partial class CaseLineSimple
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
            this.tlpCaseLine = new System.Windows.Forms.TableLayoutPanel();
            this.slbCaseNo = new SmartControls.SmartLabel();
            this.slbSeller = new SmartControls.SmartLabel();
            this.slbStatus = new SmartControls.SmartLabel();
            this.slbProperty = new SmartControls.SmartLabel();
            this.slbPropertyType = new SmartControls.SmartLabel();
            this.slbPrice = new SmartControls.SmartLabel();
            this.slbPriceTrend = new SmartControls.SmartLabel();
            this.btnViewCase = new SmartControls.SmartButton();
            this.tlpCaseLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpCaseLine
            // 
            this.tlpCaseLine.ColumnCount = 5;
            this.tlpCaseLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.11499F));
            this.tlpCaseLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.79261F));
            this.tlpCaseLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.32649F));
            this.tlpCaseLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.76591F));
            this.tlpCaseLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCaseLine.Controls.Add(this.slbCaseNo, 0, 0);
            this.tlpCaseLine.Controls.Add(this.slbSeller, 1, 0);
            this.tlpCaseLine.Controls.Add(this.slbStatus, 1, 1);
            this.tlpCaseLine.Controls.Add(this.slbProperty, 2, 0);
            this.tlpCaseLine.Controls.Add(this.slbPropertyType, 2, 1);
            this.tlpCaseLine.Controls.Add(this.slbPrice, 3, 0);
            this.tlpCaseLine.Controls.Add(this.slbPriceTrend, 3, 1);
            this.tlpCaseLine.Controls.Add(this.btnViewCase, 4, 0);
            this.tlpCaseLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCaseLine.Location = new System.Drawing.Point(0, 0);
            this.tlpCaseLine.Margin = new System.Windows.Forms.Padding(2);
            this.tlpCaseLine.Name = "tlpCaseLine";
            this.tlpCaseLine.RowCount = 2;
            this.tlpCaseLine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCaseLine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCaseLine.Size = new System.Drawing.Size(1095, 50);
            this.tlpCaseLine.TabIndex = 0;
            // 
            // slbCaseNo
            // 
            this.slbCaseNo.AutoSize = true;
            this.slbCaseNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slbCaseNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.slbCaseNo.Location = new System.Drawing.Point(0, 0);
            this.slbCaseNo.Name = "slbCaseNo";
            this.tlpCaseLine.SetRowSpan(this.slbCaseNo, 2);
            this.slbCaseNo.Size = new System.Drawing.Size(118, 50);
            this.slbCaseNo.TabIndex = 2;
            this.slbCaseNo.Text = "xxxx";
            this.slbCaseNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slbCaseNo.Title = "Sag #";
            this.slbCaseNo.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            // 
            // slbSeller
            // 
            this.slbSeller.AutoSize = true;
            this.slbSeller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slbSeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.slbSeller.Location = new System.Drawing.Point(118, 0);
            this.slbSeller.Name = "slbSeller";
            this.slbSeller.Size = new System.Drawing.Size(222, 25);
            this.slbSeller.TabIndex = 3;
            this.slbSeller.Text = "Navn på sælger";
            this.slbSeller.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slbSeller.Title = "Sælger:";
            this.slbSeller.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            // 
            // slbStatus
            // 
            this.slbStatus.AutoSize = true;
            this.slbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.slbStatus.Location = new System.Drawing.Point(118, 25);
            this.slbStatus.Name = "slbStatus";
            this.slbStatus.Size = new System.Drawing.Size(222, 25);
            this.slbStatus.TabIndex = 4;
            this.slbStatus.Text = "Status på salg";
            this.slbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slbStatus.Title = "Status:";
            this.slbStatus.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            // 
            // slbProperty
            // 
            this.slbProperty.AutoSize = true;
            this.slbProperty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slbProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.slbProperty.Location = new System.Drawing.Point(340, 0);
            this.slbProperty.Name = "slbProperty";
            this.slbProperty.Size = new System.Drawing.Size(422, 25);
            this.slbProperty.TabIndex = 5;
            this.slbProperty.Text = "Adressen";
            this.slbProperty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slbProperty.Title = "Ejendom:";
            this.slbProperty.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            // 
            // slbPropertyType
            // 
            this.slbPropertyType.AutoSize = true;
            this.slbPropertyType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slbPropertyType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.slbPropertyType.Location = new System.Drawing.Point(340, 25);
            this.slbPropertyType.Name = "slbPropertyType";
            this.slbPropertyType.Size = new System.Drawing.Size(422, 25);
            this.slbPropertyType.TabIndex = 6;
            this.slbPropertyType.Text = "Ejerlejlighed";
            this.slbPropertyType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slbPropertyType.Title = "Ejendsomstype:";
            this.slbPropertyType.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            // 
            // slbPrice
            // 
            this.slbPrice.AutoSize = true;
            this.slbPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.slbPrice.Location = new System.Drawing.Point(762, 0);
            this.slbPrice.Name = "slbPrice";
            this.slbPrice.Size = new System.Drawing.Size(212, 25);
            this.slbPrice.TabIndex = 7;
            this.slbPrice.Text = "x.xxx.xxx";
            this.slbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slbPrice.Title = "Udbudspris:";
            this.slbPrice.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            // 
            // slbPriceTrend
            // 
            this.slbPriceTrend.AutoSize = true;
            this.slbPriceTrend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slbPriceTrend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.slbPriceTrend.Location = new System.Drawing.Point(762, 25);
            this.slbPriceTrend.Name = "slbPriceTrend";
            this.slbPriceTrend.Size = new System.Drawing.Size(212, 25);
            this.slbPriceTrend.TabIndex = 8;
            this.slbPriceTrend.Text = "-5%";
            this.slbPriceTrend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slbPriceTrend.Title = "Prisudvikling:";
            this.slbPriceTrend.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            // 
            // btnViewCase
            // 
            this.btnViewCase.AutoSize = true;
            this.btnViewCase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewCase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnViewCase.Color = SmartControls.SmartColor.ColorStyle.Light;
            this.btnViewCase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewCase.FlatAppearance.BorderSize = 0;
            this.btnViewCase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnViewCase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnViewCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnViewCase.Location = new System.Drawing.Point(984, 10);
            this.btnViewCase.Margin = new System.Windows.Forms.Padding(10);
            this.btnViewCase.Name = "btnViewCase";
            this.tlpCaseLine.SetRowSpan(this.btnViewCase, 2);
            this.btnViewCase.Size = new System.Drawing.Size(101, 30);
            this.btnViewCase.TabIndex = 9;
            this.btnViewCase.Text = "Se sag";
            this.btnViewCase.UseVisualStyleBackColor = false;
            // 
            // CaseLineSimple
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tlpCaseLine);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CaseLineSimple";
            this.Size = new System.Drawing.Size(1095, 50);
            this.tlpCaseLine.ResumeLayout(false);
            this.tlpCaseLine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.TableLayoutPanel tlpCaseLine;
        private SmartControls.SmartLabel slbCaseNo;
        private SmartControls.SmartLabel slbSeller;
        private SmartControls.SmartLabel slbStatus;
        private SmartControls.SmartLabel slbProperty;
        private SmartControls.SmartLabel slbPropertyType;
        private SmartControls.SmartLabel slbPrice;
        private SmartControls.SmartLabel slbPriceTrend;
		private SmartControls.SmartButton btnViewCase;
    }
}
