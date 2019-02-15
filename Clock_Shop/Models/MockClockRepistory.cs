using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clock_Shop.Models;

namespace Clock_Shop.Models
{
    public class MockClockRepistory:IClockRepistory
    {
        
        
            private List<Clock> _clocks;

            public MockClockRepistory()
            {
                if (_clocks == null)
                {
                    InitializeClocks();
                }

            }
            private void InitializeClocks()
            {
                _clocks = new List<Clock>
                {
                    new Clock {Name="ClockName1",Brand="BrandName1",Price=100},
                    new Clock {Name="ClockName2",Brand="BrandName2",Price=750},
                    new Clock {Name="ClockName3",Brand="BrandName3",Price=10000},
                    new Clock {Name="ClockName4",Brand="BrandName4",Price=40},
                    new Clock {Name="ClockName5",Brand="BrandName5",Price=1500},
                    new Clock {Name="ClockName6",Brand="BrandName6",Price=300},
            };

            }

            public IEnumerable<Clock> GetAllClocks()
            {
                return _clocks;
            }




        
    }
}
