using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1
            Console.WriteLine("It's easy to win forgiveness for being wrong;");
            Console.WriteLine("being right is what gets you into real trouble.");
            Console.WriteLine("Bjarne Stroustrup");
            Console.WriteLine();
            ////2
            Console.WriteLine("Enter numeric: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter numeric: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter numeric: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter numeric: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter numeric: ");
            int n4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n + n1 + n2 + n3 + n4);
            Console.WriteLine(n * n1 * n2 * n3 * n4);            

            int max = int.MinValue;
            int min = int.MaxValue;

            Console.WriteLine("Введіть 5 чисел");
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Введіть {i + 1}-е число: ");
                int number = int.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }
            Console.WriteLine("Максимум: " + max);
            Console.WriteLine("Мінімум: " + min);
            Console.ReadLine();
            //3
            Console.Write("Введіть шестизначне число: ");
            string input = Console.ReadLine();

            if (input.Length != 6)
            {
                Console.WriteLine("Введене число не є шестизначним.");
            }
            else
            {
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                string reversed = new string(charArray);

                Console.WriteLine("Перевернуте число: " + reversed);
            }

            Console.ReadLine();
            //6                            
            Console.Write("Введіть довжину лінії: ");
            int length=int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введіть символ заповнювача: ");
            char fillCharacter = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine();
            char direction;
            do
            {
                Console.Write("Виберіть напрямок лінії (H - горизонтальний, V - вертикальний): ");
                direction = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                Console.WriteLine();
                if (direction == 'H')
                {
                    for (int i = 0; i < length; i++)
                    {
                        Console.Write(fillCharacter);
                    }
                }
                else if (direction == 'V')
                {
                    for (int i = 0; i < length; i++)
                    {
                        Console.WriteLine(fillCharacter);
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Невірний напрямок лінії. Введіть 'H' для горизонтальної лінії або 'V' для вертикальної.");
                    Console.WriteLine();
                }
                
            }
            
            while (direction != 'H'&& direction != 'V');
            Console.WriteLine();
        }
    }
}

