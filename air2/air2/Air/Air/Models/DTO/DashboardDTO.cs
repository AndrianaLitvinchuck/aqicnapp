using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Air.Models.DTO
{
    public class DashboardDTO
    {
        public List<DB.City> Cities { get; set; }

        public List<DB.AQData> Data { get; set; }
    }
}
