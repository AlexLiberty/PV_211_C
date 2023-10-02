using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_5_4
{
    internal class Website
    {
        private string name;
        private string url;
        private string description;
        private string ipAddress;
        public string Name { get { return name; } set { name = value; } }
        public string Url { get { return url; } set { url = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string IpAddress { get {  return ipAddress; } set {  ipAddress = value; } }

        public void InputData()
        {
            Console.Write("Введіть назву сайту: ");
            name = Console.ReadLine();

            Console.Write("Введіть шлях до сайту: ");
            url = Console.ReadLine();

            Console.Write("Введіть опис сайту: ");
            description = Console.ReadLine();

            Console.Write("Введіть IP-адресу сайту: ");
            ipAddress = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine("Назва сайту: " + name);
            Console.WriteLine("Шлях до сайту: " + url);
            Console.WriteLine("Опис сайту: " + description);
            Console.WriteLine("IP-адреса сайту: " + ipAddress);
        }

    }

}
