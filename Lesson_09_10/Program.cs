using Lesson_09_10;

MyMath mm=new MyMath();
MyDelegate md=new MyDelegate(mm.Sum);
//md(3, 4);

md += mm.Min;
md += mm.Mul;

foreach (var el in md.GetInvocationList())
{
    Console.WriteLine(el.Method.Name);    
}
md(3, 4);//однаково
md.Invoke(3,4); //однаково

