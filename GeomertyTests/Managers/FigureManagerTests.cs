using System;
using Geometry.Entities;
using Geometry.Managers;
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
            var manager = new FigureManager();
            var expected = 1764.60;

            //Act
            manager.SetSquare(circle);

            // Assert
            Assert.AreEqual(expected, circle.Square);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Invalid currency.")]
        public void SetCircleSquareTest__ResultNotOk()
        {

            // Arrange
            var circle = new Circle(-1);
            var manager = new FigureManager();

            //Act
            manager.SetSquare(circle);

            // Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void SetRectangleTriangleSquareTest__ResultOk()
        {

            // Arrange
            var triangle = new Triangle(4.5,6,7.5);
            var manager = new FigureManager();
            var expectedSquare = 13.5;
            var expectedIsRight = true;

            //Act
            manager.SetSquare(triangle);

            // Assert
            Assert.AreEqual(expectedSquare, triangle.Square);
            Assert.AreEqual(expectedIsRight, triangle.IsRight);
        }

        [TestMethod()]
        public void SetTriangleSquareTest__ResultOk()
        {

            // Arrange
            var triangle = new Triangle(4,6,7);
            var manager = new FigureManager();
            var expectedSquare = 11.98;
            var expectedIsRight = false;

            //Act
            manager.SetSquare(triangle);

            // Assert
            Assert.AreEqual(expectedSquare, triangle.Square);
            Assert.AreEqual(expectedIsRight, triangle.IsRight);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Invalid currency.")]
        public void SetTriangleSquareTest__ResultNotOk()
        {

            // Arrange
            var triangle = new Triangle(0,6,7);
            var manager = new FigureManager();

            //Act
            manager.SetSquare(triangle);

            // Assert
            Assert.Fail();
        }
    }
}