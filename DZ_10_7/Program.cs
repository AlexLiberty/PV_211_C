using DZ_10_7;
Console.OutputEncoding = System.Text.Encoding.UTF8;

PersonList personList = new PersonList();
personList.AddPerson("Гриць", "Криць", 20);
personList.AddPerson("Володя", "Бринько", 25);
personList.AddPerson("Оксана", "Іванова", 30);

foreach (var person in personList)
{
    Console.WriteLine($"Ім'я: {person.FirstName}, Прізвище: {person.LastName}, Вік: {person.Age}");
}
Console.WriteLine();
var youngestPerson = personList.MinByAge();
Console.WriteLine($"Молодша людина: {youngestPerson.FirstName} {youngestPerson.LastName}, Вік: {youngestPerson.Age}");

Console.WriteLine();
var oldestPerson = personList.MaxByAge();
Console.WriteLine($"Старша людина: {oldestPerson.FirstName} {oldestPerson.LastName}, Вік: {oldestPerson.Age}");

Console.WriteLine();
double averageAge = personList.AverageAge();
Console.WriteLine($"Середній вік: {averageAge:F2} років");

Console.WriteLine();
Console.ReadLine();