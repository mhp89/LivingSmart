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
using LivingSmartForms.DropIns;

namespace LivingSmartForms.Views
{
	public partial class EstateAgentSearch : UserControl
	{
	    private EstateAgentSearchDropIn dropIn { get; set; }
	    public EstateAgent EstateAgent { get; private set; }

		public EstateAgentSearch(EstateAgentSearchDropIn dropIn, EstateAgent estateAgent)
        {
	        this.dropIn = dropIn;
	        EstateAgent = estateAgent;

            InitializeComponent();

			UpdateFields();

			Click += Select;
			BindEvent(this);
        }

	    private void BindEvent(Control parent)
		{
		    foreach (Control control in parent.Controls)
		    {
				control.Click += Select;
				BindEvent(control);
		    }
		}

	    private void UpdateFields()
	    {
		    slbEstateAgentNo.Text = EstateAgent.Id.ToString();
		    slbName.Text = EstateAgent.Name;
		    slbPhone.Text = EstateAgent.Telephone;
	    }

	    private void Select(object sender, EventArgs e)
	    {
		    dropIn.SelectEstateAgent(this);
	    }
	}
}
