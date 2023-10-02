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
            MyArray<int> array1 = new MyArray<int>(3);
            MyArray<int> array2 = new MyArray<int>(3);
            MyArray<double> array3 = new MyArray<double>(3);

            array1[0] = 1;
            array1[1] = 2;
            array1[2] = 3;
            array1.Print();

            array2[0] = 4;
            array2[1] = 5;
            array2[2] = 6;
            array2.Print();

            array3[0] = 7.8;
            array3[1] = 8.8;
            array3[2] = 9.9;
            array3.Print();

            MyArray<int> result = array1 + array2;
            result.Print();
        }
    }
}
