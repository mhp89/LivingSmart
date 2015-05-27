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
using LivingSmartForms.UserControls;

namespace LivingSmartForms.Views
{
    public partial class NewCaseStepProperty : CaseStep
    {
        public NewCaseStepProperty(BaseForm baseForm)
        {
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
				CaseController.Instance.SetLivingArea(Convert.ToInt32(stbPropertyArea.Text));
				CaseController.Instance.SetBasementArea(Convert.ToInt32(stbPropertyBasement.Text));
				CaseController.Instance.SetBuiltYear(Convert.ToInt32(stbPropertyBuildYear.Text));
				CaseController.Instance.SetEnergyClassification(stbPropertyEnergyMark.Text);
				CaseController.Instance.SetFloors(Convert.ToInt32(stbPropertyFloors.Text));
				CaseController.Instance.SetRooms(Convert.ToInt32(stbPropertyRooms.Text));
				CaseController.Instance.SetBedrooms(Convert.ToInt32(stbPropertyBedrooms.Text));
				CaseController.Instance.SetBathrooms(Convert.ToInt32(stbPropertyBathrooms.Text));
				CaseController.Instance.SetToilets(Convert.ToInt32(stbPropertyToilets.Text));
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
