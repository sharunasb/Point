using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_trainings
{
    public class Triangle
    {
        public Point a;
        public Point b;
        public Point c;

        public Triangle(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double GetPerimeter()
        {
            double distance1 = a.GetDistance(b);
            double distance2 = b.GetDistance(c);
            double distance3 = c.GetDistance(a);

            return distance1 + distance2 + distance3;
        }
    }
}
