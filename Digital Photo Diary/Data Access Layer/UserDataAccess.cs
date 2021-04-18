using Digital_Photo_Diary.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Photo_Diary.Data_Access_Layer
{
    class UserDataAccess : DataAccess
    {
        public int AddUser(User user)
        {
            string sql = "INSERT INTO UsersRegistration(Name,UserName,Password,Email,DateofBirth, Gender,BloodGroup) VALUES('" + user.Name + "','" + user.UserName + "','" + user.Password + "','" + user.Email + "','" + user.DateOfBirth + "','" + user.Gender + "','" + user.BloodGroup + "')";
            return this.ExecuteQuery(sql);
        }

        public string Search(User user)
        {
            string sql = "SELECT * FROM UsersRegistration WHERE Username='" + user.UserName + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return reader["UserName"].ToString();
            }
            return null;
        }
    }
}