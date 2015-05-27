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

	    private int lastID = 0;

        internal CustomerCatalog()
        {
            //customers = new List<Customer>();
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
			//TODO: Remove auto ID
			customer.Id = ++lastID;
			customers.Add(customer.Id, customer);
        }

        internal void RemoveFromCatalog(Customer customer)
        {
            customers.Remove(customer.Id);
        }
		
		internal List<Customer> SearchCustomers(int id, string name, string address, int zipcode, string telephone, string email)
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

				if (zipcode != -1 && customer.Value.City.ZipCode.ToString().ToLower().Contains(zipcode.ToString().ToLower()))
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
    }
}
