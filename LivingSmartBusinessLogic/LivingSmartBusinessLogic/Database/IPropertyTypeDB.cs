using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IPropertyTypeDB
    {
        List<PropertyType> ReadPropertyTypes();
        void UpdatePropertyType(PropertyType propertyType);
        int CreatePropertyType(PropertyType propertyType);
    }
}
