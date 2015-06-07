using System;
using LivingSmartBusinessLogic.Controller;
using LivingSmartBusinessLogic.Entity;
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.Classes;
using LivingSmartForms.DropIns;
using DistanceToSystemType = LivingSmartBusinessLogic.Entity.DistanceTo.DistanceToSystemType;

namespace LivingSmartForms.Views
{
    public partial class NewCaseStepProperty : CaseStep
    {
		private DistanceTo disShopping;
		private DistanceTo disCenter;
		private DistanceTo disSchool;

		public NewCaseStepProperty(NewCaseDropIn baseView, Case cCase) : base(cCase)
        {
            InitializeComponent();

	        foreach (var propertyType in PropertyTypeController.Instance.GetPropertyTypes())
	        {
		        cboPropertyType.Items.Add(propertyType);
				cboPropertyType.DisplayMember = "Description";
	        }

			if (cCase != null)
			{
				cboPropertyType.SelectedItem = cCase.PropertyType;
				stbPropertyArea.Text = cCase.LivingArea.ToString();
				stbPropertyBasement.Text = cCase.BasementArea.ToString();
				stbPropertyBuildYear.Text = cCase.BuiltYear.ToString();
				stbPropertyEnergyMark.Text = cCase.EnergyClassification;
				stbPropertyFloors.Text = cCase.Floors.ToString();
				stbPropertyRooms.Text = cCase.Rooms.ToString();
				stbPropertyBedrooms.Text = cCase.Bedrooms.ToString();
				stbPropertyBathrooms.Text = cCase.Bathrooms.ToString();
				stbPropertyToilets.Text = cCase.Toilets.ToString();

				var distances = CaseController.Instance.GetDistanceTos(cCase.Id);
				foreach (var distance in distances)
				{
					if (distance.Type == DistanceToSystemType.Shopping.ToString())
					{
						disShopping = distance;
						stbDistanceToShopping.Text = distance.Distance.ToString();
					}
					else if (distance.Type == DistanceToSystemType.School.ToString())
					{
						disSchool = distance;
						stbDistanceToSchool.Text = distance.Distance.ToString();
					}
					else if (distance.Type == DistanceToSystemType.Center.ToString())
					{
						disCenter = distance;
						stbDistanceToCenter.Text = distance.Distance.ToString();
					}
				}
			}
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
	            }
	            else
					CaseController.Instance.SetDistance(disShopping, shoppingDistance);

				if (disCenter == null)
				{
					disCenter = CaseController.Instance.MakeNewDistanceTo(
						DistanceToSystemType.Center.ToString(),
						centerDistance
					);
				}
				else
					CaseController.Instance.SetDistance(disCenter, centerDistance);

				if (disSchool == null)
				{
					disSchool = CaseController.Instance.MakeNewDistanceTo(
						DistanceToSystemType.School.ToString(),
						schoolDistance
					);
				}
				else
					CaseController.Instance.SetDistance(disSchool, schoolDistance);
            }
            return fielddataOk;
        }

        private bool VerifyFields()
        {
            bool fielddataOk = true;
	        fielddataOk &= cboPropertyType.SelectedItem != null;
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
