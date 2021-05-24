using Charts.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charts.Data
{
    public class MyContext: DbContext
    {

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        public DbSet<SalesOrder> salesOrders { get; set; }
    }

}
