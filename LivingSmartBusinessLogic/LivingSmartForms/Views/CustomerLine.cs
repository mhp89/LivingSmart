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
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.DropIns;

namespace LivingSmartForms.Views
{
    public partial class CustomerLine : UserControl
    {
	    private Customer customer;
        private BaseForm baseForm;

        public CustomerLine(BaseForm baseForm, Customer customer)
        {
	        this.customer = customer;
            this.baseForm = baseForm;

            InitializeComponent();

	        UpdateFields();
        }

	    private void UpdateFields()
	    {
		    slbCustomerNo.Text = customer.Id.ToString();
		    slbCustomer.Text = customer.Name;
		    slbCustomerAddress.Text = customer.Address;
		    slbCustomerZipcode.Text = customer.City.ZipCode + " " + customer.City.District;
		    slbCustomerPhone.Text = customer.Telephone;
		    slbCustomerEmail.Text = customer.Email;
		    slbCustomerBirthday.Text = customer.DateOfBirth.ToShortDateString();
	    }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            baseForm.ShowDropIn(new NewCustomerDropIn(baseForm, customer));
        }
    }
}
