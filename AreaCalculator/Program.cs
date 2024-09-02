using ShapeAreaCalculator;

namespace AreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(10);
            IShape triangle = new Triangle(3, 4, 5);

            AreaCalculator calculator = new AreaCalculator();

            Console.WriteLine($"Area of Circle: {calculator.CalculateShapeArea(circle)}");
            Console.WriteLine($"Area of Triangle: {calculator.CalculateShapeArea(triangle)}");
        }
    }
}
