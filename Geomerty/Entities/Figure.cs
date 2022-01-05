
using System;

namespace Geometry.Entities
{
    public abstract class Figure
    {
        public FigureType Type { get; init; }

        public double Square { get; private set; }

        public virtual void ValidateSides()
        {

        }

        public void SetSquare()
        {
            switch (Type)
            {
                case FigureType.Circle:
                    SetCircleSquare(this as Circle);
                    break;
                case FigureType.Triangle:
                    SetTriangleSquare(this as Triangle);
                    break;
                default: throw new ArgumentException("Unknown type of figure");
            }
        }

        private void SetCircleSquare(Circle circle)
        {
            circle.Square = Math.Round(Math.Pow(circle.Radius, 2) * Math.PI, 2);
        }

        private void SetTriangleSquare(Triangle triangle)
        {
            var halfPerimeter = triangle.Perimeter / 2d;
            triangle.Square = Math.Sqrt(
                halfPerimeter * (halfPerimeter - triangle.FirstCathetus)
                              * (halfPerimeter - triangle.SecondCathetus)
                              * (halfPerimeter - triangle.Hypotenuse));

            triangle.Square = Math.Round(triangle.Square, 2);

        }

    }
}
