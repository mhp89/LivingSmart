using System;
using System.Collections.Generic;
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.Classes;
using LivingSmartForms.DropIns;

namespace LivingSmartForms.Pages
{
	public partial class OpenHousePage : BasePage
	{
        public List<EstateAgent> agents = new List<EstateAgent>();
        public List<Case> property = new List<Case>();

		public OpenHousePage(BaseForm baseForm) : base(baseForm)
		{
			InitializeComponent();
		}

		private void btnSelectEstateAgents_Click(object sender, EventArgs e)
		{
			baseForm.ShowDropIn(new SelectEstateAgentDropIn(baseForm, EstateAgentList));
        }

        private void btnSelectProperties_Click(object sender, EventArgs e)
        {
            baseForm.ShowDropIn(new SelectPropertyDropIn(baseForm));
        }

        private void EstateAgentList(List<EstateAgent> agents)
        {
            this.agents = agents;
            Console.WriteLine(agents.Count);
        }
	}
}
