using Tyuiu.FedorovaDA.Sprint2.Task6.V7.Lib;

namespace Tyuiu.FedorovaDA.Sprint2.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckMonth()
        {
            DataService ds = new DataService();

            int n = 1;
            

            Assert.AreEqual("€нварь", ds.FindMonthName(1990, 1));
            Assert.AreEqual("февраль", ds.FindMonthName(1990, 2));
            Assert.AreEqual("март", ds.FindMonthName(1990, 3));
            Assert.AreEqual("апрель", ds.FindMonthName(1990, 4));
            Assert.AreEqual("май", ds.FindMonthName(1990, 5));
            Assert.AreEqual("июнь", ds.FindMonthName(1990, 6));
            Assert.AreEqual("июль", ds.FindMonthName(1990, 7));
            Assert.AreEqual("август", ds.FindMonthName(1990, 8));
            Assert.AreEqual("сент€брь", ds.FindMonthName(1990, 9));
            Assert.AreEqual("окт€брь", ds.FindMonthName(1990, 10));
            Assert.AreEqual("но€брь", ds.FindMonthName(1990, 11));
            Assert.AreEqual("декабрь", ds.FindMonthName(1990, 12));
            
        }
    }
}