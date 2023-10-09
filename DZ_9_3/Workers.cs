using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_9_3
{
    internal class Workers
    {
        public string Name {  get; set; }
        public int Age {  get; set; }
        public string Position {  get; set; }
        public Workers(string name, int age, string position) 
        {
          Name=name;
            Age=age;
            Position=position;
        }
    }
}
