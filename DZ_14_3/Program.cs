using DZ_14_3;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Виберіть дію:");
Console.WriteLine("1 - Зберегти масив у файл");
Console.WriteLine("2 - Завантажити масив із файлу");
Console.Write("Введіть номер дії: ");

if (int.TryParse(Console.ReadLine(), out int choice))
{
    switch (choice)
    {
        case 1:
            Console.Write("Введіть розмір масиву: ");
            if (int.TryParse(Console.ReadLine(), out int arraySize) && arraySize > 0)
            {
                int[] array = new int[arraySize];

                for (int i = 0; i < arraySize; i++)
                {
                    Console.Write($"Введіть значення для елементу {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int elementValue))
                    {
                        array[i] = elementValue;
                    }
                    else
                    {
                        Console.WriteLine("Невірний формат введення. Будь ласка, введіть ціле число.");
                        i--;
                    }
                }

                SaveLoad saver = new SaveToFile(array);
                saver.Save();
            }
            else
            {
                Console.WriteLine("Невірний розмір масиву. Будь ласка, введіть додатнє ціле число.");
            }
            break;

        case 2:
            SaveLoad loader = new SaveToFile(null);
            loader.Load();
            break;

        default:
            Console.WriteLine("Невірний вибір дії.");
            break;
    }
}
else
{
    Console.WriteLine("Невірний формат вводу.");
}