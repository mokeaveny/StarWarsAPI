using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsAPI.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PlanetId { get; set; }
        public long Population { get; set; }
        public string Description { get; set; }
    }
}
