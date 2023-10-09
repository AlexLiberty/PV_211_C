using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_9_1
{
    internal class SeaCreature
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }

        public SeaCreature(string name, string species, int age)
        {
            Name = name;
            Species = species;
            Age = age;
        }
    }
}
