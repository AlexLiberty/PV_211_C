using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_9_1
{
    internal class Oceanarium : IEnumerable<SeaCreature>
    {
        private List<SeaCreature> creatures;

        public Oceanarium()
        {
            creatures = new List<SeaCreature>();
        }

        public void AddCreature(string name, string species, int age)
        {
            SeaCreature creature = new SeaCreature(name, species, age);
            creatures.Add(creature);
        }

        public IEnumerator<SeaCreature> GetEnumerator()
        {
            return creatures.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
