using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KolesnikovMN.Sprint6.Task2.V21.Lib
{
    public class DataService : ISprint6Task2V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            int ind = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == -2)
                {    
                    valueArray[ind] = 0;
                    ind++;
                }
                else
                {
                    valueArray[ind] = Math.Round( Math.Cos(x) + (Math.Cos(x) / (x + 2)) - (3 * x), 2 );
                    ind++;
                }
            }
            return valueArray;
        }
    }
}
