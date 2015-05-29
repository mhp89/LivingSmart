using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic.DBLayer;

namespace LivingSmartBusinessLogic.DB
{
    internal class CaseDBMSSQL : ICaseDB
    {
        public List<Case> ReadCases(int estateAgentUId)
        {
            throw new NotImplementedException();
        }

        public void UpdateCase(Case ca)
        {
            throw new NotImplementedException();
        }

        public int CreateCase(Case ca)
        {
            int adId = 0;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "INSERT INTO Case VALUES (@CaseId, @Type, @StartDate, @EndDate, @Price); " + "SELECT CAST(scope_identity() AS int);"
            };

            cmd.Parameters.Add("@SellerId", SqlDbType.Int, 4, "SellerId").Value = ca.Seller.Id;
            cmd.Parameters.Add("@BuyerId", SqlDbType.Int, 4, "BuyerId").Value = ca.Buyer.Id;
            cmd.Parameters.Add("@EstateAgentId", SqlDbType.Int, 4, "EstateAgentId").Value = ca.EstateAgent.Id;
            cmd.Parameters.Add("@CreationDate", SqlDbType.Date, 8, "CreationDate").Value = ca.CreationDate;
            cmd.Parameters.Add("@Status", SqlDbType.Char, 50, "Status").Value = ca.Status;
            cmd.Parameters.Add("@DateOfSale", SqlDbType.Date, 8, "DateOfSale").Value = ca.DateOfSale;
            cmd.Parameters.Add("@TransferDate", SqlDbType.Date, 8, "TransferDate").Value = ca.TransferDate;
            cmd.Parameters.Add("@DateOfCompletion", SqlDbType.Date, 8, "DateOfCompletion").Value = ca.DateOfCompletion;
            cmd.Parameters.Add("@SellingPrice", SqlDbType.BigInt, 8, "SellingPrice").Value = ca.SellingPrice;
            cmd.Parameters.Add("@Description", SqlDbType.Char, 500, "Description").Value = ca.Description;
            cmd.Parameters.Add("@PropertyTypeId", SqlDbType.Int, 4, "PropertyTypeId").Value = ca.PropertyType;
            cmd.Parameters.Add("@LandRegistryNumber", SqlDbType.Int, 4, "LandRegistryNumber").Value = ca.LandRegistryNumber;
            cmd.Parameters.Add("@Address", SqlDbType.Char, 10, "Address").Value = ca.Address;
            cmd.Parameters.Add("@ZipCode", SqlDbType.Int, 4, "ZipCode").Value = ca.City.ZipCode;
            cmd.Parameters.Add("@Neighborhood", SqlDbType.Char, 15, "Neighborhood").Value = ca.Neighborhood;
            cmd.Parameters.Add("@PublicRating", SqlDbType.BigInt, 8, "PublicRating").Value = ca.PublicRating;
            cmd.Parameters.Add("@LandValue", SqlDbType.BigInt, 8, "LandValue").Value = ca.LandValue;
            cmd.Parameters.Add("@GroundArea", SqlDbType.Int, 4, "GroundArea").Value = ca.GroundArea;
            cmd.Parameters.Add("@LivingArea", SqlDbType.Date, 4, "LivingArea").Value = ca.LivingArea;
            cmd.Parameters.Add("@BuiltArea", SqlDbType.Int, 4, "BuiltArea").Value = ca.BuiltArea;
            cmd.Parameters.Add("@BasementArea", SqlDbType.Int, 4, "BasementArea").Value = ca.BasementArea;
            cmd.Parameters.Add("@GarageArea", SqlDbType.Int, 4, "GarageArea").Value = ca.GarageArea;
            cmd.Parameters.Add("@BuiltYear", SqlDbType.Int, 4, "BuiltYear").Value = ca.BuiltYear;
            cmd.Parameters.Add("@EnergyClassification", SqlDbType.Char, 10, "EnergyClassification").Value = ca.EnergyClassification;
            cmd.Parameters.Add("@Floors", SqlDbType.Int, 4, "Floors").Value = ca.Floors;
            cmd.Parameters.Add("@Rooms", SqlDbType.Int, 4, "Rooms").Value = ca.Rooms;
            cmd.Parameters.Add("@Bedrooms", SqlDbType.Int, 4, "Bedrooms").Value = ca.Bedrooms;
            cmd.Parameters.Add("@Bathrooms", SqlDbType.Int, 4, "Bathrooms").Value = ca.Bathrooms;
            cmd.Parameters.Add("@Toilets", SqlDbType.Int, 4, "Toilets").Value = ca.Toilets;
            cmd.Parameters.Add("@View", SqlDbType.Int, 4, "View").Value = ca.View;

            try
            {
                connection.Open();
                adId = (int)cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return adId;
        }
    }
}
