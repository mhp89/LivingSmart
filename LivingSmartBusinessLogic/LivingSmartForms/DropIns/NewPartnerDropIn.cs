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
	public partial class NewPartnerDropIn : BaseDropIn
	{
		private NewPartner newPartnerForm;

		public NewPartnerDropIn(BaseForm baseForm) : base(baseForm)
		{
			InitializeComponent();

			newPartnerForm = new NewPartner(baseForm);
			newPartnerForm.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
			newPartnerForm.Location = new Point(10, 10);
			pnlContentHolder.Controls.Add(newPartnerForm);
		}
		public override string GetDropInId()
		{
			return "NewPartner";
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (newPartnerForm.Save())
			{
				//Partner saved
				Close();
			}
		}
	}
}
