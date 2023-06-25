namespace Geometry
{
    public class Triangle : ITriangle
    {
        public double EdgeA { get; private set; }

        public double EdgeB { get; private set; }

        public double EdgeC { get; private set; }

        public bool IsRightTriangle { get; private set; } = false;

        public Triangle(double edgeA, double edgeB, double edgeC)
        {
            if (edgeA < IFigure.CalculationAccuracy)
                throw new ArgumentException("Значение для стороны указано некорректно.", nameof(edgeA));
            
            if (edgeB < IFigure.CalculationAccuracy)
                throw new ArgumentException("Значение для стороны указано некорректно.", nameof(edgeB));
            
            if (edgeC < IFigure.CalculationAccuracy)
                throw new ArgumentException("Значение для стороны указано некорректно.", nameof(edgeC));

            if (edgeA + edgeB - edgeC < IFigure.CalculationAccuracy
                || edgeB + edgeC - edgeA < IFigure.CalculationAccuracy
                || edgeC + edgeA - edgeB < IFigure.CalculationAccuracy)
                throw new ArgumentException("Такой треугольник не существует.");

            EdgeA = edgeA;
            EdgeB = edgeB;
            EdgeC = edgeC;

            if (Math.Pow(EdgeA, 2) + Math.Pow(EdgeB, 2) == Math.Pow(EdgeC, 2)
                || Math.Pow(EdgeB, 2) + Math.Pow(EdgeC, 2) == Math.Pow(EdgeA, 2)
                || Math.Pow(EdgeC, 2) + Math.Pow(EdgeA, 2) == Math.Pow(EdgeB, 2)) IsRightTriangle = true;
        }

        public double GetSquare()
        {
            double halfPerimeter = (EdgeA + EdgeB + EdgeC) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - EdgeA) * (halfPerimeter - EdgeB) * (halfPerimeter - EdgeC));
        }
    }
}
