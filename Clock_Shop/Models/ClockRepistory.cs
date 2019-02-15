using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clock_Shop.Models;

namespace Clock_Shop.Models
{
    public class ClockRepistory
    {
        private AppDbContex _dbcontex;

        public ClockRepistory(AppDbContex dbcontex)
        {
            _dbcontex = dbcontex;
        }




        public IEnumerable<Clock> GetAllClocks()
        {
            return _dbcontex.Clocks.OrderBy(c => c.Name);
        }
    }
}
