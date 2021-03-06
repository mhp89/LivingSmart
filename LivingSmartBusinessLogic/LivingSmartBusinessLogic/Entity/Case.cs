using System;
using System.Collections.Generic;
using LivingSmartBusinessLogic.Controller;
using DistanceToSystemType = LivingSmartBusinessLogic.Entity.DistanceTo.DistanceToSystemType;

namespace LivingSmartBusinessLogic.Entity
{
    /// <summary>
    /// Holds the information for a Case
    /// </summary>
    /// <author>Mathias Poulsen</author>
    public class Case
    {
        public enum CaseStatus
        {
            Open,
            Sold,
            Closed,
        }

        #region Private Fields

        private Customer _seller;
        private Customer _buyer;
        private EstateAgent _estateAgent;
        private DateTime _creationDate;
        private CaseStatus _status;
        private DateTime? _dateOfSale;
        private DateTime? _transferDate;
        private DateTime? _dateOfCompletion;
        private long? _sellingPrice;
        private string _description;
        private string _landRegistryNumber;
        private string _address;
        private City _city;
        private PropertyType _propertyType;
        private long _publicRating;
        private long _landValue;
        private int _groundArea;
        private int _builtArea;
        private int _livingArea;
        private int _basementArea;
        private int _builtYear;
        private string _energyClassification;
        private int _floors;
        private int _rooms;
        private int _bedrooms;
        private int _bathrooms;
        private int _toilets;
        private int _garageArea;
        private int _view;
        private Neighborhood _neighborhood;

        #endregion

        #region Properties

        public int Id
        {
            get; 
            internal set;
        }

        public Customer Seller
        {
            get { return _seller; } 
            internal set { _seller = value; }
        }

        public Customer Buyer
        {
            get { return _buyer; } 
            internal set { _buyer = value; }
        }

        public EstateAgent EstateAgent
        {
            get { return _estateAgent; }
            internal set { _estateAgent = value; }
        }

        public DateTime CreationDate 
        {
            get { return _creationDate; } 
            internal set { _creationDate = value; } 
        }

        public CaseStatus Status
        {
            get { return _status; }
            internal set { _status = value; }
        }

        public DateTime? DateOfSale 
        {
            get { return _dateOfSale; } 
            internal set { _dateOfSale = value; } 
        }
        public DateTime? TransferDate 
        {
            get { return _transferDate; }
            internal set { _transferDate = value;} 
        }
        public DateTime? DateOfCompletion 
        {
            get { return _dateOfCompletion; }
            internal set { _dateOfCompletion = value; } 
        }
        public long? SellingPrice 
        {
            get { return _sellingPrice; }
            internal set { _sellingPrice = value; } 
        }
        public string Description 
        {
            get { return _description; }
            internal set { _description = value; } 
        }
        public string LandRegistryNumber 
        {
            get { return _landRegistryNumber; }
            internal set { _landRegistryNumber = value; } 
        }

        public string Address
        {
            get { return _address; } 
            internal set { _address = value; }
        }

        public City City
        {
            get { return _city; } 
            internal set { _city = value; }
        }

        public PropertyType PropertyType
        {
            get { return _propertyType; } 
            internal set { _propertyType = value; }
        }
        public long PublicRating 
        { 
            get { return _publicRating; } 
            internal set { _publicRating = value; } 
        }

        public long LandValue
        {
            get { return _landValue; } 
            internal set { _landValue = value; }
        }

        public int GroundArea
        {
            get { return _groundArea; } 
            internal set { _groundArea = value; }
        }

        public int BuiltArea
        {
            get { return _builtArea; } 
            internal set { _builtArea = value; }
        }

        public int LivingArea
        {
            get { return _livingArea; } 
            internal set { _livingArea = value; }
        }
        public int BasementArea { 
            get { return _basementArea; } 
            internal set { _basementArea = value; } 
        }

        public int BuiltYear
        {
            get { return _builtYear; } 
            internal set { _builtYear = value; }
        }
        public string EnergyClassification 
        { 
            get { return _energyClassification; } 
            internal set { _energyClassification = value; } 
        }

        public int Floors
        {
            get { return _floors; } 
            internal set { _floors = value; }
        }

        public int Rooms
        {
            get { return _rooms; } 
            internal set { _rooms = value; }
        }

        public int Bedrooms
        {
            get { return _bedrooms; } 
            internal set { _bedrooms = value; }
        }

        public int Bathrooms
        {
            get { return _bathrooms; } 
            internal set { _bathrooms = value; }
        }

        public int Toilets
        {
            get { return _toilets; } 
            internal set { _toilets = value; }
        }

        public int GarageArea
        {
            get { return _garageArea; } 
            internal set { _garageArea = value; }
        }

        public int View
        {
            get { return _view; } 
            internal set { _view = value; }
        }
        public Neighborhood Neighborhood 
        { 
            get { return _neighborhood; } 
            internal set { _neighborhood = value; } 
        }

        public decimal NewestAskingPrice
        {
            get { return CaseController.Instance.GetNewestAskingPrice(Id).Value; }
        }

        public decimal PriceTrend
        {
            get { return CaseController.Instance.GetPriceTrend(Id); }
        }


        #endregion

