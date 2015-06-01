using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.DB
{
    internal interface ICustomerDB
    {
        /// <summary>
        /// Returns all the Customers from the database.
        /// </summary>
        /// <returns>Returns a List of all the Customer from the database</returns>
        List<Customer> ReadCustomers();

        /// <summary>
        /// Updates the information from a Customer, in the database.
        /// </summary>
        /// <param name="customer">Customer to be updated.</param>
        void UpdateCustomer(Customer customer);

        /// <summary>
        /// Creates a new Customer in the database.
        /// </summary>
        /// <param name="customer">Customer to be created.</param>
        /// <returns>Returns the Id of the Customer created.</returns>
        int CreateCustomer(Customer customer);
    }
}
