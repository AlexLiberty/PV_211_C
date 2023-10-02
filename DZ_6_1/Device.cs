using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6_1
{
    internal class Device
    {
        protected string name;
        protected string characteristics;

        public Device(string name, string characteristics)
        {
            this.name = name;
            this.characteristics = characteristics;
        }
        public virtual void Sound()
        {
            Console.WriteLine($"Звук пристрою {name}: ...");
        }
        public void Show()
        {
            Console.WriteLine($"Назва пристрою: {name}");
        }
        public void Desc()
        {
            Console.WriteLine($"Опис пристрою {name}: {characteristics}");
        }

    }
}
