using Digital_Photo_Diary.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Photo_Diary.Data_Access_Layer
{
    class PicturesAccess : DataAccess
    {

        //public List<string> pictures = new List<string>();
        public List<Pictures> GetPictures(string eventName)
        {
            string sql = "SELECT * FROM EventPictures WHERE EventName='"+eventName+"'";
            SqlDataReader reader = this.GetData(sql);
            List<Pictures> pictures = new List<Pictures>();
            while (reader.Read())
            {
                Pictures picture = new Pictures();
                picture.PictureNo = Convert.ToInt32(reader["PictureNo"]);
                picture.StorageLocation = reader["StorageLocation"].ToString();
                picture.EventName = reader["EventName"].ToString();
                
                pictures.Add(picture);
            }
            return pictures;
        }


        public int AddPictures(Pictures picture)
        {

            string sql = "INSERT INTO EventPictures(StorageLocation,EventName) VALUES('" + picture.StorageLocation + "','" + picture.EventName + "')";
            return this.ExecuteQuery(sql);
        }
    }
}