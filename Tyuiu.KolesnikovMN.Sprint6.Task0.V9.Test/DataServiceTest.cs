using Tyuiu.KolesnikovMN.Sprint6.Task0.V9.Lib;

namespace Tyuiu.KolesnikovMN.Sprint6.Task0.V9.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void CalcValid()
    {
        DataService ds = new();

        int x = 1;
        double res = ds.Calculate(x);

        Assert.AreEqual(res, 3.0); 
    }
}