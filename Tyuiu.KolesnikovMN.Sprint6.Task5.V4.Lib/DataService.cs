using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KolesnikovMN.Sprint6.Task5.V4.Lib
{
    public class DataService : ISprint6Task5V4
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)    
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] numsArrays = new double[len];
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (index == 0)
                    {
                        numsArrays[index] = Convert.ToDouble(line) * -1.0;
                        index++;
                    }
                    else
                    {
                        numsArrays[index] = Convert.ToDouble(line);
                        index++;
                    }
                }
            }

            numsArrays = numsArrays.Where(val => val == Convert.ToInt32(val)).ToArray();
            return numsArrays;
        }
    }
}
