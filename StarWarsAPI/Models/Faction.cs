using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsAPI.Models
{
    public class Faction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LeaderTitle { get; set; }
        public string DateFounded { get; set; }
        public int PlanetOfOrigin { get; set; }
    }
}
