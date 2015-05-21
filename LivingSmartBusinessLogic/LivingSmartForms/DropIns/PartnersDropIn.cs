using LivingSmartBusinessLogic;
using LivingSmartForms.Classes;
using LivingSmartForms.Views;

namespace LivingSmartForms.DropIns
{
	public partial class PartnersDropIn : BaseDropIn
	{
		public PartnersDropIn(BaseForm baseForm) : base(baseForm)
		{
			InitializeComponent();

			var partner = new Partner
			{
				Name = "Newyorker Houses",
				City = "New York City",
				RegionShort = "NY",
				Telephone = "+1 917-710-045",
				Email = "contact@NYHouses.com",
				Timezone = "Eastern Standard Time"
			};

			clsPartners.AddControl(new PartnerView(partner));

			partner = new Partner
			{
				Name = "Hawao Houses",
				City = "Hawaii",
				RegionShort = "NY",
				Telephone = "+1 917-710-045",
				Email = "contact@NYHouses.com",
				Timezone = "Hawaiian Standard Time"
			};

			clsPartners.AddControl(new PartnerView(partner));
		}
	}
}
