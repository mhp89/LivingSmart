using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LivingSmartBusinessLogic.Controller
{
    public class CustomerController
	{
		#region Singleton

		private static CustomerController _instance;
		public static CustomerController Instance
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

        public Customer MakeNewCustomer(string name, DateTime dateOfBirth, string address, int zipCode, string email, string telephone)
        {
            return new Customer(name, dateOfBirth, address, CityController.Instance.GetCity(zipCode), email, telephone);
        }

        public Customer ReadCustomer(int id)
        {
            return customerCatalog.Check(id);        
        }

        public ReadOnlyCollection<Customer> GetCustomers()
        {
            return customerCatalog.GetCustomers();
        }

        public void SetName(string name)
        {
            if (activeCustomer.Name != name)
                activeCustomer.Name = name;
        }

        public void SetDateOfBirth(DateTime dateOfBirth)
        {
            if (activeCustomer.DateOfBirth != dateOfBirth)
                activeCustomer.DateOfBirth = dateOfBirth;
        }

        public void SetTelephone(string telephone)
        {
            if (activeCustomer.Telephone != telephone)
                activeCustomer.Telephone = telephone;
        }

        public void SetAddress(string address)
        {
            if (activeCustomer.Address != address)
                activeCustomer.Address = address;
        }

        public void SetCity(int zipCode)
        {
	        var city = CityController.Instance.GetCity(zipCode);
			if (activeCustomer.City != city)
                activeCustomer.City = city;
        }

        public void SetEmail(string email)
        {
            if (activeCustomer.Email != email)
                activeCustomer.Email = email;
        }

		public ReadOnlyCollection<Customer> SearchCustomers(int id, string name, string address, int zipcode, string telephone, string email)
		{
			return customerCatalog.SearchCustomers(id, name, address, zipcode, telephone, email).AsReadOnly();
		}

        #endregion
    }
}
