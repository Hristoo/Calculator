using System.Drawing;

namespace Calculator.Models
{
    public class Triangle
    {
        public string Name = "Triangle";
        public double Base;
        public double Height;
        public double Area;
        public double Perimeter;

        public Triangle(double bSide, double h, double a, double b, double c)
        {
            Base = bSide;
            Height = h;
            Area = GetArea(b, h);
            Perimeter = GetPerimeter(a, b, c);
        }


        private double GetArea(double bSide, double h)
        {
            return h * bSide / 2;
        }

        private double GetPerimeter(double a, double b, double c)
        {
            return a + b + c;
        }
    }
}
