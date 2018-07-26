using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TipTracker_web.Models
{
    public class Delivery
    {
        public int CustomerID { get; set; }
        public int ID { get; set; }
        public DateTime CheckOut { get; set; }
        public DateTime CheckIn { get; set; }
        public int OrderNum { get; set; }
        public double Total { get; set; }
        public int PayType { get; set; }
        public double Tip { get; set; }
        public double Stash { get; set; }
    }
}
