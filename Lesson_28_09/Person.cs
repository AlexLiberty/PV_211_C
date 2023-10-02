using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_28_09
{
    internal class Person
    {
        public required string? Name { get; set; }//required обов'язкова ініціалізація на стадії створення об'єкту/ ? дозволяє { Name="null"}
        public override string ToString()
        {
            return $"Name: {Name}";
        }
        public void Drive(Transport tr)
        {
            tr.Move();
        }
    }
}
