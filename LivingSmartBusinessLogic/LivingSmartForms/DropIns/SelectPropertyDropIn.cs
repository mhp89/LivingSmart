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
    public partial class SelectPropertyDropIn : BaseDropIn
    {
        public SelectPropertyDropIn(BaseForm baseForm) : base(baseForm)
        {
            InitializeComponent();

            //CustomerController.Instance.
            for (int i = 0; i < 10; i++)  //Vis alle ejendomme til salg
            {
                var control = new PropertyLineSelect();
                control.Margin = Padding.Empty;
                clsAllProperties.AddControl(control);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
