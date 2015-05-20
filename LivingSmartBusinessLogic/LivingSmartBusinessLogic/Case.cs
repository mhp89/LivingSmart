using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Case
    {
        public int Id { get; private set; }

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


        public Customer Seller { get { return _seller; } internal set { _seller = value; } }
        public Customer Buyer { get { return _buyer; } internal set { _buyer = value; } }
        public EstateAgent EstateAgent { get { return _estateAgent; } internal set { _estateAgent = value; } }
        public DateTime CreationDate { get { return _creationDate; } internal set { _creationDate = value; } }
        public string Status { get { return _status; } internal set { _status = value; } }
        public DateTime DateOfSale { get { return _dateOfSale; } internal set { _dateOfSale = value; } }
        public DateTime TransferDate { get { return _transferDate; } internal set { _transferDate = value; } }
        public DateTime DateOfCompletion { get { return _dateOfCompletion; } internal set { _dateOfCompletion = value; } }
        public long SellingPrice { get { return _sellingPrice; } internal set { _sellingPrice = value; } }
        public string Description { get { return _description; } internal set { _description = value; } }
        public string LandRegistryNumber { get { return _landRegistryNumber; } internal set { _landRegistryNumber = value; } }
        public string Address { get { return _address; } internal set { _address = value; } }
        public City City { get { return _city; } internal set { _city = value; } }
        public PropertyType PropertyType { get { return _propertyType; } internal set { _propertyType = value; } }
        public long PublicRating { get { return _publicRating; } internal set { _publicRating = value; } }
        public long LandValue { get { return _landValue; } internal set { _landValue = value; } }
        public int GroundArea { get { return _groundArea; } internal set { _groundArea = value; } }
        public int BuiltArea { get { return _builtArea; } internal set { _builtArea = value; } }
        public int LivingArea { get { return _livingArea; } internal set { _livingArea = value; } }
        public int BasementArea { get { return _basementArea; } internal set { _basementArea = value; } }
        public int BuiltYear { get { return _builtYear; } internal set { _builtYear = value; } }
        public string EnergyClassification { get { return _energyClassification; } internal set { _energyClassification = value; } }
        public int Floors { get { return _floors; } internal set { _floors = value; } }
        public int Rooms { get { return _rooms; } internal set { _rooms = value; } }
        public int Bedrooms { get { return _bedrooms; } internal set { _bedrooms = value; } }
        public int Bathrooms { get { return _bathrooms; } internal set { _bathrooms = value; } }
        public int Toilets { get { return _toilets; } internal set { _toilets = value; } }
        public int GarageArea { get { return _garageArea; } internal set { _garageArea = value; } }
        public int View { get { return _view; } internal set { _view = value; } }
        public Neighborhood Neighborhood { get { return _neighborhood; } internal set { _neighborhood = value; } }

        #endregion

        #region Collections

        private List<Ad> ads;
        private List<PotentialBuyer> potentialBuyers;
        private List<Document> documents;
        private List<Rating> ratings;
        private List<AskingPrice> askingPrices;
        private List<DistanceTo> distanceTos;
        private List<Picture> pictures;

        #endregion

        internal Case()
        {
            ads = new List<Ad>();
            potentialBuyers = new List<PotentialBuyer>();
            documents = new List<Document>();
            ratings = new List<Rating>();
            askingPrices = new List<AskingPrice>();
            distanceTos = new List<DistanceTo>();
            pictures = new List<Picture>();
        }

        #region Methods

        internal void CloseCase()
        {
            throw new System.NotImplementedException();
        }

        internal void AddDocument(Document document)
        {
            documents.Add(document);
        }

        internal void AddPicture(Picture picture)
        {
            pictures.Add(picture);
        }

        internal void AddAd(Ad ad)
        {
            ads.Add(ad);
        }

        internal void AddRating(Rating rating)
        {
            ratings.Add(rating);
        }

        internal void AddAskingPrice(AskingPrice askingPrice)
        {
            askingPrices.Add(askingPrice);
        }

        internal void AddPotentialBuyer(PotentialBuyer potentialBuyer)
        {
            potentialBuyers.Add(potentialBuyer);
        }

        internal void AddDistanceTo(DistanceTo distanceTo)
        {
            distanceTos.Add(distanceTo);
        }

        internal ReadOnlyCollection<Ad> GetAds()
        {
            return ads.AsReadOnly();
        }

        internal ReadOnlyCollection<PotentialBuyer> GetPotentialBuyers()
        {
            return potentialBuyers.AsReadOnly();
        }

        internal ReadOnlyCollection<Document> GetDocuments()
        {
            return documents.AsReadOnly();
        }

        internal ReadOnlyCollection<Rating> GetRatings()
        {
            return ratings.AsReadOnly();
        }

        internal ReadOnlyCollection<AskingPrice> GetAskingPrices()
        {
            return askingPrices.AsReadOnly();
        }

        internal ReadOnlyCollection<DistanceTo> GetDistanceTos()
        {
            return distanceTos.AsReadOnly();
        }

        internal ReadOnlyCollection<Picture> GetPictures()
        {
            return pictures.AsReadOnly();
        }
        
        #endregion

    }
}
