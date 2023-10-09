using DZ_9_1;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Oceanarium oceanarium = new Oceanarium();
oceanarium.AddCreature("Дельфін", "звичайний", 3);
oceanarium.AddCreature("Акула", "велика", 5);
oceanarium.AddCreature("Черепаха", "на суп", 100);
oceanarium.AddCreature("Кит", "кашалот", 50);

foreach (var creature in oceanarium)
{
    Console.WriteLine($"Назва: {creature.Name}, Вид: {creature.Species}, Вік: {creature.Age} роки(ів)");
}