using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons13_09
{
    public struct Cat
    {
        private int _age;
        private string _name;
        private bool _isExist;
        private double _weight;

        public Cat(string name,int age)
        {
            _name= name;    
            _age= age;      
            _weight= 5;    
            _isExist= true;
        }
        public string GetName()
        {
            return _name;
        }  
        public int GetAge()
        {
            return _age;
        }
        public void SetAge(int age)
        {
            _age = age;
        }

        public void PrintCat()
        {
            //Конкатенація (склейка рядків)
            Console.WriteLine("Name: " + _name + " Age: " + _age);
            Console.WriteLine("Name {0}. Age {1}", _name, _age);
            //Інтерполяція
            Console.WriteLine($"Name{_name}. Age {_age}. IsExist{_isExist}. Weight{_weight} ");

        }
    }
}
