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
    public partial class CaseLineSimple : UserControl
    {
	    private Case cCase;
		public CaseLineSimple(BaseForm baseForm, Case cCase)
		{
			this.cCase = cCase;

            InitializeComponent();

			UpdateFields();
		}
		private void UpdateFields()
		{
			slbCaseNo.Text = cCase.Id.ToString();
			slbSeller.Text = cCase.Seller.Name;
			slbStatus.Text = cCase.Status;
			slbProperty.Text = cCase.Address+", "+cCase.City.District;
			slbPropertyType.Text = cCase.PropertyType.Description;
			slbPrice.Text = cCase.NewestAskingPrice.ToString();
			slbPriceTrend.Text = cCase.PriceTrend+" %";
		}
    }
}
