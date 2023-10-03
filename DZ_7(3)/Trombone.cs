using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_7_3_
{
    internal class Trombone: MusicInstrument
    {
        public Trombone(string name, string characteristics, string description) : base(name, characteristics, description)
        {
        }
        public override void Sound()
        {
            Console.WriteLine("Звук тромбону...");
        }
    }
}
