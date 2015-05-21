using System;
using System.Collections.ObjectModel;

namespace LivingSmartBusinessLogic.Controller
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

        public void SaveActiveCase()
        {
            AddCase();
        }
        
        /// <summary>
        /// Tilføjer en case til casecatalog
        /// </summary>
        public void AddCase()
        {
            caseCatalog.AddToCatalog(activeCase);
            UpdateCase();
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
        /// <returns></returns>
        public Case ReadCase()
        {
            return caseCatalog.Check(activeCase.Id);
        }

        /// <summary>
        /// Opdaterer en case på casecataloget
        /// </summary>
        public void UpdateCase()
        {
            caseCatalog.Save(activeCase);
        }

        /// <summary>
        /// Laver en ny vurdering ud fra en given case
        /// </summary>
        /// <returns></returns>
        public Rating RateProperty()
        {
            return new Rating(activeCase);
        }
        
        /// <summary>
        /// Tilføjer et dokument til casen
        /// </summary>
        /// <param name="document"></param>
        public void AddDocumentToCase(Document document)
        {
            activeCase.AddDocument(document);
        }

        /// <summary>
        /// Fjerner et dokument fra casen
        /// </summary>
        public void RemoveDocumentFromCase(Document document)
        {
            
        }

        /// <summary>
        /// Tilføjer et billede til casen
        /// </summary>
        /// <param name="picture"></param>
        public void AddPictureToCase(Picture picture)
        {
            activeCase.AddPicture(picture);
        }

        /// <summary>
        /// Fjerner et billede fra casen
        /// </summary>
        public void RemovePictureFromCase(Picture picture)
        {
            
        }

        /// <summary>
        /// Tilføjer en annonce til casen
        /// </summary>
        /// <param name="ad"></param>
        public void AddAdToCase(Ad ad)
        {
            activeCase.AddAd(ad);
        }

        /// <summary>
        /// Fjerner en annonce fra casen
        /// </summary>
        public void RemoveAdFromCase(Ad ad)
        {
            
        }

        /// <summary>
        /// Tilføjer en vurdering til casen
        /// </summary>
        /// <param name="rating"></param>
        public void AddRatingToCase(Rating rating)
        {
            activeCase.AddRating(rating);
        }

        /// <summary>
        /// Fjerner en vurdering fra casen
        /// </summary>
        public void RemoveRatingFromCase(Rating rating)
        {
            
        }

        /// <summary>
        /// Tilføjer en udbudspris til casen
        /// </summary>
        /// <param name="askingPrice"></param>
        public void AddAskingPriceToCase(AskingPrice askingPrice)
        {
            activeCase.AddAskingPrice(askingPrice);
        }

        /// <summary>
        /// Fjerner en udbudspris fra casen
        /// </summary>
        public void RemoveAskingPriceFromCase(AskingPrice askingPrice)
        {
            
        }

        /// <summary>
        /// Tilføjer en potentiel køber til casen
        /// </summary>
        /// <param name="potentialBuyer"></param>
        public void AddPotentialBuyerToCase(PotentialBuyer potentialBuyer)
        {
            activeCase.AddPotentialBuyer(potentialBuyer);
        }

        /// <summary>
        /// Fjerner en potentiel køber fra casen
        /// </summary>
        /// <param name="potentialBuyer"></param>
        public void RemoveProtentialBuyerFromCase(PotentialBuyer potentialBuyer)
        {
            
        }

        /// <summary>
        /// Tilføjer en "Afstand til" til casen
        /// </summary>
        /// <param name="distanceTo"></param>
        public void AddDistanceToCase(DistanceTo distanceTo)
        {
            activeCase.AddDistanceTo(distanceTo);
        }

        /// <summary>
        /// Fjerner en "Afstand til" fra casen
        /// </summary>
        public void RemoveDistanceToFromCase(DistanceTo distanceTo)
        {
            
        }

        /// <summary>
        /// Tilføjer salgsprisen til casen
        /// </summary>
        public void AddSellingPriceToCase(long sellingPrice)
        {
            activeCase.SellingPrice = sellingPrice;
        }

        public ReadOnlyCollection<Ad> GetAds()
        {
            return activeCase.GetAds();
        }

        public ReadOnlyCollection<PotentialBuyer> GetPotentialBuyers()
        {
            return activeCase.GetPotentialBuyers();
        }

        public ReadOnlyCollection<Document> GetDocuments()
        {
            return activeCase.GetDocuments();
        }

        public ReadOnlyCollection<Rating> GetRatings()
        {
            return activeCase.GetRatings();
        }

        public ReadOnlyCollection<AskingPrice> GetAskingPrices()
        {
            return activeCase.GetAskingPrices();
        }

        public ReadOnlyCollection<DistanceTo> GetDistanceTos()
        {
            return activeCase.GetDistanceTos();
        }

        public ReadOnlyCollection<Picture> GetPictures()
        {
            return activeCase.GetPictures();
        }

        public void SetSeller(Customer seller)
        {
            if (activeCase.Seller != seller)
                activeCase.Seller = seller;
        }
        public void SetBuyer(Customer buyer)
        {
            if (activeCase.Buyer != buyer)
                activeCase.Buyer = buyer;
        }
        public void SetEstateAgent(EstateAgent estateAgent)
        {
            if (activeCase.EstateAgent != estateAgent)
                activeCase.EstateAgent = estateAgent;
        }
        public void SetCreationDate(DateTime creationDate)
        {
            if (activeCase.CreationDate != creationDate)
                activeCase.CreationDate = creationDate;
        }
        public void SetStatus(string status)
        {
            if (activeCase.Status != status)
                activeCase.Status = status;
        }
        public void SetDateOfSale(DateTime dateOfSale)
        {
            if (activeCase.DateOfSale != dateOfSale)
                activeCase.DateOfSale = dateOfSale;
        }
        public void SetTransferDate(DateTime transferDate)
        {
            if (activeCase.TransferDate != transferDate)
                activeCase.TransferDate = transferDate;
        }
        public void SetDateOfCompletion(DateTime dateOfCompletion)
        {
            if (activeCase.DateOfCompletion != dateOfCompletion)
                activeCase.DateOfCompletion = dateOfCompletion;
        }
        public void SetSellingPrice(long sellingPrice)
        {
            if (activeCase.SellingPrice != sellingPrice)
                activeCase.SellingPrice = sellingPrice;
        }
        public void SetDescription(string description)
        {
            if (activeCase.Description != description)
                activeCase.Description = description;
        }
        public void SetLandRegistryNumber(string landRegistryNumber)
        {
            if (activeCase.LandRegistryNumber != landRegistryNumber)
                activeCase.LandRegistryNumber = landRegistryNumber;
        }
        public void SetAddress(string address)
        {
            if (activeCase.Address != address)
                activeCase.Address = address;
        }
        public void SetCity(City city)
        {
            if (activeCase.City != city)
                activeCase.City = city;
        }
        public void SetPropertyType(PropertyType propertyType)
        {
            if (activeCase.PropertyType != propertyType)
                activeCase.PropertyType = propertyType;
        }
        public void SetPublicRating(long publicRating)
        {
            if (activeCase.PublicRating != publicRating)
                activeCase.PublicRating = publicRating;
        }
        public void SetLandValue(long landValue)
        {
            if (activeCase.LandValue != landValue)
                activeCase.LandValue = landValue;
        }
        public void SetGroundArea(int groundArea)
        {
            if (activeCase.GroundArea != groundArea)
                activeCase.GroundArea = groundArea;
        }
        public void SetBuiltArea(int builtArea)
        {
            if (activeCase.BuiltArea != builtArea)
                activeCase.BuiltArea = builtArea;
        }
        public void SetLivingArea(int livingArea)
        {
            if (activeCase.LivingArea != livingArea)
                activeCase.LivingArea = livingArea;
        }
        public void SetBasementArea(int basementArea)
        {
            if (activeCase.BasementArea != basementArea)
                activeCase.BasementArea = basementArea;
        }
        public void SetBuiltYear(int builtYear)
        {
            if (activeCase.BuiltYear != builtYear)
                activeCase.BuiltYear = builtYear;
        }
        public void SetEnergyClassification(string energyClassification)
        {
            if (activeCase.EnergyClassification != energyClassification)
                activeCase.EnergyClassification = energyClassification;
        }
        public void SetFloors(int floors)
        {
            if (activeCase.Floors != floors)
                activeCase.Floors = floors;
        }
        public void SetRooms(int rooms)
        {
            if (activeCase.Rooms != rooms)
                activeCase.Rooms = rooms;
        }
        public void SetBedrooms(int bedrooms)
        {
            if (activeCase.Bedrooms != bedrooms)
                activeCase.Bedrooms = bedrooms;
        }
        public void SetBathrooms(int bathrooms)
        {
            if (activeCase.Bathrooms != bathrooms)
                activeCase.Bathrooms = bathrooms;
        }
        public void SetToilets(int toilets)
        {
            if (activeCase.Toilets != toilets)
                activeCase.Toilets = toilets;
        }
        public void SetGarageArea(int garageArea)
        {
            if (activeCase.GarageArea != garageArea)
                activeCase.GarageArea = garageArea;
        }
        public void SetView(int view)
        {
            if (activeCase.View != view)
                activeCase.View = view;
        }
        public void SetNeighborhood(Neighborhood neighborhood)
        {
            if (activeCase.Neighborhood != neighborhood)
                activeCase.Neighborhood = neighborhood;
        }

        #endregion
    }
}
