using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_5_6
{
    internal class Shop
    {
        string name;
        string address;
        string description;
        int phone;
        string email;

        public string Name { get { return name; } set {  name = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Description { get { return description; } set { description = value; } }
        public int Phone { get { return phone; } set { phone = value; } }
        public string Email { get { return email; } set { email = value; } }

        public void InputData()
        {
            Console.Write("Введіть назву магазину: ");
            name = Console.ReadLine();

            Console.Write("Введіть адресу: ");
            address = Console.ReadLine();

            Console.Write("Введіть опис: ");
            description = Console.ReadLine();

            Console.Write("Введіть номер телефону: ");
            phone = int.Parse(Console.ReadLine());

            Console.Write("Введіть email: ");
            email = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine("Назва  магазину: " + name);
            Console.WriteLine("Адреса магазину: " + address);
            Console.WriteLine("Опис: " + description);
            Console.WriteLine("Телефон: " + phone);
            Console.WriteLine("email: " + email);
        }
    }
}
