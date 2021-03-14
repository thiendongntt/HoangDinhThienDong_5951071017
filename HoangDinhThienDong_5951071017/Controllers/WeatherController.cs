using HoangDinhThienDong_5951071017.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HoangDinhThienDong_5951071017.Controllers
{
    public class WeatherController : ApiController
    {
        // GET: api/Weather
        public IEnumerable<WeatherInfo> Get()
        {
            var weatherInflist = new List<WeatherInfo>();
            for(int i = 0; i < 10; i++)
            {
                var WeatherInfo = new WeatherInfo
                {
                    Location = $"Location {i}",
                    Degree = i * 23 / 17,
                    DateTime = DateTime.Now.ToUniversalTime()
                };
                weatherInflist.Add(WeatherInfo);
            }


            return weatherInflist;
        }

        // GET: api/Weather/5
        public WeatherInfo Get(int id)
        {

            return new WeatherInfo {
                Location = $"Location {id}",
                Degree = id * 23 / 17,
                DateTime = DateTime.Now.ToUniversalTime()
            }; ;
        }

        // POST: api/Weather
       
    }
}
