using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KolesnikovMN.Sprint6.Task4.V24.Lib
{
    public class DataService : ISprint6Task4V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];

            int ind = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 1.2 == 0)
                {
                    valueArray[ind] = 0;
                    ind++;
                }
                else
                {
                    valueArray[ind] = Math.Round( (Math.Sin(x)/(x + 1.2)) - (Math.Sin(x) * 2) - (2 * x), 2 );
                    ind++;
                }
            }
            return valueArray;
        }
    }
}
