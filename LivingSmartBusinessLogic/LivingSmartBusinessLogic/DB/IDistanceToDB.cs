﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IDistanceToDB
    {
        List<Customer> ReadCustomers();
        void UpdateCustomer(Customer customer);
        int CreateCustomer(Customer customer);
    }
}
