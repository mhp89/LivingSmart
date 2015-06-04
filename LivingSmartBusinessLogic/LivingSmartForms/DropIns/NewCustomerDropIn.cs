using System;
using System.Drawing;
using System.Windows.Forms;
using LivingSmartBusinessLogic.Controller;
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.Classes;
using LivingSmartForms.Views;

namespace LivingSmartForms.DropIns
{
	public partial class NewCustomerDropIn : BaseDropIn
	{
		private NewCustomer newCustomerForm;

		private NewCustomerFinish callback;
		public delegate void NewCustomerFinish(Customer customer);

		public NewCustomerDropIn(BaseForm baseForm, Customer customer, NewCustomerFinish callback=null) : base(baseForm)
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

        private void FinishCreating(Customer customer)
		{
			CustomerController.Instance.CancelActiveCustomer();
			if(customer != null && callback != null)
				callback(customer);
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			FinishCreating(null);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
            if (newCustomerForm.Save())
			{
				//Customer saved
				FinishCreating(newCustomerForm.CreatedUser);
			}
		}
	}
}
