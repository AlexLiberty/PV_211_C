using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_9_2
{
    internal class Player
    {
        public string Name { get; set; }
        public int Age {  get; set; }
        public int Numer {  get; set; }
        public Player(string name, int age, int numer)
        {
            Name = name;
            Age = age;
            Numer = numer;
        }
    }
}
