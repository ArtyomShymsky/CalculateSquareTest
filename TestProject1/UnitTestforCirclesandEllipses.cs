using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesTAppLib;
using TesTAppLib.Figure;

namespace TestProject1
{
    [TestClass]
    public class UnitTestforCirclesandEllipses
    {
        /// <summary>
        /// Проверка площади круга
        /// </summary>
        [TestMethod]
        public void TestSquareofCircle()
        {
            EllipseOrCircle ellipseOrCircle = new EllipseOrCircle();
            ellipseOrCircle.Radius = 10;
            double expectedresult = 314.159;
            CalculateSquare calculateSquare = new CalculateSquare();
            double square= calculateSquare.CalculateSquareFig(ellipseOrCircle);
            Assert.AreEqual(expectedresult,Math.Round(square,3));
        }
        /// <summary>
        /// Проверка площади эллипса
        /// </summary>
        [TestMethod]
        public void TestSquareofEllips()
        {
            EllipseOrCircle ellipseOrCircle = new EllipseOrCircle();
            ellipseOrCircle.SemiMinorAxis = 6;
            ellipseOrCircle.SemiMajorAxis = 8;
            double expectedresult = 150.796;
            CalculateSquare calculateSquare = new CalculateSquare();
            double square = calculateSquare.CalculateSquareFig(ellipseOrCircle);
            Assert.AreEqual(expectedresult, Math.Round(square, 3));
        }

    }
}
