using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_02_10
{
       class Car:IComparable<Car>
    {
        public int Price { get; set; }
        public string Model { get; set; }
        public Car(string m, int p)
        {
            Price = p;
            Model = m;
        }
        public override string ToString()
        {
            return $"{Model} : {Price}";
        }
        //Компаратор, для порівняння об'єктів 
        // Повертає 0, якщо об'єкти однакові
        // 1 - поточний об'єкт після other 
        // -1 - поточний об'єкт до other
        public int CompareTo(Car other)
        {

            if (other != null)
            {
                if (this.Price == other.Price)
                    return 0;
                else if (this.Price < other.Price)
                    return -1;
                else
                    return 1;
                //return Model.CompareTo(other.Model);
            }

            throw new Exception("fail");
        }
    }
}
