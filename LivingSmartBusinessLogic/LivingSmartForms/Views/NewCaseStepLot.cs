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
    public partial class NewCaseStepLot : CaseStep
    {
        private CaseController caseController;
        public NewCaseStepLot(BaseForm baseForm)
        {
            caseController = baseForm.CaseController;
            InitializeComponent();
        }

        public override bool Save()
        {
            bool fielddataOk = ValidateFields();
            if (fielddataOk)
            {
                caseController.SetLandRegistryNumber(stbLotNumber.Text);
                caseController.SetAddress(stbLotAddress.Text);
                caseController.SetLandValue(Convert.ToInt32(stbLotValue.Text));
                caseController.SetGroundArea(Convert.ToInt32(stbLotArea.Text));
                caseController.SetBuiltArea(Convert.ToInt32(stbLotBuildArea.Text));
                caseController.SetGarageArea(Convert.ToInt32(stbLotGarageArea.Text));
                caseController.SetView(Convert.ToInt32(stbLotView.Text));
            }
            return fielddataOk;
        }

        private bool ValidateFields()
        {
            bool fielddataOk = true;
            fielddataOk &= stbLotNumber.Validate();
            fielddataOk &= stbLotAddress.Validate();
            fielddataOk &= stbLotValue.Validate();
            fielddataOk &= stbLotArea.Validate();
            fielddataOk &= stbLotBuildArea.Validate();
            fielddataOk &= stbLotGarageArea.Validate();
            fielddataOk &= stbLotView.Validate();
            return fielddataOk;
        }
    }
}
