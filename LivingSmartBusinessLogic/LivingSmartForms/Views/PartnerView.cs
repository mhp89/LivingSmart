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
using LivingSmartBusinessLogic.Model;

namespace LivingSmartForms.Views
{
	public partial class PartnerView : UserControl
	{
		public PartnerView(Partner partner)
		{
			InitializeComponent();

			lnlPartner.Text = partner.Name;
			lblCity.Text = partner.City + ", " + partner.RegionShort;
			lblTelephone.Text = partner.Telephone;
			lblEmail.Text = partner.Email;

			analogClock.Timezone = partner.Timezone;
		}

		public PartnerView()
		{
			InitializeComponent();
		}
	}
}
