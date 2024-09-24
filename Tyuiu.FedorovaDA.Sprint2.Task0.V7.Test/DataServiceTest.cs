using Tyuiu.FedorovaDA.Sprint2.Task0.V7.Lib;

namespace Tyuiu.FedorovaDA.Sprint2.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 103;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool [] wait = new bool[6] {true, false, true, true, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}