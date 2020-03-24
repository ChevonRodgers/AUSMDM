using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AUSMDM.Models
{
    public class EventClass
    {
        public int IdentityNumber { get; set; }

        public string Name { get; set; }

        public string Protocol { get; set; }

        public static List<EventClass> Events = new List<EventClass>
        {
            new EventClass {Name="MeterEVT",Protocol="DLMSProtocolKGZ"}
        };
    }
}
