using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DZ_8_1
{
    internal class MyArray: ICalc, IOutput
    {
        private int Size { get; set; }
        private int[] arr;
        public MyArray(int size)
        {
            Size = size;
            arr = new int[size];
        }
        public int[] Items
        {
            get { return arr; }
            set { arr = value; }
        }
        public int this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }
        public void Print()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.Write(this[i]);
                if (i < Size - 1)
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
        public int Less(int valueToCompare)
        {
            //return arr.Count(e => e < valueToCompare);
            int count = 0;

            foreach (int item in arr)
            {
                if (item < valueToCompare)
                {
                    count++;
                }
            }

            return count;
        }
        public int Greater(int valueToCompare)
        {
            //return arr.Count(e => e > valueToCompare);
            int count = 0;

            foreach (int item in arr)
            {
                if (item > valueToCompare)
                {
                    count++;
                }
            }

            return count;
        }
        public void ShowEven()
        {
            foreach (int item in arr)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine($"Even = {item}");
                }
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            foreach (int item in arr)
            {
                if (item % 2 == 1)
                {
                    Console.WriteLine($"Odd = {item}");
                }
            }
            Console.WriteLine();
        }
    }
}
