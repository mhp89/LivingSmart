using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IPictureDB
    {
        List<Partner> ReadPictures();
        void UpdatePictures(Picture picture);
        int CreatePartner(Picture picture);
    }
}
