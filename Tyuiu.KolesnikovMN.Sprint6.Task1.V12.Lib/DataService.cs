using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KolesnikovMN.Sprint6.Task1.V12.Lib
{
    public class DataService : ISprint6Task1V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];
            
            for (int i = 0; i < res.Length; i++)
            {
                if (startValue == 2)
                {
                    res[i] = 0;
                    startValue++;
                }
                else
                {
                    res[i] = Math.Round(Math.Sin(startValue) + ( (Math.Cos(startValue) + 1) / (2 - startValue) ) + 2 * startValue, 2);
                    startValue++;
                }
            }
            return res;
        }
    }
}
