using DZ_10_8;

Console.OutputEncoding = System.Text.Encoding.UTF8;

PointList pointList = new PointList();

pointList.AddPoint(1, 2, 3);
pointList.AddPoint(4, 5, 6);
pointList.AddPoint(-2, 0, 1);
pointList.AddPoint(7, 8, 9);

// Знаходимо максимальну відстань між точками та інформацію про них
double maxDistance = double.MinValue;
Point3D pointA = null;
Point3D pointB = null;

// Використовуємо LINQ для обчислення відстаней між усіма точками та знаходження максимальної відстані
var combinations = from p1 in pointList
                   from p2 in pointList
                   where !p1.Equals(p2)
                   select new { Point1 = p1, Point2 = p2, Distance = Point3D.Distance(p1, p2) };

foreach (var pair in combinations)
{
    if (pair.Distance > maxDistance)
    {
        maxDistance = pair.Distance;
        pointA = pair.Point1;
        pointB = pair.Point2;
    }
}

// Виводимо інформацію про максимальну відстань та точки
Console.WriteLine($"Максимальна відстань між точками: {maxDistance:F2}");
Console.WriteLine($"Точка 1: ({pointA.X}, {pointA.Y}, {pointA.Z})");
Console.WriteLine($"Точка 2: ({pointB.X}, {pointB.Y}, {pointB.Z})");
