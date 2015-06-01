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

namespace LivingSmartForms.Views
{
    public partial class PartnerLine : UserControl
    {
		private Partner partner;

		public PartnerLine(BaseForm baseForm, Partner partner)
        {
			this.partner = partner;
            InitializeComponent();

	        UpdateFields();
        }

	    private void UpdateFields()
	    {
		    slbParterName.Text = partner.Name;
		    slbPartnerAddress.Text = partner.City+", "+partner.Country;
		    slbPartnerPhone.Text = partner.Telephone;
		    slbPartnerEmail.Text = partner.Email;
	    }
    }
}
