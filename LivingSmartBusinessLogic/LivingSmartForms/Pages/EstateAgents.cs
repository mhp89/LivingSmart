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
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.Classes;
using LivingSmartForms.DropIns;
using LivingSmartForms.Views;

namespace LivingSmartForms.Pages
{
	public partial class EstateAgents : BasePage
	{
		public EstateAgents(BaseForm baseForm)
			: base(baseForm)
		{
			InitializeComponent();
		}
		private void UpdateList()
		{
			clsEstateAgents.SuspendLayout();

			clsEstateAgents.ClearList();
			var estateAgents = EstateAgentController.Instance.GetEstateAgents();
			foreach (var estateAgent in estateAgents)
			{
				var control = new EstateAgentLine(baseForm, estateAgent) {Margin = Padding.Empty};
				clsEstateAgents.AddControl(control, true);
			}
			sblActiveCases.Text = estateAgents.Count.ToString();

			clsEstateAgents.ResumeLayout();
		}

		public override void OnShow()
		{
			UpdateList();
		}

		private void NewEstateAgentAdded(EstateAgent estateAgent)
		{
			if (estateAgent != null)
			{
				var control = new EstateAgentLine(baseForm, estateAgent) {Margin = Padding.Empty};
				clsEstateAgents.AddControl(control);
				sblActiveCases.Text = clsEstateAgents.Controls.Count.ToString();
			}
		}

		private void btnNewEstateAgents_Click(object sender, EventArgs e)
		{
			baseForm.ShowDropIn(new NewEstateAgentDropIn(baseForm, NewEstateAgentAdded));
		}
	}
}
