using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using LivingSmartBusinessLogic.Entity;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Database
{
    internal class CustomerDBMSSQL : ICustomerDB
    {
        /// <summary>
        /// Returns all the Customers from the database.
        /// </summary>
        /// <returns>Returns a List of all the Customer from the database</returns>
        /// <author>René Sørensen</author>
        public List<Customer> ReadCustomers()
        {
            List<Customer> customerList = new List<Customer>();

            SqlCommand cmd = new SqlCommand
            {
                CommandText = "SELECT * FROM Customer;",
            };

	        SqlDataReader reader = null;
            try
            {
	            reader = DBConnectionMSSQL.Instance.ExecuteReader(cmd);
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
				if (reader != null)
					reader.Close();
			}

            return customerList;
        }

        /// <summary>
        /// Updates the information from a Customer, in the database.
        /// </summary>
        /// <param name="customer">Customer to be updated.</param>
        /// <author>René Sørensen</author>
        public void UpdateCustomer(Customer customer)
        {
            int customerID = customer.Id;

            SqlCommand cmd = new SqlCommand
            {
				CommandText = "UPDATE Customer SET Name = (@Name), DateOfBirth = (@DateOfBirth), " +
                              "Address = (@Address), ZipCode = (@ZipCode), " + 
                              "Telephone = (@Telephone), Email = (@Email)" + 
                              "WHERE CustomerID = (@CustomerID)"
			};

			cmd.Parameters.Add("@CustomerID", SqlDbType.Int, 4, "CustomerID").Value = customerID;

            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name").Value = customer.Name;
			cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date, 8, "DateOfBirth").Value = customer.DateOfBirth;
			cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 50, "Address").Value = customer.Address;
			cmd.Parameters.Add("@ZipCode", SqlDbType.Int, 4, "ZipCode").Value = customer.City.ZipCode;
			cmd.Parameters.Add("@Telephone", SqlDbType.NVarChar, 20, "Telephone").Value = customer.Telephone;
			cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 50, "Email").Value = customer.Email;

			DBConnectionMSSQL.Instance.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// Creates a new Customer in the database.
        /// </summary>
        /// <param name="customer">Customer to be created.</param>
        /// <returns>Returns the Id of the Customer created.</returns>
        /// <author>René Sørensen</author>
        public int CreateCustomer(Customer customer)
        {
            SqlCommand cmd = new SqlCommand
            {
				CommandText = "INSERT INTO Customer OUTPUT INSERTED.CustomerId VALUES " + 
                              "(@Name, @DateOfBirth, @Address, @ZipCode, @Telephone, @Email);"
            };

            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name").Value = customer.Name;
            cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date, 8, "DateOfBirth").Value = customer.DateOfBirth;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 50, "Address").Value = customer.Address;
            cmd.Parameters.Add("@ZipCode", SqlDbType.Int, 4, "ZipCode").Value = customer.City.ZipCode;
            cmd.Parameters.Add("@Telephone", SqlDbType.NVarChar, 20, "Telephone").Value = customer.Telephone;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 50, "Email").Value = customer.Email;

			return  (int)DBConnectionMSSQL.Instance.ExecuteScalar(cmd, -1);
        }
    }
}
