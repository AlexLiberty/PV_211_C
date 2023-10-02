using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_21_09_01_
{
    internal class Number
    {
        public int  Data { get; set; }
        public Number(int data)

        { this.Data = data; }
        public override string ToString()
        {
            return $"Data: {Data}";
        }
        public static Number operator+(Number n1,Number n2)
        {
            return new Number(n1.Data + n2.Data);
        }
        public static Number operator +(Number n1, int value)
        {
            return new Number(n1.Data + value);
        }

        public static Number operator ++(Number n)
        {
            n.Data++;
            return n;
        }



    }
}
