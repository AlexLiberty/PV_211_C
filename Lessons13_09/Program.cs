using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lessons13_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dog dog; //=new Dog("Eric",4);
            //dog =new Dog("Eric",4);
            //dog.PrintDog();

            //Dog dog2 = new Dog();
            //dog2.PrintDog();

            //Cat cat = new Cat();
            //cat.PrintCat();

            //Cat cat1= new Cat("Mimi",10);
            //cat1.PrintCat();

            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
