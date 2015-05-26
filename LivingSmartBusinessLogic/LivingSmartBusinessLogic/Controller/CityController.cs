﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.Controller
{
    class CityController
    {
        private CityCatalog cityCatalog;
        public CityController()
        {
            cityCatalog = new CityCatalog();
        }

        public City GetCity(int zipCode)
        {
            return cityCatalog.GetCity(zipCode);
        }
    }
}
