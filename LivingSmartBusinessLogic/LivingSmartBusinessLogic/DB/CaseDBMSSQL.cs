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

        public void UpdateAd(Case ca)
        {
            throw new NotImplementedException();
        }

        public int CreateAd(Case ca)
        {
            throw new NotImplementedException();
        }
    }
}
