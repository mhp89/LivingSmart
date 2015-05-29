using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using LivingSmartBusinessLogic.DB;

namespace LivingSmartBusinessLogic
{
    public class CustomerCatalog
    {
        private Dictionary<int, Customer> customers;

	    private ICustomerDB db;
		
        internal CustomerCatalog()
        {
			db = CustomerDBFactory.GetDBL();
            customers = new Dictionary<int, Customer>();

			LoadCatalog();
        }

        internal void LoadCatalog()
        {
	        var customerList = db.ReadCustomers();
	        foreach (var customer in customerList)
		        AddToCatalog(customer);
        }

        internal Customer Check(int id)
        {
            throw new System.NotImplementedException();
        }

        internal void Save(Customer customer)
		{
			//TODO: Check for exist
			customer.Id = db.CreateCustomer(customer);
        }

        internal void AddToCatalog(Customer customer)
        {
			if(!customers.ContainsKey(customer.Id))
				customers.Add(customer.Id, customer);
        }

        internal void RemoveFromCatalog(Customer customer)
        {
            customers.Remove(customer.Id);
        }

        internal List<Customer> SearchCustomers(int id, string name, string address, int zipcode, string telephone,
            string email)
        {
            List<Customer> result = new List<Customer>();

            foreach (var customer in customers)
            {
                bool success = true;

                if (id != -1 && !customer.Value.Id.ToString().ToLower().Contains(id.ToString().ToLower()))
                    success = false;

                if (name != null && !customer.Value.Name.ToLower().Contains(name.ToLower()))
                    success = false;

                if (address != null && !customer.Value.Address.ToLower().Contains(address.ToLower()))
                    success = false;

                if (zipcode != -1 &&
                    customer.Value.City.ZipCode.ToString().ToLower().Contains(zipcode.ToString().ToLower()))
                    success = false;

                if (telephone != null && !customer.Value.Telephone.ToLower().Contains(telephone.ToLower()))
                    success = false;

                if (email != null && !customer.Value.Email.ToLower().Contains(email.ToLower()))
                    success = false;

                if (success)
                    result.Add(customer.Value);
            }

            return result;
        }

        internal ReadOnlyCollection<Customer> GetCustomers()
        {
            var customerList = customers.Values.ToList();
            return customerList.AsReadOnly();
        }
    }
}
