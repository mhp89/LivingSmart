using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartControls;
using LivingSmartBusinessLogic;
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.DropIns;

namespace LivingSmartForms.Views
{
    public partial class PropertyLineSelect : UserControl
    {
        private SelectPropertyDropIn dropIn;
        private Case property;
        public bool Selected { get; private set; }

        public PropertyLineSelect(SelectPropertyDropIn dropIn, Case property)
        {
            this.property = property;
            this.dropIn = dropIn;
            InitializeComponent();

            UpdateFields();

            BindEvent(this);
        }

        private void BindEvent(Control parent)
        {
            parent.Click += Select;

            foreach (Control control in parent.Controls)
                BindEvent(control);
        }

        private void UpdateFields()
        {
            slbPropertyAddress.Text = property.Address + ", " + property.ZipCode + " " + property.City;
        }

        private void Select(object sender, EventArgs e)
        {
            Selected = !Selected;
            BackColor = (Selected) ? SmartColor.DarkA10 : default(Color);
        }
    }
}
