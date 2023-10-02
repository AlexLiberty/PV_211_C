using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAssembly;

namespace Lesson_21_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document("MyDoc",200,"pdf");
            Console.WriteLine(document);
        }
    }
}
