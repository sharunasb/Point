using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_trainings
{
    public class Point
    {
        public int x, y;

        public Point() : this(0, 0)
        { }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(Object obj)
        {

            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Point p = (Point)obj;
                return (x == p.x) && (y == p.y);
            }
        }

        public override int GetHashCode()
        {
            return (x << 2) ^ y;
        }

        public override string ToString()
        {
            return String.Format("Point({0}, {1})", x, y);
        }
        public static Point operator +(Point x, Point y)
        {
            Point PointResult = new Point(x.x + y.x, y.y + x.y);
            return PointResult;
        }
        public double GetDistance(Point point)
        {
            double result = (this.x - point.x) * (this.x - point.x);
            return result;
        }
    }


    sealed class Point3D : Point
    {
        int z;

        public Point3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }

        public override bool Equals(Object obj)
        {
            Point3D pt3 = obj as Point3D;
            if (pt3 == null)
                return false;
            else
                return base.Equals((Point)obj) && z == pt3.z;
        }

        public override int GetHashCode()
        {
            return (base.GetHashCode() << 2) ^ z;
        }

        public override String ToString()
        {
            return String.Format("Point({0}, {1}, {2})", x, y, z);
        }
       
    }

}
