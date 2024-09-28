using Tyuiu.FedorovaDA.Sprint2.Task3.V26.Lib;
namespace Tyuiu.FedorovaDA.Sprint2.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidContition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 4.702;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidContition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1.667;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidContition3()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            double wait = -4.754;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidContition4()
        {
            DataService ds = new DataService();
            double x = -31;
            double res = ds.Calculate(x);
            double wait = -247.968;
            Assert.AreEqual(wait, res);
        }
    }
}