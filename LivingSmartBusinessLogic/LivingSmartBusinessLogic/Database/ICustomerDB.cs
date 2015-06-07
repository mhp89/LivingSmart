using System.Collections.Generic;
using LivingSmartBusinessLogic.Entity;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Database
{
    internal interface ICustomerDB
    {
        /// <summary>
        /// Returns all the Customers from the database.
        /// </summary>
        /// <returns>Returns a List of all the Customer from the database</returns>
        /// <author>René Sørensen</author>
        List<Customer> ReadCustomers();

        /// <summary>
        /// Updates the information from a Customer, in the database.
        /// </summary>
        /// <param name="customer">Customer to be updated.</param>
        /// <author>René Sørensen</author>
        void UpdateCustomer(Customer customer);

        /// <summary>
        /// Creates a new Customer in the database.
        /// </summary>
        /// <param name="customer">Customer to be created.</param>
        /// <returns>Returns the Id of the Customer created.</returns>
        /// <author>René Sørensen</author>
        int CreateCustomer(Customer customer);
    }
}
