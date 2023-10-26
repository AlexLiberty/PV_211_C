using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EXAM_C_
{
    internal class Menu : MyMenu
    {
        public Menu()
        {
            InitMenu();
        }
        public void PrintMenu()//вивід меню
        {
            Console.Clear();

            int windowHeight = Console.WindowHeight;
            int menuHeight = menu_items.Count;
            int menuWidth = menu_items.Max(item => item.Length);
            int startY = (windowHeight - menuHeight) / 2;

            ConsoleColor originalForegroundColor = Console.ForegroundColor;

            for (int i = 0; i < menu_items.Count; i++)
            {
                int leftMargin = (Console.WindowWidth - menuWidth) / 2;
                Console.SetCursorPosition(leftMargin, startY + i);

                if (i == active_menu)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(menu_items[i]);
                }
                else
                {
                    Console.ForegroundColor = originalForegroundColor; 
                    Console.WriteLine(menu_items[i]);
                }
            }

            Console.ForegroundColor = originalForegroundColor; 
        }
        public void ProcessMenu()//прокрутка меню та клавіші
        {
            Console.CursorVisible = false;
            int menuItemsCount = menu_items.Count;
            ConsoleKey key;

            do
            {
                PrintMenu();
                key = Console.ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        active_menu = (active_menu - 1 + menuItemsCount) % menuItemsCount;
                        break;

                    case ConsoleKey.DownArrow:
                        active_menu = (active_menu + 1) % menuItemsCount;
                        break;

                    case ConsoleKey.Enter:
                        MenuItems(active_menu);
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine("Програма завершує роботу.");
                        return;

                    default:
                        break;
                }
            } while (key != ConsoleKey.Escape);
        }
    }
}
