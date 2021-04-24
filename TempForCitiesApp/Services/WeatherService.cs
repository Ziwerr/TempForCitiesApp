using System;
using System.Threading.Tasks;
using RestSharp;
using TempForCitiesApp.Entites;

namespace TempForCitiesApp.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly IRestClient _client;

        public WeatherService(IRestClient client)
        {
            _client = client;
            _client.BaseUrl = new Uri("https://api.openweathermap.org/data/2.5/");
        }
        
        public async Task<WeatherResponse> GetCities(double lat, double lon)
        {
            var request = new RestRequest("find")
                .AddParameter("lat", lat)
                .AddParameter("lon", lon)
                .AddParameter("cnt", 50)
                .AddParameter("appid", "ce82774295db466472b892ef8345ae11")
                .AddParameter("units", "metric");

            var response = await _client.ExecuteAsync<WeatherResponse>(request);
            return response.Data;
        }
    }
}