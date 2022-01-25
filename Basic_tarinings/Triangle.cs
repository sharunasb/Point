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
        public int GetPerimeter()
        {
            int distance1 = a.GetDistance(b);
            int distance2 = b.GetDistance(c);
            int distance3 = c.GetDistance(a);

            return distance1 + distance2 + distance3;
        }
        public virtual double AreaOfTriangle()
        {
            double perimeter = a.GetDistance(b) + b.GetDistance(c) + c.GetDistance(a);
            double area = (double)Math.Sqrt(perimeter * (perimeter - a.GetDistance(b)) * (perimeter - b.GetDistance(c)) * (perimeter - c.GetDistance(a)));
            return area;
           
        }
        
    }
}
