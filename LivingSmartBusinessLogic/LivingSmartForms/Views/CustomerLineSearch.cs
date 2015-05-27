using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivingSmartBusinessLogic;
using LivingSmartForms.DropIns;

namespace LivingSmartForms.Views
{
    public partial class CustomerLineSearch : UserControl
    {
	    private CustomerSearchDropIn dropIn { get; set; }
	    public Customer Customer { get; private set; }

        public CustomerLineSearch(CustomerSearchDropIn dropIn, Customer customer)
        {
	        this.dropIn = dropIn;
	        this.Customer = customer;

            InitializeComponent();

			UpdateFields();

			Click += Select;
			BindEvent(this);
        }

	    private void BindEvent(Control parent)
		{
		    foreach (Control control in parent.Controls)
		    {
				control.Click += Select;
				BindEvent(control);
		    }
		}

	    private void UpdateFields()
	    {
		    slbCustomerNo.Text = Customer.Id.ToString();
		    slbCustomer.Text = Customer.Name;
		    slbCustomerPhone.Text = Customer.Telephone;
	    }

	    private void Select(object sender, EventArgs e)
	    {
		    dropIn.SelectCustomer(this);
	    }
    }
}
