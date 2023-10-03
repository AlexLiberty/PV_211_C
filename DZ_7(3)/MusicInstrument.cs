using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DZ_7_3_
{
    internal class MusicInstrument
    {
        private string _name;
        private string _characteristics;
        private string _description;

        public MusicInstrument(string name, string characteristics, string description)
        {
            _name = name;
            _characteristics = characteristics;
            _description = description;
        }
        public virtual void Sound()
        {
            Console.WriteLine($"Звук пристрою {_name}: ...");
        }
        public virtual void Show()
        {
            Console.WriteLine($"Назва пристрою: {_name}");
        }
        public void Desc()
        {
            Console.WriteLine($"Опис пристрою {_name}: {_characteristics}");
        }
        public void History()
        {
            Console.WriteLine($"Історія пристрою {_name}: {_description}");
        }
        

    }
}
