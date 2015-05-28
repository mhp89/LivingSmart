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
using LivingSmartBusinessLogic.Controller;

namespace LivingSmartForms.Views
{
    public partial class NewEstateAgent : UserControl
    {
		public NewEstateAgent(BaseForm baseForm)
        {
            InitializeComponent();
        }

		public bool Save()
		{
			bool fielddataOk = ValidateFields();
			if (fielddataOk)
			{
				var estateAgent = EstateAgentController.Instance.MakeNewEstateAgent();
				EstateAgentController.Instance.SetName(estateAgent, stbEstateAgentName.Text);
				EstateAgentController.Instance.SetTelephone(estateAgent, stbEstateAgentPhone.Text);
				EstateAgentController.Instance.SetEmail(estateAgent, stbEstateAgentEmail.Text);
				EstateAgentController.Instance.AddEstateAgent(estateAgent);
			}
			return fielddataOk;
		}

		private bool ValidateFields()
		{
			bool fielddataOk = true;

			fielddataOk &= stbEstateAgentName.Validate();
			fielddataOk &= stbEstateAgentPhone.Validate();
			fielddataOk &= stbEstateAgentEmail.Validate();

			//TODO: Validate birthday

			return fielddataOk;
		}
    }
}
