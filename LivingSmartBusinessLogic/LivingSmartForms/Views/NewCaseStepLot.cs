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
using LivingSmartForms.Classes;

namespace LivingSmartForms.Views
{
    public partial class NewCaseStepLot : CaseStep
    {
        private CaseController caseController;
        public NewCaseStepLot(CaseController caseController)
        {
            this.caseController = caseController;
            InitializeComponent();
        }

        public override bool Save()
        {
            bool fielddataOk = ValidateFields();
            if (fielddataOk)
            {
                caseController.SetlandRegistryNumber(stbLotNumber.Text);
                caseController.Setaddress(stbLotAddress.Text);
                caseController.SetlandValue(Convert.ToInt32(stbLotValue.Text));
                caseController.SetgroundArea(Convert.ToInt32(stbLotArea.Text));
                caseController.SetbuiltArea(Convert.ToInt32(stbLotBuildArea.Text));
                caseController.SetgarageArea(Convert.ToInt32(stbLotGarageArea.Text));
                caseController.Setview(Convert.ToInt32(stbLotView.Text));
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
