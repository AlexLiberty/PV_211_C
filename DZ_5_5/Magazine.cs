using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DZ_5_5
{
    internal class Magazine
    {
        string name;
        int year;
        int people;
        string description;
        int phone;
        string email;

        public string Name { get { return name; } set { name = value; } }
        public int Year { get { return year; } set { year = value; } }
        public int People { get { return people; }set { people = value; } }
        public string Description { get { return description; } set { description = value; } }
        public int Phone { get { return phone; } set { phone = value; } }
        public string Email { get { return email; } set { email = value; } }
        public void InputData()
        {
            Console.Write("\nВведіть назву журналу: ");
            name = Console.ReadLine();

            Console.Write("Введіть рік: ");
            year = int.Parse(Console.ReadLine());

            Console.Write("Введіть кількість працівників: ");
            people = int.Parse(Console.ReadLine());

            Console.Write("Введіть опис: ");
            description = Console.ReadLine();

            Console.Write("Введіть номер телефону: ");
            phone = int.Parse(Console.ReadLine());

            Console.Write("Введіть email: ");
            email = Console.ReadLine();
        }
        public void DisplayData()
        {
            Console.WriteLine("Назву журналу: " + name);
            Console.WriteLine("Рік заснування: " + year);
            Console.WriteLine("Опис: " + description);
            Console.WriteLine("Телефон: " + phone);
            Console.WriteLine("email: " + email);
        }

        public static Magazine operator +(Magazine magazine, int value)
        {
            magazine.People += value;
            return magazine;
        }
        public static bool operator ==(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.People == magazine2.People;
        }
        public static bool operator !=(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.People != magazine2.People;
        }
        public static bool operator <(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.People < magazine2.People;
        }
        public static bool operator >(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.People > magazine2.People;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Magazine otherMagazine = (Magazine)obj;
            return People == otherMagazine.People;
        }
    }
}
