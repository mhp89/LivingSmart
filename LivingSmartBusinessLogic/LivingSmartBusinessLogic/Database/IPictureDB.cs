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
        List<Picture> ReadPictures();
        void UpdatePicture(Picture picture);
        int CreatePicture(Picture picture);
    }
}
