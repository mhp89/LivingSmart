using System.Collections.Generic;
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
				PartnerController.Instance.MakeNewPartner(stbName.Text, stbPhone.Text, stbEmail.Text, stbCountry.Text, stbCity.Text, stbRegion.Text, stbRegionShort.Text, stbTimeZone.Text);
				PartnerController.Instance.SaveActivePartner();
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
