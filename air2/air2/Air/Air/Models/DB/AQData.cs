using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Air.Models.DB
{
    public class AQData
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public int CityId { get; set; }
        public DateTime Date { get; set; }
        public double PM10 { get; set; }
        public double PM25 { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }

        public City City { get; set; }
    }
}
