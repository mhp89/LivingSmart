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
			var partner = controller.MakeNewPartner();
			controller.SetName(partner, "Newyorker Houses");
			controller.SetCity(partner, "New York City");
			controller.SetRegionShort(partner, "NY");
			controller.SetTelephone(partner, "+1 917-710-045");
			controller.SetEmail(partner, "contact@NYHouses.com");
			controller.SetTimeZone(partner, "Eastern Standard Time");

			clsPartners.AddControl(new PartnerView(partner));

			partner = controller.MakeNewPartner();
			controller.SetName(partner, "Hawaoo Houses");
			controller.SetCity(partner, "Hawaii");
			controller.SetRegionShort(partner, "NY");
			controller.SetTelephone(partner, "+1 917-710-045");
			controller.SetEmail(partner, "contact@Hawaoo.com");
			controller.SetTimeZone(partner, "Hawaiian Standard Time");

			clsPartners.AddControl(new PartnerView(partner));

			HideCloseButton();
		}
	}
}
