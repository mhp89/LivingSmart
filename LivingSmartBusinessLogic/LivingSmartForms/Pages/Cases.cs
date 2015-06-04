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
using LivingSmartForms.DropIns;
using LivingSmartForms.Views;

namespace LivingSmartForms.Pages
{
	public partial class Cases : BasePage
	{
		public Cases(BaseForm baseForm) : base(baseForm)
		{
			InitializeComponent();
		}

		private void UpdateList()
		{
			clsCases.SuspendLayout();

			clsCases.ClearList();
			var cases = CaseController.Instance.GetOpenCases();
			foreach (var cCase in cases)
			{
				var control = new CaseLineSimple(baseForm, cCase);
				control.Margin = Padding.Empty;
				clsCases.AddControl(control, true);
			}
			sblActiveCases.Text = cases.Count.ToString();

			clsCases.ResumeLayout();
		}

		public override void OnShow()
		{
			UpdateList();
		}

		private void btnNewCase_Click(object sender, EventArgs e)
		{
			baseForm.ShowDropIn(new NewCaseDropIn(baseForm));
		}

        private void btnArrangeOpenHouse_Click(object sender, EventArgs e)
        {

        }
	}
}
