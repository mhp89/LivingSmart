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
				EstateAgentController.Instance.MakeNewEstateAgent(stbName.Text, stbPhone.Text, stbEmail.Text, (DateTime) dafStartDate.GetDateTime(), stbUsername.Text, stbPassword.Text);
				EstateAgentController.Instance.SaveActiveEstateAgent();
			}
			return fielddataOk;
		}

		private bool ValidateFields()
		{
			bool fielddataOk = true;

			fielddataOk &= stbName.Validate();
			fielddataOk &= stbPhone.Validate();
			fielddataOk &= stbEmail.Validate();
			fielddataOk &= dafStartDate.Validate();
			
			return fielddataOk;
		}
    }
}
