using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Catalog
{
    internal class PictureCatalog
    {
        private Dictionary<int, List<Picture>> pictureDictionary;

        internal PictureCatalog()
        {
            pictureDictionary = new Dictionary<int, List<Picture>>();
        }

        internal Picture Check(int id)
        {
            throw new NotImplementedException();
        }

        internal void Save(Picture picture)
		{
			//if (picture.Id == -1)
				//Create //TODO: Save picture to server
			//else
				//Update
        }

        internal void AddToCatalog(int caseId, Picture picture)
        {
            if (!pictureDictionary.ContainsKey(caseId))
                pictureDictionary.Add(caseId, new List<Picture>());
            pictureDictionary[caseId].Add(picture);
        }

        internal void RemoveFromCatalog(int caseId, Picture picture)
        {
            pictureDictionary[caseId].Remove(picture);
        }

        internal ReadOnlyCollection<Picture> GetPictures(int caseId)
        {
            return pictureDictionary[caseId].AsReadOnly();
        }
    }
}
