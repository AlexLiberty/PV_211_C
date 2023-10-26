using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_C_
{
    internal class MenuFunction
    {
        private Dictionary dictionary;
        ConsoleColor originalForegroundColor = Console.ForegroundColor;
        public Dictionary AddDictionary()
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            CenterText("Меню: додавання словника\n\n");
            Console.ForegroundColor = originalForegroundColor;

            string name, type;

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Введіть назву словника: ");
                Console.ForegroundColor = originalForegroundColor;
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Назва словника не може бути порожньою. Спробуйте ще раз.");
                    Console.ForegroundColor = originalForegroundColor;
                }
            } while (string.IsNullOrWhiteSpace(name));

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Введіть тип словника (наприклад, англо-український): ");
                Console.ForegroundColor = originalForegroundColor;
                type = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(type))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Тип словника не може бути порожнім. Спробуйте ще раз.");
                    Console.ForegroundColor = originalForegroundColor;
                }
            } while (string.IsNullOrWhiteSpace(type));

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            CenterText("Словник створено");
            Console.ForegroundColor = originalForegroundColor;

            return new Dictionary(name, type);

        }
        public Dictionary AddWord(Dictionary dictionary)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            CenterText("Меню: додавання слів та переладу\n\n");
            Console.ForegroundColor = originalForegroundColor;

            if (dictionary == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                CenterText("Спершу створіть словник.");
                Console.ForegroundColor = originalForegroundColor;
                Console.WriteLine();
                return null;
            }

            string word;

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Введіть слово: ");
                Console.ForegroundColor = originalForegroundColor;
                word = Console.ReadLine().Trim();
                if (string.IsNullOrWhiteSpace(word))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    CenterText("Слово не може бути порожнім!");
                    Console.ForegroundColor = originalForegroundColor;
                }
            } while (string.IsNullOrWhiteSpace(word));

            // Пошук слова в словнику
            var existingTranslation = dictionary.Translations.FirstOrDefault(t => t.Word.Equals(word, StringComparison.OrdinalIgnoreCase));

            if (existingTranslation != null)
            {
                // Якщо слово знайдено, додаємо нові переклади до існуючого варіанту перекладу
                string translationsInput;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Введіть нові переклад(-и) слова (розділяйте комою): ");
                    Console.ForegroundColor = originalForegroundColor;
                    translationsInput = Console.ReadLine();
                    string[] translations = translationsInput.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s.Trim())
                        .ToArray();

                    if (translations.Length > 0)
                    {
                        existingTranslation.Translations.AddRange(translations);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        CenterText("Нові переклади додані до слова.");
                        Console.ForegroundColor = originalForegroundColor;
                        Console.WriteLine();
                    }
                } while (string.IsNullOrWhiteSpace(translationsInput));
            }
            else
            {
                // Якщо слово не знайдено, створюю новий варіант перекладу
                string translationsInput;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Введіть переклад(-и) слова (розділяйте комою): ");
                    Console.ForegroundColor = originalForegroundColor;
                    translationsInput = Console.ReadLine();
                    string[] translations = translationsInput.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s.Trim())
                        .ToArray();

                    if (translations.Length == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        CenterText("Не вказано жодного перекладу!");
                        Console.ForegroundColor = originalForegroundColor;
                    }
                    else
                    {
                        Translation newTranslation = new Translation(word, translations.ToList());
                        dictionary.Translations.Add(newTranslation);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        CenterText("Слово та переклади додані до словника.");
                        Console.ForegroundColor = originalForegroundColor;
                        Console.WriteLine();
                    }
                } while (string.IsNullOrWhiteSpace(translationsInput));
            }

            return dictionary;
        }
        public Dictionary ReplaceWord(Dictionary dictionary)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            CenterText("Меню: редагування слів та перекладу\n\n");
            Console.ForegroundColor = originalForegroundColor;

            if (dictionary == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                CenterText("Спершу створіть словник.");
                Console.ForegroundColor = originalForegroundColor;
                Console.WriteLine();
                return null;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Введіть слово, яке ви хочете замінити: ");
            Console.ForegroundColor = originalForegroundColor;
            string wordToReplace = Console.ReadLine().Trim();

            Translation translationToReplace = dictionary.Translations.Find(t => t.Word.Equals(wordToReplace, StringComparison.OrdinalIgnoreCase));

            if (translationToReplace == null)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                CenterText($"Слово '{wordToReplace}' не знайдено у словнику.");
                Console.ForegroundColor = originalForegroundColor;
                Console.WriteLine();
                return dictionary;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Введіть нове слово: ");
            Console.ForegroundColor = originalForegroundColor;
            string newWord = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(newWord))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                CenterText("Нове слово не може бути порожнім.");
                Console.ForegroundColor = originalForegroundColor;
                Console.WriteLine();
                return dictionary;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Введіть новий переклад(-и) слова (розділяйте комою): ");
            Console.ForegroundColor = originalForegroundColor;
            string newTranslationsInput = Console.ReadLine();

            string[] newTranslations = newTranslationsInput.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                         .Select(s => s.Trim())
                                                         .ToArray();

            if (newTranslations.Length == 0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                CenterText("Не вказано жодного нового перекладу.");
                Console.ForegroundColor = originalForegroundColor;
                Console.WriteLine();
                return dictionary;
            }

            translationToReplace.Word = newWord;
            translationToReplace.Translations = newTranslations.ToList();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            CenterText("Слово та переклади були замінені у словнику.");
            Console.ForegroundColor = originalForegroundColor;
            return dictionary;
        }
        public void Display(Dictionary dictionary)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            CenterText("Меню: перегляду\n\n");
            Console.ForegroundColor = originalForegroundColor;

            if (dictionary == null || dictionary.Translations.Count == 0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                CenterText("Словник порожній або не був створений.");
                Console.ForegroundColor = originalForegroundColor;
                Console.WriteLine();
                return;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            CenterText($"Словник: {dictionary.Name} ({dictionary.Type})");
            Console.ForegroundColor = originalForegroundColor;
            foreach (var translation in dictionary.Translations)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"Слово: {translation.Word}");
                Console.ForegroundColor = originalForegroundColor;
                
                Console.Write("\nПереклад(-и):");                

                foreach (var trans in translation.Translations)
                {
                    Console.Write($"\n- {trans}");                    
                }
                Console.WriteLine();
            }
            
        }
        public Dictionary RemoveWord(Dictionary dictionary)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            CenterText("Меню: видалення слів та перекладу\n\n");
            Console.ForegroundColor = originalForegroundColor;

            if (dictionary == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                CenterText("Спершу створіть словник.");
                Console.ForegroundColor = originalForegroundColor;
                Console.WriteLine();
                return null;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Введіть слово, яке ви хочете видалити: ");
            Console.ForegroundColor = originalForegroundColor;
            string wordToRemove = Console.ReadLine().Trim();

            bool removed = dictionary.RemoveWord(wordToRemove);
            if (!removed)
            {
                return dictionary;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            CenterText($"Слово '{wordToRemove}' було видалено із словника.");
            Console.ForegroundColor = originalForegroundColor;
            return dictionary;
        }
        public void SearchTranslation(Dictionary dictionary)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            CenterText("Меню: пошуку слів\n\n");
            Console.ForegroundColor = originalForegroundColor;
            Console.WriteLine();

            if (dictionary == null)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Спершу створіть словник.");
                Console.ForegroundColor = originalForegroundColor;
                Console.WriteLine();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Введіть слово, для якого шукаєте переклад: ");
            Console.ForegroundColor = originalForegroundColor;           
            string wordToSearch = Console.ReadLine();
            Console.WriteLine();

            dictionary.SearchTranslation(wordToSearch);
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

