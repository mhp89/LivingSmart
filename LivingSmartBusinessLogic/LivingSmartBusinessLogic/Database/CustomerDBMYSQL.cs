using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.DB
{
    internal class CustomerDBMYSQL : ICustomerDB
    {
        /// <summary>
        /// Returns all the Customers from the database.
        /// </summary>
        /// <returns>Returns a List of all the Customer from the database</returns>
        public List<Customer> ReadCustomers()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the information from a Customer, in the database.
        /// </summary>
        /// <param name="customer">Customer to be updated.</param>
        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new Customer in the database.
        /// </summary>
        /// <param name="customer">Customer to be created.</param>
        /// <returns>Returns the Id of the Customer created.</returns>
        public int CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
