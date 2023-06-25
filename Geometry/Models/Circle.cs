namespace Geometry
{
    public class Circle : IFigure
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            if (radius < IFigure.CalculationAccuracy)
                throw new ArgumentException("Значение для радиуса указано некорректно.", nameof(radius));

            Radius = radius;
        }

        public double GetSquare() => Math.PI * Math.Pow(Radius, 2);
    }
}
