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
using LivingSmartForms.DropIns;

namespace LivingSmartForms.Views
{
    public partial class CaseLineSimple : UserControl
    {
	    private BaseForm baseForm;

	    private Case cCase;

		public CaseLineSimple(BaseForm baseForm, Case cCase)
		{
			this.baseForm = baseForm;
			this.cCase = cCase;

            InitializeComponent();

			UpdateFields();
		}
		private void UpdateFields()
		{
			slbCaseNo.Text = cCase.Id.ToString();
			slbSeller.Text = cCase.Seller.Name;
            slbStatus.Text = Case.TranslateStatus(cCase.Status);
			slbProperty.Text = cCase.Address+", "+cCase.City.District;
			slbPropertyType.Text = cCase.PropertyType.Description;
			slbPrice.Text = cCase.NewestAskingPrice+" kr.";
			slbPriceTrend.Text = cCase.PriceTrend.ToString("N1")+" %";
		}

		private void btnViewCase_Click(object sender, EventArgs e)
		{
			baseForm.ShowDropIn(new NewCaseDropIn(baseForm, cCase));
		}
    }
}
