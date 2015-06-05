using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.Catalog;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Controller
{
    /// <summary>
    /// Customercontroller
    /// </summary>
    /// <author>Mathias Pousen</author>
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

        private CustomerController()
        {
            customerCatalog = new CustomerCatalog();
        }

        #region Methods

        #region AdminActiveCustomer

        /// <summary>
        /// Sætter aktiv kunde
        /// </summary>
        /// <param name="newActiveCustomer"></param>
        /// <author>Mathias Poulsen</author>
        public void SetActiveCustomer(Customer newActiveCustomer)
        {
            activeCustomer = newActiveCustomer;
        }
        /// <summary>
        /// Fortryder valg af aktiv kunde. / Sætter aktiv kunde lig null
        /// </summary>
        /// <author>Mathias Poulsen</author>
        public void CancelActiveCustomer()
        {
            activeCustomer = null;
        }

        /// <summary>
        /// Gemmer den aktive kunde
        /// </summary>
        /// <author>Mathias Petersen</author>
        public void SaveActiveCustomer()
        {
			customerCatalog.Save(activeCustomer);
			if(activeCustomer.Id != -1)
				customerCatalog.AddToCatalog(activeCustomer);
        }
        #endregion

        /// <summary>
        /// Laver en ny kunde, sætter denne kunde som ny aktiv kunde 
        /// og retunerer den aktive kunde
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="address"></param>
        /// <param name="zipCode"></param>
        /// <param name="email"></param>
        /// <param name="telephone"></param>
        /// <returns></returns>
        /// <author>Mathias Poulsen</author>
        public Customer MakeNewCustomer(string name, DateTime dateOfBirth, string address, 
            int zipCode, string email, string telephone)
        {
            SetActiveCustomer(new Customer(name, dateOfBirth, address, 
                zipCode, email, telephone));
            return activeCustomer;
        }
        /// <summary>
        /// Henter en kunde
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <author>Mathias Poulsen</author>
        public Customer ReadCustomer(int id)
        {
            return customerCatalog.Read(id);        
        }
        /// <summary>
        /// Henter alle kunder
        /// </summary>
        /// <returns></returns>
        /// <author>Mathias Poulsen</author>
        public ReadOnlyCollection<Customer> GetCustomers()
        {
            return customerCatalog.GetCustomers();
        }
        /// <summary>
        /// Henter en kunde
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        /// <author>Mathias Poulsen</author>
        public Customer GetCustomer(int customerId)
        {
            return customerCatalog.GetCustomer(customerId);
        }

        #region PropertyMethods
        /// <summary>
        /// Sætter navn på den aktive kunde
        /// </summary>
        /// <param name="name"></param>
        /// <author>Mathias Poulsen</author>
        public void SetName(string name)
        {
            if (activeCustomer.Name != name)
                activeCustomer.Name = name;
        }
        /// <summary>
        /// Sætter fødselsdag på den aktive kunde
        /// </summary>
        /// <param name="dateOfBirth"></param>
        /// <author>Mathias Poulsen</author>
        public void SetDateOfBirth(DateTime dateOfBirth)
        {
            if (activeCustomer.DateOfBirth != dateOfBirth)
                activeCustomer.DateOfBirth = dateOfBirth;
        }
        /// <summary>
        /// Sætter telefonnummer på den aktive kunde
        /// </summary>
        /// <param name="telephone"></param>
        /// <author>Mathias Poulsen</author>
        public void SetTelephone(string telephone)
        {
            if (activeCustomer.Telephone != telephone)
                activeCustomer.Telephone = telephone;
        }
        /// <summary>
        /// Sætter adresse på den aktive kunde
        /// </summary>
        /// <param name="address"></param>
        /// <author>Mathias Poulsen</author>
        public void SetAddress(string address)
        {
            if (activeCustomer.Address != address)
                activeCustomer.Address = address;
        }
        /// <summary>
        /// Sætter by på den aktive kunde
        /// </summary>
        /// <param name="zipCode"></param>
        /// <author>Mathias Poulsen</author>
        public void SetCity(int zipCode)
        {
            var city = CityController.Instance.GetCity(zipCode);
            if (activeCustomer.City != city)
                activeCustomer.City = city;
        }
        /// <summary>
        /// Sætter email på den aktive kunde
        /// </summary>
        /// <param name="email"></param>
        /// <author>Mathias Poulsen</author>
        public void SetEmail(string email)
        {
            if (activeCustomer.Email != email)
                activeCustomer.Email = email;
        }
        #endregion
        
        /// <summary>
        /// Søger efter kunder
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="zipcode"></param>
        /// <param name="telephone"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        /// <author>Mathias Petersen</author>
		public ReadOnlyCollection<Customer> SearchCustomers(int id, string name, string address, int zipcode, string telephone, string email)
		{
			return customerCatalog.SearchCustomers(id, name, address, zipcode, telephone, email).AsReadOnly();
		}

        #endregion
    }
}
