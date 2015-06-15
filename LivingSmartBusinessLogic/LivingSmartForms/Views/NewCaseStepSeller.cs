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
using LivingSmartBusinessLogic.Entity;
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.Classes;
using LivingSmartForms.DropIns;

namespace LivingSmartForms.Views
{
    public partial class NewCaseStepSeller : CaseStep
    {
		private NewCaseDropIn baseView;

	    private bool newCustomer = true;
	    private Customer createdCustomer;

		public NewCaseStepSeller(NewCaseDropIn baseView, Case cCase)
			: base(cCase)
        {
			this.baseView = baseView;
			
            InitializeComponent();

	        if (cCase != null)
			{
				SetSellerFields(cCase.Seller);
                UpdateEstateAgent(cCase.EstateAgent);
	        }
            else
			    UpdateEstateAgent(baseView.baseForm.DefaultEstateAgent);
        }

	    public override bool Save()
		{
			bool fielddataOk = ValidateFields();
			if (fielddataOk)
			{
				//Hvis der skal oprettes en ny kunde, og kunden ikke allerede er oprettet,
				//ellers opdatere den oprettede.
				if (newCustomer)
				{
					if (CaseController.Instance.GetActiveCase().Seller == null)
					{
						createdCustomer = CustomerController.Instance.MakeNewCustomer(
							stbSellerName.Text,
							(DateTime) dafBirthday.GetDateTime(),
							stbSellerAdress.Text,
							Convert.ToInt32(stbSellerZipCode.Text),
							stbSellerEmail.Text,
							stbSellerPhone.Text
							);
						CaseController.Instance.SetSeller(createdCustomer);
					}
					else if (newCustomer)
					{
						//Sikrer at det er den oprettede kunde der ændres.
						CustomerController.Instance.SetActiveCustomer(createdCustomer);

						CustomerController.Instance.SetName(stbSellerName.Text);
						CustomerController.Instance.SetDateOfBirth((DateTime) dafBirthday.GetDateTime());
						CustomerController.Instance.SetAddress(stbSellerAdress.Text);
						CustomerController.Instance.SetCity(Convert.ToInt32(stbSellerZipCode.Text));
						CustomerController.Instance.SetEmail(stbSellerEmail.Text);
						CustomerController.Instance.SetTelephone(stbSellerPhone.Text);
					}
					CustomerController.Instance.SaveActiveCustomer();
				}
			}
			return fielddataOk;
	    }

        private bool ValidateFields()
		{
			bool fielddataOk = true;
			fielddataOk &= stbSellerName.Validate();
			fielddataOk &= stbSellerAdress.Validate();
			fielddataOk &= stbSellerZipCode.Validate();
			fielddataOk &= stbSellerPhone.Validate();
			fielddataOk &= stbSellerEmail.Validate();
	        fielddataOk &= dafBirthday.Validate();
			return fielddataOk;
        }

		private void btnExistingCustomer_Click(object sender, EventArgs e)
		{
			if (newCustomer)
				CustomerSearchDropIn.Show(baseView.baseForm, CustomerSearchFinish);
			else
				CustomerSearchFinish(null);
		}

	    private void CustomerSearchFinish(Customer customer)
		{
			CaseController.Instance.SetSeller(customer);

		    SetSellerFields(customer);
	    }

	    private void SetSellerFields(Customer customer)
	    {
			if (customer != null)
			{
				lblSellerIdNo.Text = customer.Id.ToString();
				stbSellerName.Text = customer.Name;
				stbSellerAdress.Text = customer.Address;
				stbSellerPhone.Text = customer.Telephone;
				stbSellerEmail.Text = customer.Email;
				stbSellerZipCode.Text = customer.City.ZipCode.ToString();
				dafBirthday.SetDate(customer.DateOfBirth);
				btnFindCustomer.Text = "Ryd kunde";

				SetSellerFieldsEnabled(false);

				newCustomer = false;
			}
			else
			{
				lblSellerIdNo.Text = stbSellerName.Text = stbSellerAdress.Text =
				stbSellerPhone.Text = stbSellerEmail.Text =
				stbSellerZipCode.Text = "";

				btnFindCustomer.Text = "Find kunde";
				dafBirthday.ClearDate();

				SetSellerFieldsEnabled(true);

				newCustomer = true;
			}
	    }

	    private void SetSellerFieldsEnabled(bool newState)
		{
			stbSellerName.Enabled = stbSellerAdress.Enabled =
			stbSellerPhone.Enabled = stbSellerEmail.Enabled =
			stbSellerZipCode.Enabled = dafBirthday.Enabled = newState;
	    }

	    private void UpdateEstateAgent(EstateAgent estateAgent)
		{
			if (estateAgent != null)
			{
				CaseController.Instance.SetEstateAgent(estateAgent);

				lblEstateAgentName.Text = estateAgent.Name;
			}
	    }

		private void stbFindEstateAgent_Click(object sender, EventArgs e)
		{
			EstateAgentSearchDropIn.Show(baseView.baseForm, UpdateEstateAgent);
		}
		
		private void stbSellerZipCode_TextChanged(object sender, EventArgs e)
		{
			GeneralValidation.ZipCodeValidation(stbSellerZipCode, lblSellerCityCountry);
		}
    }
}
