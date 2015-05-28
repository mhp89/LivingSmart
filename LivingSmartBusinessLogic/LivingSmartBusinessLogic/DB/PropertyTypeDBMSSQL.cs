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
    internal class PropertyTypeDBMSSQL : IPropertyTypeDB
    {
        public List<Partner> ReadPropertyTypes()
        {
            throw new NotImplementedException();
        }

        public void UpdatePropertyType(PropertyType propertyType)
        {
            throw new NotImplementedException();
        }

        public int CreatePropertyType(PropertyType propertyType)
        {
            throw new NotImplementedException();
        }
    }
}
