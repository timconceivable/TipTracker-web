using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TipTracker_web.Models
{
    public class Customer
    {
        public int UserID { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public double Phone { get; set; }
        public string Address { get; set; }
    }
}
