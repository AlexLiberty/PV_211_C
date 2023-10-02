using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.Write("Введіть шестизначне число: ");
            string input = Console.ReadLine();

            if (input.Length != 6)
            {
                Console.WriteLine("Введене число не є шестизначним.");
            }

            Console.WriteLine("Введіть номери розрядів для заміни цифр (наприклад, 1 6):");
            string[] swapPositions = Console.ReadLine().Split(' ');
            if (swapPositions.Length != 2)
            {
                Console.WriteLine("Помилка: Потрібно ввести два номери розрядів.");
            }

            if (!int.TryParse(swapPositions[0], out int position1) || !int.TryParse(swapPositions[1], out int position2))
            {
                Console.WriteLine("Помилка: Введіть коректні номери розрядів.");
                return;
            }

            if (position1 < 1 || position1 > 6 || position2 < 1 || position2 > 6)
            {
                Console.WriteLine("Помилка: Номери розрядів мають бути від 1 до 6.");
                return;
            }

            char[] numberArray = input.ToCharArray();
            char temp = numberArray[position1 - 1];
            numberArray[position1 - 1] = numberArray[position2 - 1];
            numberArray[position2 - 1] = temp;

            string result = new string(numberArray);
            Console.WriteLine("Результат заміни цифр: " + result);

            //2

                Console.Write("Введіть дату (у форматі дд.мм.рррр): ");
            string dateString = Console.ReadLine();

            if (DateTime.TryParseExact(dateString, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                string season = GetSeason(date);
                string dayOfWeek = date.ToString("dddd");

                Console.WriteLine($"{season} {dayOfWeek}");
            }
            else
            {
                Console.WriteLine("Помилка: Некоректний формат дати.");
            }
        }

        static string GetSeason(DateTime date)
        {
            int month = date.Month;

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    return "Зимова(ий)";
                case 3:
                case 4:
                case 5:
                    return "Весняна(ий)";
                case 6:
                case 7:
                case 8:
                    return "Літня(ій)";
                case 9:
                case 10:
                case 11:
                    return "Осіння(ій)";
                default:
                    return 0;
            }

            //3

            Console.Write("Введіть перше число: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            int number2 = int.Parse(Console.ReadLine());

            int start = Math.Min(number1, number2);
            int end = Math.Max(number1, number2);

            Console.WriteLine($"Парні числа в діапазоні від {start} до {end}:");
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }    
}