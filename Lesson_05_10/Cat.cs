using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_10
{
    internal class Cat
    {
        private string _name { get; set; }
        private int _year { get; set; }
        public Cat(string name,int year) 
        {
            _name = name;
            _year = year;
        }
    }
}
