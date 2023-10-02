using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_28_09
{
    internal class Transport
    {
        public string Model { get; set; }
        public Transport()
        {
            Console.WriteLine(" I am constructor Transport");
        }
        public Transport(string model)
        {
            Model = model;
        }
        public virtual void Move()
        {
            Console.WriteLine(" I am moving....Transport");
        }
    }
}
