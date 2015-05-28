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
				var estateAgent = EstateAgentController.Instance.MakeNewEstateAgent(stbEstateAgentName.Text, stbEstateAgentPhone.Text, stbEstateAgentEmail.Text, DateTime.Today);
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
