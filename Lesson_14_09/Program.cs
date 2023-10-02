using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] arr2D = new int[2, 3];
            //Random rand = new Random();
            //for (int i = 0; i < arr2D.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2D.GetLength(1); j++)
            //    {
            //        arr2D[i, j] = rand.Next(-10, 10);
            //        Console.Write(arr2D[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            /////////////////////////////////////////////////////////////////
            //    Console.WriteLine("Введіть три числа: ");
            //    int[] arr = new int[3];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.Write($"Введіть {i + 1}-е число: ");
            //        arr[i] = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine(arr[i]);
            //    }

            //    int[] arr2 = new int[10];
            //    Random rand = new Random();
            //    for (int i = 0; i < arr2.Length; i++)
            //    {
            //        arr2[i] = rand.Next(1, 10);
            //        Console.Write(arr2[i] + " ");
            //    }

            //    int count = 0;

            //    for (int i = 0; i < arr2.Length - 2; i++)
            //    {
            //        if (arr2[i] == arr[0] && arr2[i + 1] == arr[1] && arr2[i + 2] == arr[2])
            //        {
            //            count++;
            //        }
            //    }

            //    Console.Write("\nКількість повторень послідовності: ");
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.Write(arr[i] + " ");
            //    }
            //    Console.WriteLine($": {count}");
            //}

            int[] arr = new int[10];
            int[] arr2 = new int[10];           
            int[] arr3 = new int[10];
            ///
            //int[] arr3;
            ///
            Random rand = new Random();

            Console.WriteLine("Масив 1");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10);
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("Масив 2");

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rand.Next(10);
                Console.Write(arr2[i] + " ");
            }

            Console.WriteLine("Масив 3");

            int arr3_Index = 0;

            foreach (int num in arr)
            {
                if (Array.IndexOf(arr2, num) != -1 && Array.IndexOf(arr3, num) == -1)
                {
                    arr3[arr3_Index] = num;
                    arr3_Index++;
                    Console.Write(num + " ");
                }
            }
            Array.Resize(ref arr3, arr3_Index);
            /////////////////
            //arr3 = arr.Intersect(arr2).Distinct().ToArray();//Знаходження загальних елементів без повторень (підгледів)

            //Console.WriteLine("Масив 3");

            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    Console.Write(arr3[i] + " ");
            //}
            //////////////////
            Console.WriteLine();            
        }
    }
    
}
