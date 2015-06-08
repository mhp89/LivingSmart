using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartControls;
using LivingSmartBusinessLogic.Model;
using LivingSmartBusinessLogic.Controller;
using LivingSmartBusinessLogic.Entity;

namespace LivingSmartForms.Classes
{
	/// <summary>
	/// Klasse med diverse generelle valideringsmetoder
	/// </summary>
	/// <author>Mathias Petersen</author>
	public static class GeneralValidation
	{
		public static bool ZipCodeValidation(SmartTextBox textBox, Label label = null)
		{
			bool success = false;
			City city = null;

			if (textBox.Validate())
			{
				int zipCode = Convert.ToInt32(textBox.Text);
				city = CityController.Instance.GetCity(zipCode);

				if (city == null)
					textBox.SetError("Ugyldigt postnummer");
				else
					success = true;
			}

			if (label != null)
				label.Text = city != null ? city.District : "";

			return success;
		}
	}
}
