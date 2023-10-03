using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DZ_7_3_
{
    internal class Violin : MusicInstrument
    {
        public Violin(string name, string characteristics, string description) : base(name, characteristics, description)
        {
        }
        public override void Sound()
        {
            Console.WriteLine("Звук скрипки...");
        }
    }
}
