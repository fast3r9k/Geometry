using System;

namespace Geometry.Entities
{
    public class Triangle : Figure
    {
        public double FirstCathetus { get; }
        public double SecondCathetus { get; }
        public double Hypotenuse { get; }
        public bool IsRight { get; }
        public double Perimeter { get; }

        public Triangle(double firstCathetus, double secondCathetus, double hypotenuse)
        {
            FirstCathetus = firstCathetus;
            SecondCathetus = secondCathetus;
            Hypotenuse = hypotenuse;
            ValidateSides();
            IsRight = Math.Pow(Hypotenuse, 2).Equals(Math.Pow(FirstCathetus, 2) + Math.Pow(SecondCathetus, 2));
            Type = FigureType.Triangle;
            Perimeter = FirstCathetus + SecondCathetus + Hypotenuse;
        }

        public sealed override void ValidateSides()
        {
            if (FirstCathetus <= 0 || SecondCathetus <= 0 || Hypotenuse <= 0)
                throw new ArgumentException("All sides must be greater than zero");
        }
    }
}
