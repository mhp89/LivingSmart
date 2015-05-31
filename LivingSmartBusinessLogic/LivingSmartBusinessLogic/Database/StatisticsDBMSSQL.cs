using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using LivingSmartBusinessLogic.DBLayer;

namespace LivingSmartBusinessLogic.DB
{
    internal class StatisticsDBMSSQL : IStatisticsDB
    {
        /// <summary>
        /// Henter solgte ejendomme fra databasen for et år og en mægler
        /// baseret på input og viser summen af salgspriser og antal opdelt per måned
        /// </summary>
        /// <param name="estateAgentId"></param>
        /// <param name="chosenYear"></param>
        /// <returns></returns>
        public List<Statistics> ReadEstateAgentStatistics(int estateAgentId, int chosenYear)
        {
            List<Statistics> list = new List<Statistics>();

            string sqlstring = "SELECT DATEPART(YEAR, DateOfSale) AS Year,";
            sqlstring += "DATEPART(MONTH, DateOfSale) AS Month,";
            sqlstring += "SUM(SellingPrice) as Total, COUNT(SellingPrice) as Count";
            sqlstring += "FROM [Case] inner join EstateAgent on";
            sqlstring += "[Case].EstateAgentId = EstateAgent.EstateAgentId";
            sqlstring += "WHERE Status = 'Solgt' and DATEPART(YEAR, DateOfSale) = " + chosenYear;
            sqlstring += "and [Case].EstateAgentId = " + estateAgentId;
            sqlstring += "Group by DATEPART(MONTH, DateOfSale), DATEPART(YEAR, DateOfSale), ";
            sqlstring += "EstateAgent.Name";
            sqlstring += "Order by MONTH desc";

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = sqlstring,
            };

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int year = (int)reader["Year"];
                    string month = MonthToString((int)reader["Month"]);
                    int total = (int)reader["Total"];
                    int count = (int)reader["Count"];

                    Statistics stats = new Statistics(year, month, total, count);
                    list.Add(stats);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return list;
        }

        /// <summary>
        /// Henter alle solgte ejendomme fra databasen og viser summen af salgprisen
        /// og antallet af ejendomme per år per måned per mægler
        /// </summary>
        /// <returns></returns>
        public List<Statistics> ReadAllStatistics()
        {
            List<Statistics> list = new List<Statistics>();

            string sqlstring = "SELECT DATEPART(YEAR, DateOfSale) AS Year,";
            sqlstring += "DATEPART(MONTH, DateOfSale) AS Month, EstateAgent.Name,";
            sqlstring += "SUM(SellingPrice) as Total, COUNT(SellingPrice) as Count";
            sqlstring += "FROM [Case] inner join EstateAgent on";
            sqlstring += "[Case].EstateAgentId = EstateAgent.EstateAgentId";
            sqlstring += "WHERE Status = 'Solgt'";
            sqlstring += "Group by DATEPART(MONTH, DateOfSale), DATEPART(YEAR, DateOfSale), ";
            sqlstring += "EstateAgent.Name";
            sqlstring += "Order by YEAR desc, Month desc";

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = sqlstring,
            };

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int year = (int)reader["Year"];
                    string month = MonthToString((int)reader["Month"]);
                    string name = (string)reader["Name"];
                    int total = (int)reader["Total"];
                    int count = (int)reader["Count"];

                    Statistics stats = new Statistics(year, month, name, total, count);
                    list.Add(stats);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return list;
        }

        public Statistics ReadDialStatistics()
        {
            Statistics stats = new Statistics();

            string sqlstring = "SELECT DATEPART(YEAR, DateOfSale) AS Year,";
            sqlstring += "SUM(SellingPrice) as Total, COUNT(SellingPrice) as Count";
            sqlstring += "FROM [Case]";
            sqlstring += "WHERE Status = 'Solgt'";
            sqlstring += "and DATEPART(YEAR, DateOfSale) = DATEPART(YEAR, GETDATE())";
            sqlstring += "Group by DATEPART(YEAR, DateOfSale)";

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = sqlstring,
            };

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    stats.Year = (int)reader["Year"];
                    stats.SellingpriceTotal = (int)reader["Total"];
                    stats.PropertiesTotal = (int)reader["Count"];
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return stats;
        }

        /// <summary>
        /// Returnerer navnet på måneden efter at have fået input som tal.
        /// Få det forkortede månedsnavn med AbbreviatedMonthName istedet for GetMonthName
        /// </summary>
        /// <param name="month"></param>
        /// <returns></returns>
        private static string MonthToString(int month)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
        }
    }
}
