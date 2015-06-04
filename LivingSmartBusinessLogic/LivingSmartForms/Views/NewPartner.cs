using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LivingSmartBusinessLogic.Controller;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartForms.Views
{
    public partial class NewPartner : UserControl
    {
        private Partner currentPartner;

        public NewPartner(BaseForm baseForm, Partner partner)
        {
            InitializeComponent();

            currentPartner = partner;
            int timeIndex = 0;
            var timezones = TimeZoneInfo.GetSystemTimeZones();

            int indexCount = 0;
            foreach (var timezone in timezones)
            {
                cboTimezone.Items.Add(timezone);

                if (partner.Timezone == timezone.Id)
                    timeIndex = indexCount;

                indexCount++;
            }

            if (currentPartner != null)
            {
                stbName.Text = partner.Name;
                stbCity.Text = partner.City;
                stbRegion.Text = partner.Region;
                stbRegionShort.Text = partner.RegionShort;
                stbCountry.Text = partner.Country;
                stbPhone.Text = partner.Telephone;
                stbEmail.Text = partner.Email;
                cboTimezone.SelectedIndex = timeIndex;
            }
        }

        public bool Save()
        {
            bool fielddataOk = ValidateFields();
            if (fielddataOk)
            {
                if (currentPartner == null)
                {
                    PartnerController.Instance.MakeNewPartner(stbName.Text, stbPhone.Text, stbEmail.Text,
                        stbCountry.Text, stbCity.Text, stbRegion.Text, stbRegionShort.Text,
                        ((TimeZoneInfo)cboTimezone.SelectedItem).Id);
                    PartnerController.Instance.SaveActivePartner();
                }
                else
                {
                    PartnerController.Instance.SetActivePartner(currentPartner);
                    PartnerController.Instance.SetName(currentPartner, stbName.Text);
                    PartnerController.Instance.SetCity(currentPartner, stbCity.Text);
                    PartnerController.Instance.SetRegion(currentPartner, stbRegion.Text);
                    PartnerController.Instance.SetRegionShort(currentPartner, stbRegionShort.Text);
                    PartnerController.Instance.SetCountry(currentPartner, stbCountry.Text);
                    PartnerController.Instance.SetTelephone(currentPartner, stbPhone.Text);
                    PartnerController.Instance.SetEmail(currentPartner, stbEmail.Text);
                    PartnerController.Instance.SetTimeZone(currentPartner, ((TimeZoneInfo)cboTimezone.SelectedItem).Id);
                    PartnerController.Instance.SaveActivePartner();
                }
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
