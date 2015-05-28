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
using LivingSmartForms.DropIns;

namespace LivingSmartForms.Views
{
    public partial class NewCaseStepSeller : CaseStep
    {
	    private BaseForm baseForm;

	    private bool newCustomer = true;
	    private Customer existingCustomer;
	    private EstateAgent estateAgent;

        public NewCaseStepSeller(BaseForm baseForm)
        {
	        this.baseForm = baseForm;
			
            InitializeComponent();

			UpdateEstateAgent(baseForm.DefaultEstateAgent);
        }

	    public override bool Save()
		{
			bool fielddataOk = ValidateFields();
			if (fielddataOk)
			{
				Customer customer;
				if (newCustomer)
				{
					customer = CustomerController.Instance.MakeNewCustomer();
					CustomerController.Instance.SetName(customer, stbSellerName.Text);
					CustomerController.Instance.SetAddress(customer, stbSellerAdress.Text);
					CustomerController.Instance.SetCity(customer, Convert.ToInt32(stbSellerZipCode.Text));
					CustomerController.Instance.SetTelephone(customer, stbSellerPhone.Text);
					CustomerController.Instance.SetEmail(customer, stbSellerEmail.Text);
					CustomerController.Instance.SaveActiveCustomer();
				}
				else
				{
					customer = existingCustomer;
				}

				CaseController.Instance.SetEstateAgent(estateAgent);
				CaseController.Instance.SetSeller(customer);
			}
			return fielddataOk;
	    }

        private bool ValidateFields()
		{
			bool fielddataOk = true;
			//fielddataOk &= stbEstateAgentName.Validate();

			fielddataOk &= stbSellerName.Validate();
			fielddataOk &= stbSellerAdress.Validate();
			fielddataOk &= stbSellerZipCode.Validate();
			fielddataOk &= stbSellerPhone.Validate();
			fielddataOk &= stbSellerEmail.Validate();
			return fielddataOk;
        }

		private void btnExistingCustomer_Click(object sender, EventArgs e)
		{
			if (newCustomer)
			{
				CustomerSearchDropIn.Show(baseForm, CustomerSearchFinish);
			}
			else
			{
				CustomerSearchFinish(null);
			}
		}

	    private void CustomerSearchFinish(Customer customer)
		{
		    if (customer != null)
		    {
			    existingCustomer = customer;

			    stbSellerName.Text = customer.Name;
				stbSellerAdress.Text = customer.Address;
				stbSellerPhone.Text = customer.Telephone;
			    stbSellerEmail.Text = customer.Email;
			    stbSellerZipCode.Text = customer.City.ZipCode.ToString();
			    btnFindCustomer.Text = "Ryd kunde";

			    stbSellerName.Enabled = stbSellerAdress.Enabled = 
				stbSellerPhone.Enabled = stbSellerEmail.Enabled = 
				stbSellerZipCode.Enabled = false;

			    newCustomer = false;
		    }
		    else
			{
				stbSellerName.Text = "";
				stbSellerAdress.Text = "";
				stbSellerPhone.Text = "";
				stbSellerEmail.Text = "";
				stbSellerZipCode.Text = "";
				btnFindCustomer.Text = "Find kunde";

				stbSellerName.Enabled = stbSellerAdress.Enabled =
				stbSellerPhone.Enabled = stbSellerEmail.Enabled =
				stbSellerZipCode.Enabled = true;

				newCustomer = true;
		    }
	    }

	    private void UpdateEstateAgent(EstateAgent estateAgent)
		{
			if (estateAgent != null)
			{
				this.estateAgent = estateAgent;

				lblEstateAgentName.Text = estateAgent.Name;
			}
	    }

		private void stbFindEstateAgent_Click(object sender, EventArgs e)
		{
			EstateAgentSearchDropIn.Show(baseForm, UpdateEstateAgent);
		}
		
		private void stbSellerZipCode_TextChanged(object sender, EventArgs e)
		{
			City city = null;

			if (!string.IsNullOrEmpty(stbSellerZipCode.Text))
			{
				int zipCode = Convert.ToInt32(stbSellerZipCode.Text);
				city = CityController.Instance.GetCity(zipCode);
			}

			lblSellerCityCountry.Text = city != null ? city.District : "";
		}
    }
}
