using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using RestSharp;
using TempForCitiesApp.Entites;
using TempForCitiesApp.Services;
using TempForCitiesApp.ViewModels;

namespace TempForCitiesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddScoped<IWeatherService, WeatherService>()
                .AddScoped<IRestClient,RestClient>()
                .BuildServiceProvider();
            var weatherService = serviceProvider.GetService<IWeatherService>();
            
            Forecast forecast = new Forecast();
            
            forecast.InteractWithUser();
            var result = weatherService.GetCities(forecast.Latitude,forecast.Longitude).Result; //List of 50 cities
            var orderedList = forecast.OrderList(result.List);
            forecast.Display(orderedList);
            Console.ReadKey();
        }
    }
}