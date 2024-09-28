using Tyuiu.FedorovaDA.Sprint2.Task2.V15.Lib;

namespace Tyuiu.FedorovaDA.Sprint2.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDoInShadedArea()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 3;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}