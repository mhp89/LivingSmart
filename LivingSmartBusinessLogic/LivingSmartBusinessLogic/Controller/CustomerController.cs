using System;

namespace LivingSmartBusinessLogic.Controller
{
    public class CustomerController
    {
        private CustomerCatalog customerCatalog;

        private Customer activeCustomer;

        public CustomerController()
        {
            customerCatalog = new CustomerCatalog();
        }

        #region Methods
        
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

        public void SetZipCode(Customer customer, City city)
        {
            if (customer.City != city)
                customer.City = city;
        }

        public void SetEmail(Customer customer, string email)
        {
            if (customer.Email != email)
                customer.Email = email;
        }

        #endregion
    }
}
