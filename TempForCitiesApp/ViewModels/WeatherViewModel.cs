namespace TempForCitiesApp.ViewModels
{
    public class WeatherViewModel
    {
        public string Name { get; set; }
        public double Temp { get; set; }
        
        public override string ToString()
        {
            return $"City: {Name}, Temperature: {Temp} degree Celsius";
        }
    }
}