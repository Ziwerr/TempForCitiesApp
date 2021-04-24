using System.Collections.Generic;

namespace TempForCitiesApp.Entites
{
    public class WeatherResponse
    {
        public IEnumerable<City> List { get; set; }
    }
}