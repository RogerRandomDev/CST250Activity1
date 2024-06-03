using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Maker
{
    public class SuperHero
    {
        public string Name { get; set; }
        public List<string> SpecialAbilities { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime SuperPowerDiscovery { get; set; }
        public DateTime FatefulDay { get; set; }
        public List<string> OfficeLocations { get; set; }
        public string PreferredTransportation { get; set; }
        public int YearsOfExperience { get; set; }
        public string CapeColor { get; set; }
        public int DarkSidePropensity { get; set; }
        public int Speed { get; set; }
        public int Stamina { get; set; }
        public int Strength { get; set; }
    }
}
