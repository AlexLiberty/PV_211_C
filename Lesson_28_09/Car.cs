using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_28_09
{
    internal class Car:Transport
    {      
        public Car()
        {
            Console.WriteLine(" I am constructor Car");
        }
        public override void Move() 
        {
            Console.WriteLine(" I am moving....Car");
        }
    }
}
