using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Photo_Diary.Data_Access_Layer.Entities
{
    class Events
    {
        public string EventName { get; set; }
        public string Story { get; set; }
        public string EventDate { get; set; }
        public string Importance { get; set; }
        public string Pictures { get; set; }
        public string UserName { get; set; }
    }
}
