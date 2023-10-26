using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_C_
{
    internal class MyMenu : MeinMenu
    {
        protected int active_menu;
        protected List<string> menu_items;

        private Dictionary dictionary;
        private MenuFunction menuFunction;
        private SaveToFile saveFile;
        public MyMenu()
        {
            saveFile = new SaveToFile();
        }
        public void InitMenu()
        {
            active_menu = 0;
            menu_items = new List<string>
        {
            "Створити словник",
            "Додавати слово та перелад",
            "Замінити слово або переклад",
            "Видалити слово",
            "Шукати переклад слова",
            "Вивід на екран",
            "Завантаження з файлу",
            "Вихід"
        };
            dictionary = null;
            menuFunction = new MenuFunction();


        }

        public void MenuItems(int selectedIndex)
        {
            ConsoleColor originalForegroundColor = Console.ForegroundColor;
            Console.Clear();

            switch (selectedIndex)
            {
                case 0:
                    dictionary = menuFunction.AddDictionary(); 
                    Console.WriteLine();
                    break;
                case 1:
                    dictionary = menuFunction.AddWord(dictionary);
                    Console.WriteLine();
                    break;
                case 2:
                    dictionary = menuFunction.ReplaceWord(dictionary);
                    Console.WriteLine();
                    break;
                case 3:
                    dictionary = menuFunction.RemoveWord(dictionary);
                    Console.WriteLine();
                    break;
                case 4:
                    menuFunction.SearchTranslation(dictionary);
                    Console.WriteLine();
                    break;
                case 5:
                    menuFunction.Display(dictionary);
                    break;
                case 6:         
                    string fileName = "SAVE.json";
                    saveFile.Load(fileName, ref dictionary);
                    menuFunction.Display(dictionary);
                    break;
                case 7:
                    saveFile.Save(dictionary);
                    CenterText("Програма завершує роботу.");
                    Environment.Exit(0);
                    return;
                default:
                    break;
            }

            CenterText("Натисніть будь-яку клавішу, щоб продовжити...");
            Console.ReadKey();
        }
        public void CenterText(string text)//вивід тексту по центру(будь-якого)
        {
            int windowWidth = Console.WindowWidth;
            int textLength = text.Length;
            int leftMargin = (windowWidth - textLength) / 2;
            Console.SetCursorPosition(leftMargin, Console.CursorTop);
            Console.WriteLine(text);
        }
    }
}
