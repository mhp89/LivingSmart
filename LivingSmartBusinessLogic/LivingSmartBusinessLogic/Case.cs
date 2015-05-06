using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Case
    {
        private int Id;
        private Customer Seller;
        private Customer Buyer;
        private EstateAgent EstateAgent;
        private int CreationDate;
        private String Status;
        private int DateOfSale;
        private int TransferDate;
        private int DateOfCompletion;
        private int SellingPrice;
        private int Description;
        private int LandRegistryNumber;
        private int Address;
        private ZipCode ZipCode;
        private PropertyType PropertyType;
        private int PublicRating;
        private int LandValue;
        private int GroundArea;
        private int BuiltArea;
        private int LivingArea;
        private int BasementArea;
        private int BuiltYear;
        private int EnergyClassification;
        private int Floors;
        private int Rooms;
        private int Bedrooms;
        private int Bathrooms;
        private int Toilets;
        private int GarageArea;
        private int View;
        private List<Ad> Ads;
        private List<PotentialBuyer> PotentialBuyers;
        private List<Document> Documents;
        private List<Rating> Ratings;
        private List<AskingPrice> AskingPrices;
        private List<DistanceTo> DistanceTos;
        private List<Picture> Pictures;
    }
}
