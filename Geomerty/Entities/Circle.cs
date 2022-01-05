
using System;

namespace Geometry.Entities
{
    public class Circle : Figure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
            ValidateSides();
            Type = FigureType.Circle;
        }

        public sealed override void ValidateSides()
        {
            if (Radius <= 0)
                throw new ArgumentException("Radius must be greater than zero");
        }

    }
}
