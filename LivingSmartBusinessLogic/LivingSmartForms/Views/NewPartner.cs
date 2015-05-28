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

namespace LivingSmartForms.Views
{
    public partial class NewPartner : UserControl
    {
		public NewPartner(BaseForm baseForm)
        {
            InitializeComponent();
        }

		public bool Save()
		{
			bool fielddataOk = ValidateFields();
			if (fielddataOk)
			{
				var partner = PartnerController.Instance.MakeNewPartner();
				PartnerController.Instance.SetName(partner, stbName.Text);
				PartnerController.Instance.SetCity(partner, stbCity.Text);
				PartnerController.Instance.SetRegionShort(partner, stbRegionShort.Text);
				PartnerController.Instance.SetCountry(partner, stbCountry.Text);
				PartnerController.Instance.SetTelephone(partner, stbPhone.Text);
				PartnerController.Instance.SetEmail(partner, stbEmail.Text);
				PartnerController.Instance.AddPartner(partner);
			}
			return fielddataOk;
		}

		private bool ValidateFields()
		{
			bool fielddataOk = true;

			fielddataOk &= stbName.Validate();
			fielddataOk &= stbCity.Validate();
			fielddataOk &= stbRegionShort.Validate();
			fielddataOk &= stbCountry.Validate();
			fielddataOk &= stbPhone.Validate();
			fielddataOk &= stbEmail.Validate();
			
			return fielddataOk;
		}
    }
}
