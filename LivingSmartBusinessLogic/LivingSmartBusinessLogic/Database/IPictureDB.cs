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
        List<Picture> ReadPictures(int caseId);
        Dictionary<int, List<Picture>> ReadPictures();
        void UpdatePicture(Picture picture, int caseId);
        int CreatePicture(Picture picture, int caseId);
    }
}
