
using System;

namespace Geometry.Entities
{
    public class Circle : Figure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
            Validate();
            Type = FigureType.Circle;
        }

        private void Validate()
        {
            if (Radius <= 0)
                throw new ArgumentException("Radius must be greater than zero");
        }

    }
}
