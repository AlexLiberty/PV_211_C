using Prakt_04_10;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Club club1 = new Club();    

Console.WriteLine($"Розмір пам'яті у керованій кучі: {GC.GetTotalMemory(false)} байт");
Console.WriteLine($"Кількість поколіннь: { GC.MaxGeneration + 1}");
Console.WriteLine($"{GC.GetTotalMemory(false)}");
Console.WriteLine($"Наш об'єкт у поколінні: {GC.GetGeneration(club1)}");

const int Size = 1000000;

Club[] list = new Club[Size];
for (int i = 0; i < Size; i++)
{
    list[i]=new Club();
}

Console.WriteLine($"Розмір пам'яті у керованій кучі: {GC.GetTotalMemory(false)} байт");
Console.WriteLine($"Наш об'єкт у поколінні: {GC.GetGeneration(club1)}");

Console.WriteLine("Количество очисток для 0 поколения: " + GC.CollectionCount(0));
Console.WriteLine("Количество очисток для 1 поколения: " + GC.CollectionCount(1));
Console.WriteLine("Количество очисток для 2 поколения: " + GC.CollectionCount(2));
Console.Beep();//звуковий сигнал консолі