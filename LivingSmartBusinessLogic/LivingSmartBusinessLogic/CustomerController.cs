using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class CustomerController
    {
        private CustomerCatalog customerCatalog;
        public void AddCustomer(Customer customer)
        {
            customerCatalog.AddToCatalog(customer);
        }

        public Customer MakeNewCustomer()
        {
            return new Customer();
        }

        public Customer ReadCustomer(int id)
        {
            return customerCatalog.Check(id);        
        }

        public void UpdateCustomer(Customer customer)
        {
            customerCatalog.Save(customer);
        }
    }
}
