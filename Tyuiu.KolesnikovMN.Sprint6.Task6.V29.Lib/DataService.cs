using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KolesnikovMN.Sprint6.Task6.V29.Lib
{
    public class DataService : ISprint6Task3V29
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[] fifthRow = new int[5];
            for (int i = 0; i < fifthRow.Length; i++)
            {
                fifthRow[i] = matrix[i, 4];
            }
            Array.Sort(fifthRow);
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, 4] = fifthRow[i];
            }
            return matrix;
        }
    }
}
