using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt_04_10
{
    internal class Club
    {
        public string Name { get; set; }

        public string City { get; set; }

        public Club(string name, string city)
        {
            this.Name = name;
            this.City = city;
        }
        public Club() : this("Динамо", "Киев") { }
        public void Show()
        {
            Console.WriteLine("\n{0}   {1}", Name, City);
        }
        public void Input()
        {
            Console.WriteLine("\nВведите название клуба: ");
            this.Name = Console.ReadLine();
            Console.WriteLine("\nВведите название города: ");
            this.City = Console.ReadLine();
        }
    }
}
