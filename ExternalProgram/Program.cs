using ShapeAreaCalculator.Shapes;
using ShapeAreaCalculator.Interfaces;

namespace ExternalProgramExample
{
    internal class Program
    {
        // Упрощённый пример использования библиотеки.
        static void Main()
        {
            IShape circle = new Circle(10);
            IShape triangle = new Triangle(3, 4, 5);

            Console.WriteLine($"Area of Circle: {AreaCalculator.CalculateShapeArea(circle)}");
            Console.WriteLine($"Area of Triangle: {AreaCalculator.CalculateShapeArea(triangle)}");
        }
    }

    public static class AreaCalculator
    {
        public static double CalculateShapeArea(IShape shape) => shape.CalculateArea();
    }
}
