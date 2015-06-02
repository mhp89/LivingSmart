using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartControls;
using LivingSmartBusinessLogic.Model;
using LivingSmartBusinessLogic.Controller;

namespace LivingSmartForms.Classes
{
	public static class GeneralValidation
	{
		public static void ZipCodeValidation(SmartTextBox textBox, Label label = null)
		{
			City city = null;

			if (textBox.Validate())
			{
				int zipCode = Convert.ToInt32(textBox.Text);
				city = CityController.Instance.GetCity(zipCode);

				if (city == null)
					textBox.SetError("Ugyldigt postnummer");
			}

			if (label != null)
				label.Text = city != null ? city.District : "";
		}
	}
}
