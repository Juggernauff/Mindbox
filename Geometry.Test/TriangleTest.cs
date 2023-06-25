namespace Geometry.Test
{
    public class TriangleTest
    {
        [Fact]
        public void InitTriangle_ReturnsException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-1, -1, -1));
            Assert.Throws<ArgumentException>(() => new Triangle(1e-7, 1e-7, 1e-7));
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));

        }

        [Fact]
        public void InitTriangle_ReturnsTriangle()
        {
            Assert.NotNull(new Triangle(1e-6, 1e-6, 1e-6));
            Assert.NotNull(new Triangle(3, 4, 5));
            Assert.NotNull(new Triangle(7, 8, 9));
        }

        [Fact]
        public void Triangle_GetSquare()
        {
            // Arrange
            Triangle triangle1 = new Triangle(3, 4, 5);
            Triangle triangle2 = new Triangle(6, 6, 6);
            Triangle triangle3 = new Triangle(7, 8, 9);

            // Act
            double actualSquare1 = GetSquare(triangle1.EdgeA, triangle1.EdgeB, triangle1.EdgeC);
            double actualSquare2 = GetSquare(triangle2.EdgeA, triangle2.EdgeB, triangle2.EdgeC);
            double actualSquare3 = GetSquare(triangle3.EdgeA, triangle3.EdgeB, triangle3.EdgeC);

            double square1 = triangle1.GetSquare();
            double square2 = triangle2.GetSquare();
            double square3 = triangle3.GetSquare();

            // Assert
            Assert.Equal(square1, actualSquare1);
            Assert.Equal(square2, actualSquare2);
            Assert.Equal(square3, actualSquare3);
        }

        [Fact]
        public void Triangle_IsRightTriangle_ReturnsFalse()
        {
            Assert.False(new Triangle(7, 8, 9).IsRightTriangle);
            Assert.False(new Triangle(3, 3, 3).IsRightTriangle);
            Assert.False(new Triangle(2.1d, 2.8d, 3.1d).IsRightTriangle);
        }

        [Fact]
        public void Triangle_IsRightTriangle_ReturnsTrue()
        {
            Assert.True(new Triangle(3, 4, 5).IsRightTriangle);
            Assert.True(new Triangle(5, 12, 13).IsRightTriangle);
            Assert.True(new Triangle(2.1d, 2.8d, 3.5d).IsRightTriangle);
        }

        private double GetSquare(double edgeA, double edgeB, double edgeC)
        {
            double halfPerimeter = (edgeA + edgeB + edgeC) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - edgeA) * (halfPerimeter - edgeB) * (halfPerimeter - edgeC));
        }
    }
}
