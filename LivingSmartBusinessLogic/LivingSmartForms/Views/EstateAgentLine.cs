using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivingSmartBusinessLogic;
using LivingSmartBusinessLogic.Entity;
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.DropIns;

namespace LivingSmartForms
{
    public partial class EstateAgentLine : UserControl
    {
        private BaseForm baseForm;
	    private EstateAgent estateAgent;

		public EstateAgentLine(BaseForm baseForm, EstateAgent estateAgent)
		{
			this.estateAgent = estateAgent;
		    this.baseForm = baseForm;

			InitializeComponent();
			UpdateFields();
        }

	    private void UpdateFields()
	    {
		    slbEmployeeNo.Text = estateAgent.Id.ToString();
		    slbName.Text = estateAgent.Name;
		    slbPhone.Text = estateAgent.Telephone;
		    slbEmail.Text = estateAgent.Email;
		    slbHireDate.Text = estateAgent.StartingDate.ToShortDateString() + " - " +
				((estateAgent.TerminationDate.HasValue) ? estateAgent.TerminationDate.Value.ToShortDateString() : "Nu");
	    }

        private void btnSeeEstateAgent_Click(object sender, EventArgs e)
        {
            baseForm.ShowDropIn(new NewEstateAgentDropIn(baseForm, estateAgent, Callback));
        }

        private void Callback(EstateAgent estateAgent)
        {
            UpdateFields();
        }
    }
}
