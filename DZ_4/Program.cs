using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            //1
            //    Console.Write("Введіть рядок для шифрування: ");
            //    string input = Console.ReadLine();

            //    Console.Write("Введіть ключ (ціле число): ");
            //    int key = int.Parse(Console.ReadLine());

            //    string encryptedText = Encrypt(input, key);
            //    Console.WriteLine($"Зашифрований рядок: {encryptedText}");

            //    string decryptedText = Decrypt(encryptedText, key);
            //    Console.WriteLine($"Розшифрований рядок: {decryptedText}");
            //}

            //static string Encrypt(string text, int key)
            //{
            //    char[] result = new char[text.Length];

            //    for (int i = 0; i < text.Length; i++)
            //    {
            //        char character = text[i];

            //        if (char.IsLetter(character))
            //        {
            //            char offset = char.IsUpper(character) ? 'А' : 'а';
            //            result[i] = (char)(((character + key - offset) % 26) + offset);
            //        }
            //        else
            //        {
            //            result[i] = character;
            //        }
            //    }

            //    return new string(result);
            //}

            //static string Decrypt(string text, int key)
            //{
            //    return Encrypt(text, 26 - key);
            //}

            //2

            Console.Write("Введіть арифметичний вираз: ");
            string input = Console.ReadLine();
            try
            {
                double result = Action(input);
                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        static double Action(string input)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), input);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            double result = double.Parse((string)row["expression"]);
            return result;
        }
        
    }
}
