﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DB
{
    internal static class CaseDBFactory
    {
        public static CaseDBMSSQL GetDBL()
        {
            if (Properties.Settings.Default.Database == "MSSQL")
                return new CaseDBMSSQL();
//            if (Properties.Settings.Default.Database == "XML")
//                return new CustomerDBXML();
//            if (Properties.Settings.Default.Database == "MYSQL")
//                return new CustomerDBMYSQL();
            return null;
        }
    }
}