using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class CustomerCatalog
    {
        private Dictionary<int, Customer> customers;
        //private List<Customer> customers;

        public CustomerCatalog()
        {
            //customers = new List<Customer>();
            customers = new Dictionary<int, Customer>();
        }

        public void LoadCatalog()
        {
            throw new System.NotImplementedException();
        }

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
            customers.Add(customer.Id, customer);
        }

        public void RemoveFromCatalog(Customer customer)
        {
            customers.Remove(customer.Id);
        }
    }
}
