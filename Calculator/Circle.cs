using System.Drawing;

namespace Calculator
{
    public class Circle
    {
        public string Name = "Circle";
        public double Radius;
        public double Area;
        public double Perimeter;

        public Circle(double r)
        {
            Radius = r;
            Area = GetArea(r);
            Perimeter = GetPerimeter(r);
        }

        private double GetArea(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        private double GetPerimeter(double r)
        {
            return 2 * r * Math.PI;
        }
    }
}