        internal Case()
		{
			Id = -1;
            CreationDate = DateTime.Now;
	        Status = CaseStatus.Open;
		}
        internal Case(int id, int sellerId, int buyerId, int estateAgentId, 
            DateTime creationDate, string status, DateTime? dateOfSale, 
            DateTime? transferDate, DateTime? dateOfCompletion, long? sellingPrice, 
            string description, string landRegistryNumber, string address, int zipCode, 
            int propertyTypeId, long publicRating, long landValue, 
            int groundArea, int builtArea, int livingArea, int basementArea, 
            int builtYear, string energyClassification, int floors, int rooms, 
            int bedrooms, int bathrooms, int toilets, int garageArea, 
            int view, int neighborhoodId)
        {
            Id = id;
            Seller = CustomerController.Instance.GetCustomer(sellerId);
	        if (buyerId != -1)
		        Buyer = CustomerController.Instance.GetCustomer(buyerId);
	        EstateAgent = EstateAgentController.Instance.GetEstateAgent(estateAgentId);
            CreationDate = creationDate;
            Status = (CaseStatus)Enum.Parse(typeof(CaseStatus), status);
            DateOfSale = dateOfSale;
            TransferDate = transferDate;
            DateOfCompletion = dateOfCompletion;
            SellingPrice = sellingPrice;
            Description = description;
            LandRegistryNumber = landRegistryNumber;
            Address = address;
            City = CityController.Instance.GetCity(zipCode);
            PropertyType = PropertyTypeController.Instance.GetPropertyType(propertyTypeId);
            PublicRating = publicRating;
            LandValue = landValue;
            GroundArea = groundArea;
            BuiltArea = builtArea;
            LivingArea = livingArea;
            BasementArea = basementArea;
            BuiltYear = builtYear;
            EnergyClassification = energyClassification;
            Floors = floors;
            Rooms = rooms;
            Bedrooms = bedrooms;
            Bathrooms = bathrooms;
            Toilets = toilets;
            GarageArea = garageArea;
            View = view;
            Neighborhood = NeighborhoodController.Instance.GetHood(zipCode, neighborhoodId);
        }

	    #region Methods
        /// <summary>
        /// Lukker sagen
        /// </summary>
        /// <author>Mathias Poulsen</author>
        internal void CloseCase()
        {
            Status = CaseStatus.Closed;
        }

	    /// <summary>
	    /// Beregner værdien af ejendommen baseret på grundpris, pris for bebygget areal,
	    /// kælderareal, alder af ejendommen og faktor fra RatingFactor()
	    /// </summary>
	    /// <param name="tempDistanceTos"></param>
	    /// <returns></returns>
        /// <author>Maja Olesen</author>
	    internal long CalculatePropertyRating(List<DistanceTo> distanceTos)
        {
            int basementValue = _neighborhood.Value / 4;  //Estimeret værdi
            
            return Convert.ToInt64((_landValue + _livingArea * _neighborhood.Value
									+ _basementArea * basementValue) * RatingFactor(distanceTos)
                                    * (1 - (DateTime.Today.Year -_builtYear) / 1000));
        }

        /// <summary>
        /// Finder beregningsfaktorer for udsigt, afstand til skole, indkøb og centrum
        /// baseret på deres faktiske værdier. 
        /// </summary>
        /// <author>Maja Olesen</author>
		internal double RatingFactor(List<DistanceTo> distanceTos)
        {
            double viewFactor;
            double schoolFactor;
            double shoppingFactor;
            double centerFactor;
            int schoolDistance = Int32.MaxValue;
			int shoppingDistance = Int32.MaxValue;
			int centerDistance = Int32.MaxValue;

			//Disse 3 afstandstyper er påkrævet af programmet og vil altid forefindes i databasen
			foreach (DistanceTo dist in distanceTos)
            {
				if (dist.Type == DistanceToSystemType.School.ToString())
                    schoolDistance = dist.Distance;
				else if (dist.Type == DistanceToSystemType.Shopping.ToString())
                    shoppingDistance = dist.Distance;
				else if (dist.Type == DistanceToSystemType.Center.ToString())
                    centerDistance = dist.Distance;
            }

            if (_view == 3)
                viewFactor = 0.7;
            else if (_view == 2)
                viewFactor = 0.4;
            else
                viewFactor = 0.1;

            if (schoolDistance <= 1000)
                schoolFactor = 0.5;
            else if (schoolDistance <= 4000)
                schoolFactor = 0.3;
            else
                schoolFactor = 0.1;

            if (shoppingDistance <= 500)
                shoppingFactor = 0.4;
            else if (shoppingDistance <= 3000)
                shoppingFactor = 0.2;
            else
                shoppingFactor = 0.1;

            if (centerDistance <= 1000)
                centerFactor = 0.6;
            else if (centerDistance <= 4000)
                centerFactor = 0.3;
            else
                centerFactor = 0.1;

            return viewFactor + schoolFactor + shoppingFactor + centerFactor;
        }

        /// <summary>
        /// Oversætter den engelske status fra databasen til dansk til brug i GUI
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        /// <author>Maja Olesen</author>
        public static string TranslateStatus(CaseStatus status)
        {
            string danishStatus;

            if (status == CaseStatus.Open)
                danishStatus = "Åben";
            else if (status == CaseStatus.Sold)
                danishStatus = "Solgt";
            else
                danishStatus = "Lukket";

            return danishStatus;
        }

        #endregion
    }
}
