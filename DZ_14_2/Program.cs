Console.OutputEncoding = System.Text.Encoding.UTF8;

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
else
{
    Console.WriteLine("Невірний розмір масиву. Будь ласка, введіть додатнє ціле число.");
}
