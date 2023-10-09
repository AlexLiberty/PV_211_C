using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10_8
{
    internal class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

      //не сам (з математикою прям біда...)
        public static double Distance(Point3D point1, Point3D point2)//обчислює відстань між двома точками у тривимірному просторі за допомогою формули відстані між двома точками в тривимірному просторі.
        {
            double dx = point1.X - point2.X;//point1 і point2 - це дві об'єкти класу Point3D, які мають координати (X, Y, Z) в тривимірному просторі.
            double dy = point1.Y - point2.Y;
            double dz = point1.Z - point2.Z;

            return Math.Sqrt(dx * dx + dy * dy + dz * dz);//обчислення квадратного кореня суми квадратів різниць по всіх трьох координатах
        }
    }
}
