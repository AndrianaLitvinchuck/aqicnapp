using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Air.Models.DB
{
    public class AppCtx : DbContext
    {
        public AppCtx(DbContextOptions<AppCtx> options) : base(options)
        {
            
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<AQData> AQDatas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }


    }
}
