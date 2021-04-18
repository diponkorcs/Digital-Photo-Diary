using Digital_Photo_Diary.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Photo_Diary.Data_Access_Layer
{
    class EventDataAccess : DataAccess
    {
        public int AddEvents(Events events)
        {
            string sql = "INSERT INTO Events(EventName, Story, EventDate, Importance, UserName) VALUES('" + events.EventName + "','" + events.Story + "','" + events.EventDate + "','" + events.Importance + "','" + events.UserName + "')";
            return this.ExecuteQuery(sql);
        }

        public List<string> EventNames(string userName)
        {
            string sql = "SELECT * FROM Events WHERE UserName='"+userName+"'";
            SqlDataReader reader = this.GetData(sql);
            List<string> events = new List<string>();
            while (reader.Read())
            {
                Events events1 = new Events();

                events1.EventName = reader["EventName"].ToString();
                
                events.Add(events1.EventName);
            }
            return events;
        }
    }
}
