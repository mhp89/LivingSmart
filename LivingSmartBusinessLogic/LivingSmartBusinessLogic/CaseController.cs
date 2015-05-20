using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class CaseController
    {
        private CaseCatalog caseCatalog;

        private Case activeCase;

        public CaseController()
        {
            caseCatalog = new CaseCatalog();
        }

        #region Methods

        public void SetActiveCase(Case activeCase)
        {
            this.activeCase = activeCase;
        }

        public void CancelActiveCase()
        {
            activeCase = null;
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
            return activeCase = new Case();
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
        public void RemoveDocumentFromCase(Case cCase, Document document)
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
        public void RemovePictureFromCase(Case cCase, Picture picture)
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
        public void RemoveAdFromCase(Case cCase, Ad ad)
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
        public void RemoveRatingFromCase(Case cCase, Rating rating)
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
        public void RemoveAskingPriceFromCase(Case cCase, AskingPrice askingPrice)
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
        public void RemoveDistanceToFromCase(Case cCase, DistanceTo distanceTo)
        {
            
        }

        /// <summary>
        /// Tilføjer salgsprisen til casen
        /// </summary>
        public void AddSellingPriceToCase(Case cCase, long sellingPrice)
        {
            cCase.SellingPrice = sellingPrice;
        }

        public ReadOnlyCollection<Ad> GetAds(Case cCase)
        {
            return cCase.GetAds();
        }

        public ReadOnlyCollection<PotentialBuyer> GetPotentialBuyers(Case cCase)
        {
            return cCase.GetPotentialBuyers();
        }

        public ReadOnlyCollection<Document> GetDocuments(Case cCase)
        {
            return cCase.GetDocuments();
        }

        public ReadOnlyCollection<Rating> GetRatings(Case cCase)
        {
            return cCase.GetRatings();
        }

        public ReadOnlyCollection<AskingPrice> GetAskingPrices(Case cCase)
        {
            return cCase.GetAskingPrices();
        }

        public ReadOnlyCollection<DistanceTo> GetDistanceTos(Case cCase)
        {
            return cCase.GetDistanceTos();
        }

        public ReadOnlyCollection<Picture> GetPictures(Case cCase)
        {
            return cCase.GetPictures();
        }

        public void Setseller(Customer seller)
        {
            if (activeCase.Seller != seller)
                activeCase.Seller = seller;
        }
        public void Setbuyer(Customer buyer)
        {
            if (activeCase.Buyer != buyer)
                activeCase.Buyer = buyer;
        }
        public void SetestateAgent(EstateAgent estateAgent)
        {
            if (activeCase.EstateAgent != estateAgent)
                activeCase.EstateAgent = estateAgent;
        }
        public void SetcreationDate(DateTime creationDate)
        {
            if (activeCase.CreationDate != creationDate)
                activeCase.CreationDate = creationDate;
        }
        public void Setstatus(string status)
        {
            if (activeCase.Status != status)
                activeCase.Status = status;
        }
        public void SetdateOfSale(DateTime dateOfSale)
        {
            if (activeCase.DateOfSale != dateOfSale)
                activeCase.DateOfSale = dateOfSale;
        }
        public void SettransferDate(DateTime transferDate)
        {
            if (activeCase.TransferDate != transferDate)
                activeCase.TransferDate = transferDate;
        }
        public void SetdateOfCompletion(DateTime dateOfCompletion)
        {
            if (activeCase.DateOfCompletion != dateOfCompletion)
                activeCase.DateOfCompletion = dateOfCompletion;
        }
        public void SetsellingPrice(long sellingPrice)
        {
            if (activeCase.SellingPrice != sellingPrice)
                activeCase.SellingPrice = sellingPrice;
        }
        public void Setdescription(string description)
        {
            if (activeCase.Description != description)
                activeCase.Description = description;
        }
        public void SetlandRegistryNumber(string landRegistryNumber)
        {
            if (activeCase.LandRegistryNumber != landRegistryNumber)
                activeCase.LandRegistryNumber = landRegistryNumber;
        }
        public void Setaddress(string address)
        {
            if (activeCase.Address != address)
                activeCase.Address = address;
        }
        public void Setcity(City city)
        {
            if (activeCase.City != city)
                activeCase.City = city;
        }
        public void SetpropertyType(PropertyType propertyType)
        {
            if (activeCase.PropertyType != propertyType)
                activeCase.PropertyType = propertyType;
        }
        public void SetpublicRating(long publicRating)
        {
            if (activeCase.PublicRating != publicRating)
                activeCase.PublicRating = publicRating;
        }
        public void SetlandValue(long landValue)
        {
            if (activeCase.LandValue != landValue)
                activeCase.LandValue = landValue;
        }
        public void SetgroundArea(int groundArea)
        {
            if (activeCase.GroundArea != groundArea)
                activeCase.GroundArea = groundArea;
        }
        public void SetbuiltArea(int builtArea)
        {
            if (activeCase.BuiltArea != builtArea)
                activeCase.BuiltArea = builtArea;
        }
        public void SetlivingArea(int livingArea)
        {
            if (activeCase.LivingArea != livingArea)
                activeCase.LivingArea = livingArea;
        }
        public void SetbasementArea(int basementArea)
        {
            if (activeCase.BasementArea != basementArea)
                activeCase.BasementArea = basementArea;
        }
        public void SetbuiltYear(int builtYear)
        {
            if (activeCase.BuiltYear != builtYear)
                activeCase.BuiltYear = builtYear;
        }
        public void SetenergyClassification(string energyClassification)
        {
            if (activeCase.EnergyClassification != energyClassification)
                activeCase.EnergyClassification = energyClassification;
        }
        public void Setfloors(int floors)
        {
            if (activeCase.Floors != floors)
                activeCase.Floors = floors;
        }
        public void Setrooms(int rooms)
        {
            if (activeCase.Rooms != rooms)
                activeCase.Rooms = rooms;
        }
        public void Setbedrooms(int bedrooms)
        {
            if (activeCase.Bedrooms != bedrooms)
                activeCase.Bedrooms = bedrooms;
        }
        public void Setbathrooms(int bathrooms)
        {
            if (activeCase.Bathrooms != bathrooms)
                activeCase.Bathrooms = bathrooms;
        }
        public void Settoilets(int toilets)
        {
            if (activeCase.Toilets != toilets)
                activeCase.Toilets = toilets;
        }
        public void SetgarageArea(int garageArea)
        {
            if (activeCase.GarageArea != garageArea)
                activeCase.GarageArea = garageArea;
        }
        public void Setview(int view)
        {
            if (activeCase.View != view)
                activeCase.View = view;
        }
        public void Setneighborhood(Neighborhood neighborhood)
        {
            if (activeCase.Neighborhood != neighborhood)
                activeCase.Neighborhood = neighborhood;
        }

        #endregion
    }
}
