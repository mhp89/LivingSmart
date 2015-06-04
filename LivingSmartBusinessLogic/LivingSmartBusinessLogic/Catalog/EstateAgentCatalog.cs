using System.Collections.Generic;
using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.DB;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Catalog
{
    internal class EstateAgentCatalog
    {
        private Dictionary<int, EstateAgent> estateAgents;

        private IEstateAgentDB db;

        internal EstateAgentCatalog()
        {
            db = EstateAgentDBFactory.GetDBL();
            estateAgents = new Dictionary<int, EstateAgent>();

            LoadCatalog();
        }

        internal void LoadCatalog()
        {
            var estateAgentList = db.ReadEstateAgents();
            foreach (var estateAgent in estateAgentList)
                AddToCatalog(estateAgent);
        }

        internal EstateAgent Read(int id)
        {
            return GetEstateAgent(id);
        }

        internal void Save(EstateAgent estateAgent)
        {
            if (estateAgent.Id == -1)
                estateAgent.Id = db.CreateEstateAgent(estateAgent);
            else
                db.UpdateEstateAgent(estateAgent);
        }

        internal void AddToCatalog(EstateAgent estateAgent)
        {
            if (!estateAgents.ContainsKey(estateAgent.Id))
                estateAgents.Add(estateAgent.Id, estateAgent);
        }

        internal void RemoveFromCatalog(EstateAgent estateAgent)
        {
            if (estateAgents.ContainsKey(estateAgent.Id))
                estateAgents.Remove(estateAgent.Id);
        }


        internal ReadOnlyCollection<EstateAgent> GetEstateAgents()
        {
            var estateAgentList = new List<EstateAgent>();
            estateAgentList.AddRange(estateAgents.Values);
            return estateAgentList.AsReadOnly();
        }

        internal EstateAgent GetEstateAgent(int estateAgentId)
        {
            if (estateAgents.ContainsKey(estateAgentId))
            {
                return estateAgents[estateAgentId];
            }
            return null;
        }

        internal List<EstateAgent> SearchEstateAgents(int id, string name, string telephone, string email)
        {
            List<EstateAgent> result = new List<EstateAgent>();

            foreach (var estateAgent in estateAgents)
            {
                bool success = true;

                if (id != -1 && !estateAgent.Value.Id.ToString().ToLower().Contains(id.ToString().ToLower()))
                    success = false;

                if (name != null && !estateAgent.Value.Name.ToLower().Contains(name.ToLower()))
                    success = false;

                if (telephone != null && !estateAgent.Value.Telephone.ToLower().Contains(telephone.ToLower()))
                    success = false;

                if (email != null && !estateAgent.Value.Email.ToLower().Contains(email.ToLower()))
                    success = false;

                if (success)
                    result.Add(estateAgent.Value);
            }

            return result;
        }

        internal EstateAgent LoginEstateAgent(string username, string password)
        {
            return db.LoginEstateAgent(username, password);
        }

        internal bool IsUsernameAvailable(string username)
        {
            var estateAgentlist = GetEstateAgents();

            for (int i = 0; i <= estateAgentlist.Count - 1; i++)
            {
                if (estateAgentlist[i].Username == username)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
