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
                //          stbPropertyType.Text = cCase.PropertyType.Description;
                //          caseController.SetpropertyType();
                //	        stbPropertyArea.Text = cCase.LivingArea.ToString();
                caseController.SetlivingArea(Convert.ToInt32(stbPropertyArea.Text));
                //	        stbPropertyBasement.Text = cCase.BasementArea.ToString()
                caseController.SetbasementArea(Convert.ToInt32(stbPropertyBasement.Text));
                //	        stbPropertyBuildYear.Text = cCase.BuiltYear.ToString();
                caseController.SetbuiltYear(Convert.ToInt32(stbPropertyBuildYear.Text));
                //	        stbPropertyEnergyMark.Text = cCase.EnergyClassification;
                caseController.SetenergyClassification(stbPropertyEnergyMark.Text);
                //	        stbPropertyFloors.Text = cCase.Floors.ToString();
                caseController.Setfloors(Convert.ToInt32(stbPropertyFloors.Text));
                //	        stbPropertyRooms.Text = cCase.Rooms.ToString();
                caseController.Setrooms(Convert.ToInt32(stbPropertyRooms.Text));
                //	        stbPropertyBedrooms.Text = cCase.Bedrooms.ToString();
                caseController.Setbedrooms(Convert.ToInt32(stbPropertyBedrooms.Text));
                //	        stbPropertyBathrooms.Text = cCase.Bathrooms.ToString();
                caseController.Setbathrooms(Convert.ToInt32(stbPropertyBathrooms.Text));
                //	        stbPropertyToilets.Text = cCase.Toilets.ToString();
                caseController.Settoilets(Convert.ToInt32(stbPropertyToilets.Text));
            }
            return fielddataOk;
        }

        private bool VerifyFields()
        {
            return true;
        }
    }
}
