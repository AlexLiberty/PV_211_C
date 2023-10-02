using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_21_09_01_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number n1 = new Number(100);
            Number n2 = new Number(50);
            Number n3 = n1 + n2;
            Console.WriteLine(n3);
            Number n4 = n1 + 10;
            Console.WriteLine(n4);
            n4++;
            Console.WriteLine(n4);
        }
    }
}
