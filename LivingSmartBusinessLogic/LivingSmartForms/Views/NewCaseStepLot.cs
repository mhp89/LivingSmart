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
    public partial class NewCaseStepLot : CaseStep
    {

        public NewCaseStepLot(BaseForm baseForm)
        {
            InitializeComponent();

	        cboNeighborhood.DisplayMember = "DisplayName";
        }

        public override bool Save()
        {
            bool fielddataOk = ValidateFields();
            if (fielddataOk)
            {
                CaseController.Instance.SetLandRegistryNumber(stbLotNumber.Text);
				CaseController.Instance.SetAddress(stbLotAddress.Text);
				CaseController.Instance.SetZipCode(Convert.ToInt32(stbLotZipCode.Text));
				CaseController.Instance.SetNeighborhood(cboNeighborhood.SelectedItem as Neighborhood);
				CaseController.Instance.SetLandValue(Convert.ToInt32(stbLotValue.Text));
				CaseController.Instance.SetGroundArea(Convert.ToInt32(stbLotArea.Text));
				CaseController.Instance.SetBuiltArea(Convert.ToInt32(stbLotBuildArea.Text));
				CaseController.Instance.SetGarageArea((string.IsNullOrEmpty(stbLotGarageArea.Text)?0:Convert.ToInt32(stbLotGarageArea.Text)));
				CaseController.Instance.SetView(Convert.ToInt32(stbLotView.Text));
            }
            return fielddataOk;
        }

        private bool ValidateFields()
        {
            bool fielddataOk = true;
            fielddataOk &= stbLotNumber.Validate();
            fielddataOk &= stbLotAddress.Validate();
	        fielddataOk &= stbLotZipCode.Validate();
	        fielddataOk &= cboNeighborhood.SelectedItem != null;
            fielddataOk &= stbLotValue.Validate();
            fielddataOk &= stbLotArea.Validate();
            fielddataOk &= stbLotBuildArea.Validate();
            fielddataOk &= stbLotGarageArea.Validate();
            fielddataOk &= stbLotView.Validate();
            return fielddataOk;
        }

		private void stbLotZipCode_TextChanged(object sender, EventArgs e)
		{
			if (GeneralValidation.ZipCodeValidation(stbLotZipCode, lblLotCityCountry))
			{
				cboNeighborhood.Enabled = true;

				int zipCode = Convert.ToInt32(stbLotZipCode.Text);

				var hoods = NeighborhoodController.Instance.GetHoods(zipCode);
				cboNeighborhood.Items.Clear();
				if (hoods != null)
				{
					foreach (var hood in hoods)
						cboNeighborhood.Items.Add(hood);
				}
			}
			else
			{
				cboNeighborhood.Enabled = false;
			}
		}
    }
}
