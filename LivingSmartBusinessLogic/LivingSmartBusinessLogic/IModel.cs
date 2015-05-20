﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic
{
    interface IModel
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
    }
}
