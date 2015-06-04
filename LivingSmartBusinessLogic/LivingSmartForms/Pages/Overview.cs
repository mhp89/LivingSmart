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
using LivingSmartForms.Classes;
using LivingSmartForms.Views;

namespace LivingSmartForms.Pages
{
	public partial class Overview : BasePage
	{
		public Overview(BaseForm baseForm) : base(baseForm)
		{
			InitializeComponent();
		}

		public override void OnShow()
		{
			base.OnShow();

			UpdateCaseList();
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
	}
}
