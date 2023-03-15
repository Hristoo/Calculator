using System.Linq;
using static Calculator.CreateFigure;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var create = new CreateFigure();
            create.GetData();
        }
    }
}