using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_trainings
{
    public class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(Point a, Point b, Point c) : base(a, b, c)
        {
        }
        public override double AreaOfTriangle()
        {
            //return Math.Sqrt(3) / 4 * a.GetDistance(b) * a.GetDistance(b);
            double eqarea = Math.Sqrt(3) / 4 * a.GetDistance(b) * a.GetDistance(b);
            return eqarea;
        }
    }
}
