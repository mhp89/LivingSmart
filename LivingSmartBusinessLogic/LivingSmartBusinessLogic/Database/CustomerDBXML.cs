using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DB
{
    internal class CustomerDBXML : ICustomerDB
    {
        /// <summary>
        /// Returns all the customers from the database.
        /// </summary>
        /// <returns>Returns a List of all the customers from the database.</returns>
        public List<Customer> ReadCustomers()
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer()
        {
            throw new NotImplementedException();
        }

        public int CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
