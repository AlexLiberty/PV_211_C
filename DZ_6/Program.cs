using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Money initialPrice = new Money(5, 75, "доларів");
            Product product = new Product("Продукт 1", initialPrice);

            Console.WriteLine("Початкова інформація про продукт:");
            product.Display();

            product.ReducePrice(3, 45, "доларів");

            Console.WriteLine("\nІнформація про продукт після зниження ціни:");
            product.Display();
        }
    }
}
