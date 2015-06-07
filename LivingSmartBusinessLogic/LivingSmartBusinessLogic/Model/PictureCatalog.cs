using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.Database;
using LivingSmartBusinessLogic.Entity;

namespace LivingSmartBusinessLogic.Model
{
    /// <summary>
    /// Billedkatalog
    /// </summary>
    /// <author>Mathias Poulsen</author>
    internal class PictureCatalog
    {
        private Dictionary<int, List<Picture>> pictureDictionary;
        private IPictureDB db;

        internal PictureCatalog()
        {
            db = PictureDBFactory.GetDBL();
            pictureDictionary = new Dictionary<int, List<Picture>>();

            LoadCatalog();
        }

        internal void LoadCatalog()
        {
            var pictureList = db.ReadPictures();
            foreach (var pictures in pictureList)
                foreach (var picture in pictures.Value)
                {
                    AddToCatalog(pictures.Key, picture);
                }
        }

        internal Picture Check(int id)
        {
            throw new NotImplementedException();
        }

        internal void Save(Picture picture, int caseId)
        {
            if (picture.Id == -1)
                picture.Id = db.CreatePicture(picture, caseId);
            else
                db.UpdatePicture(picture, caseId);
        }

        internal void AddToCatalog(int caseId, Picture picture)
        {
            if (!pictureDictionary.ContainsKey(caseId))
                pictureDictionary.Add(caseId, new List<Picture>());
            pictureDictionary[caseId].Add(picture);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="caseId"></param>
        /// <param name="picture"></param>
        /// <author>Mathias Petersen</author>
        internal void RemoveFromCatalog(int caseId, Picture picture)
        {
			db.DeletePicture(picture);
            pictureDictionary[caseId].Remove(picture);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="caseId"></param>
        /// <returns></returns>
        /// <author>Mathias Petersen</author>
        internal ReadOnlyCollection<Picture> GetPictures(int caseId)
        {
	        if (!pictureDictionary.ContainsKey(caseId))
		        return new ReadOnlyCollection<Picture>(new List<Picture>());

            return pictureDictionary[caseId].AsReadOnly();
        }
    }
}
