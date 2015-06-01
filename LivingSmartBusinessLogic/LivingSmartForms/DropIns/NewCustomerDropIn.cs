using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivingSmartBusinessLogic.Controller;
using LivingSmartForms.Classes;
using LivingSmartForms.Views;

namespace LivingSmartForms.DropIns
{
	public partial class NewCustomerDropIn : BaseDropIn
	{
		private NewCustomer newCustomerForm;

		public NewCustomerDropIn(BaseForm baseForm) : base(baseForm)
		{
			InitializeComponent();

			newCustomerForm = new NewCustomer(baseForm);
			newCustomerForm.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
			newCustomerForm.Location = new Point(10, 10);
			pnlContentHolder.Controls.Add(newCustomerForm);
		}
		public override string GetDropInId()
		{
			return "NewCustomer";
		}

		protected override void Close()
		{
			CustomerController.Instance.CancelActiveCustomer();
			base.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (newCustomerForm.Save())
			{
				//Customer saved
				Close();
			}
		}
	}
}
