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
		}

		private void UpdateList()
		{
			clsPartners.SuspendLayout();

			clsPartners.ClearList();
			var partners = PartnerController.Instance.GetPartners();
			foreach (var partner in partners)
			{
				var control = new PartnerLine(baseForm, partner);
				control.Margin = Padding.Empty;
				clsPartners.AddControl(control, true);
			}
			sblPartners.Text = partners.Count.ToString();

			clsPartners.ResumeLayout();
		}

		public override void OnShow()
		{
			UpdateList();
		}

		private void btnNewEstateAgents_Click(object sender, EventArgs e)
		{
			baseForm.ShowDropIn(new NewPartnerDropIn(baseForm, null, UpdateList));
		}
	}
}
