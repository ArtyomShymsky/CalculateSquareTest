using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesTAppLib.Figure
{
    public class EllipseOrCircle : IFigure
    {
        double semiminoraxis;//малая полуось
        double semimajoraxis;//большая полуось
        double radius;//радиус
        public double SemiMinorAxis{ get{ return semiminoraxis; } set{ semiminoraxis = value; } }
        public double SemiMajorAxis { get { return semimajoraxis; } set { semimajoraxis = value; } }
        public double Radius { get { return radius; } set { radius = value; } }



        public double CalculateSquareofFigure()
        {
            double square = 0;
            if(semiminoraxis!=0 && semimajoraxis != 0)
            {
                square = semiminoraxis * semimajoraxis * Math.PI;

            }
            else if (radius != 0)
            {
                square = Math.Pow(radius, 2) * Math.PI;

            }
            else
            {
                throw new Exception("нет данных для вычисления площади!");
            }


            return square;
        }

    }
}
