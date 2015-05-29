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

namespace LivingSmartForms
{
    public partial class EstateAgentLine : UserControl
    {
	    private EstateAgent estateAgent;

		public EstateAgentLine(BaseForm baseForm, EstateAgent estateAgent)
		{
			this.estateAgent = estateAgent;
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
    }
}
