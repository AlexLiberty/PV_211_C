using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_15
{
    internal class MyArray
    {
        private int[] numbers;

        public MyArray(int[] inputArray)
        {
            numbers = inputArray;
        }
        public int[] GetAllIntegers()
        {
            return numbers;
        }
        public int[] GetEvenNumbers()
        {
            return numbers.Where(x => x % 2 == 0).ToArray();
        }
        public int[] GetOddNumbers()
        {
            return numbers.Where(x => x % 2 != 0).ToArray();
        }
        public int[] GetNumbersGreaterThan(int value)
        {
            return numbers.Where(x => x > value).ToArray();
        }
        public int[] GetNumbersInRange(int start, int end)
        {
            return numbers.Where(x => x >= start && x <= end).ToArray();
        }
        public int[] GetMultiplesOfSevenAscending()
        {
            return numbers.Where(x => x % 7 == 0).OrderBy(x => x).ToArray();
        }
        public int[] GetMultiplesOfEightDescending()
        {
            return numbers.Where(x => x % 8 == 0).OrderByDescending(x => x).ToArray();
        }
    }
}
