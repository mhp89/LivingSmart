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
using LivingSmartBusinessLogic.Entity;
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.DropIns;

namespace LivingSmartForms.Views
{
    public partial class PartnerLine : UserControl
    {
		private Partner partner;
        private BaseForm baseForm;

		public PartnerLine(BaseForm baseForm, Partner partner)
        {
			this.partner = partner;
		    this.baseForm = baseForm;

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

        private void btnEditPartner_Click(object sender, EventArgs e)
        {
            baseForm.ShowDropIn(new NewPartnerDropIn(baseForm, partner, UpdateFields));
        }
    }
}
