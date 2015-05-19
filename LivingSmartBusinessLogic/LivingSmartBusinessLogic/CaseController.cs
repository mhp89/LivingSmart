using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class CaseController
    {
        private CaseCatalog caseCatalog;

        public CaseController()
        {
            caseCatalog = new CaseCatalog();
        }
        /// <summary>
        /// Tilføjer en case til casecatalog
        /// </summary>
        /// <param name="newCase"></param>
        public void AddCase(Case newCase)
        {
            caseCatalog.AddToCatalog(newCase);
        }

        /// <summary>
        /// Laver en ny case
        /// </summary>
        /// <returns></returns>
        public Case MakeNewCase()
        {
            return new Case();
        }

        /// <summary>
        /// Læser en given fil fra casecatalog
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Case ReadCase(int id)
        {
            return caseCatalog.Check(id);
        }

        /// <summary>
        /// Opdaterer en case på casecataloget
        /// </summary>
        /// <param name="cCase"></param>
        public void UpdateCase(Case cCase)
        {
            caseCatalog.Save(cCase);
        }

        /// <summary>
        /// Laver en ny vurdering ud fra en given case
        /// </summary>
        /// <param name="cCase"></param>
        /// <returns></returns>
        public Rating RateProperty(Case cCase)
        {
            return new Rating(cCase);
        }
        
        /// <summary>
        /// Tilføjer et dokument til casen
        /// </summary>
        /// <param name="cCase"></param>
        /// <param name="document"></param>
        public void AddDocumentToCase(Case cCase, Document document)
        {
            cCase.AddDocument(document);
        }

        /// <summary>
        /// Fjerner et dokument fra casen
        /// </summary>
        public void RemoveDocumentFromCase()
        {
            
        }

        /// <summary>
        /// Tilføjer et billede til casen
        /// </summary>
        /// <param name="cCase"></param>
        /// <param name="picture"></param>
        public void AddPictureToCase(Case cCase, Picture picture)
        {
            cCase.AddPicture(picture);
        }

        /// <summary>
        /// Fjerner et billede fra casen
        /// </summary>
        public void RemovePictureFromCase()
        {
            
        }

        /// <summary>
        /// Tilføjer en annonce til casen
        /// </summary>
        /// <param name="cCase"></param>
        /// <param name="ad"></param>
        public void AddAdToCase(Case cCase, Ad ad)
        {
            cCase.AddAd(ad);
        }

        /// <summary>
        /// Fjerner en annonce fra casen
        /// </summary>
        public void RemoveAdFromCase()
        {
            
        }

        /// <summary>
        /// Tilføjer en vurdering til casen
        /// </summary>
        /// <param name="cCase"></param>
        /// <param name="rating"></param>
        public void AddRatingToCase(Case cCase, Rating rating)
        {
            cCase.AddRating(rating);
        }

        /// <summary>
        /// Fjerner en vurdering fra casen
        /// </summary>
        public void RemoveRatingFromCase()
        {
            
        }

        /// <summary>
        /// Tilføjer en udbudspris til casen
        /// </summary>
        /// <param name="cCase"></param>
        /// <param name="askingPrice"></param>
        public void AddAskingPriceToCase(Case cCase, AskingPrice askingPrice)
        {
            cCase.AddAskingPrice(askingPrice);
        }

        /// <summary>
        /// Fjerner en udbudspris fra casen
        /// </summary>
        public void RemoveAskingPriceFromCase()
        {
            
        }

        /// <summary>
        /// Tilføjer en potentiel køber til casen
        /// </summary>
        /// <param name="cCase"></param>
        /// <param name="potentialBuyer"></param>
        public void AddPotentialBuyerToCase(Case cCase, PotentialBuyer potentialBuyer)
        {
            cCase.AddPotentialBuyer(potentialBuyer);
        }

        /// <summary>
        /// Fjerner en potentiel køber fra casen
        /// </summary>
        /// <param name="cCase"></param>
        /// <param name="potentialBuyer"></param>
        public void RemoveProtentialBuyerFromCase(Case cCase, PotentialBuyer potentialBuyer)
        {
            
        }

        /// <summary>
        /// Tilføjer en "Afstand til" til casen
        /// </summary>
        /// <param name="cCase"></param>
        /// <param name="distanceTo"></param>
        public void AddDistanceToCase(Case cCase, DistanceTo distanceTo)
        {
            cCase.AddDistanceTo(distanceTo);
        }

        /// <summary>
        /// Fjerner en "Afstand til" fra casen
        /// </summary>
        public void RemoveDistanceToFromCase()
        {
            
        }

        /// <summary>
        /// Tilføjer salgsprisen til casen
        /// </summary>
        public void AddSellingPriceToCase(Case cCase, long sellingPrice)
        {
            cCase.SellingPrice = sellingPrice;
        }
    }
}
