using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_02_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c2 = new Car("bwm", 200);
            Car c1 = new Car("audi", 100);
            Car c3 = new Car("opel", 90);
            Car[] cars = new Car[] { c1, c2, c3 };
            Array.Sort(cars);
            foreach (Car el in cars)
            {
                Console.WriteLine(el);
            }
            //int[] arr = { 4, 5, 1, 9, -10 };
            //Array.Sort(arr);
            //foreach(var el in arr)
            //{
            //    Console.WriteLine(el);
            //}
        }
    
    }
}
