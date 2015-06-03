using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using LivingSmartBusinessLogic.Catalog;
using LivingSmartBusinessLogic.Model;

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

        private CaseController()
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
        /// <summary>
        /// Sætter den aktive sag
        /// </summary>
        /// <param name="activeCase"></param>
        public void SetActiveCase(Case activeCase)
        {
            this.activeCase = activeCase;
        }

        /// <summary>
        /// Fortryder valg af aktiv sag
        /// </summary>
        public void CancelActiveCase()
        {
            activeCase = null;
        }

        /// <summary>
        /// Gemmer aktiv sag
        /// </summary>
        public void SaveActiveCase()
		{
			caseCatalog.Save(activeCase);
			if (activeCase.Id != -1)
				caseCatalog.AddToCatalog(activeCase);
        }
        #endregion

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
        /// Læser den aktive sag fra casecatalog
        /// </summary>
        /// <returns></returns>
        public Case ReadCase()
        {
            return caseCatalog.Check(activeCase.Id);
        }

        /// <summary>
        /// Læser en given sag fra casecatalog
        /// </summary>
        /// <param name="caseId"></param>
        /// <returns></returns>
        public Case GetCase(int caseId)
        {
            return caseCatalog.GetCase(caseId);
        }

		/// <summary>
		/// Retunere den aktive sag
		/// </summary>
		/// <returns></returns>
	    public Case GetActiveCase()
	    {
		    return activeCase;
	    }

		public ReadOnlyCollection<Case> GetCases()
		{
			return caseCatalog.GetCases();
		}
       
        #region Document

        /// <summary>
        /// Laver et nyt dokument
        /// </summary>
        /// <param name="type"></param>
        /// <param name="price"></param>
        /// <param name="location"></param>
        /// <param name="status"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Returnerer den aktive sags billeder som en list
        /// </summary>
        /// <returns></returns>
        public ReadOnlyCollection<Document> GetDocuments()
        {
            return documentCatalog.GetDocuments(activeCase.Id);
        }
        #endregion
        
        #region Picture
        /// <summary>
        /// Laver et nyt billede
        /// </summary>
        /// <param name="location"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        public Picture MakeNewPicture(string location, string description)
        {
			return new Picture(location, description);
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
        /// <summary>
        /// Returnerer den aktive sags billeder som en list
        /// </summary>
        /// <returns></returns>
        public ReadOnlyCollection<Picture> GetPictures()
        {
            return pictureCatalog.GetPictures(activeCase.Id);
        }
        #endregion

        #region Ad

        /// <summary>
        /// Laver en ny annonce
        /// </summary>
        /// <param name="type"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        public Ad MakeNewAd(string type, DateTime startDate, DateTime endDate, int price)
        {
            return new Ad(type, startDate, endDate, price);
        }
        /// <summary>
        /// Tilføjer en annonce til den aktive sag
        /// </summary>
        /// <param name="ad"></param>
        public void AddAdToCase(Ad ad)
        {
            adCatalog.AddToCatalog(activeCase.Id, ad);
        }

        /// <summary>
        /// Fjerner en annonce fra den aktive sag
        /// </summary>
        public void RemoveAdFromCase(Ad ad)
        {
            adCatalog.RemoveFromCatalog(activeCase.Id, ad);
        }
        /// <summary>
        /// Henter den aktive sags annoncer som en list
        /// </summary>
        /// <returns></returns>
        public ReadOnlyCollection<Ad> GetAds()
        {
            return adCatalog.GetAds(activeCase.Id);
        }
        #endregion

        #region Rating

        /// <summary>
        /// Laver en ny vurdering baseret på den aktive sag
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Henter en given sags vurderinger som en list
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ReadOnlyCollection<Rating> GetRatings(int id)
        {
            return ratingCatalog.GetRatings(activeCase.Id);
        }

        /// <summary>
        /// Henter en specifik sags vurderinger som en list
        /// </summary>
        /// <returns></returns>
        public Rating GetLastRating(Case cCase)
        {
            return ratingCatalog.GetLastRating(cCase);
        }
		/// <summary>
		/// Henter den aktive sags vurderinger som en list
		/// </summary>
		/// <returns></returns>
		public Rating GetLastRating()
		{
			return GetLastRating(activeCase);
		}

        #endregion

        #region AskingPrice

        /// <summary>
        /// Laver en ny udbudspris
        /// </summary>
        /// <param name="value"></param>
        /// <param name="date"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Henter en given sags udbudspriser som en list
        /// </summary>
        /// <param name="caseId"></param>
        /// <returns></returns>
        public ReadOnlyCollection<AskingPrice> GetAskingPrices(int caseId)
        {
            return askingPriceCatalog.GetAskingPrices(caseId);
        }

        /// <summary>
        /// Henter den aktive sags udbudspriser som en list
        /// </summary>
        /// <returns></returns>
        public ReadOnlyCollection<AskingPrice> GetAskingPrices()
        {
            return GetAskingPrices(activeCase.Id);

        }
        /// <summary>
        /// Henter den nyeste udbudsprise på en given sag
        /// </summary>
        /// <param name="caseId"></param>
        /// <returns></returns>
        public AskingPrice GetNewestAskingPrice(int caseId)
        {
            var askingPrices = GetAskingPrices(caseId);
            return askingPrices[askingPrices.Count - 1];
        }
        /// <summary>
        /// Henter den nyeste udbudsprise på den aktive sag
        /// </summary>
        /// <returns></returns>
        public AskingPrice GetNewestAskingPrice()
        {
            return GetNewestAskingPrice(activeCase.Id);
        }

        /// <summary>
        /// Henter prisudvikling på en given case. Prisudviklingen udregnes på 
        /// baggrund af den første og den sidste udbudspris
        /// </summary>
        /// <param name="caseId"></param>
        /// <returns></returns>
        public double GetPriceTrend(int caseId)
        {
            ReadOnlyCollection<AskingPrice> askingPrices = GetAskingPrices(caseId);
            if (askingPrices.Count == 0)
            {
                return 0;
            }
            long firstRating = askingPrices[0].Value;
            long lastRating = askingPrices[askingPrices.Count - 1].Value;

            return (((lastRating / firstRating) - 1) * 100);
        }

        #endregion

        #region DistanceTo

        /// <summary>
        /// Laver en ny "Afstand til"
        /// </summary>
        /// <param name="type"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
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
		public ReadOnlyCollection<DistanceTo> GetDistanceTos(int id)
		{
			return distanceToCatalog.GetDistanceTos(id);
		}
        public ReadOnlyCollection<DistanceTo> GetDistanceTos()
        {
            return GetDistanceTos(activeCase.Id);
        }
        #endregion

        #region PropertyMethods
        /// <summary>
        /// Sætter sælger
        /// </summary>
        /// <param name="seller"></param>
        public void SetSeller(Customer seller)
        {
			if (activeCase.Seller != seller)
				activeCase.Seller = seller;
        }
        /// <summary>
        /// Sætter køber
        /// </summary>
        /// <param name="buyer"></param>
        public void SetBuyer(Customer buyer)
        {
			if (activeCase.Buyer != buyer)
				activeCase.Buyer = buyer;
        }
        /// <summary>
        /// Sætter mægler
        /// </summary>
        /// <param name="estateAgent"></param>
        public void SetEstateAgent(EstateAgent estateAgent)
        {
			if (activeCase.EstateAgent != estateAgent)
				activeCase.EstateAgent = estateAgent;
        }
        /// <summary>
        /// Sætter oprettelsesdato
        /// </summary>
        /// <param name="creationDate"></param>
        public void SetCreationDate(DateTime creationDate)
        {
            if (activeCase.CreationDate != creationDate)
                activeCase.CreationDate = creationDate;
        }
        /// <summary>
        /// Sætter sagens status
        /// </summary>
        /// <param name="status"></param>
        public void SetStatus(string status)
        {
            if (activeCase.Status != status)
                activeCase.Status = status;
        }
        /// <summary>
        /// Sætter salgsdato
        /// </summary>
        /// <param name="dateOfSale"></param>
        public void SetDateOfSale(DateTime dateOfSale)
        {
            if (activeCase.DateOfSale != dateOfSale)
                activeCase.DateOfSale = dateOfSale;
        }
        /// <summary>
        /// Sætter overdragelsesdato
        /// </summary>
        /// <param name="transferDate"></param>
        public void SetTransferDate(DateTime transferDate)
        {
            if (activeCase.TransferDate != transferDate)
                activeCase.TransferDate = transferDate;
        }
        /// <summary>
        /// Sætter dato for sagens afsluttelse
        /// </summary>
        /// <param name="dateOfCompletion"></param>
        public void SetDateOfCompletion(DateTime dateOfCompletion)
        {
            if (activeCase.DateOfCompletion != dateOfCompletion)
                activeCase.DateOfCompletion = dateOfCompletion;
        }
        /// <summary>
        /// Sætter salgspris
        /// </summary>
        /// <param name="sellingPrice"></param>
        public void SetSellingPrice(long sellingPrice)
        {
            if (activeCase.SellingPrice != sellingPrice)
                activeCase.SellingPrice = sellingPrice;
        }
        /// <summary>
        /// Sætter beskrivelse
        /// </summary>
        /// <param name="description"></param>
        public void SetDescription(string description)
        {
            if (activeCase.Description != description)
                activeCase.Description = description;
        }
        /// <summary>
        /// Sætter matrikelnummer
        /// </summary>
        /// <param name="landRegistryNumber"></param>
        public void SetLandRegistryNumber(string landRegistryNumber)
        {
            if (activeCase.LandRegistryNumber != landRegistryNumber)
                activeCase.LandRegistryNumber = landRegistryNumber;
        }
        /// <summary>
        /// Sætter adresse
        /// </summary>
        /// <param name="address"></param>
        public void SetAddress(string address)
        {
            if (activeCase.Address != address)
                activeCase.Address = address;
        }
        /// <summary>
        /// Sætter by baseret på postnummer
        /// </summary>
        /// <param name="zipcode"></param>
        public void SetZipCode(int zipcode)
        {
			if (activeCase.ZipCode != zipcode)
				activeCase.ZipCode = zipcode;
        }
        /// <summary>
        /// Sætter ejendomstype
        /// </summary>
        /// <param name="propertyType"></param>
        public void SetPropertyType(PropertyType propertyType)
        {
			if (activeCase.PropertyType != propertyType)
				activeCase.PropertyType = propertyType;
        }
        /// <summary>
        /// Sætter den offentlige vurdering
        /// </summary>
        /// <param name="publicRating"></param>
        public void SetPublicRating(long publicRating)
        {
            if (activeCase.PublicRating != publicRating)
                activeCase.PublicRating = publicRating;
        }
        /// <summary>
        /// Sætter grundværdien
        /// </summary>
        /// <param name="landValue"></param>
        public void SetLandValue(long landValue)
        {
            if (activeCase.LandValue != landValue)
                activeCase.LandValue = landValue;
        }
        /// <summary>
        /// Sætter grundareal
        /// </summary>
        /// <param name="groundArea"></param>
        public void SetGroundArea(int groundArea)
        {
            if (activeCase.GroundArea != groundArea)
                activeCase.GroundArea = groundArea;
        }
        /// <summary>
        /// Sætter bebygget areal
        /// </summary>
        /// <param name="builtArea"></param>
        public void SetBuiltArea(int builtArea)
        {
            if (activeCase.BuiltArea != builtArea)
                activeCase.BuiltArea = builtArea;
        }
        /// <summary>
        /// Sætter beboelsesareal
        /// </summary>
        /// <param name="livingArea"></param>
        public void SetLivingArea(int livingArea)
        {
            if (activeCase.LivingArea != livingArea)
                activeCase.LivingArea = livingArea;
        }
        /// <summary>
        /// Sætter kælderareal
        /// </summary>
        /// <param name="basementArea"></param>
        public void SetBasementArea(int basementArea)
        {
            if (activeCase.BasementArea != basementArea)
                activeCase.BasementArea = basementArea;
        }
        /// <summary>
        /// Sætter byggeår
        /// </summary>
        /// <param name="builtYear"></param>
        public void SetBuiltYear(int builtYear)
        {
            if (activeCase.BuiltYear != builtYear)
                activeCase.BuiltYear = builtYear;
        }
        /// <summary>
        /// Sætter energimærke
        /// </summary>
        /// <param name="energyClassification"></param>
        public void SetEnergyClassification(string energyClassification)
        {
            if (activeCase.EnergyClassification != energyClassification)
                activeCase.EnergyClassification = energyClassification;
        }
        /// <summary>
        /// Sætter antal etager
        /// </summary>
        /// <param name="floors"></param>
        public void SetFloors(int floors)
        {
            if (activeCase.Floors != floors)
                activeCase.Floors = floors;
        }
        /// <summary>
        /// Sætter antal rum
        /// </summary>
        /// <param name="rooms"></param>
        public void SetRooms(int rooms)
        {
            if (activeCase.Rooms != rooms)
                activeCase.Rooms = rooms;
        }
        /// <summary>
        /// Sætter antal soveværelser
        /// </summary>
        /// <param name="bedrooms"></param>
        public void SetBedrooms(int bedrooms)
        {
            if (activeCase.Bedrooms != bedrooms)
                activeCase.Bedrooms = bedrooms;
        }
        /// <summary>
        /// Sætter antal badeværelser
        /// </summary>
        /// <param name="bathrooms"></param>
        public void SetBathrooms(int bathrooms)
        {
            if (activeCase.Bathrooms != bathrooms)
                activeCase.Bathrooms = bathrooms;
        }
        /// <summary>
        /// Sætter antal toiletter
        /// </summary>
        /// <param name="toilets"></param>
        public void SetToilets(int toilets)
        {
            if (activeCase.Toilets != toilets)
                activeCase.Toilets = toilets;
        }
        /// <summary>
        /// Sætter garageareal
        /// </summary>
        /// <param name="garageArea"></param>
        public void SetGarageArea(int garageArea)
        {
            if (activeCase.GarageArea != garageArea)
                activeCase.GarageArea = garageArea;
        }
        /// <summary>
        /// Sætter "udsigtsfaktor"
        /// </summary>
        /// <param name="view"></param>
        public void SetView(int view)
        {
            if (activeCase.View != view)
                activeCase.View = view;
        }
        /// <summary>
        /// Bestemmer nabolag
        /// </summary>
        /// <param name="neighborhood"></param>
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
