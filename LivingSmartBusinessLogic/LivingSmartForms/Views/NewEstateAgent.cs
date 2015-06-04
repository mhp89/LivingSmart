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
using LivingSmartBusinessLogic.Model;

namespace LivingSmartForms.Views
{
    public partial class NewEstateAgent : UserControl
    {
        public EstateAgent CreatedEstateAgent { get; private set; }
        private EstateAgent currentEstateAgent;

        public NewEstateAgent(BaseForm baseForm, EstateAgent estateAgent)
        {
            currentEstateAgent = estateAgent;

            InitializeComponent();

            if (estateAgent != null)
            {
                stbName.Text = estateAgent.Name;
                stbPhone.Text = estateAgent.Telephone;
                stbEmail.Text = estateAgent.Email;
                dafStartDate.SetDate(estateAgent.StartingDate);
                if (estateAgent.TerminationDate != null) dafTerminationDate.SetDate((DateTime)estateAgent.TerminationDate);
                stbUsername.Text = estateAgent.Username;
                stbPassword.Text = estateAgent.Password;

                stbUsername.Enabled = false;
                stbPassword.Enabled = false;
            }
        }

        public bool Save()
        {
            bool fielddataOk = ValidateFields();
            if (fielddataOk)
            {
                if (currentEstateAgent == null)
                {
                    CreatedEstateAgent = EstateAgentController.Instance.MakeNewEstateAgent(stbName.Text, stbPhone.Text,
                        stbEmail.Text, (DateTime)dafStartDate.GetDateTime(), stbUsername.Text, stbPassword.Text);
                    EstateAgentController.Instance.SaveActiveEstateAgent();

                    if (CreatedEstateAgent.Id == -1)
                    {
                        MessageBox.Show("Tilykke, du fandt en fejl!");
                        fielddataOk = false;
                    }
                }
                else
                {
                    EstateAgentController.Instance.SetActiveEstateAgent(currentEstateAgent);
                    EstateAgentController.Instance.SetName(stbName.Text);
                    EstateAgentController.Instance.SetTelephone(stbPhone.Text);
                    EstateAgentController.Instance.SetEmail(stbEmail.Text);
                    EstateAgentController.Instance.SetStartingDate((DateTime)dafStartDate.GetDateTime());
                    EstateAgentController.Instance.SetTerminationDate((DateTime)dafTerminationDate.GetDateTime());
                    EstateAgentController.Instance.SaveActiveEstateAgent();
                }
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
            fielddataOk &= stbUsername.Validate();
            fielddataOk &= stbPassword.Validate();

            if (fielddataOk && currentEstateAgent == null && !EstateAgentController.Instance.IsUsernameAvailable(stbUsername.Text))
            {
                stbUsername.SetError("Brugernavn allerede i brug");
                fielddataOk = false;
            }

            return fielddataOk;
        }
    }
}
