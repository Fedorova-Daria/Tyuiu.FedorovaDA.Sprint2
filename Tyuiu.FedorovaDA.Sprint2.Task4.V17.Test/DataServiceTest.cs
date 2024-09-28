using System.Data;
using Tyuiu.FedorovaDA.Sprint2.Task4.V17.Lib;
namespace Tyuiu.FedorovaDA.Sprint2.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 24;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 6.003;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 22;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 1.025;
            Assert.AreEqual(wait, res);
        }
    }
}