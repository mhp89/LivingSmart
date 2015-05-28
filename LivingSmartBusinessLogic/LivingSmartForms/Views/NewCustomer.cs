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
using LivingSmartBusinessLogic.Controller;
using LivingSmartForms.Classes;

namespace LivingSmartForms.Views
{
	public partial class NewCustomer : UserControl
    {
        public NewCustomer(BaseForm baseForm)
        {
            InitializeComponent();
        }

		public bool Save()
		{
			bool fielddataOk = ValidateFields();
			if (fielddataOk)
			{
				var customer = CustomerController.Instance.MakeNewCustomer();
				CustomerController.Instance.SetName(customer, stbCustomerName.Text);
				CustomerController.Instance.SetAddress(customer, stbCustomerAddress.Text);
				CustomerController.Instance.SetCity(customer, Convert.ToInt32(stbCustomerZipCode.Text));
				CustomerController.Instance.SetTelephone(customer, stbCustomerPhone.Text);
				CustomerController.Instance.SetEmail(customer, stbCustomerEmail.Text);
				CustomerController.Instance.SetDateOfBirth(customer, (DateTime) dafCustomerBirthday.GetDateTime());
				CustomerController.Instance.AddCustomer(customer);
			}
			return fielddataOk;
		}

		private bool ValidateFields()
		{
			bool fielddataOk = true;

			fielddataOk &= stbCustomerName.Validate();
			fielddataOk &= stbCustomerAddress.Validate();
			fielddataOk &= stbCustomerZipCode.Validate();
			fielddataOk &= stbCustomerPhone.Validate();
			fielddataOk &= stbCustomerEmail.Validate();
			fielddataOk &= dafCustomerBirthday.Validate();

			return fielddataOk;
		}

		private void stbCustomerZipCode_TextChanged(object sender, EventArgs e)
		{
			City city = null;

			if (!string.IsNullOrEmpty(stbCustomerZipCode.Text))
			{
				int zipCode = Convert.ToInt32(stbCustomerZipCode.Text);
				city = CityController.Instance.GetCity(zipCode);
			}

			lblCustomerCityCountry.Text = city != null ? city.District : "";
		}
    }
}
