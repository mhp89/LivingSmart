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
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.DropIns;

namespace LivingSmartForms.Views
{
	public partial class EstateAgentLineSearch : UserControl
	{
	    private EstateAgentSearchDropIn dropIn { get; set; }
	    public EstateAgent EstateAgent { get; private set; }

		public EstateAgentLineSearch(EstateAgentSearchDropIn dropIn, EstateAgent estateAgent)
        {
	        this.dropIn = dropIn;
	        EstateAgent = estateAgent;

            InitializeComponent();

			UpdateFields();

			BindEvent(this);
        }

		private void BindEvent(Control parent)
		{
			parent.Click += Select;
			parent.DoubleClick += FastSelect;

			foreach (Control control in parent.Controls)
				BindEvent(control);
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
		private void FastSelect(object sender, EventArgs e)
		{
			dropIn.FastSelectEstateAgent(this);
		}
	}
}
