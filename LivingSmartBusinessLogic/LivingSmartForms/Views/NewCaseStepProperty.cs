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
using LivingSmartForms.UserControls;

namespace LivingSmartForms.Views
{
    public partial class NewCaseStepProperty : CaseStep
    {
        private CaseController caseController;
        public NewCaseStepProperty(CaseController caseController)
        {
            this.caseController = caseController;
            InitializeComponent();
            NewDistanceInput();
        }

        private NewCaseStepProperty()
        {
            InitializeComponent();
        }

        private void NewDistanceInput()
        {
            clsDistances.AddControl(new DistanceField());
        }

        public override bool Save()
        {
            bool fielddataOk = VerifyFields();
            if (fielddataOk)
            {
                // stbPropertyType.Text = cCase.PropertyType.Description;
                // caseController.SetPropertyType();
                caseController.SetLivingArea(Convert.ToInt32(stbPropertyArea.Text));
                caseController.SetBasementArea(Convert.ToInt32(stbPropertyBasement.Text));
                caseController.SetBuiltYear(Convert.ToInt32(stbPropertyBuildYear.Text));
                caseController.SetEnergyClassification(stbPropertyEnergyMark.Text);
                caseController.SetFloors(Convert.ToInt32(stbPropertyFloors.Text));
                caseController.SetRooms(Convert.ToInt32(stbPropertyRooms.Text));
                caseController.SetBedrooms(Convert.ToInt32(stbPropertyBedrooms.Text));
                caseController.SetBathrooms(Convert.ToInt32(stbPropertyBathrooms.Text));
                caseController.SetToilets(Convert.ToInt32(stbPropertyToilets.Text));
            }
            return fielddataOk;
        }

        private bool VerifyFields()
        {
            bool fielddataOk = true;
            fielddataOk &= stbPropertyArea.Validate();
            fielddataOk &= stbPropertyBasement.Validate();
            fielddataOk &= stbPropertyBuildYear.Validate();
            fielddataOk &= stbPropertyEnergyMark.Validate();
            fielddataOk &= stbPropertyFloors.Validate();
            fielddataOk &= stbPropertyRooms.Validate();
            fielddataOk &= stbPropertyBedrooms.Validate();
            fielddataOk &= stbPropertyBathrooms.Validate();
            fielddataOk &= stbPropertyToilets.Validate();
            return fielddataOk;
        }
    }
}
