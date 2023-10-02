using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_28_09
{
    internal class Bike:Transport
    {
        public Bike()
        {
            Console.WriteLine(" I am constructor Bike");
        }
        public override void Move()
        {
            Console.WriteLine(" I am moving....Bike");
        }
    }
}
