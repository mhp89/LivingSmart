using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Net.Mime;
using System.Drawing;

namespace LivingSmartBusinessLogic.Controller
{
    public class CaseController
	{
		#region Singleton

		private static CaseController _instance;
		public static CaseController Instance
		{
			get { return _instance ?? (_instance = new CaseController()); }
		}

		#endregion


        private CaseCatalog caseCatalog;
        private AdCatalog adCatalog;
        private AskingPriceCatalog askingPriceCatalog;
        private DistanceToCatalog distanceToCatalog;
        private DocumentCatalog documentCatalog;
        private PictureCatalog pictureCatalog;
        private RatingCatalog ratingCatalog;

        private Case activeCase;

        public CaseController()
        {
            caseCatalog = new CaseCatalog();
            adCatalog = new AdCatalog();
            askingPriceCatalog = new AskingPriceCatalog();
            distanceToCatalog = new DistanceToCatalog();
            documentCatalog = new DocumentCatalog();
            pictureCatalog = new PictureCatalog();
            ratingCatalog = new RatingCatalog();
        }

        #region Methods

        #region AdminActiveCase
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
        #endregion
        
        /// <summary>
        /// Tilføjer en case til casecatalog
        /// </summary>
        public void AddCase()
        {
            caseCatalog.AddToCatalog(activeCase);
        }

        /// <summary>
        /// Laver en ny case
        /// </summary>
        /// <returns></returns>
        public Case MakeNewCase()
        {
            SetActiveCase(new Case());
            return activeCase;
        }

        /// <summary>
        /// Læser en given fil fra casecatalog
        /// </summary>
        /// <returns></returns>
        public Case ReadCase()
        {
            return caseCatalog.Check(activeCase.Id);
        }

        public Case GetCase(int caseId)
        {
            return caseCatalog.GetCase(caseId);
        }

		public ReadOnlyCollection<Case> GetCases()
		{
			return caseCatalog.GetCases();
		}
       
        #region Document

        public Document MakeNewDocument(string type, int price, string location, string status)
        {
            return new Document(type, price, location, status);
        }
        /// <summary>
        /// Tilføjer et dokument til casen
        /// </summary>
        /// <param name="document"></param>
        public void AddDocumentToCase(Document document)
        {
            documentCatalog.AddToCatalog(activeCase.Id, document);
        }

        /// <summary>
        /// Fjerner et dokument fra casen
        /// </summary>
        public void RemoveDocumentFromCase(Document document)
        {
            documentCatalog.RemoveFromCatalog(activeCase.Id, document);
        }
        public ReadOnlyCollection<Document> GetDocuments()
        {
            return documentCatalog.GetDocuments(activeCase.Id);
        }
        #endregion
        
        #region Picture
        public Picture MakeNewPicture(string fileLocation, string description)
        {
			return new Picture(fileLocation, description);
        }

        /// <summary>
        /// Tilføjer et billede til casen
        /// </summary>
        /// <param name="picture"></param>
        public void AddPictureToCase(Picture picture)
        {
            pictureCatalog.AddToCatalog(activeCase.Id, picture);
        }

        /// <summary>
        /// Fjerner et billede fra casen
        /// </summary>
        public void RemovePictureFromCase(Picture picture)
        {
            pictureCatalog.RemoveFromCatalog(activeCase.Id, picture);
        }
        public ReadOnlyCollection<Picture> GetPictures()
        {
            return pictureCatalog.GetPictures(activeCase.Id);
        }
        #endregion

        #region Ad

        public Ad MakeNewAd(string type, DateTime startDate, DateTime endDate, int price)
        {
            return new Ad(type, startDate, endDate, price);
        }
        /// <summary>
        /// Tilføjer en annonce til casen
        /// </summary>
        /// <param name="ad"></param>
        public void AddAdToCase(Ad ad)
        {
            adCatalog.AddToCatalog(activeCase.Id, ad);
        }

        /// <summary>
        /// Fjerner en annonce fra casen
        /// </summary>
        public void RemoveAdFromCase(Ad ad)
        {
            adCatalog.RemoveFromCatalog(activeCase.Id, ad);
        }
        public ReadOnlyCollection<Ad> GetAds()
        {
            return adCatalog.GetAds(activeCase.Id);
        }
        #endregion

        #region Rating

        public Rating MakeNewRating()
        {
            return new Rating(activeCase);
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
        /// Tilføjer en vurdering til casen
        /// </summary>
        /// <param name="rating"></param>
        public void AddRatingToCase(Rating rating)
        {
            ratingCatalog.AddToCatalog(activeCase.Id, rating);
        }

        /// <summary>
        /// Fjerner en vurdering fra casen
        /// </summary>
        public void RemoveRatingFromCase(Rating rating)
        {
            ratingCatalog.RemoveFromCatalog(activeCase.Id, rating);
        }
        public ReadOnlyCollection<Rating> GetRatings()
        {
            return ratingCatalog.GetRatings(activeCase.Id);
        }
        #endregion

        #region AskingPrice

        public AskingPrice MakeNewAskingPrice(long value, DateTime date)
        {
            return new AskingPrice(value, date);
        }
        /// <summary>
        /// Tilføjer en udbudspris til casen
        /// </summary>
        /// <param name="askingPrice"></param>
        public void AddAskingPriceToCase(AskingPrice askingPrice)
        {
            askingPriceCatalog.AddToCatalog(activeCase.Id, askingPrice);
        }

        /// <summary>
        /// Fjerner en udbudspris fra casen
        /// </summary>
        public void RemoveAskingPriceFromCase(AskingPrice askingPrice)
        {
            askingPriceCatalog.RemoveFromCatalog(activeCase.Id, askingPrice);
        }
        public ReadOnlyCollection<AskingPrice> GetAskingPrices()
        {
            return askingPriceCatalog.GetAskingPrices(activeCase.Id);
        }
        #endregion

        #region DistanceTo

        public DistanceTo MakeNewDistanceTo(string type, int distance)
        {
            return new DistanceTo(type, distance);
        }
        /// <summary>
        /// Tilføjer en "Afstand til" til casen
        /// </summary>
        /// <param name="distanceTo"></param>
        public void AddDistanceToCase(DistanceTo distanceTo)
        {
            distanceToCatalog.AddToCatalog(activeCase.Id, distanceTo);
        }

        /// <summary>
        /// Fjerner en "Afstand til" fra casen
        /// </summary>
        public void RemoveDistanceToFromCase(DistanceTo distanceTo)
        {
            distanceToCatalog.RemoveFromCatalog(activeCase.Id, distanceTo);
        }
        public ReadOnlyCollection<DistanceTo> GetDistanceTos()
        {
            return distanceToCatalog.GetDistanceTos(activeCase.Id);
        }
        #endregion

        #region PropertyMethods
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
        /// <summary>
        /// Tilføjer salgsprisen til casen
        /// </summary>
        public void AddSellingPriceToCase(long sellingPrice)
        {
            activeCase.SellingPrice = sellingPrice;
        }
        #endregion
        
        #endregion

	}
}
