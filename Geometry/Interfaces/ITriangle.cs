namespace Geometry
{
    public interface ITriangle : IFigure
    {
        public double EdgeA { get; }
        public double EdgeB { get; }
        public double EdgeC { get; }
        public bool IsRightTriangle { get; }
    }
}
