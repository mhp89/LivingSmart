using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivingSmartForms.Classes;
using LivingSmartForms.Views;

namespace LivingSmartForms.DropIns
{
	public partial class NewEstateAgentDropIn : BaseDropIn
	{
		private NewEstateAgent newEstateAgentForm;

		public NewEstateAgentDropIn(BaseForm baseForm) : base(baseForm)
		{
			InitializeComponent();

			newEstateAgentForm = new NewEstateAgent(baseForm);
			newEstateAgentForm.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
			newEstateAgentForm.Location = new Point(10, 10);
			pnlContentHolder.Controls.Add(newEstateAgentForm);
		}
		public override string GetDropInId()
		{
			return "NewEstateAgent";
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (newEstateAgentForm.Save())
			{
				//Customer saved
				Close();
			}
		}
	}
}
