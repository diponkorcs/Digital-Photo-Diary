using Digital_Photo_Diary.Data_Access_Layer;
using Digital_Photo_Diary.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Photo_Diary.Codes
{
    class EventService
    {
        EventDataAccess eventDataAccess;

        public EventService()
        {
            this.eventDataAccess = new EventDataAccess();
        }

        public int AddEvent(string eventName, string story, string eventDate, string importance, string userName)
        {
            Events events = new Events()
            {
                EventName = eventName,
                Story = story,
                EventDate = eventDate,
                Importance = importance,
                UserName = userName
            };

            this.eventDataAccess = new EventDataAccess();
            return this.eventDataAccess.AddEvents(events);
        }
    }
}
