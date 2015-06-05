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
using LivingSmartForms.DropIns;

namespace LivingSmartForms.Views
{
    public partial class NewCaseStepEndCase : CaseStep
    {
		private NewCaseDropIn baseView;

	    private Customer buyer;

		public NewCaseStepEndCase(NewCaseDropIn baseView, Case cCase)
			: base(cCase)
        {
			this.baseView = baseView;
			
            InitializeComponent();
			
			BuyerSearchFinish(cCase.Buyer);

			SetSellerFieldsEnabled(buyer != null);

			UpdateStatusLabel();
		}

	    public NewCaseStepEndCase() : base(null)
	    {
		    InitializeComponent();
	    }

	    public override bool Save()
		{
			bool fielddataOk = ValidateFields();
			if (fielddataOk)
			{
				if (buyer != null)
				{
					CaseController.Instance.SetDateOfSale((DateTime) dafDateOfSale.GetDateTime());
					CaseController.Instance.SetTransferDate((DateTime) dafTransferDate.GetDateTime());
					CaseController.Instance.SetSellingPrice(Convert.ToInt64(stbSellingPrice.Text));
				}
				else
				{
					CaseController.Instance.SetDateOfSale(null);
					CaseController.Instance.SetTransferDate(null);
					CaseController.Instance.SetSellingPrice(null);
				}
				UpdateStatusLabel();
			}
			return fielddataOk;
	    }

        private bool ValidateFields()
		{
			bool fielddataOk = true;
			if (buyer != null)
			{
				fielddataOk &= dafDateOfSale.Validate();
				fielddataOk &= dafTransferDate.Validate();
				fielddataOk &= stbSellingPrice.Validate();
	        }

			return fielddataOk;
        }

		private void BuyerSearchFinish(Customer customer)
		{
			CaseController.Instance.SetBuyer(customer);

		    SetSellerFields(customer);
	    }

	    private void SetSellerFields(Customer customer)
	    {
		    buyer = (customer == cCase.Seller) ? null : customer;

		    if (buyer != null)
		    {
			    lblBuyerName.Text = buyer.Name;
				stbSellingPrice.Text = cCase.NewestAskingPrice.ToString();
				dafDateOfSale.SetDate(DateTime.Now);
				btnFindBuyer.Text = "Ryd kunde";

				SetSellerFieldsEnabled(true);

				CaseController.Instance.SetStatus(Case.CaseStatus.Sold);
			}
			else
			{
				lblBuyerName.Text = stbSellingPrice.Text = "";
				stbSellingPrice.ClearError();

				dafTransferDate.ClearDate();
				dafDateOfSale.ClearDate();

				dafTransferDate.ClearError();
				dafDateOfSale.ClearError();

				btnFindBuyer.Text = "Find kunde";

				SetSellerFieldsEnabled(false);

				CaseController.Instance.SetStatus(Case.CaseStatus.Open);
			}
	    }

	    private void SetSellerFieldsEnabled(bool newState)
		{
			dafTransferDate.Enabled = dafDateOfSale.Enabled = stbSellingPrice.Enabled = newState;
	    }

		private void btnFindBuyer_Click(object sender, EventArgs e)
		{
			if (buyer == null)
				CustomerSearchDropIn.Show(baseView.baseForm, BuyerSearchFinish);
			else
				BuyerSearchFinish(null);
		}

	    private void UpdateStatusLabel()
	    {
			lblStatus.Text = Case.TranslateStatus(cCase.Status);
	    }
		private void stbCloseCase_Click(object sender, EventArgs e)
		{
			BuyerSearchFinish(null);
			CaseController.Instance.CloseCase();
			baseView.NextStep();
		}
    }
}
