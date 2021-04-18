using Digital_Photo_Diary.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
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
    }
}
