using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Magazine magazine = new Magazine();
            magazine.InputData();
            Console.WriteLine("\n Інформація про журнал:\n ");
            magazine.DisplayData();

            Magazine magazine1 = new Magazine();
            magazine1.InputData();
            Console.WriteLine("\n Інформація про журнал:\n ");
            magazine1.DisplayData();

            if (magazine == magazine1)
            {                
                Console.WriteLine("\nКількість співробітників рівна.");
            }

            if(magazine < magazine1)
            {
                Console.WriteLine($"\nКількість співробітників {magazine1.Name} більша ніж {magazine.Name}.");
            }

            else
            {
                Console.WriteLine($"\nКількість співробітників {magazine.Name} більша ніж {magazine1.Name}.");
            }

            bool Equal = magazine1.Equals(magazine);

            if (Equal==true)
            {
                Console.WriteLine($"Кількість співробітників{magazine1.Name} та {magazine.Name} рівна.");
            }
            else
            {
                Console.WriteLine($"Кількість співробітників{magazine1.Name} та {magazine.Name} не рівна.");
            }
        }
    }
}
