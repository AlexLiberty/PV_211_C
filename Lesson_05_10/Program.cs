
using Lesson_05_10;
using System.Runtime.InteropServices;

Person p = new Person("Stepan", "Baran");
Person p1 = new Person("Stepan", "Baran");
Console.WriteLine(p.Equals(p1));
p1 = p1 with
{
    FirstName = "Bogdan"
};
Console.WriteLine(p1);
Cat c1 = new Cat("Barsik", 10);
Cat c2= new Cat("Barsik2", 10);
Console.WriteLine(c1.Equals(c2));
