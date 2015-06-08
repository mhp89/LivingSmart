using System;
using System.Drawing;
using System.Windows.Forms;
using LivingSmartBusinessLogic.Controller;
using LivingSmartBusinessLogic.Entity;
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.Classes;
using LivingSmartForms.Views;

namespace LivingSmartForms.DropIns
{
	/// <summary>
	/// DropIn til oprettelse af ny kunde. Håndterer form til indtastning
	/// </summary>
	/// <author>Mathias Petersen</author>
	public partial class NewCustomerDropIn : BaseDropIn
	{
		private NewCustomer newCustomerForm;

		private CustomerFinish callback;
		public delegate void CustomerFinish(Customer customer);

		public NewCustomerDropIn(BaseForm baseForm, Customer customer, CustomerFinish callback=null) : base(baseForm)
		{
			InitializeComponent();
			this.callback = callback;
		    if (customer != null)
		    {
		        btnSave.Text = "Gem";
		        lblNewCustomer.Text = "Redigér kunde";
		    }

		    newCustomerForm = new NewCustomer(baseForm, customer);
			newCustomerForm.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
			newCustomerForm.Location = new Point(10, 10);
			pnlContentHolder.Controls.Add(newCustomerForm);
		}
		
        public override string GetDropInId()
		{
			return "NewCustomer";
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
            if (newCustomerForm.Save())
            {
                var customer = newCustomerForm.CurrentCustomer;
                CustomerController.Instance.CancelActiveCustomer();
                if (customer != null && callback != null)
                    callback(customer);
                Close();
			}
		}
	}
}
