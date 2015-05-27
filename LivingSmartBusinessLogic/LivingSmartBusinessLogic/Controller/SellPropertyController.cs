namespace LivingSmartBusinessLogic.Controller
{
    public class SellPropertyController
	{
		#region Singleton

		private static SellPropertyController _instance;
		public static SellPropertyController Instance
		{
			get { return _instance ?? (_instance = new SellPropertyController()); }
		}

		#endregion
    }
}
