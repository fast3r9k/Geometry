using System;
using Geometry.Entities;

namespace Geometry.Managers
{
    public class FigureManager : IFigureManager
    {
        public FigureManager()
        {

        }

        public void SetSquare(Figure figure)
        {
            switch (figure.Type)
            {
                case FigureType.Circle:
                     SetCircleSquare(figure as Circle);
                    break;
                case FigureType.Triangle:
                     SetTriangleSquare(figure as Triangle);
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
