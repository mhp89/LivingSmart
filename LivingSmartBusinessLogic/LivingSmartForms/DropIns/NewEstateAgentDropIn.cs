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
using LivingSmartBusinessLogic.Entity;
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.Classes;
using LivingSmartForms.Views;

namespace LivingSmartForms.DropIns
{
    public partial class NewEstateAgentDropIn : BaseDropIn
    {
        private NewEstateAgent newEstateAgentForm;
        private NewEstateAgentFinish callback;
        private EstateAgent currentEstateAgent;

        public delegate void NewEstateAgentFinish(EstateAgent customer);

        public NewEstateAgentDropIn(BaseForm baseForm, EstateAgent estateAgent, NewEstateAgentFinish callback)
            : base(baseForm)
        {
            InitializeComponent();

            this.currentEstateAgent = estateAgent;
            this.callback = callback;

            if (currentEstateAgent != null)
            {
                btnSave.Text = @"Gem";
                lblNewEstateAgent.Text = @"Redigér ejendomsmægler";
            }

            newEstateAgentForm = new NewEstateAgent(baseForm, estateAgent);
            newEstateAgentForm.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            newEstateAgentForm.Location = new Point(10, 10);
            pnlContentHolder.Controls.Add(newEstateAgentForm);
        }
        public override string GetDropInId()
        {
            return "NewEstateAgent";
        }
        private void FinishCreating(EstateAgent estateAgent)
        {
            EstateAgentController.Instance.CancelActiveEstateAgent();
            if (callback != null)
                callback(estateAgent);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (newEstateAgentForm.Save())
            {
                //Customer saved
                FinishCreating(newEstateAgentForm.CurrentEstateAgent);
            }
        }
    }
}
