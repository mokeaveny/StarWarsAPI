using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsAPI.Models
{
    public class Planet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Sector { get; set; }
        public string System { get; set; }
        public int NumberOfMoons { get; set; }
        public int NumberOfSuns { get; set; }
        public Double OrbitalPeriod { get; set; }
        public Double RotationPeriod { get; set; }
        public string Class { get; set; }
        public Double Diameter { get; set; }
        public long Population { get; set; }
    }
}
