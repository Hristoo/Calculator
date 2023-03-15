using Calculator.Models;

namespace Calculator
{
    public class CreateFigure
    {
        public void GetData()
        {
            double number;
            Console.WriteLine("Enter side of square");
            var input = Console.ReadLine();

            if (double.TryParse(input, out number) && number > 0)
            {
                Console.WriteLine(CreateSquare(double.Parse(input)));
            }
            else
            {
                Console.WriteLine("Side of square must be positive number");
            }
            Console.WriteLine();

            Console.WriteLine("Enter dimensions of triangle separate by empty space as:");
            Console.WriteLine(" - first two are Base and Height");
            Console.WriteLine(" - the rest are the sides of the triangle");

            input = Console.ReadLine();
            var arr = CheckArray(input);

            if (arr != null)
            {
                Console.WriteLine(CreateTriangle(arr));
            }
            else
            {
                Console.WriteLine("Dimensions of triangle must be positive numbers");
            }
            Console.WriteLine();

            Console.WriteLine("Enter radius of circle");
            input = Console.ReadLine();

            if (double.TryParse(input, out number) && number > 0)
            {
                Console.WriteLine(CreateCircle(double.Parse(input)));
            }
            else
            {
                Console.WriteLine("Radius must be positive number");
            }
        }
        private string CreateSquare(double input)
        {
            var squareObj = new Square(input);
            return $"The {squareObj.Name} Area is {squareObj.Area} and Perimeter is {squareObj.Perimeter}";
        }
        private string CreateTriangle(double[] triangle)
        {
            var triangleObj = new Triangle(triangle[0], triangle[1], triangle[2], triangle[3], triangle[4]);
            return $"The {triangleObj.Name} Area is {triangleObj.Area} and Perimeter is {triangleObj.Perimeter}";
        }
        private string CreateCircle(double input)
        {
            var circleObj = new Circle(input);
            return $"The {circleObj.Name} Area is {circleObj.Area:f6} and Perimeter is {circleObj.Perimeter:f6}";
        }

        private double[] CheckArray(string str)
        {
            try
            {
                var arr = str.Split(' ').Select(n => Convert.ToDouble(n)).ToArray();

                if (arr.Min() <= 0)
                {
                    return null;
                }
                return arr;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}