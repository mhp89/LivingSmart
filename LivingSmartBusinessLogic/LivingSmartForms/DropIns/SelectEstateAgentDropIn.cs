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

namespace LivingSmartForms.DropIns
{
    public partial class SelectEstateAgentDropIn : BaseDropIn
    {
        public SelectEstateAgentDropIn(BaseForm baseForm) : base(baseForm)
        {
            InitializeComponent();

            UpdateList();
        }

        public override string GetDropInId()
        {
            return "SelectEstateAgent";
        }

        private void UpdateList()
        {
            clsAllEstateAgents.SuspendLayout();

            clsAllEstateAgents.ClearList();
            var estateAgents = EstateAgentController.Instance.GetEstateAgents();
            foreach (var estateAgent in estateAgents)
            {
                var control = new EstateAgentLineSelect(this, estateAgent);
                control.Margin = Padding.Empty;
                clsAllEstateAgents.AddControl(control, true);
            }

            clsAllEstateAgents.ResumeLayout();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
