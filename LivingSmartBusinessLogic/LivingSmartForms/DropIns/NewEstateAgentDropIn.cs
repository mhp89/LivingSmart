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

namespace LivingSmartForms.DropIns
{
	public partial class NewEstateAgentDropIn : BaseDropIn
	{
		private NewEstateAgent newEstateAgentForm;

		private NewEstateAgentFinish callback;
		public delegate void NewEstateAgentFinish(EstateAgent customer);

		public NewEstateAgentDropIn(BaseForm baseForm, NewEstateAgentFinish callback) : base(baseForm)
		{
			InitializeComponent();

			this.callback = callback;

			newEstateAgentForm = new NewEstateAgent(baseForm);
			newEstateAgentForm.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
			newEstateAgentForm.Location = new Point(10, 10);
			pnlContentHolder.Controls.Add(newEstateAgentForm);
		}
		public override string GetDropInId()
		{
			return "NewEstateAgent";
		}
		private void FinishCreating(EstateAgent estateAgent)
		{
			EstateAgentController.Instance.CancelActiveEstateAgent();
			callback(estateAgent);
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			FinishCreating(null);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (newEstateAgentForm.Save())
			{
				//Customer saved
				FinishCreating(newEstateAgentForm.CreatedEstateAgent);
			}
		}
	}
}
