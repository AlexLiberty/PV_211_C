using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_14_3
{
    internal class SaveToFile : SaveLoad
    {
        private int[] array;

        public SaveToFile(int[] array)
        {
            this.array = array;
        }

        public void Save()
        {
            Console.Write("Введіть шлях до файлу для збереження масиву: ");
            string filePath = Console.ReadLine();

            try
            {
                File.WriteAllText(filePath, string.Join(", ", array));
                Console.WriteLine($"Масив був збережений у файл {filePath}.");
            }
            catch (IOException e)
            {
                Console.WriteLine($"Помилка при збереженні файлу: {e.Message}");
            }
        }

        public void Load()
        {
            Console.Write("Введіть шлях до файлу для завантаження масиву: ");
            string filePath = Console.ReadLine();

            if (File.Exists(filePath))
            {
                try
                {
                    string content = File.ReadAllText(filePath);
                    string[] values = content.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    int[] loadedArray = new int[values.Length];

                    for (int i = 0; i < values.Length; i++)
                    {
                        if (int.TryParse(values[i].Trim(), out int elementValue))
                        {
                            loadedArray[i] = elementValue;
                        }
                        else
                        {
                            Console.WriteLine($"Невірний формат даних у файлі. Завантаження скасовано.");
                            return;
                        }
                    }

                    Console.WriteLine("Завантажений масив:");
                    Console.WriteLine(string.Join(", ", loadedArray));
                }
                catch (IOException e)
                {
                    Console.WriteLine($"Помилка при завантаженні файлу: {e.Message}");
                }
            }
            else
            {
                Console.WriteLine($"Файл {filePath} не існує.");
            }
        }
    }
}
