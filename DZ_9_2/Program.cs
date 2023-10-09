using DZ_9_2;
using System.Numerics;

Console.OutputEncoding = System.Text.Encoding.UTF8;

FootballTeam footballteam = new FootballTeam();
footballteam.AddPlayer("Вася", 25, 3);
footballteam.AddPlayer("Коля", 27, 5);
footballteam.AddPlayer("Жорік", 22, 15);
footballteam.AddPlayer("Толік", 23, 20);

foreach (var player in footballteam)
{
    Console.WriteLine($"Ім'я: {player.Name}, Вік: {player.Age}, Номер: {player.Numer} ");
}
