using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TipTracker_web.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool OnClock { get; set; }
        public bool OnDelivery { get; set; }
        public double TotalHours { get; set; }
        public double DeliveryHours { get; set; }
        public double DeliveryTotal { get; set; }
    }
}
