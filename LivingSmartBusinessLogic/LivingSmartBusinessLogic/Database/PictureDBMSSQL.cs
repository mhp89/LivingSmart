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
        public List<Picture> ReadPictures()
        {
            throw new NotImplementedException();
        }

        public void UpdatePicture(Picture picture)
        {
            throw new NotImplementedException();
        }

        public int CreatePicture(Picture picture)
        {
            throw new NotImplementedException();
        }
    }
}
