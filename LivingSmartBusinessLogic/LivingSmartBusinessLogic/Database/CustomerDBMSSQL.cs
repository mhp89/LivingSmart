using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic.Controller;
using LivingSmartBusinessLogic.DBLayer;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.DB
{
    internal class CustomerDBMSSQL : ICustomerDB
    {
        /// <summary>
        /// Returns all the Customers from the database.
        /// </summary>
        /// <returns>Returns a List of all the Customer from the database</returns>
        public List<Customer> ReadCustomers()
        {
            List<Customer> customerList = new List<Customer>();
            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "SELECT * FROM Customer;",
            };

            try
			{
				connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int) reader["CustomerId"];
                    string name = (string) reader["Name"];
                    DateTime dateOfBirth = (DateTime) reader["DateOfBirth"];
                    string address = (string) reader["Address"];
                    int zipCode = (int) reader["ZipCode"];
                    string telephone = (string) reader["Telephone"];
                    string email = (string) reader["Email"];

                    Customer c = new Customer(id, name, dateOfBirth, address, zipCode, email, telephone);
                    customerList.Add(c);
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

            return customerList;
        }

        /// <summary>
        /// Updates the information from a Customer, in the database.
        /// </summary>
        /// <param name="customer">Customer to be updated.</param>
        public void UpdateCustomer(Customer customer)
        {
            int customerID = customer.Id;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "UPDATE CUSTOMER SET NAME = (@Name), DateOfBirth = (@DateOfBirth), Address = (@Address), ZipCode = (@ZipCode), Telephone = (@Telephone), Email = (@Email)" + "WHERE CustomerID = " + customerID
            };

            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name").Value = customer.Name;
            cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date, 8, "Name").Value = customer.DateOfBirth;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 50, "Name").Value = customer.Address;
            cmd.Parameters.Add("@ZipCode", SqlDbType.Int, 4, "Name").Value = customer.City.ZipCode;
            cmd.Parameters.Add("@Telephone", SqlDbType.NVarChar, 20, "Name").Value = customer.Telephone;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 50, "Name").Value = customer.Email;

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Creates a new Customer in the database.
        /// </summary>
        /// <param name="customer">Customer to be created.</param>
        /// <returns>Returns the Id of the Customer created.</returns>
        public int CreateCustomer(Customer customer)
        {
            int customerID = 0;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
				CommandText = "INSERT INTO Customer OUTPUT INSERTED.CustomerId VALUES (@Name, @DateOfBirth, @Address, @ZipCode, @Telephone, @Email); "
            };

            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name").Value = customer.Name;
            cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date, 8, "Name").Value = customer.DateOfBirth;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 50, "Name").Value = customer.Address;
            cmd.Parameters.Add("@ZipCode", SqlDbType.Int, 4, "Name").Value = customer.City.ZipCode;
            cmd.Parameters.Add("@Telephone", SqlDbType.NVarChar, 20, "Name").Value = customer.Telephone;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 50, "Name").Value = customer.Email;

            try
            {
                connection.Open();
                customerID = (int) cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return customerID;
        }
    }
}
