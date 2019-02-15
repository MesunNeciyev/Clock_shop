using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clock_Shop.Models
{
   public interface IClockRepistory
    {
        IEnumerable<Clock> GetAllClocks();
    }
}
