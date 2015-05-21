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

            //stbPropertyType.Text = cCase.PropertyType.Description;
            //stbPropertyArea.Text = cCase.LivingArea.ToString();
            //stbPropertyBasement.Text = cCase.BasementArea.ToString();
            //stbPropertyBuildYear.Text = cCase.BuiltYear.ToString();
            //stbPropertyEnergyMark.Text = cCase.EnergyClassification;
            //stbPropertyFloors.Text = cCase.Floors.ToString();
            //stbPropertyRooms.Text = cCase.Rooms.ToString();
            //stbPropertyBedrooms.Text = cCase.Bedrooms.ToString();
            //stbPropertyBathrooms.Text = cCase.Bathrooms.ToString();
            //stbPropertyToilets.Text = cCase.Toilets.ToString();

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
                //stbPropertyType.Text = cCase.PropertyType.Description;
                //caseController.SetpropertyType();
                //stbPropertyArea.Text = cCase.LivingArea.ToString();
                caseController.SetlivingArea(Convert.ToInt32(stbPropertyArea.Text));
                caseController.SetbasementArea(Convert.ToInt32(stbPropertyBasement.Text));
                caseController.SetbuiltYear(Convert.ToInt32(stbPropertyBuildYear.Text));
                caseController.SetenergyClassification(stbPropertyEnergyMark.Text);
                caseController.Setfloors(Convert.ToInt32(stbPropertyFloors.Text));
                caseController.Setrooms(Convert.ToInt32(stbPropertyRooms.Text));
                caseController.Setbedrooms(Convert.ToInt32(stbPropertyBedrooms.Text));
                caseController.Setbathrooms(Convert.ToInt32(stbPropertyBathrooms.Text));
                caseController.Settoilets(Convert.ToInt32(stbPropertyToilets.Text));
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
