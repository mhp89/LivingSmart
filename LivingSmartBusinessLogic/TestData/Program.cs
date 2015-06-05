using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic.DBLayer;

namespace TestData
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Dictionary<int, ZipCode> cityList = new Dictionary<int, ZipCode>();
            List<Neighborhood> neighborhoods = new List<Neighborhood>();
            List<string> strings = new List<string>();
            
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "SELECT * FROM ZipCode;"
            };

            int tal = 1;

            SqlDataReader reader = null;
            try
            {
                reader = DBConnectionMSSQL.Instance.ExecuteReader(cmd);
                while (reader.Read())
                {
                    int zipCode = (int)reader["ZipCode"];
                    string district = (string)reader["District"];

                    ZipCode city = new ZipCode(zipCode, district);
                    cityList.Add(tal, city);
                    tal++;
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

            int neighborhoodId = 1;

            Neighborhood neighborhood1;
            Neighborhood neighborhood2;
            Neighborhood neighborhood3;

            strings.Add("USE [LivingSmart] ");
            strings.Add("GO");
            strings.Add("SET IDENTITY_INSERT Neighborhood ON");

            for (int i = 1; i <= cityList.Count; i++)
            {
                neighborhood1 = new Neighborhood(neighborhoodId, cityList[i].postnummer, "Centrum", rnd);
                strings.Add("INSERT INTO [dbo].[Neighborhood] ([Id], [ZipCode], [Neighborhood], [Value]) VALUES (" + neighborhood1.id + "," + neighborhood1.zipcode + ",'" + neighborhood1.name + "'," + neighborhood1.value + ")");
                neighborhoodId++;
                neighborhood2 = new Neighborhood(neighborhoodId, cityList[i].postnummer, "Nord", rnd);
                strings.Add("INSERT INTO [dbo].[Neighborhood] ([Id], [ZipCode], [Neighborhood], [Value])  VALUES (" + neighborhood2.id + "," + neighborhood2.zipcode + ",'" + neighborhood2.name + "'," + neighborhood2.value + ")");
                neighborhoodId++;
                neighborhood3 = new Neighborhood(neighborhoodId, cityList[i].postnummer, "Syd", rnd);
                strings.Add("INSERT INTO [dbo].[Neighborhood] ([Id], [ZipCode], [Neighborhood], [Value]) " +
                            " VALUES (" + neighborhood3.id + "," + neighborhood3.zipcode + ",'" + neighborhood3.name + "'," + neighborhood3.value + ")");
                neighborhoodId++;
            }

            strings.Add("SET IDENTITY_INSERT Neighborhood OFF");
            strings.Add("GO");

            System.IO.File.WriteAllText(@"C:\Users\Bruger\Desktop\nabolag.sql", "");
            System.IO.File.AppendAllLines(@"C:\Users\Bruger\Desktop\nabolag.sql", strings);

            //Console.ReadKey();
        }
    }

    class ZipCode
    {
        public int postnummer;
        public string distrikt;

        public ZipCode(int postnummer, string distrikt)
        {
            this.postnummer = postnummer;
            this.distrikt = distrikt;
        }
    }

    class Neighborhood
    {
        public int id;
        public int zipcode;
        public string name;
        public int value;

        public Neighborhood(int id, int zipcode, string neighborhood, Random rnd)
        {
            this.id = id;
            this.zipcode = zipcode;
            this.name = neighborhood;
            value = rnd.Next(10000, 50000);
        }
    }
}
