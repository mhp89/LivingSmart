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
	public partial class OpenHouse : BasePage
	{
		public OpenHouse(BaseForm baseForm) : base(baseForm)
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
