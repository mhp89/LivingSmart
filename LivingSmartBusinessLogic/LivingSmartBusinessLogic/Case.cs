using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Case
    {
        private int Id;

        #region Private Fields
        private Customer _Seller;
        private Customer _Buyer;
        private EstateAgent _EstateAgent;
        private int _CreationDate;
        private string _Status;
        private int _DateOfSale;
        private int _TransferDate;
        private int _DateOfCompletion;
        private int _SellingPrice;
        private int _Description;
        private int _LandRegistryNumber;
        private int _Address;
        private City _City;
        private PropertyType _PropertyType;
        private int _PublicRating;
        private int _LandValue;
        private int _GroundArea;
        private int _BuiltArea;
        private int _LivingArea;
        private int _BasementArea;
        private int _BuiltYear;
        private int _EnergyClassification;
        private int _Floors;
        private int _Rooms;
        private int _Bedrooms;
        private int _Bathrooms;
        private int _Toilets;
        private int _GarageArea;
        private int _View;
        private Neighborhood _Neighborhood;

        #endregion

        #region Properties

        public Customer Seller { get { return _Seller; } set { _Seller = value; } }
        public Customer Buyer { get { return _Buyer; } set { _Buyer = value; } }
        public EstateAgent EstateAgent { get { return _EstateAgent; } set { _EstateAgent = value; } }
        public int CreationDate { get { return _CreationDate; } set { _CreationDate = value; } }
        public string Status { get { return _Status; } set { _Status = value; } }
        public int DateOfSale { get { return _DateOfSale; } set { _DateOfSale = value; } }
        public int TransferDate { get { return _TransferDate; } set { _TransferDate = value; } }
        public int DateOfCompletion { get { return _DateOfCompletion; } set { _DateOfCompletion = value; } }
        public int SellingPrice { get { return _SellingPrice; } set { _SellingPrice = value; } }
        public int Description { get { return _Description; } set { _Description = value; } }
        public int LandRegistryNumber { get { return _LandRegistryNumber; } set { _LandRegistryNumber = value; } }
        public int Address { get { return _Address; } set { _Address = value; } }
        public City City { get { return _City; } set { _City = value; } }
        public PropertyType PropertyType { get { return _PropertyType; } set { _PropertyType = value; } }
        public int PublicRating { get { return _PublicRating; } set { _PublicRating = value; } }
        public int LandValue { get { return _LandValue; } set { _LandValue = value; } }
        public int GroundArea { get { return _GroundArea; } set { _GroundArea = value; } }
        public int BuiltArea { get { return _BuiltArea; } set { _BuiltArea = value; } }
        public int LivingArea { get { return _LivingArea; } set { _LivingArea = value; } }
        public int BasementArea { get { return _BasementArea; } set { _BasementArea = value; } }
        public int BuiltYear { get { return _BuiltYear; } set { _BuiltYear = value; } }
        public int EnergyClassification { get { return _EnergyClassification; } set { _EnergyClassification = value; } }
        public int Floors { get { return _Floors; } set { _Floors = value; } }
        public int Rooms { get { return _Rooms; } set { _Rooms = value; } }
        public int Bedrooms { get { return _Bedrooms; } set { _Bedrooms = value; } }
        public int Bathrooms { get { return _Bathrooms; } set { _Bathrooms = value; } }
        public int Toilets { get { return _Toilets; } set { _Toilets = value; } }
        public int GarageArea { get { return _GarageArea; } set { _GarageArea = value; } }
        public int View { get { return _View; } set { _View = value; } }
        public Neighborhood Neighborhood { get { return _Neighborhood; } set { _Neighborhood = value; } }

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

        public void CloseCase()
        {
            throw new System.NotImplementedException();
        }

        public void AddDocument()
        {
            throw new System.NotImplementedException();
        }

        public void AddPicture()
        {
            throw new System.NotImplementedException();
        }

        public void AddAd()
        {
            throw new System.NotImplementedException();
        }

        public void AddRating()
        {
            throw new System.NotImplementedException();
        }

        public void AddAskingPrice()
        {
            throw new System.NotImplementedException();
        }

        public void Rate()
        {
            throw new System.NotImplementedException();
        }

    }
}
