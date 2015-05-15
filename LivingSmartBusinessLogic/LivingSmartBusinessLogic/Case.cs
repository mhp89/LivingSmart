using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Case
    {
        private int id;


        #region Private Fields

        private Customer _seller;
        private Customer _buyer;
        private EstateAgent _estateAgent;
        private DateTime _creationDate;
        private string _status;
        private DateTime _dateOfSale;
        private DateTime _transferDate;
        private DateTime _dateOfCompletion;
        private long _sellingPrice;
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

        public Customer Seller { get { return _seller; } set { _seller = value; } }
        public Customer Buyer { get { return _buyer; } set { _buyer = value; } }
        public EstateAgent EstateAgent { get { return _estateAgent; } set { _estateAgent = value; } }
        public DateTime CreationDate { get { return _creationDate; } set { _creationDate = value; } }
        public string Status { get { return _status; } set { _status = value; } }
        public DateTime DateOfSale { get { return _dateOfSale; } set { _dateOfSale = value; } }
        public DateTime TransferDate { get { return _transferDate; } set { _transferDate = value; } }
        public DateTime DateOfCompletion { get { return _dateOfCompletion; } set { _dateOfCompletion = value; } }
        public long SellingPrice { get { return _sellingPrice; } set { _sellingPrice = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public string LandRegistryNumber { get { return _landRegistryNumber; } set { _landRegistryNumber = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public City City { get { return _city; } set { _city = value; } }
        public PropertyType PropertyType { get { return _propertyType; } set { _propertyType = value; } }
        public long PublicRating { get { return _publicRating; } set { _publicRating = value; } }
        public long LandValue { get { return _landValue; } set { _landValue = value; } }
        public int GroundArea { get { return _groundArea; } set { _groundArea = value; } }
        public int BuiltArea { get { return _builtArea; } set { _builtArea = value; } }
        public int LivingArea { get { return _livingArea; } set { _livingArea = value; } }
        public int BasementArea { get { return _basementArea; } set { _basementArea = value; } }
        public int BuiltYear { get { return _builtYear; } set { _builtYear = value; } }
        public string EnergyClassification { get { return _energyClassification; } set { _energyClassification = value; } }
        public int Floors { get { return _floors; } set { _floors = value; } }
        public int Rooms { get { return _rooms; } set { _rooms = value; } }
        public int Bedrooms { get { return _bedrooms; } set { _bedrooms = value; } }
        public int Bathrooms { get { return _bathrooms; } set { _bathrooms = value; } }
        public int Toilets { get { return _toilets; } set { _toilets = value; } }
        public int GarageArea { get { return _garageArea; } set { _garageArea = value; } }
        public int View { get { return _view; } set { _view = value; } }
        public Neighborhood Neighborhood { get { return _neighborhood; } set { _neighborhood = value; } }

        #endregion

        #region Collections

        private List<Ad> Ads;
        private List<PotentialBuyer> PotentialBuyers;
        private List<Document> Documents;
        private List<Rating> Ratings;
        private List<AskingPrice> AskingPrices;
        private List<DistanceTo> DistanceTos;
        private List<Picture> Pictures;

        #endregion

        #region Methods

        public void CloseCase()
        {
            throw new System.NotImplementedException();
        }

        public void AddDocument(Document document)
        {
            Documents.Add(document);
        }

        public void AddPicture(Picture picture)
        {
            Pictures.Add(picture);
        }

        public void AddAd(Ad ad)
        {
            Ads.Add(ad);
        }

        public void AddRating(Rating rating)
        {
            Ratings.Add(rating);
        }

        public void AddAskingPrice(AskingPrice askingPrice)
        {
            AskingPrices.Add(askingPrice);
        }

        public void AddPotentialBuyer(PotentialBuyer potentialBuyer)
        {
            PotentialBuyers.Add(potentialBuyer);
        }

        public void AddDistanceTo(DistanceTo distanceTo)
        {
            DistanceTos.Add(distanceTo);
        }
        
        #endregion

    }
}
