using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt_25_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;            

            Console.Write("Введіть кількість рядків: ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть кількість стовпців: ");
            int col = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть початок масиву: ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Введіть кінець масиву: ");
            int max = int.Parse(Console.ReadLine());

            Matrix matrix = new Matrix(row, col);
            matrix.SetRandom(min, max);
            
            Matrix matrix1 = new Matrix(row, col);
            matrix1.SetRandom(min, max);

            Console.WriteLine("Матриця_1:");
            matrix.PrintMatrix();

            Console.WriteLine("Матриця_2:");
            matrix1.PrintMatrix();

            Matrix matrix2 = matrix + matrix1;
            Matrix matrix3 = matrix - matrix1;

            Console.WriteLine("Додавання матриць:");
            matrix2.PrintMatrix();
            Console.WriteLine("Віднімання матриць:");
            matrix3.PrintMatrix();

            Console.Write("Матриця_2 більша за матрицю_3?: ");
            bool comparison= matrix2 >= matrix3;
            if (comparison)
            {
                Console.WriteLine("Так");
            }
            else
            {
                Console.WriteLine("Ні");
            }

            Console.ReadLine();
        }
    }
}
