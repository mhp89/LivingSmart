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
    public partial class OpenHouseProperty : UserControl
    {
        public Case Property { get; private set; }

        public OpenHouseProperty(Case property)
        {
            Property = property;
            InitializeComponent();
        }

        private void UpdateFields()
        {
            lblAddress.Text = Property.Address;
            lblZipCode.Text = Property.ZipCode + " " + Property.City;
        }
    }
}
