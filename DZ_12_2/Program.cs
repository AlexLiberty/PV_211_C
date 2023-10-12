using DZ_12_2;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
Console.OutputEncoding = System.Text.Encoding.UTF8;

MyMath bb = new MyMath();
//bb.Par(3);
//bb.Par(4);

MyDelegate md = new MyDelegate(bb.Min);
md += bb.Sum;
md += bb.Mul;
//4
md.Invoke(5, 4);

Console.WriteLine();

//3
static bool IsEven(int n)
{
    return (n % 2 == 0);
}


Predicate<int> cc = IsEven;
Console.WriteLine(cc(4));
Console.WriteLine(cc(5));

Console.Write("Введіть число: ");
int numeric=Convert.ToInt32(Console.ReadLine());
static bool FibonacciEquals(int n)
{
    {
        if (n <= 1)
        {
            return true;
        }
        int a = 0;
        int b = 1;

        while (b < n)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        return b == n;
    }
}

if (FibonacciEquals(numeric))
{
    Console.WriteLine($"{numeric} є числом Фібоначчі.");
}
else
{
    Console.WriteLine($"{numeric} не є числом Фібоначчі.");
}