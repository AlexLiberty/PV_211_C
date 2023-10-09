using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10_7
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName {  get; set; }
        public int Age {  get; set; }
        public Person(string firstname, string lastname, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
        }
    }
}
