using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_C_
{
    internal class Dictionary
    {
        public string Name { get; set; }
        public List<Translation> Translations { get; set; }
        public string Type { get; set; }
        ConsoleColor originalForegroundColor = Console.ForegroundColor;

        public Dictionary(string name,string type)
        {
            Name = name;
            Type = type;
            Translations = new List<Translation>();
        }
        public bool RemoveWord(string word)
        {
            Translation translationToRemove = Translations.FirstOrDefault(t => t.Word.Equals(word, StringComparison.OrdinalIgnoreCase));

            if (translationToRemove == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                CenterText($"Слово '{word}' не знайдено у словнику.");
                Console.ForegroundColor = originalForegroundColor;
                return false;
            }

            if (Translations.Count == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                CenterText("Неможливо видалити останній варіант перекладу.");
                Console.ForegroundColor = originalForegroundColor;
                return false;
            }

            Translations.Remove(translationToRemove);
            Console.ForegroundColor = ConsoleColor.Red;
            CenterText($"Слово '{word}' та його переклади були видалені зі словника.");
            Console.ForegroundColor = originalForegroundColor;
            return true;
        }
        public void SearchTranslation(string wordToSearch)
        {
            var translation = Translations.FirstOrDefault(t => t.Word.Equals(wordToSearch, StringComparison.OrdinalIgnoreCase));

            if (translation != null)
            {
                Console.WriteLine($"Переклад слова '{wordToSearch}':");
                foreach (var trans in translation.Translations)
                {
                    Console.WriteLine(trans);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                CenterText($"Переклад слова '{wordToSearch}' не знайдено в словнику.");
                Console.ForegroundColor = originalForegroundColor;
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
