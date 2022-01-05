using System;
using Geometry.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryTests.Managers
{
    [TestClass()]
    public class FigureManagerTests
    {
        [TestMethod()]
        public void SetCircleSquareTest__ResultOk()
        {

            // Arrange
            var circle = new Circle(23.7);
            var expected = 1764.60;

            //Act
            circle.SetSquare();

            // Assert
            Assert.AreEqual(expected, circle.Square);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Invalid currency.")]
        public void SetCircleSquareTest__ResultNotOk()
        {

            // Arrange
            var circle = new Circle(-1);

            //Act
            circle.SetSquare();

            // Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void SetRectangleTriangleSquareTest__ResultOk()
        {

            // Arrange
            var triangle = new Triangle(4.5, 6, 7.5);
            var expectedSquare = 13.5;
            var expectedIsRight = true;

            //Act
            triangle.SetSquare();

            // Assert
            Assert.AreEqual(expectedSquare, triangle.Square);
            Assert.AreEqual(expectedIsRight, triangle.IsRight);
        }

        [TestMethod()]
        public void SetTriangleSquareTest__ResultOk()
        {

            // Arrange
            var triangle = new Triangle(4, 6, 7);
            var expectedSquare = 11.98;
            var expectedIsRight = false;

            //Act
            triangle.SetSquare();

            // Assert
            Assert.AreEqual(expectedSquare, triangle.Square);
            Assert.AreEqual(expectedIsRight, triangle.IsRight);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Invalid currency.")]
        public void SetTriangleSquareTest__ResultNotOk()
        {

            // Arrange
            var triangle = new Triangle(0, 6, 7);

            //Act
            triangle.SetSquare();

            // Assert
            Assert.Fail();
        }
    }
}