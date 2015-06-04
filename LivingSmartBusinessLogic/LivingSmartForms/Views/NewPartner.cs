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

            var timezones = TimeZoneInfo.GetSystemTimeZones();

            foreach (var timezone in timezones)
                cboTimezone.Items.Add(timezone);

            cboTimezone.DisplayMember = "DisplayName";

            if (currentPartner != null)
            {
                stbName.Text = partner.Name;
                stbCity.Text = partner.City;
                stbRegion.Text = partner.Region;
                stbRegionShort.Text = partner.RegionShort;
                stbCountry.Text = partner.Country;
                stbPhone.Text = partner.Telephone;
                stbEmail.Text = partner.Email;
                cboTimezone.DisplayMember = "foo";
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
                        ((TimeZoneInfo) cboTimezone.SelectedItem).StandardName);
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
                    // PartnerController.Instance.SetTimeZone(currentPartner, stbName.Text);
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
