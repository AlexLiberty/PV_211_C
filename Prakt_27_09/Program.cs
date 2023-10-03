using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt_27_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray<int> array = new MyArray<int>(3);

            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array.Print();
        }
    }
    
}
