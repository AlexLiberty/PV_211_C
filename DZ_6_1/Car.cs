using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6_1
{
    internal class Car : Device
    {
        public Car(string name, string characteristics) : base(name, characteristics) {}
        public override void Sound()
        {
            Console.WriteLine("Звук автомобіля: Робота двигуна");
        }
    }
}
