using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10_8
{
    internal class PointList:IEnumerable<Point3D>
    {
        private List<Point3D> _points;
        public PointList() 
        {
            _points = new List<Point3D>();
        }
        public void AddPoint(double x, double y, double z)
        {
            Point3D point = new Point3D(x, y, z);
            _points.Add(point);
        }
        public IEnumerator<Point3D> GetEnumerator()
        {
            return _points.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
