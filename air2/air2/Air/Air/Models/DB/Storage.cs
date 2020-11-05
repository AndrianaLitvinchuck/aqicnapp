using Air.Models.DB;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Air.Models
{
    public class Storage
    {

        private readonly AppCtx _ctx;

        public Storage(DbContextOptions<AppCtx> options)
        {
            _ctx = new AppCtx(options);

        }

        public Storage(AppCtx ctx)
        {
            _ctx = ctx;
        }

        public List<DB.City> GetCities()
        {
            List<DB.City> cities = new List<DB.City>();
            cities =  _ctx.Cities.Where(n => !n.Name.Equals(null)).ToList();
            return cities;
        }


        public DB.City GetCity(int id)
        {
            return _ctx.Cities.FirstOrDefault(n => n.Id.Equals(id));
        }

        public List<DB.AQData> GetData()
        {
            List<DB.AQData> aQDatas = new List<AQData>();
            aQDatas = _ctx.AQDatas.Include(c=>c.City)
                                .Where(c => !c.City.Equals(null))
                                .OrderBy(d => d.Date)
                                .ToList();
            return aQDatas;
        }

        public List<DB.AQData> GetDataByCity(DB.City city)
        {
            List<DB.AQData> aQDatas = new List<AQData>();
            aQDatas = _ctx.AQDatas.Include(c => c.City)
                                .Where(c => c.City.Equals(city))
                                .OrderBy(d => d.Date)
                                .ToList();
            return aQDatas;
        }


        public int WriteData(Data data)
        {
            try
            {
                DB.City city = _ctx.Cities.FirstOrDefault(n => n.Id.Equals(data.Idx));
                AQData aQData = new AQData();

                aQData.PM10 = data.Iaqi.pm10.V;
                aQData.PM25 = data.Iaqi.pm25.V;
                aQData.Temperature = data.Iaqi.t.V;
                aQData.Date = DateTime.Parse(data.Time.S);
                aQData.Humidity = data.Iaqi.h.V;


                if (city != null)
                { 
                    aQData.CityId = city.Id;                    
                }
                else
                {
                    DB.City newCity = new DB.City();
                    newCity.Name = GetShortName(data.City.Name);
                    newCity.Id = data.Idx;
                    aQData.CityId = data.Idx;
                    _ctx.Cities.Add(newCity);
                }

                _ctx.AQDatas.Add(aQData);
                return  _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public async Task<List<AQData>> GetDataAsync()
        {
            return await Task.Run(() => GetData());
        }

        public async Task<List<DB.City>> GetCitiesAsync()
        {
            return await Task.Run(() => GetCities());
        }

        private string GetShortName(string adress)
        {
            List<string> names = new List<string>() { };
            names.Add("Ternopil");
            names.Add("Ivano-Frankivsk");
            names.Add("Lviv");
            names.Add("Chernivci");

            foreach (var item in names)
            {
                if (adress.Contains(item)) return item;
            }
            return "";
        }

    }
}
