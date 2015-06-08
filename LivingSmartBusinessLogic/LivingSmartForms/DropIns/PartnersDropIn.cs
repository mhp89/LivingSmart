using System.Windows.Forms;
using LivingSmartBusinessLogic;
using LivingSmartBusinessLogic.Controller;
using LivingSmartForms.Classes;
using LivingSmartForms.Views;

namespace LivingSmartForms.DropIns
{
	/// <summary>
	/// Oversigt over samarbejdspartnere
	/// </summary>
	/// <author>Mathias Petersen</author>
	public partial class PartnersDropIn : BaseDropIn
	{
		public PartnersDropIn(BaseForm baseForm) : base(baseForm)
		{
			InitializeComponent();

			UpdateList();

			HideCloseButton();
		}

		private void UpdateList()
		{
			var partners = PartnerController.Instance.GetPartners();

			clsPartners.SuspendLayout();

			clsPartners.ClearList();

			foreach (var partner in partners)
				clsPartners.AddControl(new PartnerView(partner));

			clsPartners.ResumeLayout();

		}
	}
}
