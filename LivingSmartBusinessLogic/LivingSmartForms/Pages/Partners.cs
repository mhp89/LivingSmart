using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivingSmartBusinessLogic.Controller;
using LivingSmartForms.Classes;
using LivingSmartForms.DropIns;
using LivingSmartForms.Views;

namespace LivingSmartForms.Pages
{
	public partial class Partners : BasePage
	{
		public Partners(BaseForm baseForm) : base(baseForm)
		{
			InitializeComponent();


			//CustomerController.Instance.
			for (int i = 0; i < 10; i++)
			{
				var control = new PartnerLine();
				control.Margin = Padding.Empty;
				clsPartners.AddControl(control);
			}
		}

		private void btnNewEstateAgents_Click(object sender, EventArgs e)
		{
			baseForm.ShowDropIn(new NewPartnerDropIn(baseForm));
		}
	}
}
