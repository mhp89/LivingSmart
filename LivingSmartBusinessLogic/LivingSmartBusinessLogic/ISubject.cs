﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic
{
    interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(IObserver observer);
    }
}