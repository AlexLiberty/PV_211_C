using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons13_09
{

    internal class Dog
    {
                private string _name;
        private int _age;
        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="name">Ім'я</param>
        /// <param name="age">Вік</param>

        public Dog() { }
        public Dog(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string GetName()
        {
            return _name;
        }
        /// <summary>
        /// Гетер віку
        /// </summary>
        /// <returns>вік</returns>
        public int GetAge()
        {
            return _age;
        }
        public void SetAge(int age)
        {
            _age = age;
        }
        public void PrintDog()
        {
            //Конкатенація (склейка рядків)
            Console.WriteLine("Name: " + _name + " Age: " + _age);
            Console.WriteLine("Name {0}. Age {1}", _name, _age);
            //Інтерполяція
            Console.WriteLine($"Name{_name}. Age {_age}");

        }

    }
}
