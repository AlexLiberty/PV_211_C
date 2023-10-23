
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введіть шлях до файлу: ");
string filePath = Console.ReadLine();

if (File.Exists(filePath))
{
    string fileContent = File.ReadAllText(filePath);
    Console.WriteLine($"Вміст файлу {filePath}:");
    Console.WriteLine(fileContent);
}
else
{
    Console.WriteLine($"Помилка: Файл {filePath} не існує.");
}
