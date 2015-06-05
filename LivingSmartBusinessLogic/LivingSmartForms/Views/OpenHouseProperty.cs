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
    /// <summary>
    /// 
    /// </summary>
    /// <author>Maja Olesen</author>
    public partial class OpenHouseProperty : UserControl
    {
        public Case Property { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="property"></param>
        public OpenHouseProperty(Case property)
        {
            Property = property;
            InitializeComponent();

            UpdateFields();
        }

        /// <summary>
        /// Opdaterer felterne i controlen
        /// </summary>
        private void UpdateFields()
        {
            lblAddress.Text = Property.Address;
	        lblZipCode.Text = Property.City.NiceDisplay;
            lblPrice.Text = Property.NewestAskingPrice.ToString("c0");
        }
    }
}
