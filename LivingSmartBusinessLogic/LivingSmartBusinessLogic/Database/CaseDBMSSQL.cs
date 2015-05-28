using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic.DBLayer;

namespace LivingSmartBusinessLogic.DB
{
    internal class CaseDBMSSQL : ICaseDB
    {
        public List<Case> ReadCases()
        {
            throw new NotImplementedException();
        }

        public void UpdateCase(Case ca)
        {
            throw new NotImplementedException();
        }

        public int CreateCase(Case ca)
        {
            throw new NotImplementedException();
        }
    }
}
