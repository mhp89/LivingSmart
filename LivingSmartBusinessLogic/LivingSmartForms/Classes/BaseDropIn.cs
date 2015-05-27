using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivingSmartForms.Classes
{
	public partial class BaseDropIn : UserControl
	{
		protected BaseForm baseForm;
		public BaseDropIn(BaseForm baseForm)
		{
			this.baseForm = baseForm;
			AutoScaleMode = AutoScaleMode.None;

			InitializeComponent();

			Load += BaseDropIn_Load;
		}

		void BaseDropIn_Load(object sender, EventArgs e)
		{
			btnClose.BringToFront();
			btnClose.Location = new Point(Width - btnClose.Width - 10, 10);
		}

		protected void HideCloseButton()
		{
			btnClose.Visible = false;
		}

		private BaseDropIn() { }

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		protected virtual void Close()
		{
			baseForm.CloseDropIn();
		}
	}
}
