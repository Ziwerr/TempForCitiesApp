using System.Collections.Generic;

namespace TempForCitiesApp.Entites
{
    public class City
    {
        public string Name { get; set; }
        public IEnumerable<TempereratureDetails> Main { get; set; }
    }
}