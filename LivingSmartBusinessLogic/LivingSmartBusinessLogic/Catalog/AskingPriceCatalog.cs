using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.DB;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Catalog
{
    internal class AskingPriceCatalog
    {
        private Dictionary<int, List<AskingPrice>> askingPriceDictionary;
        private IAskingPriceDB db;

        internal AskingPriceCatalog()
        {
            db = AskingPriceDBFactory.GetDBL();
            askingPriceDictionary = new Dictionary<int, List<AskingPrice>>();

            //LoadCatalog();
        }

        //internal void LoadCatalog()
        //{
        //    var askingPriceList = db.ReadAskingPrices();
        //    foreach (var askingPrices in askingPriceList)
        //        foreach (var askingPrice in askingPrices.Value)
        //        {
        //            AddToCatalog(askingPrices.Key, askingPrice);
        //        }
        //}

        internal AskingPrice Check(int id)
        {
            throw new NotImplementedException();
        }

        internal void Save(AskingPrice askingPrice, int caseId)
        {
            if (askingPrice.Id == -1)
                askingPrice.Id = db.CreateAskingPrice(askingPrice, caseId);
            else
                db.UpdateAskingPrice(askingPrice, caseId);
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
