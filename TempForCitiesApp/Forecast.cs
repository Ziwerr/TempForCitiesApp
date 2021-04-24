using System;
using System.Collections.Generic;
using System.Linq;
using TempForCitiesApp.Entites;
using TempForCitiesApp.ViewModels;

namespace TempForCitiesApp
{
    public class Forecast
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public void InteractWithUser()
        {
            bool isValidLat, isValidLon;
            do
            {
                do
                {
                    Console.WriteLine("Type latitude: ");
                    string latString = Console.ReadLine();
                    isValidLat = Double.TryParse(latString, out var lat);
                    if (!isValidLat)
                    {
                        Console.WriteLine("Value must be a double");
                    }
                    Latitude = lat;
                } while (!isValidLat);
                
                do
                {
                    Console.WriteLine("Type longitude: ");
                    string lonString = Console.ReadLine();
                    isValidLon = Double.TryParse(lonString, out var lon);
                    if (!isValidLon)
                    {
                        Console.WriteLine("Value must be a double");
                    }
                    Longitude = lon;
                } while (!isValidLon);
                
            } while (false);
        }
        
        public void Display(IEnumerable<WeatherViewModel> weatherViewModel)
        {
            foreach (var item in weatherViewModel)
            {
                Console.WriteLine(item);
            }
        }
        
        public IEnumerable<WeatherViewModel> OrderList(IEnumerable<City> list)
        {
            return list.Select(x => new WeatherViewModel
            {
                Name = x.Name,
                Temp = x.Main.Select(x => x.Temp).FirstOrDefault()
            }).OrderByDescending(x => x.Temp).Take(20);
        }
    }
}