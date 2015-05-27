using System;
using System.Collections.Generic;

namespace LivingSmartBusinessLogic.Controller
{
    public class CustomerController
	{
		#region Singleton
		
		private CustomerController _instance;
	    public CustomerController Instance
	    {
			get { return _instance ?? (_instance = new CustomerController()); }
	    }

		#endregion


		private CustomerCatalog customerCatalog;

        private Customer activeCustomer;

        public CustomerController()
        {
            customerCatalog = new CustomerCatalog();
        }

        #region Methods

        #region AdminActiveCustomer
        public void SetActiveCustomer(Customer activeCustomer)
        {
            this.activeCustomer = activeCustomer;
        }

        public void CancelActiveCustomer()
        {
            activeCustomer = null;
        }

        public void SaveActiveCustomer()
        {

            AddCustomer(activeCustomer);
        }
        #endregion

        public void AddCustomer(Customer customer)
        {
			//TODO: Check for valid ID
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

        public void SetName(Customer customer, string name)
        {
            if (customer.Name != name)
                customer.Name = name;
        }

        public void SetDateOfBirth(Customer customer, DateTime dateOfBirth)
        {
            if (customer.DateOfBirth != dateOfBirth)
                customer.DateOfBirth = dateOfBirth;
        }

        public void SetTelephone(Customer customer, string telephone)
        {
            if (customer.Telephone != telephone)
                customer.Telephone = telephone;
        }

        public void SetAddress(Customer customer, string address)
        {
            if (customer.Address != address)
                customer.Address = address;
        }

        public void SetCity(Customer customer, int zipCode)
        {
            var city = CityController.Instance.GetCity(zipCode);
			if (customer.City != city)
                customer.City = city;
        }

        public void SetEmail(Customer customer, string email)
        {
            if (customer.Email != email)
                customer.Email = email;
        }

		public List<Customer> SearchCustomers(int id, string name, string address, int zipcode, string telephone, string email)
		{
			return customerCatalog.SearchCustomers(id, name, address, zipcode, telephone, email);
		}

        #endregion
    }
}
