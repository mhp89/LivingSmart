using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class CustomerCatalog
    {
        private System.Collections.Generic.List<LivingSmartBusinessLogic.Customer> customers;

        public Customer Check(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public void AddToCatalog(Customer customer)
        {
            customers.Add(customer);
        }

        public void RemoveFromCatalog(Customer customer)
        {
            customers.Remove(customer);
        }
    }
}
