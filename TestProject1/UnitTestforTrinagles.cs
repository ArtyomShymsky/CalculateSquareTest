using TesTAppLib;
using TesTAppLib.Figure;

namespace TestProject1
{
    [TestClass]
    public class UnitTestforTrinagles
    {
        /// <summary>
        /// Тест прямоугольного треугольника
        /// </summary>
        [TestMethod]
        public void TestSquareofRectangularTrinagle()
        {
            Triangle triangle = new Triangle();
            triangle.FirstSide = 3;
            triangle.SecondSide = 4;
            triangle.ThirdSide = 5;
            double expectedresult = 6;

            CalculateSquare calculateSquare = new CalculateSquare();
            double square = calculateSquare.CalculateSquareFig(triangle);
            Assert.AreEqual(expectedresult, square);
        }
        /// <summary>
        /// Тест равнобедренного треугольника
        /// </summary>
        [TestMethod]
        public void TestSquareofIsoscelesTrinagle()
        {
            Triangle triangle = new Triangle();
            triangle.FirstSide = 3;
            triangle.SecondSide = 3;
            triangle.ThirdSide = 4;
            double expectedresult = 4.472;

            CalculateSquare calculateSquare = new CalculateSquare();
            double square = calculateSquare.CalculateSquareFig(triangle);
            Assert.AreEqual(expectedresult,Math.Round(square,3));
        }
        /// <summary>
        /// Тест произвольного треугольника
        /// </summary>
        [TestMethod]
        public void TestSquareofRandomTrinagle()
        {
            Triangle triangle = new Triangle();
            triangle.FirstSide = 3;
            triangle.SecondSide = 6;
            triangle.ThirdSide = 7;
            double expectedresult = 8.944;

            CalculateSquare calculateSquare = new CalculateSquare();
            double square = calculateSquare.CalculateSquareFig(triangle);
            Assert.AreEqual(expectedresult, Math.Round(square, 3));
        }
    }
}