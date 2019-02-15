using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clock_Shop.Models
{
    public class Clock
    {

        public int ClockId { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public int Price { get; set; }

        public string ImageUrlForClock { get; set; }
    }
}
