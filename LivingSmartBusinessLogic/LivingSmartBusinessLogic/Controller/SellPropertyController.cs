namespace LivingSmartBusinessLogic.Controller
{
    public class SellPropertyController
	{
		#region Singleton

		private SellPropertyController _instance;
		public SellPropertyController Instance
		{
			get { return _instance ?? (_instance = new SellPropertyController()); }
		}

		#endregion
    }
}
