using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DZ_11_2
{
    internal class DisplayInfo : Output, IDisposable
    {
        private Shop shop;
        private readonly object Name;

        public DisplayInfo(string name, string type, string address)
        {
            shop = new Shop(name, type, address);
        }
        public void Write()
        {
            Console.WriteLine($"Назва: {shop.Name}, Тип: {shop.Type}, Адреса: {shop.Adress}");
        }
        public void Dispose()
        {
            Console.WriteLine($"Вивільнення ресурсів для магазину {Name}");
        }
        ~DisplayInfo() 
        {
            Console.WriteLine($"Фіналізатор викликаний для DisplayInfo з назвою {shop.Name}");
        }
    }
}
