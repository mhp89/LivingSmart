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

            //EstateAgentController.Instance.
            for (int i = 0; i < 10; i++)
            {
                var control = new EstateAgentLineSelect();
                control.Margin = Padding.Empty;
                clsAllEstateAgents.AddControl(control);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
