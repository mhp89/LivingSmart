using LivingSmartForms.Views;
using SmartControls;

namespace LivingSmartForms.DropIns
{
	partial class NewCaseDropIn
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
            this.pnlSubmenuHolder = new System.Windows.Forms.Panel();
            this.pnlSubmenuBorder = new System.Windows.Forms.Panel();
            this.pnlSubmenu = new System.Windows.Forms.Panel();
            this.lblNewCustomer = new System.Windows.Forms.Label();
            this.stepIndicator = new SmartControls.StepIndicator();
            this.pnlBottomControlsHolder = new System.Windows.Forms.Panel();
            this.pnlBottomControlsBorder = new System.Windows.Forms.Panel();
            this.pnlBottomControls = new System.Windows.Forms.Panel();
            this.btnPrev = new SmartControls.SmartButton();
            this.btnNext = new SmartControls.SmartButton();
            this.pnlStepHolder = new System.Windows.Forms.Panel();
			this.pnlStepHolderInner = new System.Windows.Forms.Panel();
            this.pnlSubmenuHolder.SuspendLayout();
            this.pnlSubmenu.SuspendLayout();
            this.pnlBottomControlsHolder.SuspendLayout();
            this.pnlBottomControls.SuspendLayout();
			this.pnlStepHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSubmenuHolder
            // 
            this.pnlSubmenuHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSubmenuHolder.Controls.Add(this.pnlSubmenuBorder);
            this.pnlSubmenuHolder.Controls.Add(this.pnlSubmenu);
            this.pnlSubmenuHolder.Location = new System.Drawing.Point(2, 2);
            this.pnlSubmenuHolder.Name = "pnlSubmenuHolder";
            this.pnlSubmenuHolder.Size = new System.Drawing.Size(498, 50);
            this.pnlSubmenuHolder.TabIndex = 3;
            // 
            // pnlSubmenuBorder
            // 
			this.pnlSubmenuBorder.BackColor = SmartColor.Dark;
            this.pnlSubmenuBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSubmenuBorder.Location = new System.Drawing.Point(0, 48);
            this.pnlSubmenuBorder.Name = "pnlSubmenuBorder";
            this.pnlSubmenuBorder.Size = new System.Drawing.Size(498, 2);
            this.pnlSubmenuBorder.TabIndex = 1;
            // 
            // pnlSubmenu
            // 
            this.pnlSubmenu.Controls.Add(this.lblNewCustomer);
            this.pnlSubmenu.Controls.Add(this.stepIndicator);
            this.pnlSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSubmenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSubmenu.Name = "pnlSubmenu";
            this.pnlSubmenu.Padding = new System.Windows.Forms.Padding(10, 15, 0, 0);
            this.pnlSubmenu.Size = new System.Drawing.Size(498, 50);
            this.pnlSubmenu.TabIndex = 0;
            // 
            // lblNewCustomer
            // 
            this.lblNewCustomer.AutoSize = true;
            this.lblNewCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNewCustomer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblNewCustomer.Location = new System.Drawing.Point(10, 15);
            this.lblNewCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.lblNewCustomer.Name = "lblNewCustomer";
            this.lblNewCustomer.Size = new System.Drawing.Size(57, 20);
            this.lblNewCustomer.TabIndex = 1;
            this.lblNewCustomer.Text = "Ny sag";
            this.lblNewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stepIndicator
            // 
            this.stepIndicator.CurrentStep = 0;
			this.stepIndicator.CurrentStepBorderColor = SmartColor.Dark;
            this.stepIndicator.CurrentStepFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.stepIndicator.LineCompletedColor = SmartColor.Dark;
            this.stepIndicator.LineThickness = 2;
            this.stepIndicator.LineUncompletedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.stepIndicator.LineWidth = 25;
            this.stepIndicator.Location = new System.Drawing.Point(74, 15);
            this.stepIndicator.Name = "stepIndicator";
            this.stepIndicator.Size = new System.Drawing.Size(350, 20);
			this.stepIndicator.StepCompletedBorderColor = SmartColor.Dark;
			this.stepIndicator.StepCompletedFillColor = SmartColor.Dark;
            this.stepIndicator.Steps = 6;
            this.stepIndicator.StepSize = 18;
			this.stepIndicator.StepUncompletedBorderColor = SmartColor.Dark;
			this.stepIndicator.StepUncompletedFillColor = SmartColor.Light;
            this.stepIndicator.TabIndex = 0;
            this.stepIndicator.Text = "stepIndicator1";
            // 
            // pnlBottomControlsHolder
            // 
            this.pnlBottomControlsHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBottomControlsHolder.Controls.Add(this.pnlBottomControlsBorder);
            this.pnlBottomControlsHolder.Controls.Add(this.pnlBottomControls);
			this.pnlBottomControlsHolder.Location = new System.Drawing.Point(2, 550);
            this.pnlBottomControlsHolder.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottomControlsHolder.Name = "pnlBottomControlsHolder";
            this.pnlBottomControlsHolder.Size = new System.Drawing.Size(498, 50);
            this.pnlBottomControlsHolder.TabIndex = 4;
            // 
            // pnlBottomControlsBorder
            // 
            this.pnlBottomControlsBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlBottomControlsBorder.BackColor = SmartColor.Dark;
            this.pnlBottomControlsBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBottomControlsBorder.Name = "pnlBottomControlsBorder";
            this.pnlBottomControlsBorder.Size = new System.Drawing.Size(498, 2);
            this.pnlBottomControlsBorder.TabIndex = 1;
            // 
            // pnlBottomControls
            // 
            this.pnlBottomControls.Controls.Add(this.btnPrev);
            this.pnlBottomControls.Controls.Add(this.btnNext);
            this.pnlBottomControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomControls.Location = new System.Drawing.Point(0, 0);
            this.pnlBottomControls.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottomControls.Name = "pnlBottomControls";
            this.pnlBottomControls.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.pnlBottomControls.Size = new System.Drawing.Size(498, 50);
            this.pnlBottomControls.TabIndex = 0;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.AutoSize = true;
            this.btnPrev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnPrev.BackColor = SmartColor.Dark;
            this.btnPrev.Color = SmartControls.SmartColor.ColorStyle.Dark;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.FlatAppearance.BorderSize = 0;
			this.btnPrev.FlatAppearance.MouseDownBackColor = SmartColor.Light;
			this.btnPrev.FlatAppearance.MouseOverBackColor = SmartColor.Light;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrev.ForeColor = SmartColor.Light;
            this.btnPrev.Location = new System.Drawing.Point(17, 10);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(20, 10, 0, 10);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(90, 30);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "Forrige";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.AutoSize = true;
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnNext.BackColor = SmartColor.Dark;
            this.btnNext.Color = SmartControls.SmartColor.ColorStyle.Dark;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
			this.btnNext.FlatAppearance.MouseDownBackColor = SmartColor.Light;
			this.btnNext.FlatAppearance.MouseOverBackColor = SmartColor.Light;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNext.ForeColor = SmartColor.Light;
            this.btnNext.Location = new System.Drawing.Point(392, 10);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0, 10, 20, 10);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(86, 30);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Næste";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pnlStepHolder
            // 
            this.pnlStepHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStepHolder.AutoScroll = true;
			this.pnlStepHolder.Controls.Add(this.pnlStepHolderInner);
			this.pnlStepHolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.pnlStepHolder.Location = new System.Drawing.Point(2, 50);
            this.pnlStepHolder.Margin = new System.Windows.Forms.Padding(0);
            this.pnlStepHolder.Name = "pnlStepHolder";
			this.pnlStepHolder.Padding = new System.Windows.Forms.Padding(10);
			this.pnlStepHolder.Size = new System.Drawing.Size(498, 508);
            this.pnlStepHolder.TabIndex = 1;
            // 
			// pnlStepHolderInner
			// 
			this.pnlStepHolderInner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlStepHolderInner.AutoScroll = true;
			this.pnlStepHolderInner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.pnlStepHolderInner.Location = new System.Drawing.Point(10, 10);
			this.pnlStepHolderInner.Margin = new System.Windows.Forms.Padding(10);
			this.pnlStepHolderInner.Name = "pnlStepHolderInner";
			this.pnlStepHolderInner.Size = new System.Drawing.Size(478, 485);
			this.pnlStepHolderInner.TabIndex = 2;
			this.pnlStepHolderInner.SizeChanged += new System.EventHandler(this.pnlStepHolderInner_SizeChanged);
			// 
            // NewCaseDropIn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnlBottomControlsHolder);
            this.Controls.Add(this.pnlSubmenuHolder);
            this.Controls.Add(this.pnlStepHolder);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NewCaseDropIn";
			this.Size = new System.Drawing.Size(500, 600);
            this.pnlSubmenuHolder.ResumeLayout(false);
            this.pnlSubmenu.ResumeLayout(false);
            this.pnlSubmenu.PerformLayout();
            this.pnlBottomControlsHolder.ResumeLayout(false);
            this.pnlBottomControls.ResumeLayout(false);
            this.pnlBottomControls.PerformLayout();
			this.pnlStepHolder.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlSubmenuHolder;
		private System.Windows.Forms.Panel pnlSubmenuBorder;
		private System.Windows.Forms.Panel pnlSubmenu;
		private SmartControls.StepIndicator stepIndicator;
		private System.Windows.Forms.Panel pnlBottomControlsHolder;
		private System.Windows.Forms.Panel pnlBottomControlsBorder;
		private System.Windows.Forms.Panel pnlBottomControls;
		private SmartControls.SmartButton btnPrev;
		private SmartControls.SmartButton btnNext;
		private System.Windows.Forms.Panel pnlStepHolder;
		private System.Windows.Forms.Panel pnlStepHolderInner;

	}
}
