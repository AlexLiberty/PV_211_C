using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EXAM_C_
{
    internal class SaveToFile : Data
    {
        ConsoleColor originalForegroundColor = Console.ForegroundColor;
        public void Load(string fileName, ref Dictionary dictionary)
        {
            if (!File.Exists(fileName))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                CenterText("Файл не знайдено.");
                Console.ForegroundColor = originalForegroundColor;
                return;
            }

            try
            {
                string jsonData = File.ReadAllText(fileName);
                dictionary = JsonConvert.DeserializeObject<Dictionary>(jsonData);

                Console.ForegroundColor = ConsoleColor.Green;
                CenterText("Словник завантажено з файлу.");
                Console.ForegroundColor = originalForegroundColor;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                CenterText("Помилка при завантаженні словника.");
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = originalForegroundColor;
            }
        }

        public void Save(Dictionary dictionary)
        {
            if (dictionary == null)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                CenterText("Спершу створіть або завантажте словник.");
                Console.ForegroundColor = originalForegroundColor;
                Console.WriteLine();
                return;
            }
            string fileName = "SAVE.json";

            try
            {
                string json = JsonConvert.SerializeObject(dictionary);

                File.WriteAllText(fileName, json);

                Console.ForegroundColor = ConsoleColor.Green;
                CenterText("Словник збережено у файл.");
                Console.ForegroundColor = originalForegroundColor;
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                CenterText($"Помилка збереження словника: {ex.Message}");
                Console.ForegroundColor = originalForegroundColor;
                Console.WriteLine();
            }
        }
        public void CenterText(string text)
        {
            int windowWidth = Console.WindowWidth;
            int textLength = text.Length;
            int leftMargin = (windowWidth - textLength) / 2;
            Console.SetCursorPosition(leftMargin, Console.CursorTop);
            Console.WriteLine(text);
        }
    }

}
