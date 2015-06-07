using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivingSmartBusinessLogic.Controller;
using LivingSmartBusinessLogic.Entity;
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.Classes;
using LivingSmartForms.DropIns;
using LivingSmartForms.Views;

namespace LivingSmartForms.DropIns
{
    public partial class SelectEstateAgentDropIn : BaseDropIn
    {
        private EstateAgentSelectCallback callback;

        public delegate void EstateAgentSelectCallback(List<EstateAgent> agents);

        public SelectEstateAgentDropIn(BaseForm baseForm, EstateAgentSelectCallback callback) : base(baseForm)
        {
            this.callback = callback;
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            List<EstateAgent> agents = new List<EstateAgent>();

            foreach (var control in clsAllEstateAgents.Controls)
            {
                var lineObject = (EstateAgentLineSelect)control;
                if (lineObject.Selected == true)
                    agents.Add(lineObject.EstateAgent);
            }

            callback(agents);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
