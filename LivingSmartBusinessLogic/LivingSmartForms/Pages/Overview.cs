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
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.Classes;
using LivingSmartForms.Views;

namespace LivingSmartForms.Pages
{
    /// <summary>
    /// 
    /// </summary>
    /// <author>Mathias Petersen</author>
	public partial class Overview : BasePage
	{
		public Overview(BaseForm baseForm) : base(baseForm)
		{
			InitializeComponent();
            lblAgentName.Text = baseForm.DefaultEstateAgent.Name;
		}

		public override void OnShow()
		{
			base.OnShow();

			UpdateCaseList();
            GetDialInfo();
		}

		private void UpdateCaseList()
		{
			clsActiveCases.SuspendLayout();

			clsActiveCases.ClearList();
			var cases = CaseController.Instance.GetOpenCases(baseForm.DefaultEstateAgent.Id);
			foreach (var cCase in cases)
			{
				var control = new CaseLineSimple(baseForm, cCase);
				control.Margin = Padding.Empty;
				clsActiveCases.AddControl(control, true);
			}

			clsActiveCases.ResumeLayout();
		}

        /// <summary>
        /// Henter information fra databasen på solgte huse i år og sidste år
        /// Øger sidste års tal med 5% og sætter det til målet og sender info til labels og viserne
        /// </summary>
        /// <author>Maja Olesen</author>
        private void GetDialInfo()
        {
            Statistics newStats = StatisticsController.Instance.ReadThisYearStatistics();
            Statistics oldStats = StatisticsController.Instance.ReadLastYearStatistics();

            lblCountValue.Text = newStats.PropertiesTotal + " af " + (int)(oldStats.PropertiesTotal * 1.05);
            lblPriceValue.Text = "kr " + (newStats.SellingpriceTotal/1000000).ToString("n2") + " mio af " +
                                 (oldStats.SellingpriceTotal/1000000 * 1.05).ToString("n2") + " mio";

            mtrCount.MaxValue = (int)(oldStats.PropertiesTotal * 1.05);
            mtrCount.Value = newStats.PropertiesTotal;

            mtrPrice.MaxValue = (int)(oldStats.SellingpriceTotal * 1.05);
            mtrPrice.Value = (int)newStats.SellingpriceTotal;
        }
	}
}
