using System;
using System.Collections.Generic;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Database
{
    internal class CustomerDBXML : ICustomerDB
    {
        /// <summary>
        /// Returns all the customers from the database.
        /// </summary>
        /// <returns>Returns a List of all the customers from the database.</returns>
        /// <author>René Sørensen</author>
        public List<Customer> ReadCustomers()
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public int CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
