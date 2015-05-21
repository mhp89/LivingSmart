using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class CustomerCatalog
    {
        private Dictionary<int, Customer> customers;

        internal CustomerCatalog()
        {
            customers = new Dictionary<int, Customer>();
        }

        internal void LoadCatalog()
        {
            throw new System.NotImplementedException();
        }

        internal Customer Check(int id)
        {
            throw new System.NotImplementedException();
        }

        internal void Save(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        internal void AddToCatalog(Customer customer)
        {
            customers.Add(customer.Id, customer);
        }

        internal void RemoveFromCatalog(Customer customer)
        {
            customers.Remove(customer.Id);
        }
    }
}
