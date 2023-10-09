using DZ_10_1;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введіть число: ");
int input = Convert.ToInt32(Console.ReadLine());

if (input.EvNumber())
{
    Console.WriteLine($"Число: {input} парне");
}

else
{
    Console.WriteLine($"Число: {input} не парне");
}


