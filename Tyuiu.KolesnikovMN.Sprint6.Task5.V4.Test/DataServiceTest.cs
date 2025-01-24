using Tyuiu.KolesnikovMN.Sprint6.Task5.V4.Lib;

namespace Tyuiu.KolesnikovMN.Sprint6.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask5V4.txt";

            DataService ds = new();

            double[] waitMass = { -1, 3, -1, -3, 0, -5, 6, 7, -7, 8, -8, -9, 10, -10, 0 };
            double[] res = ds.LoadFromDataFile(path);

            CollectionAssert.AreEqual(res, waitMass);
        }
    }
}