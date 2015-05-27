namespace LivingSmartBusinessLogic.Controller
{
    class NeighborhoodController
	{
		#region Singleton

		private static NeighborhoodController _instance;
		public static NeighborhoodController Instance
		{
			get { return _instance ?? (_instance = new NeighborhoodController()); }
		}

		#endregion


    }
}
