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
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.Classes;

namespace LivingSmartForms.Views
{
	public partial class NewCustomer : UserControl
    {
		public Customer CreatedUser { get; private set; }

        public NewCustomer(BaseForm baseForm)
        {
            InitializeComponent();
        }

		public bool Save()
		{
			bool fielddataOk = ValidateFields();
			if (fielddataOk)
			{
				CreatedUser = CustomerController.Instance.MakeNewCustomer(stbCustomerName.Text,
					(DateTime) dafCustomerBirthday.GetDateTime(),
					stbCustomerAddress.Text,
					Convert.ToInt32(stbCustomerZipCode.Text),
					stbCustomerEmail.Text,
					stbCustomerPhone.Text);
				CustomerController.Instance.SaveActiveCustomer();

				if (CreatedUser.Id == -1)
				{
					MessageBox.Show("Tilykke, du fandt en fejl!");
					fielddataOk = false;
				}
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
			GeneralValidation.ZipCodeValidation(stbCustomerZipCode, lblCustomerCityCountry);
		}
    }
}
