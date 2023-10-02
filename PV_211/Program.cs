using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            object n2 = 19;
            ValueType n3 = 77;
            int n4 = (int)n3;
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine("Hello world!");
            Console.ReadLine();
            int n6;
            n6 = int.Parse(Console.ReadLine());
            int n5=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n5 + n6);
       
        }
    }
}
