using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_trainings
{
    public class Program
    {

        public static void Main()
        {
            Point point2D = new Point(2, 6);
            Point3D point3Da = new Point3D(2, 6, 3);
            Point3D point3Db = new Point3D(3, 6, 8);
            Point3D point3Dc = new Point3D(4, 2, 8);

            Console.WriteLine("{0} = {1}: {2}",
                              point2D, point3Da, point2D.Equals(point3Da));
            Console.WriteLine("{0} = {1}: {2}",
                              point2D, point3Db, point2D.Equals(point3Db));
            Console.WriteLine("{0} = {1}: {2}",
                              point3Da, point3Db, point3Da.Equals(point3Db));
            Console.WriteLine("{0} = {1}: {2}",
                              point3Da, point3Dc, point3Da.Equals(point3Dc));

            Point x = new Point(6, 9);
            Point y = new Point(5, 7);


            Point PointResult = x + y;
            Console.WriteLine($"{x} + {y} = {PointResult} ");

            Point a = new Point(6, 9);
            Point b = new Point(5, 2);
            Point c = new Point(1, 3);

            Triangle myTriangle = new Triangle(a, b, c);
            int perimeter = myTriangle.GetPerimeter();
            Console.WriteLine($"Triangle Perimeter is: {perimeter}");


            Triangle myTriangle2 = new Triangle(a, b, c);
            double area = myTriangle2.AreaOfTriangle();
            Console.WriteLine($"Triangle area is: {area}");
        
             
            RectangularTriangle myTriangle3 = new RectangularTriangle(a, b, c);
            double recarea = myTriangle3.AreaOfTriangle();
            Console.WriteLine($"Rectangular Triangle area is: {recarea}");

            EquilateralTriangle myTriangle4 = new EquilateralTriangle(a, b, c);
            double eqarea = myTriangle4.AreaOfTriangle();
            Console.WriteLine($"Equilateral Triangle area is: {eqarea}");

            
        }
    }
}
    


