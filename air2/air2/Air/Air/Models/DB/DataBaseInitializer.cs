using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Air.Models.DB
{
    public class DataBaseInitializer
    {
        public static void Initialize(AppCtx _ctx)
        {
            try
            {
                //ctx.Database.EnsureDeleted();
                _ctx.Database.EnsureCreated();
                //ctx.Database.Migrate();

                if (_ctx.AQDatas.Any())
                {
                    return;
                }
            
                _ctx.SaveChanges();
            }        
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
