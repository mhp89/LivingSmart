using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class CaseController
    {
        private CaseCatalog caseCatalog;
        public void AddCase(Case newCase)
        {
            caseCatalog.AddToCatalog(newCase);
        }

        public Case MakeNewCase()
        {
            return new Case();
        }

        public Case ReadCase(int id)
        {
            return caseCatalog.Check(id);
        }

        public void UpdateCase(Case cCase)
        {
            caseCatalog.Save(cCase);
        }

        public void RateProperty()
        {
            
        }

        public void ConnectDocumentToCase(Case cCase, Document document)
        {
            cCase.AddDocument(document);
        }

        public void ConnectPictureToCase(Case cCase, Picture picture)
        {
            cCase.AddPicture(picture);
        }

        public void ConnectAdToCase(Case cCase, Ad ad)
        {
            cCase.AddAd(ad);
        }

        public void ConnectRatingToCase(Case cCase, Rating rating)
        {
            cCase.AddRating(rating);
        }

        public void ConnectAskingPriceToCase(Case cCase, AskingPrice askingPrice)
        {
            cCase.AddAskingPrice(askingPrice);
        }

        public void
    }
}
