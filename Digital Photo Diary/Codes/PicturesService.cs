using Digital_Photo_Diary.Data_Access_Layer;
using Digital_Photo_Diary.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Photo_Diary.Codes
{
    class PicturesService
    {
        PicturesAccess picturesAccess;

        public PicturesService()
        {
            this.picturesAccess = new PicturesAccess();
        }

        public int AddPictures( string storageLocation, string eventName)
        {
            Pictures picture = new Pictures()
            {
                StorageLocation = storageLocation,
                EventName = eventName
            };

            this.picturesAccess = new PicturesAccess();
            return this.picturesAccess.AddPictures(picture);
        }
        public List<Pictures> GetPictures(string eventName)
        {
            return this.picturesAccess.GetPictures(eventName);
        }
    }
}
