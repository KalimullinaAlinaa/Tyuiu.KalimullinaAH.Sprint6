using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KalimullinaAH.Sprint6.Task4.V28.Lib
{
    public class DataService : ISprint6Task4V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] y = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y[count] = Math.Round(Math.Cos(2 * x) + (Math.Sin(x) / (x + 2.5) + 2 * x), 2);
                if (double.IsInfinity(y[count]) || double.IsNaN(y[count]))
                {
                    y[count] = 0;
                }
                count++;
            }

            return y;


        }
    }
}
