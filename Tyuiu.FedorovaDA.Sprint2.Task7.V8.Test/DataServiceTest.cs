using Tyuiu.FedorovaDA.Sprint2.Task7.V8.Lib;

namespace Tyuiu.FedorovaDA.Sprint2.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDoInShadedArea()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 2;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}