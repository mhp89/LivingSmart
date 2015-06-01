using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic
{
    class AskingPriceCatalog
    {
        private Dictionary<int, List<AskingPrice>> askingPriceDictionary;

        internal AskingPriceCatalog()
        {
            askingPriceDictionary = new Dictionary<int, List<AskingPrice>>();
        }

        internal AskingPrice Check(int id)
        {
            throw new NotImplementedException();
        }

        internal void Save(AskingPrice askingPrice)
		{
			//if (askingPrice.Id == -1)
				//Create
			//else
				//Update
        }

        internal void AddToCatalog(int caseId, AskingPrice askingPrice)
        {
            if (!askingPriceDictionary.ContainsKey(caseId))
                askingPriceDictionary.Add(caseId, new List<AskingPrice>());
            askingPriceDictionary[caseId].Add(askingPrice);
        }

        internal void RemoveFromCatalog(int caseId, AskingPrice askingPrice)
        {
            askingPriceDictionary[caseId].Remove(askingPrice);
        }

        internal ReadOnlyCollection<AskingPrice> GetAskingPrices(int caseId)
        {
            return askingPriceDictionary[caseId].AsReadOnly();
        }
    }
}
