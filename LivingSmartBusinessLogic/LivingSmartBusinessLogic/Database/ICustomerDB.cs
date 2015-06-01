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
        List<Customer> ReadCustomers();
        void UpdateCustomer(Customer customer);
        int CreateCustomer(Customer customer);
    }
}
