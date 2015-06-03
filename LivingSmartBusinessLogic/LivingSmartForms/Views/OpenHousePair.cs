using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivingSmartBusinessLogic;
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.Pages;

namespace LivingSmartForms.Views
{
    public partial class OpenHousePair : UserControl
    {
        public EstateAgent EstateAgent { get; private set; }
        public List<Case> Properties { get; private set; }

        public OpenHousePair(EstateAgent agent, List<Case> cases)
        {
            EstateAgent = agent;
            Properties = cases;
            InitializeComponent();
        }

        private void UpdateFields()
        {
            lblEstateAgentTitle.Text = EstateAgent.Name;

        }

        private void UpdateList()
        {
            clsProperties.SuspendLayout();

            clsProperties.ClearList();
            foreach (var property in Properties)
            {
                var control = new OpenHouseProperty(property);
                control.Margin = Padding.Empty;
                clsProperties.AddControl(control, true);
            }

            clsProperties.ResumeLayout();
        }
    }
}
