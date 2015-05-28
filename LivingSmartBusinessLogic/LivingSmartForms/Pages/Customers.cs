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
using LivingSmartForms.DropIns;
using LivingSmartForms.Views;

namespace LivingSmartForms.Pages
{
	public partial class Customers : BasePage
	{
        public Customers(BaseForm baseForm) : base(baseForm)
		{
			InitializeComponent();


			//CustomerController.Instance.
			for (int i = 0; i < 10; i++)
			{
				var control = new CustomerLine();
				control.Margin = Padding.Empty;
				clsCustomers.AddControl(control);
			}
		}

		private void btnNewCustomer_Click(object sender, EventArgs e)
		{
			baseForm.ShowDropIn(new NewCustomerDropIn(baseForm));
		}
	}
}
