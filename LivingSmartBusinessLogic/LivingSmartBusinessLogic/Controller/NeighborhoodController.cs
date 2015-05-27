namespace LivingSmartBusinessLogic.Controller
{
    class NeighborhoodController
	{
		#region Singleton

		private NeighborhoodController _instance;
		public NeighborhoodController Instance
		{
			get { return _instance ?? (_instance = new NeighborhoodController()); }
		}

		#endregion


    }
}
