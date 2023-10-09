using DZ_11_2;

Console.OutputEncoding = System.Text.Encoding.UTF8;

using (DisplayInfo shop1 = new DisplayInfo("24/7", "продуктовий", "Зелена, 1"))
{
    shop1.Write();
}

DisplayInfo? shop2 = new DisplayInfo("5/8", "взуття", "Червона, 5");

shop2.Write();

shop2 = null;

GC.Collect();

Console.ReadLine();



