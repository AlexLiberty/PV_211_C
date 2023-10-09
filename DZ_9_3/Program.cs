using DZ_9_3;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Kafe workers = new Kafe();
workers.AddWorker("Вася", 25, "Адміністратор");
workers.AddWorker("Петро", 20, "офіціант");
workers.AddWorker("Жорік", 30, "Кухар");
workers.AddWorker("Оля", 21, "Офіціантка");

foreach (var worker in workers)
{
    Console.WriteLine($"Ім'я: {worker.Name}, Вік: {worker.Age}, Посада: {worker.Position}");
}
