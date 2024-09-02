using ShapeAreaCalculator.Shapes;

namespace ShapeAreaCalculatorTests
{
    public class ShapeTests
    {
        [Fact]
        public void Circle_Area_ShouldBeCorrect()
        {
            var circle = new Circle(10);
            double expectedArea = Math.PI * 100;
            Assert.Equal(expectedArea, circle.CalculateArea(), precision: 5);
        }

        [Fact]
        public void Triangle_Area_ShouldBeCorrect()
        {
            var triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;
            Assert.Equal(expectedArea, triangle.CalculateArea(), precision: 5);
        }

        [Fact]
        public void Triangle_ShouldBeRight()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightTriangle());
        }

        [Fact]
        public void Triangle_ShouldNotBeRight()
        {
            var triangle = new Triangle(3, 4, 6);
            Assert.False(triangle.IsRightTriangle());
        }

        [Fact]
        public void InvalidCircle_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }

        [Fact]
        public void InvalidTriangle_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 10, 12));
        }
    }
}