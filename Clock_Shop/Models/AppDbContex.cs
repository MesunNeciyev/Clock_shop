using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clock_Shop.Models;

namespace Clock_Shop.Models
{
    public class AppDbContex:DbContext
    {
        public AppDbContex(DbContextOptions<AppDbContex> options) : base(options)
        {

        }

        public DbSet<Clock> Clocks { get; set; }
    }
}
