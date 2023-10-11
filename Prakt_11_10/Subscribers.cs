using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt_11_10
{
    internal class Subscribers
    {
        public string Name {  get; set; }
        public int Age {  get; set; }
        public Subscribers(string name,int age) 
        {
            Name = name;
            Age = age;
        }
    }
}
