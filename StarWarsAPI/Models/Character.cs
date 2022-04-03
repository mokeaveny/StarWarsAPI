using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsAPI.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string HairColour { get; set;}
        public string EyeColour { get; set; }
    }
}
