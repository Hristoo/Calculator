namespace Calculator
{
    public class Square
    {
        public string Name = "Square";
        public double Side;
        public double Area;
        public double Perimeter;

        public Square(double side)
        {
            Side = side;
            Area = GetArea(side);
            Perimeter = GetPerimeter(side);
        }

        private double GetArea(double side)
        {
            return side * side;
        }

        private double GetPerimeter(double side)
        {
            return side * 4;
        }
    }
}
