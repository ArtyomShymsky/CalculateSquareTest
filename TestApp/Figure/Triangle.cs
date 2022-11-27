using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesTAppLib.Figure
{
    public class Triangle : IFigure
    {
        double firstside;
        double secondside;
        double thirdside;
        public double FirstSide { get { return firstside; } set { firstside = value; } }
        public double SecondSide { get { return secondside; } set { secondside = value; } }
        public double ThirdSide { get { return thirdside; } set { thirdside = value; } }

        public double CalculateSquareofFigure()
        {
            double square = 0;

            if (Math.Pow(firstside, 2) + Math.Pow(secondside, 2) == Math.Pow(thirdside, 2)
                || Math.Pow(firstside, 2) + Math.Pow(thirdside, 2) == Math.Pow(secondside, 2) ||
                Math.Pow(thirdside, 2) + Math.Pow(secondside, 2) == Math.Pow(firstside, 2))//проверка на равнобедеренность треугольника по теореме пифагора
            {
                if (firstside > secondside & secondside > thirdside)//firstside-гипотенуза
                {
                    square = 0.5 * secondside * thirdside;
                }
                else if (secondside > firstside & firstside > thirdside)//secondside-гипотенуза
                {
                    square = 0.5 * firstside * thirdside;
                }
                else//thirdside-гипотенуза
                {
                    square = 0.5 * secondside * firstside;
                }
            }
            else//площадь произвольного треугольника по формуле Герона
            {
                double halfofperimetr = (firstside + secondside + thirdside) / 2;
                square = Math.Sqrt(halfofperimetr * (halfofperimetr - firstside) * (halfofperimetr - secondside) * (halfofperimetr - thirdside));
            }

            return square;
        }


    }
}
