using System.Windows.Forms;
using LivingSmartBusinessLogic;
using LivingSmartBusinessLogic.Controller;
using LivingSmartForms.Classes;
using LivingSmartForms.Views;

namespace LivingSmartForms.DropIns
{
	public partial class PartnersDropIn : BaseDropIn
	{
		public PartnersDropIn(BaseForm baseForm) : base(baseForm)
		{
			InitializeComponent();

			PartnerController controller = new PartnerController();
			var partner = controller.MakeNewPartner("Newyorker Houses", "+1 917-710-045", "contact@NYHouses.com", "USA", "New York City", "New York", "NY", "Eastern Standard Time");
			controller.AddPartner(partner);
			clsPartners.AddControl(new PartnerView(partner){Margin = new Padding(0)});

			partner = controller.MakeNewPartner("Hawaoo Houses", "+1 917-710-045", "contact@Hawaoo.com", "USA", "Hawaii", "Hawaii", "HI", "Hawaiian Standard Time");

			clsPartners.AddControl(new PartnerView(partner) { Margin = new Padding(0) });

			HideCloseButton();
		}
	}
}
