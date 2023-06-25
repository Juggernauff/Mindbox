using Geometry;

namespace Geometry.Test
{
    public class CircleTest
    {
        [Fact]
        public void InitCircle_ReturnsException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
            Assert.Throws<ArgumentException>(() => new Circle(0));
            Assert.Throws<ArgumentException>(() => new Circle(1e-7));
        }

        [Fact]
        public void InitCircle_ReturnsCircle()
        {
            Assert.NotNull(new Circle(1e-6));
            Assert.NotNull(new Circle(1));
        }

        [Fact]
        public void Circle_GetSquare()
        {
            // Arrange
            double radius1 = 1e-6;
            double radius2 = 1;

            Circle circle1 = new Circle(radius1);
            Circle circle2 = new Circle(radius2);

            // Act
            double square1 = circle1.GetSquare();
            double square2 = circle2.GetSquare();

            // Assert
            Assert.Equal(Math.PI * Math.Pow(radius1, 2), square1);
            Assert.Equal(Math.PI * Math.Pow(radius2, 2), square2);
        }
    }
}
