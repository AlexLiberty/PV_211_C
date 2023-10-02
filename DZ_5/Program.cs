using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Website website = new Website();
            website.InputData();
            Console.WriteLine("\n Інформація про сайт: \n");
            website.DisplayData();
        }
    }
}
