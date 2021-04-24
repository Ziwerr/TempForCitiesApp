using System.Threading.Tasks;
using TempForCitiesApp.Entites;

namespace TempForCitiesApp.Services
{
    public interface IWeatherService
    {
        Task<WeatherResponse> GetCities(double lat, double lon);
    }
}