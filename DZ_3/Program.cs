using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3
{
    internal class Program
    {
        static void Main(string[] args)
        {    //1   
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Console.WriteLine("Введіть 5 чисел");
            Console.WriteLine();

            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Введіть {i + 1}-е число: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int evenCount = numbers.Count(n => n % 2 == 0);
            int oddCount = numbers.Count(n => n % 2 != 0);
            int uniqueCount = numbers.Distinct().Count();

            Console.WriteLine($"Кількість парних чисел: {evenCount}");
            Console.WriteLine($"Кількість непарних чисел: {oddCount}");
            Console.WriteLine($"Кількість унікальних чисел: {uniqueCount}");

            Console.ReadLine();

            //2

            Console.Write("Введіть кількість рядків: ");
            int rowCount = int.Parse(Console.ReadLine());

            Console.Write("Введіть кількість стовпців: ");
            int columnCount = int.Parse(Console.ReadLine());

            int[,] arr = new int[rowCount, columnCount];

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    Console.Write($"Введіть елемент [{i + 1},{j + 1}]: ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int minValue = arr[0, 0];
            int maxValue = arr[0, 0];

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (arr[i, j] < minValue)
                    {
                        minValue = arr[i, j];
                    }

                    if (arr[i, j] > maxValue)
                    {
                        maxValue = arr[i, j];
                    }
                }
            }

            Console.WriteLine($"Мінімальне значення: {minValue}");
            Console.WriteLine($"Максимальне значення: {maxValue}");
            Console.ReadLine();

            //3//робив не сам

            Console.Write("Введіть речення: ");
            string sentence = Console.ReadLine().ToLower();// Перетворення у нижній регістр
            int vowelCount = CountVowels(sentence);

            Console.WriteLine($"Кількість голосних літер у реченні: {vowelCount}");

            Console.ReadLine();
        }
        static int CountVowels(string text)//Функція CountVowels перевіряє кожен символ речення і, якщо це голосна літера (в даному випадку, "aeiouаоуиіе"), збільшує лічильник.
        {
            int count = 0;
            foreach (char character in text)
            {
                if (IsVowel(character))
                {
                    count++;
                }
            }
            return count;
        }
        static bool IsVowel(char character)//Функція IsVowel визначає, чи є символ голосною літерою на основі заданого списку голосних літер.
        {
            // Перевіряємо, чи є символ голосною літерою (літери задаєм самостійно, як англійскі так і латиниця, можна у перемішку)
            return "aeiouаоуиіе".Contains(character);
        }
    }
}
