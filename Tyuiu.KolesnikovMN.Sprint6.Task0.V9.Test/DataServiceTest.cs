using Tyuiu.KolesnikovMN.Sprint6.Task0.V9.Lib;

namespace Tyuiu.KolesnikovMN.Sprint6.Task0.V9.Test;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void CalcValid()
    {
        DataService ds = new DataService();

        double res = ds.Calculate(3);
        double wait = -2.556;

        Assert.AreEqual(res, wait); 
    }
}