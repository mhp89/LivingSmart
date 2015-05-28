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
    internal class PictureDBMSSQL : IPictureDB
    {
        public List<Partner> ReadPictures()
        {
            throw new NotImplementedException();
        }

        public void UpdatePictures(Picture picture)
        {
            throw new NotImplementedException();
        }

        public int CreatePartner(Picture picture)
        {
            throw new NotImplementedException();
        }
    }
}
