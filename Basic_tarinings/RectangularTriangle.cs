using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_trainings
{
    public class RectangularTriangle : Triangle
    {
        

        public RectangularTriangle(Point a, Point b, Point c) : base(a, b, c)
        {
        }

        public override double AreaOfTriangle()
        {
            
            //return a.GetDistance(b) * b.GetDistance(c) / 2;
            double corner = a.GetDistance(b) * b.GetDistance(c);
            double recarea = corner / 2;
            return recarea;
            
        }
    }
}



