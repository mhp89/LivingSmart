using System;
using System.Collections.Generic;

namespace LivingSmartBusinessLogic.Controller
{
    public class EstateAgentController
	{
		#region Singleton

		private EstateAgentController _instance;
		public EstateAgentController Instance
		{
			get { return _instance ?? (_instance = new EstateAgentController()); }
		}

		#endregion


        private EstateAgentCatalog estateAgentCatalog;

        private EstateAgent activeEstateAgent;

        public EstateAgentController()
        {
            estateAgentCatalog = new EstateAgentCatalog();
        }

        #region Methods
        
        public void AddEstateAgent(EstateAgent estateAgent)
        {
            estateAgentCatalog.AddToCatalog(estateAgent);
        }

        public EstateAgent MakeNewEstateAgent()
        {
            return new EstateAgent();
        }

        public EstateAgent ReadEstateAgent(int id)
        {
            return estateAgentCatalog.Check(id);
        }

        public void UpdateEstateAgent(EstateAgent estateAgent)
        {
            estateAgentCatalog.Save(estateAgent);
        }

        public void SetName(EstateAgent estateAgent, string name)
        {
            if (estateAgent.Name != name)
                estateAgent.Name = name;
        }

        public void SetTelephone(EstateAgent estateAgent, string telephone)
        {
            if (estateAgent.Telephone != telephone)
                estateAgent.Telephone = telephone;
        }

        public void SetEmail(EstateAgent estateAgent, string email)
        {
            if (estateAgent.Email != email)
                estateAgent.Email = email;
        }

        public void SetStartingDate(EstateAgent estateAgent, DateTime startingDate)
        {
            if (estateAgent.StartingDate != startingDate)
                estateAgent.StartingDate = startingDate;
        }

        public void SetTerminationDate(EstateAgent estateAgent, DateTime startingDate)
        {
            if (estateAgent.TerminationDate != startingDate)
                estateAgent.TerminationDate = startingDate;
        }

		public List<EstateAgent> SearchEstateAgents(int id, string name, string telephone, string email)
		{
			return estateAgentCatalog.SearchEstateAgents(id, name, telephone, email);
		}
        #endregion
    }
}
