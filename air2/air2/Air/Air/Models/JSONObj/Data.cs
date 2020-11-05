using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Air.Models
{
    public class Data
    {

        [JsonPropertyName("aqi")]
        public int Aqi { get; set; }  //Real-time air quality infomrmation.

        [JsonPropertyName("idx")]
        public int Idx { get; set; } //Unique ID for the city monitoring station.

        [JsonPropertyName("attributions")]
        public List<Attribution> Attributions { get; set; }  //EPA Attribution for the station

        [JsonPropertyName("city")]
        public City City { get; set; }    //Information about the monitoring station.        

        [JsonPropertyName("dominentpol")]
        public string Dominentpol { get; set; }

        [JsonPropertyName("iaqi")]
        public Iaqi Iaqi { get; set; }   //Measurement time infomration.

        [JsonPropertyName("time")]
        public Time Time { get; set; }

        [JsonPropertyName("forecast")]
        public Forecast Forecast { get; set; }  //Forecast data

        [JsonPropertyName("debug")]
        public Debug Debug { get; set; }
    }

   
}