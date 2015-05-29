using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
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
		}

		private void UpdateList()
		{
			clsCustomers.SuspendLayout();

			clsCustomers.ClearList();
			var customers = CustomerController.Instance.GetCustomers();
			foreach (var customer in customers)
			{
				var control = new CustomerLine(baseForm, customer);
				control.Margin = Padding.Empty;
				clsCustomers.AddControl(control, true);
			}
			sblCustomers.Text = customers.Count.ToString();

			clsCustomers.ResumeLayout();
		}

		public override void OnShow()
		{
			UpdateList();
		}

		private void btnNewCustomer_Click(object sender, EventArgs e)
		{
			baseForm.ShowDropIn(new NewCustomerDropIn(baseForm));
		}
	}
}
