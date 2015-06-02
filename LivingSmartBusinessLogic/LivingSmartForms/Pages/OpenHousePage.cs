using System;
using LivingSmartForms.Classes;
using LivingSmartForms.DropIns;

namespace LivingSmartForms.Pages
{
	public partial class OpenHousePage : BasePage
	{
		public OpenHousePage(BaseForm baseForm) : base(baseForm)
		{
			InitializeComponent();
                        		
		}

		private void btnSelectEstateAgents_Click(object sender, EventArgs e)
		{
			baseForm.ShowDropIn(new SelectEstateAgentDropIn(baseForm));
        }

        private void btnSelectProperties_Click(object sender, EventArgs e)
        {
            baseForm.ShowDropIn(new SelectPropertyDropIn(baseForm));
        }
	}
}
