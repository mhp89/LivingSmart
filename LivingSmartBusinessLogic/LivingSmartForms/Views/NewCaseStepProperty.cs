using System;
using LivingSmartBusinessLogic.Controller;
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.Classes;
using DistanceToSystemType = LivingSmartBusinessLogic.Model.DistanceTo.DistanceToSystemType;

namespace LivingSmartForms.Views
{
    public partial class NewCaseStepProperty : CaseStep
    {

		private DistanceTo disShopping;
		private DistanceTo disCenter;
		private DistanceTo disSchool;

        public NewCaseStepProperty(BaseForm baseForm)
        {
            InitializeComponent();

	        foreach (var propertyType in PropertyTypeController.Instance.GetPropertyTypes())
	        {
		        cboPropertyType.Items.Add(propertyType);
				cboPropertyType.DisplayMember = "Description";
	        }
        }

        private NewCaseStepProperty()
        {
            InitializeComponent();
        }
		
        public override bool Save()
        {
            bool fielddataOk = VerifyFields();
            if (fielddataOk)
            {
	            CaseController.Instance.SetPropertyType(cboPropertyType.SelectedItem as PropertyType);
				CaseController.Instance.SetLivingArea(Convert.ToInt32(stbPropertyArea.Text));
				CaseController.Instance.SetBasementArea(Convert.ToInt32(stbPropertyBasement.Text));
				CaseController.Instance.SetBuiltYear(Convert.ToInt32(stbPropertyBuildYear.Text));
				CaseController.Instance.SetEnergyClassification(stbPropertyEnergyMark.Text);
				CaseController.Instance.SetFloors(Convert.ToInt32(stbPropertyFloors.Text));
				CaseController.Instance.SetRooms(Convert.ToInt32(stbPropertyRooms.Text));
				CaseController.Instance.SetBedrooms(Convert.ToInt32(stbPropertyBedrooms.Text));
				CaseController.Instance.SetBathrooms(Convert.ToInt32(stbPropertyBathrooms.Text));
				CaseController.Instance.SetToilets(Convert.ToInt32(stbPropertyToilets.Text));

	            var shoppingDistance = Convert.ToInt32(stbDistanceToShopping.Text);
				var centerDistance = Convert.ToInt32(stbDistanceToCenter.Text);
				var schoolDistance = Convert.ToInt32(stbDistanceToSchool.Text);

	            if (disShopping == null)
	            {
		            disShopping = CaseController.Instance.MakeNewDistanceTo(
			            DistanceToSystemType.Shopping.ToString(),
			            shoppingDistance
			            );
		            CaseController.Instance.AddDistanceToCase(disShopping);
	            }
	            /*else
		            disShopping.Distance = shoppingDistance;*/

				if (disCenter == null)
				{
					disCenter = CaseController.Instance.MakeNewDistanceTo(
						DistanceToSystemType.Center.ToString(),
						centerDistance
					);
					CaseController.Instance.AddDistanceToCase(disCenter);
				}
				/*else
					disShopping.Distance = centerDistance;*/

				if (disSchool == null)
				{
					disSchool = CaseController.Instance.MakeNewDistanceTo(
						DistanceToSystemType.Shopping.ToString(),
						schoolDistance
					);
					CaseController.Instance.AddDistanceToCase(disSchool);
				}
				/*else
					disShopping.Distance = schoolDistance;*/
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

			fielddataOk &= stbDistanceToShopping.Validate();
			fielddataOk &= stbDistanceToCenter.Validate();
			fielddataOk &= stbDistanceToSchool.Validate();

            return fielddataOk;
        }
    }
}
