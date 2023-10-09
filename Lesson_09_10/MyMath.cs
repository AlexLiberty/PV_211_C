using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///////////////////////////////Делегати////////////////////////////
namespace Lesson_09_10
{

    public delegate void MyDelegate(int n1, int n2);
    internal class MyMath
    {
        public int value { get; set; }
        public int value2 { get; set; }
        public void Sum(int n1, int n2)
        {
            Console.WriteLine(n1+n2);
        }
        public void Min(int n1, int n2)
        {
            Console.WriteLine(n1 - n2);
        }
        public void Mul(int n1, int n2)
        {
            Console.WriteLine(n1 * n2);
        }
    }

        
}
