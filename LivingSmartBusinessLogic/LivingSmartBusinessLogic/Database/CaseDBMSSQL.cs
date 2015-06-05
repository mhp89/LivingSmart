using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Database
{
    internal class CaseDBMSSQL : ICaseDB
    {
        /// <summary>
        /// Returns all the Cases from the database, with a given EstateAgentId.
        /// </summary>
        /// <param name="estateAgentId">Id of the estate agent</param>
        /// <returns>Returns a List of all the Cases, having a EstateAgentId given by the parameter</returns>
        /// <author>René Sørensen</author>
        public List<Case> ReadCases(int estateAgentId)
        {
            List<Case> caseList = new List<Case>();

            SqlCommand cmd = new SqlCommand
            {
                CommandText = "SELECT * FROM [Case] WHERE EstateAgentId = (@EstateAgentId);",
            };
            cmd.Parameters.Add("@EstateAgentId", SqlDbType.Int, 4, "EstateAgentId").Value = estateAgentId;

	        SqlDataReader reader = null;
	        try
	        {
		        reader = DBConnectionMSSQL.Instance.ExecuteReader(cmd);
		        while (reader.Read())
		        {
			        int caseId = (int) reader["CaseId"];
			        int sellerId = (int) reader["SellerId"];
			        int buyerId = (int) reader["BuyerId"];
			        DateTime creationDate = (DateTime) reader["creationDate"];
			        string status = (string) reader["Status"];
			        DateTime dateOfSale = (DateTime) reader["DateOfSale"];
			        DateTime transferDate = (DateTime) reader["TransferDate"];
			        DateTime dateOfCompletion = (DateTime) reader["DateOfCompletion"];
			        long sellingPrice = (long) reader["SellingPrice"];
			        string description = (string) reader["Description"];
			        int propertyTypeId = (int) reader["PropertyTypeId"];
			        string landRegistryNumber = (string) reader["LandRegistryNumber"];
			        string address = (string) reader["Address"];
			        int zipCode = (int) reader["ZipCode"];
			        int neighborhoodId = (int) reader["NeighborhoodId"];
			        long publicRating = (long) reader["PublicRating"];
			        long landValue = (long) reader["LandValue"];
			        string type = (string) reader["Type"];
			        int groundArea = (int) reader["GroundArea"];
			        int livingArea = (int) reader["LivingArea"];
			        int builtArea = (int) reader["BuiltArea"];
			        int basementArea = (int) reader["BasementArea"];
			        int garageArea = (int) reader["GarageArea"];
			        int builtYear = (int) reader["BuiltYear"];
			        string energyClassification = (string) reader["EnergyClassification"];
			        int floors = (int) reader["Floors"];
			        int rooms = (int) reader["Rooms"];
			        int bedrooms = (int) reader["Bedrooms"];
			        int bathrooms = (int) reader["Bathrooms"];
			        int toilets = (int) reader["Toilets"];
			        int view = (int) reader["View"];

			        Case ca = new Case(caseId, sellerId, buyerId, estateAgentId, creationDate, status, dateOfSale,
				        transferDate, dateOfCompletion, sellingPrice, description, landRegistryNumber, address,
				        zipCode, propertyTypeId, publicRating, landValue, groundArea, builtArea, livingArea,
				        basementArea, builtYear, energyClassification, floors, rooms, bedrooms, bathrooms, toilets, garageArea, view,
				        neighborhoodId);
			        caseList.Add(ca);
		        }
	        }
	        catch (SqlException e)
	        {
		        Console.WriteLine(e.Message);
	        }
	        finally
	        {
		        if (reader != null)
			        reader.Close();
	        }

            return caseList;
        }

		public List<Case> ReadCases()
		{
			List<Case> caseList = new List<Case>();

			SqlCommand cmd = new SqlCommand
			{
				CommandText = "SELECT * FROM [Case];",
			};

			SqlDataReader reader = null;
			try
			{
				reader = DBConnectionMSSQL.Instance.ExecuteReader(cmd);
				while (reader.Read())
				{
					int caseId = (int)reader["CaseId"];
					int sellerId = (int)reader["SellerId"];
				    int buyerId = reader["BuyerId"] is DBNull ? -1 : (int) reader["BuyerId"];
                    int estateAgentId = (int)reader["EstateAgentId"];
					DateTime creationDate = (DateTime)reader["creationDate"];
					string status = (string)reader["Status"];
					DateTime? dateOfSale = reader["DateOfSale"] is DBNull? null : (DateTime?) reader["DateOfSale"];
                    DateTime? transferDate = reader["TransferDate"] is DBNull ? null : (DateTime?)reader["TransferDate"];
                    DateTime? dateOfCompletion = reader["DateOfCompletion"] is DBNull ? null : (DateTime?)reader["DateOfCompletion"];
					long? sellingPrice = reader["SellingPrice"] is DBNull ? (long?) null : (long) reader["SellingPrice"];
					string description = (string)reader["Description"];
					int propertyTypeId = (int)reader["PropertyTypeId"];
					string landRegistryNumber = (string)reader["LandRegistryNumber"];
					string address = (string)reader["Address"];
					int zipCode = (int)reader["ZipCode"];
					int neighborhoodId = (int)reader["NeighborhoodId"];
					long publicRating = (long)reader["PublicRating"];
					long landValue = (long)reader["LandValue"];
					int groundArea = (int)reader["GroundArea"];
					int livingArea = (int)reader["LivingArea"];
					int builtArea = (int)reader["BuiltArea"];
					int basementArea = (int)reader["BasementArea"];
					int garageArea = (int)reader["GarageArea"];
					int builtYear = (int)reader["BuiltYear"];
					string energyClassification = (string)reader["EnergyClassification"];
					int floors = (int)reader["Floors"];
					int rooms = (int)reader["Rooms"];
					int bedrooms = (int)reader["Bedrooms"];
					int bathrooms = (int)reader["Bathrooms"];
					int toilets = (int)reader["Toilets"];
					int view = (int)reader["View"];

					Case ca = new Case(caseId, sellerId, buyerId, estateAgentId, creationDate, status, dateOfSale,
						transferDate, dateOfCompletion, sellingPrice, description, landRegistryNumber, address,
						zipCode, propertyTypeId, publicRating, landValue, groundArea, builtArea, livingArea,
						basementArea, builtYear, energyClassification, floors, rooms, bedrooms, bathrooms, toilets, garageArea, view, neighborhoodId);
					caseList.Add(ca);
				}
			}
			catch (SqlException e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				if (reader != null)
					reader.Close();
			}

			return caseList;
		}

        /// <summary>
        /// Updates the information from a Case, in the database.
        /// </summary>
        /// <param name="ca">Case to be updated.</param>
        /// <author>René Sørensen</author>
        public void UpdateCase(Case ca)
        {
            int caseId = ca.Id;

            SqlCommand cmd = new SqlCommand
            {
                CommandText = "UPDATE [Case] SET SellerId = (@SellerId), BuyerId = (@BuyerId), EstateAgentId = (@EstateAgentId), CreationDate = (@CreationDate), Status = (@Status), " +
                "DateOfSale = (@DateOfSale), TransferDate = (@TransferDate), DateOfCompletion = (@DateOfCompletion), SellingPrice = (@SellingPrice), Description = (@Description), " +
				"PropertyTypeId = (@PropertyTypeId), LandRegistryNumber = (@LandRegistryNumber), Address = (@Address), ZipCode = (@ZipCode), NeighborhoodId = (@NeighborhoodId), " +
                "PublicRating = (@PublicRating), LandValue = (@LandValue), GroundArea = (@GroundArea), LivingArea = (@LivingArea), BuiltArea = (@BuiltArea), " +
                "BasementArea = (@BasementArea), GarageArea = (@GarageArea), BuiltYear = (@BuiltYear), EnergyClassification = (@EnergyClassification), Floors = (@Floors), " +
                "Rooms = (@Rooms), Bedrooms = (@Bedrooms), Bathrooms = (@Bathrooms), Toilets = (@Toilets), [View] = (@View) " +
				"WHERE CaseId = (@CaseId)"
            };

			cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "CaseId").Value = caseId;

			cmd.Parameters.Add("@SellerId", SqlDbType.Int, 4, "SellerId").Value = ca.Seller.Id;
			cmd.Parameters.Add("@BuyerId", SqlDbType.Int, 4, "BuyerId").Value = (ca.Buyer != null) ? (object)ca.Buyer.Id : DBNull.Value;
            cmd.Parameters.Add("@EstateAgentId", SqlDbType.Int, 4, "EstateAgentId").Value = ca.EstateAgent.Id;
            cmd.Parameters.Add("@CreationDate", SqlDbType.Date, 8, "CreationDate").Value = ca.CreationDate;
			cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 50, "Status").Value = ca.Status;
			cmd.Parameters.Add("@DateOfSale", SqlDbType.Date, 8, "DateOfSale").Value = (ca.DateOfSale != null) ? (object)ca.DateOfSale : DBNull.Value;
			cmd.Parameters.Add("@TransferDate", SqlDbType.Date, 8, "TransferDate").Value = (ca.TransferDate != null) ? (object)ca.TransferDate : DBNull.Value;
			cmd.Parameters.Add("@DateOfCompletion", SqlDbType.Date, 8, "DateOfCompletion").Value = (ca.DateOfCompletion != null) ? (object)ca.DateOfCompletion : DBNull.Value;
			cmd.Parameters.Add("@SellingPrice", SqlDbType.BigInt, 8, "SellingPrice").Value = (ca.SellingPrice != null) ? (object)ca.SellingPrice : DBNull.Value;
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 500, "Description").Value = ca.Description;

            cmd.Parameters.Add("@PropertyTypeId", SqlDbType.Int, 4, "PropertyTypeId").Value = ca.PropertyType.Id;
            cmd.Parameters.Add("@LandRegistryNumber", SqlDbType.NVarChar, 10, "LandRegistryNumber").Value = ca.LandRegistryNumber;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 10, "Address").Value = ca.Address;
            cmd.Parameters.Add("@ZipCode", SqlDbType.Int, 4, "ZipCode").Value = ca.City.ZipCode;
			cmd.Parameters.Add("@NeighborhoodId", SqlDbType.Int, 4, "NeighborhoodId").Value = ca.Neighborhood.Id;
            cmd.Parameters.Add("@PublicRating", SqlDbType.BigInt, 8, "PublicRating").Value = ca.PublicRating;
            cmd.Parameters.Add("@LandValue", SqlDbType.BigInt, 8, "LandValue").Value = ca.LandValue;
            cmd.Parameters.Add("@GroundArea", SqlDbType.Int, 4, "GroundArea").Value = ca.GroundArea;
            cmd.Parameters.Add("@LivingArea", SqlDbType.Int, 4, "LivingArea").Value = ca.LivingArea;
            cmd.Parameters.Add("@BuiltArea", SqlDbType.Int, 4, "BuiltArea").Value = ca.BuiltArea;

            cmd.Parameters.Add("@BasementArea", SqlDbType.Int, 4, "BasementArea").Value = ca.BasementArea;
            cmd.Parameters.Add("@GarageArea", SqlDbType.Int, 4, "GarageArea").Value = ca.GarageArea;
            cmd.Parameters.Add("@BuiltYear", SqlDbType.Int, 4, "BuiltYear").Value = ca.BuiltYear;
            cmd.Parameters.Add("@EnergyClassification", SqlDbType.NVarChar, 10, "EnergyClassification").Value = ca.EnergyClassification;
            cmd.Parameters.Add("@Floors", SqlDbType.Int, 4, "Floors").Value = ca.Floors;
            cmd.Parameters.Add("@Rooms", SqlDbType.Int, 4, "Rooms").Value = ca.Rooms;
            cmd.Parameters.Add("@Bedrooms", SqlDbType.Int, 4, "Bedrooms").Value = ca.Bedrooms;
            cmd.Parameters.Add("@Bathrooms", SqlDbType.Int, 4, "Bathrooms").Value = ca.Bathrooms;
            cmd.Parameters.Add("@Toilets", SqlDbType.Int, 4, "Toilets").Value = ca.Toilets;
            cmd.Parameters.Add("@View", SqlDbType.Int, 4, "View").Value = ca.View;

            DBConnectionMSSQL.Instance.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// Creates a new Case in the database.
        /// </summary>
        /// <param name="ca">Case to be created.</param>
        /// <returns>Returns the Id of the Case created.</returns>
        /// <author>René Sørensen</author>
        public int CreateCase(Case ca)
        {
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "INSERT INTO [Case] OUTPUT INSERTED.CaseId VALUES (" +
                    "@SellerId, @BuyerId, @EstateAgentId, @CreationDate, @Status, @DateOfSale, @TransferDate, @DateOfCompletion, @SellingPrice, @Description, " +
					"@PropertyTypeId, @LandRegistryNumber, @Address, @ZipCode, @NeighborhoodId, @PublicRating, @LandValue, @GroundArea, @LivingArea, @BuiltArea, " +
                    "@BasementArea, @GarageArea, @BuiltYear, @EnergyClassification, @Floors, @Rooms, @Bedrooms, @Bathrooms, @Toilets, @View); "
            };

            cmd.Parameters.Add("@SellerId", SqlDbType.Int, 4, "SellerId").Value = ca.Seller.Id;
	        cmd.Parameters.Add("@BuyerId", SqlDbType.Int, 4, "BuyerId").Value = (ca.Buyer != null) ? (object) ca.Buyer.Id : DBNull.Value;
            cmd.Parameters.Add("@EstateAgentId", SqlDbType.Int, 4, "EstateAgentId").Value = ca.EstateAgent.Id;
            cmd.Parameters.Add("@CreationDate", SqlDbType.Date, 8, "CreationDate").Value = ca.CreationDate;
            cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 50, "Status").Value = ca.Status;
			cmd.Parameters.Add("@DateOfSale", SqlDbType.Date, 8, "DateOfSale").Value = (ca.DateOfSale != null) ? (object)ca.DateOfSale : DBNull.Value;
			cmd.Parameters.Add("@TransferDate", SqlDbType.Date, 8, "TransferDate").Value = (ca.TransferDate != null) ? (object)ca.TransferDate : DBNull.Value;
			cmd.Parameters.Add("@DateOfCompletion", SqlDbType.Date, 8, "DateOfCompletion").Value = (ca.DateOfCompletion != null) ? (object)ca.DateOfCompletion : DBNull.Value;
			cmd.Parameters.Add("@SellingPrice", SqlDbType.BigInt, 8, "SellingPrice").Value = (ca.SellingPrice != null) ? (object)ca.SellingPrice : DBNull.Value;
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 500, "Description").Value = ca.Description;

            cmd.Parameters.Add("@PropertyTypeId", SqlDbType.Int, 4, "PropertyTypeId").Value = ca.PropertyType.Id;
            cmd.Parameters.Add("@LandRegistryNumber", SqlDbType.NVarChar, 10, "LandRegistryNumber").Value = ca.LandRegistryNumber;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 10, "Address").Value = ca.Address;
            cmd.Parameters.Add("@ZipCode", SqlDbType.Int, 4, "ZipCode").Value = ca.City.ZipCode;
			cmd.Parameters.Add("@NeighborhoodId", SqlDbType.Int, 4, "NeighborhoodId").Value = ca.Neighborhood.Id;
            cmd.Parameters.Add("@PublicRating", SqlDbType.BigInt, 8, "PublicRating").Value = ca.PublicRating;
            cmd.Parameters.Add("@LandValue", SqlDbType.BigInt, 8, "LandValue").Value = ca.LandValue;
            cmd.Parameters.Add("@GroundArea", SqlDbType.Int, 4, "GroundArea").Value = ca.GroundArea;
            cmd.Parameters.Add("@LivingArea", SqlDbType.Int, 4, "LivingArea").Value = ca.LivingArea;
            cmd.Parameters.Add("@BuiltArea", SqlDbType.Int, 4, "BuiltArea").Value = ca.BuiltArea;

            cmd.Parameters.Add("@BasementArea", SqlDbType.Int, 4, "BasementArea").Value = ca.BasementArea;
            cmd.Parameters.Add("@GarageArea", SqlDbType.Int, 4, "GarageArea").Value = ca.GarageArea;
            cmd.Parameters.Add("@BuiltYear", SqlDbType.Int, 4, "BuiltYear").Value = ca.BuiltYear;
            cmd.Parameters.Add("@EnergyClassification", SqlDbType.NVarChar, 10, "EnergyClassification").Value = ca.EnergyClassification;
            cmd.Parameters.Add("@Floors", SqlDbType.Int, 4, "Floors").Value = ca.Floors;
            cmd.Parameters.Add("@Rooms", SqlDbType.Int, 4, "Rooms").Value = ca.Rooms;
            cmd.Parameters.Add("@Bedrooms", SqlDbType.Int, 4, "Bedrooms").Value = ca.Bedrooms;
            cmd.Parameters.Add("@Bathrooms", SqlDbType.Int, 4, "Bathrooms").Value = ca.Bathrooms;
            cmd.Parameters.Add("@Toilets", SqlDbType.Int, 4, "Toilets").Value = ca.Toilets;
            cmd.Parameters.Add("@View", SqlDbType.Int, 4, "View").Value = ca.View;

	        return (int) DBConnectionMSSQL.Instance.ExecuteScalar(cmd, -1);
        }
    }
}
