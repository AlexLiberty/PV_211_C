using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10_7
{
    internal class PersonList: IEnumerable<Person>
    {
        private List<Person> _list;
        public PersonList()
        {
            _list = new List<Person>();
        }
        public void AddPerson(string firstname, string lastname, int age)
        {
            Person person = new Person(firstname, lastname, age);
            _list.Add(person);
        }
        public IEnumerator<Person> GetEnumerator()
        {
            return _list.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
