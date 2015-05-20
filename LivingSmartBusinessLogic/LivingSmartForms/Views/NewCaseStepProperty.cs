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
        public NewCaseStepProperty(Case cCase)
        {
            InitializeComponent();

	        //stbPropertyType.Text = cCase.PropertyType.Description;
	        stbPropertyArea.Text = cCase.LivingArea.ToString();
	        stbPropertyBasement.Text = cCase.BasementArea.ToString();
	        stbPropertyBuildYear.Text = cCase.BuiltYear.ToString();
	        stbPropertyEnergyMark.Text = cCase.EnergyClassification;
	        stbPropertyFloors.Text = cCase.Floors.ToString();
	        stbPropertyRooms.Text = cCase.Rooms.ToString();
	        stbPropertyBedrooms.Text = cCase.Bedrooms.ToString();
	        stbPropertyBathrooms.Text = cCase.Bathrooms.ToString();
	        stbPropertyToilets.Text = cCase.Toilets.ToString();

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

		public override bool Save(Case cCase)
		{
			return true;
		}
    }
}
